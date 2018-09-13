using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;


namespace CustomerRelationManager
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] Items = (txtItems.Text + ";").Split(';');
            foreach (var item in Items)
            {
                string temp = Util.UppercaseWords(item.Trim());
                if (temp == "")
                    continue;

                InsertItems(temp);
            }

            txtItems.Text = "";
            txtItems.Focus();
        }

        private void InsertItems(string item)
        {
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "INSERT INTO Items(Name, Qty) VALUES (@name, @qty)";
                cmd.Parameters.AddWithValue("@name", item);
                cmd.Parameters.AddWithValue("@qty", 0);
                dbWrapper.InsertData(cmd);
                lstItems.Items.Add(item);

            }
            catch (Exception ex)
            {
            
            }
        }
        private void LoadItems()
        {
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "SELECT Name FROM Items";
                DataTable dt = dbWrapper.SelectData(cmd);

                lstItems.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lstItems.Items.Add(dt.Rows[i]["Name"]);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "DELETE FROM Items WHERE Name = @name";
                cmd.Parameters.AddWithValue("@name", lstItems.SelectedItem);
                dbWrapper.DeleteData(cmd);
                txtItems.Focus();

                LoadItems();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
