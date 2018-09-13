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
    public partial class frmSale : Form
    {
        int Qty;
        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM Items";

            DataTable dt = dbWrapper.SelectData(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboItem.Items.Add(dt.Rows[i]["Name"]);    
            }
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT Qty FROM Items WHERE Name = @name";
            cmd.Parameters.AddWithValue("@name", cboItem.Text);

            txtStock.Text = dbWrapper.ExecureScaler(cmd).ToString();
            txtPerson.Focus();

        }

        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cboAction_Enter(object sender, EventArgs e)
        {
            

           

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please enter Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQty.Focus();
                return;
            }


            if (int.TryParse(txtQty.Text, out Qty) == false)
            {
                MessageBox.Show("Please enter a numeric value.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQty.Focus();
                return;
            }

            if (Qty > Convert.ToInt32(txtStock.Text))
            {
                MessageBox.Show("Insufficient stock", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return;
            }


            if (cboAction.Text == "Dispatch")
            {
                txtRemaining.Text = (Convert.ToInt32(txtStock.Text) - Qty).ToString();
            }
            else
            {
                txtRemaining.Text = (Convert.ToInt32(txtStock.Text) + Qty).ToString();
            }

            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "UPDATE Items SET Qty = @remain WHERE Name = @name";
                cmd.Parameters.AddWithValue("@remain", txtRemaining.Text);
                cmd.Parameters.AddWithValue("@name", cboItem.Text);
                dbWrapper.UpdateData(cmd);

                cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Log(Item, Name, Qty, Action, Date, InStock, Note)
                                   VALUES(@item, @name, @qty, @action, @date, @instock,@note)";
                cmd.Parameters.AddWithValue("@item", cboItem.Text);
                cmd.Parameters.AddWithValue("@name", txtPerson.Text);
                cmd.Parameters.AddWithValue("@qty", txtQty.Text);
                cmd.Parameters.AddWithValue("@action", cboAction.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@instock", txtRemaining.Text);
                cmd.Parameters.AddWithValue("@note", txtNote.Text);
                dbWrapper.InsertData(cmd);


                MessageBox.Show("Stock update successfully", "",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }
}
