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
    public partial class frmProduct : Form
    {
        long BrandId;
        DataTable dt = new DataTable();
        DataTable dtProducts = new DataTable();


        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text == "")
            {
                MessageBox.Show("Please enter Product name.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduct.Focus();

                return;
            }

            // Add product
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Product(BrandId, ProductName) VALUES (@Id,@productName)";
                cmd.Parameters.Add("@Id", BrandId);
                cmd.Parameters.Add("@productName",Util.UppercaseWords(txtProduct.Text.Trim()));
                dbWrapper.InsertData(cmd);
                lstProduct.Items.Add( Util.UppercaseWords(txtProduct.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Clear
            txtProduct.Text = "";
            txtProduct.Focus();
        }

        

        private void frmProduct_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Brand";
            dt = dbWrapper.SelectData(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboBrand.Items.Add(dt.Rows[i]["BrandName"]);
            }

            cboBrand.Focus();
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select brand Id
            BrandId = Convert.ToInt64(dt.Rows[cboBrand.SelectedIndex]["BrandId"]);


            // load products
            LoadProducts();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Product to remove.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long ProductId = Convert.ToInt64(dtProducts.Rows[lstProduct.SelectedIndex]["ProductId"]);

            // checking if any customer associated with this product
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT COUNT(ProductId) FROM Customer WHERE ProductId = @Id";
            cmd.Parameters.AddWithValue("@Id", ProductId);
            int TotalCustomers = (int)dbWrapper.ExecureScaler(cmd);

            if (TotalCustomers > 0)
            {
                if (MessageBox.Show("There are some customer associated with this product. Are you sure you want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            
            cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE FROM Product WHERE ProductId = @Id";
            cmd.Parameters.Add("@Id", ProductId);
            dbWrapper.DeleteData(cmd);

            //Reload brands
            LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            lstProduct.Items.Clear();

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * from Product Where BrandId = @brandId";
            cmd.Parameters.Add("@brandId", BrandId);

            dtProducts = dbWrapper.SelectData(cmd);
            for (int i = 0; i < dtProducts.Rows.Count; i++)
            {
                lstProduct.Items.Add(dtProducts.Rows[i]["ProductName"]);
            }

            txtProduct.Focus();
        }
    }
}
