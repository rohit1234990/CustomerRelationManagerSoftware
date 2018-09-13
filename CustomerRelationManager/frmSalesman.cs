using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace CustomerRelationManager
{
    public partial class frmSalesman : Form
    {
        DataTable dtSalesman = new DataTable();
        int SalesmanIdToDelete;

        public frmSalesman()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Salesman Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (txtContactNumber.Text == "")
            {
                MessageBox.Show("Please enter Contact Number.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContactNumber.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter Address.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }

            if (btnSave.Text == "Update")
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"UPDATE Salesman SET Name = @name, PhoneNumber = @no, Address = @add 
                                    WHERE SalesmanId = @Id";
                cmd.Parameters.AddWithValue("@name", Util.UppercaseWords(txtName.Text.Trim()));
                cmd.Parameters.AddWithValue("@no", txtContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@add", Util.UppercaseWords(txtAddress.Text.Trim()));
                cmd.Parameters.AddWithValue("@Id", SalesmanIdToDelete);

                dbWrapper.UpdateData(cmd);
                ResetFields();
                LoadData();
                btnSave.Text = "Save";
                SalesmanIdToDelete = 0;
                btnDelete.Enabled = false;
            }
            else
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Salesman (Name, PhoneNumber, Address) VALUES
                                (@Name, @PhoneNumber, @Address)";
                cmd.Parameters.AddWithValue("@Name", Util.UppercaseWords(txtName.Text.Trim()));
                cmd.Parameters.AddWithValue("@PhoneNumber", txtContactNumber.Text);
                cmd.Parameters.AddWithValue("@Address", Util.UppercaseWords(txtAddress.Text));

                dbWrapper.InsertData(cmd);
            }

            // Clear all fields
            ResetFields();

            // Reload data
            LoadData();
        }

        private void ResetFields()
        {
            txtName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }

        private void frmSalesman_Load(object sender, EventArgs e)
        {
            LoadData();

            btnDelete.Enabled = false;
        }

        private void LoadData()
        {
            string query = @"SELECT SalesmanId as [Salesman ID], Name as [Salesman Name],
                            PhoneNumber as [Contact No.] FROM Salesman";
            dtSalesman = dbWrapper.SelectData(query);

            gridSalesman.DataSource = dtSalesman;
            gridSalesman.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void gridSalesman_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                SalesmanIdToDelete = Convert.ToInt32(dtSalesman.Rows[e.RowIndex]["Salesman ID"]);
                btnDelete.Enabled = true;

                
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "SELECT Name, PhoneNumber, Address FROM Salesman WHERE SalesmanId = @Id";
                cmd.Parameters.AddWithValue("@Id", SalesmanIdToDelete);

                DataTable dt = dbWrapper.SelectData(cmd);
                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtContactNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                }
                btnSave.Text = "Update";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesmanIdToDelete = 0;

            ResetFields();
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // checking if any customer associated with this salesman.
            if (SalesmanIdToDelete <= 0)
            {
                // no salesman
                return;
            }

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT COUNT(CustomerId) FROM Customer WHERE SalesmanId = @Id";
            cmd.Parameters.AddWithValue("@Id", SalesmanIdToDelete);
            int TotalCustomers = (int)dbWrapper.ExecureScaler(cmd);

            if (TotalCustomers > 0)
            {
                if (MessageBox.Show("There are some customer associated with this salesman. Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            else 
            {
                if (MessageBox.Show("Are you sure you want to delete this Salesman?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE FROM Salesman WHERE SalesmanId = @Id";
            cmd.Parameters.AddWithValue("@Id", SalesmanIdToDelete);

            dbWrapper.DeleteData(cmd);
            LoadData();
            ResetFields();     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
    }
}
