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
    public partial class frmBrand : Form
    {
        DataTable dt = new DataTable();

        public frmBrand()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Please enter Brand name.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrand.Focus();

                return;
            }

            // Add product
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Brand(BrandName) VALUES (@BrandName)";
                cmd.Parameters.Add("@BrandName", Util.UppercaseWords(txtBrand.Text.Trim()));
                dbWrapper.InsertData(cmd);
                lstBrand.Items.Add(Util.UppercaseWords(txtBrand.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Reload Brands
            LoadBrands();

            // Clear
            txtBrand.Text = "";
            txtBrand.Focus();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Brand to remove.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long BrandId = Convert.ToInt64(dt.Rows[lstBrand.SelectedIndex]["BrandId"]);

            // Before removing brand checking if any product associated with it.
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT COUNT(BrandId) FROM Product WHERE BrandId = @Id";
            cmd.Parameters.AddWithValue("@Id", BrandId);
            int TotalProducts = (int)dbWrapper.ExecureScaler(cmd);

            cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT COUNT(BrandId) FROM Customer WHERE BrandId = @Id";
            cmd.Parameters.AddWithValue("@Id", BrandId);
            int TotalCustomers = (int)dbWrapper.ExecureScaler(cmd);

            if (TotalProducts != 0 && TotalCustomers != 0)
            {
                string msg = @"There are " + TotalProducts + " products and " + TotalCustomers +
                              " customers associated.\nProceeding will delete all the associated data.\nAre you sure you want to continue?";
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            else if (TotalProducts != 0 && TotalCustomers == 0)
            {
                string msg = @"There are " + TotalProducts + " products associated.\nProceeding will delete all the associated data.\nAre you sure you want to continue?";
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            else
            {
            }

            try
            {
                cmd = new SqlCeCommand();
                cmd.CommandText = @"DELETE FROM Brand WHERE BrandId = @Id";
                cmd.Parameters.Add("@Id", BrandId);
                dbWrapper.DeleteData(cmd);
                //Reload brands
                LoadBrands();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadBrands()
        {
            string sql = "SELECT * FROM Brand";
            dt = dbWrapper.SelectData(sql);

            lstBrand.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstBrand.Items.Add(dt.Rows[i]["BrandName"]);
            }

            txtBrand.Focus();
        }
    }
}
