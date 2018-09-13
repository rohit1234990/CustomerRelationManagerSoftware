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
    public partial class frmCustomer : Form
    {
        DataTable dtSalesman = new DataTable();
        DataTable dtBrand = new DataTable();
        DataTable dtProducts = new DataTable();
        DataTable dtCustomers = new DataTable();
        


        long BrandId;
        long ProductId;
        int SalesmanId;

        long CustomerIdToDelete;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter Customer Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
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
            if (cboSalesMan.Text == "")
            {
                MessageBox.Show("Please select a Sales Person.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSalesMan.Focus();
                return;
            }
            if (cboBrand.Text == "")
            {
                MessageBox.Show("Please select a Brand.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBrand.Focus();
                return;
            }
            if (cboProduct.Text == "")
            {
                MessageBox.Show("Please select a Product.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProduct.Focus();
                return;
            }
            if (cboAmcDuration.Text == "" && btnSave.Text == "Save")
            {
                MessageBox.Show("Please select AMC Service Duration.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAmcDuration.Focus();
                return;
            }
            if (cboReminder.Text == "")
            {
                MessageBox.Show("Please select a Reminder Type.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboReminder.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please enter Amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
                return;
            }

            int amt;
            if (int.TryParse(txtAmount.Text, out amt) == false)
            {
                MessageBox.Show("Invalid Amount, please enter again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
                return;
            }
            else
            {
                if (amt < 0)
                {
                    MessageBox.Show("Invalid Amount, please enter again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }
            }


            // IF CAPTION IS UPDATE THEN BRANCH TO FOLLOWING FUNCTION
            if (btnSave.Text == "Update")
            {
                UpdateCustomerData();

            }
            else
            {
                try
                {
                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = @"INSERT INTO Customer (
                               Name, Phone, Address, [Date], SalesmanId, ProductId, BrandId, [Amount],
                               AMC_ExpiryDate, AMC_ReminderType,NextServiceDate,Note) VALUES 
                               (@Name, @Phone, @Address, @date, @SalesmanId, @ProductId, @BrandId, @Amount,
                                @ExpiryDate, @ReminderType,@NextDate,@Note)";

                    cmd.Parameters.AddWithValue("@Name", Util.UppercaseWords(txtCustomerName.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Phone", txtContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", Util.UppercaseWords(txtAddress.Text.Trim()));
                    cmd.Parameters.AddWithValue("@date", dtDateTime.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@SalesmanId", SalesmanId);
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);
                    cmd.Parameters.AddWithValue("@BrandId", BrandId);
                    cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                    cmd.Parameters.AddWithValue("@ExpiryDate", MakeExpiryDate().Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@ReminderType", ReminderType());
                    cmd.Parameters.AddWithValue("@NextDate", dtNextServiceDate.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Note", Util.UppercaseWords(txtNote.Text.Trim()));

                    dbWrapper.InsertData(cmd);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            // Reset Controls
            ResetControls();

            //
            CustomerIdToDelete = 0;

            // load newly added customers
            LoadCustomers();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboSearch.Text = "All";
            
            LoadCustomers();
       
            //add salesman
            string query = "SELECT SalesmanId, Name FROM Salesman";
            dtSalesman = dbWrapper.SelectData(query);

            for (int i = 0; i < dtSalesman.Rows.Count; i++)
            {
                cboSalesMan.Items.Add(dtSalesman.Rows[i]["Name"]);
            }

            // add Brand
            query = "SELECT BrandId, BrandName FROM Brand";
            dtBrand = dbWrapper.SelectData(query);

            for (int i = 0; i < dtBrand.Rows.Count; i++)
            {
                cboBrand.Items.Add(dtBrand.Rows[i]["BrandName"]);
            }

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select brand Id

            if (cboBrand.SelectedIndex != -1)
            {
                BrandId = Convert.ToInt64(dtBrand.Rows[cboBrand.SelectedIndex]["BrandId"]);

                cboProduct.Items.Clear();

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "SELECT * from Product Where BrandId = @brandId";
                cmd.Parameters.Add("@brandId", BrandId);

                dtProducts = dbWrapper.SelectData(cmd);
                for (int i = 0; i < dtProducts.Rows.Count; i++)
                {
                    cboProduct.Items.Add(dtProducts.Rows[i]["ProductName"]);
                }
            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex != -1)
            {
                ProductId = Convert.ToInt64(dtProducts.Rows[cboProduct.SelectedIndex]["ProductId"]);
            }
        }

        private void cboSalesMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSalesMan.SelectedIndex != -1)
            {
                SalesmanId = Convert.ToInt32(dtSalesman.Rows[cboSalesMan.SelectedIndex]["SalesmanId"]);
            }
        }

        private void LoadCustomers()
        {
            string query = @"SELECT  c.CustomerId AS [Customer ID], c.Name, c.Phone as [Contact No.], 
                             CONVERT(nVARCHAR(19), c.Date, 106) as [Inst. Date], b.BrandName as [Brand Name], 
                             p.ProductName as [Product Name], s.Name AS [Salesman]
                             FROM Customer AS c LEFT OUTER JOIN
                             Brand AS b ON c.BrandId = b.BrandId LEFT OUTER JOIN
                             Product AS p ON c.ProductId = p.ProductId LEFT OUTER JOIN
                             Salesman AS s ON c.SalesmanId = s.SalesmanId";

            switch (cboSearch.Text)
            {
                case "All":
                    break;
                case "Customer ID":
                    long CustId;
                       try 
	                    {	        
		                    CustId = Int64.Parse(txtSearch.Text);
                            query = query + " WHERE CustomerId = " + CustId.ToString();
	                    }
	                    catch (Exception)
	                    {
		
		                    MessageBox.Show("Invalid Customer ID, please enter valid Customer ID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	                    }
                    break;
                case "Contact No.":
                    query = query + " WHERE c.Phone like '%" + txtSearch.Text + "%'";
                    break;
                case "Customer Name":
                    query = query + " WHERE c.Name like '%" + txtSearch.Text + "%'";
                    break;
                case "Salesman Name":
                    query = query + " WHERE s.Name like '%" + txtSearch.Text + "%'";
                    break;
                case "Brand":
                    query = query + " WHERE b.BrandName like '%" + txtSearch.Text + "%'";
                    break;
                case "Product":
                    query = query + " WHERE p.ProductName like '%" + txtSearch.Text + "%'";
                    break;
            }

            //query = "select * from customer";
            dtCustomers = dbWrapper.SelectData(query);

            gridCustomer.DataSource = dtCustomers;
            lblCount.Text = "Count: " + dtCustomers.Rows.Count.ToString();
            txtCustomerName.Focus();

            btnDelete.Enabled = false;
            gridCustomer.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void ResetControls()
        {
            txtCustomerName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            txtAmount.Text = "";

            cboSalesMan.SelectedIndex = -1;
            cboBrand.SelectedIndex = -1;
            cboProduct.SelectedIndex = -1;
            cboAmcDuration.SelectedIndex = -1;
            cboReminder.SelectedIndex = -1;
            dtNextServiceDate.Text = DateTime.Now.ToLongDateString();
            txtNote.Text = "";

            txtCustomerName.Focus();
        }

       

        private void gridCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                CustomerIdToDelete = Convert.ToInt64(dtCustomers.Rows[e.RowIndex]["Customer ID"]);
                btnDelete.Enabled = true;
                cboAmcDuration.Visible = false;
                lblAmcDuration.Text = "AMC Duration Till:";
                dtAmcDuration.Visible = true;

                // Load current highlighted customer data from db
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"SELECT  c.CustomerId, c.Name AS cname, c.Phone, c.Address, c.Date, 
                                    s.Name AS sname, s.SalesmanId, p.ProductName,p.ProductId, b.BrandName, 
                                    b.BrandId, c.Amount, c.AMC_ExpiryDate, c.AMC_ReminderType, c.NextServiceDate, c.Note 
                                    FROM Customer AS c LEFT OUTER JOIN 
                                    Salesman AS s ON c.SalesmanId = s.SalesmanId LEFT OUTER JOIN 
                                    Brand AS b ON c.BrandId = b.BrandId LEFT OUTER JOIN 
                                    Product AS p ON c.ProductId = p.ProductId 
                                    WHERE (c.CustomerId = @Id)";
                cmd.Parameters.AddWithValue("@Id", CustomerIdToDelete);

                DataTable  dtUniqueCustomer = dbWrapper.SelectData(cmd);
                if (dtUniqueCustomer.Rows.Count > 0)
                {
                    txtCustomerName.Text = dtUniqueCustomer.Rows[0]["cname"].ToString();
                    txtContactNumber.Text = dtUniqueCustomer.Rows[0]["Phone"].ToString();
                    txtAddress.Text = dtUniqueCustomer.Rows[0]["Address"].ToString();
                    dtDateTime.Text = dtUniqueCustomer.Rows[0]["Date"].ToString();
                    cboSalesMan.Text = dtUniqueCustomer.Rows[0]["sname"].ToString();
                    cboBrand.Text = dtUniqueCustomer.Rows[0]["BrandName"].ToString();
                    cboProduct.Text = dtUniqueCustomer.Rows[0]["ProductName"].ToString();
                    dtAmcDuration.Text = Convert.ToDateTime(dtUniqueCustomer.Rows[0]["AMC_ExpiryDate"]).ToLongDateString();
                    if (Convert.ToInt16(dtUniqueCustomer.Rows[0]["AMC_ReminderType"]) == 1)
                    {
                        cboReminder.Text = "Yearly";
                    }
                    else
                    {
                        cboReminder.Text = "Quarterly";
                    }

                    dtNextServiceDate.Text = Convert.ToDateTime(dtUniqueCustomer.Rows[0]["NextServiceDate"]).Date.ToLongDateString();
                    txtAmount.Text = dtUniqueCustomer.Rows[0]["Amount"].ToString();
                    txtNote.Text = dtUniqueCustomer.Rows[0]["Note"].ToString();

                    // Update variable data according to current fetched values
                    // these values were already changing according to salesma, brand, product
                    // but now i have fetched some values from db so changing them acc to that.
                    // these vlaues will automatically change when change salesman, product brand etc.
                    SalesmanId = Convert.ToInt32(dtUniqueCustomer.Rows[0]["SalesmanId"]);
                    BrandId = Convert.ToInt64(dtUniqueCustomer.Rows[0]["BrandId"]);
                    ProductId = Convert.ToInt64(dtUniqueCustomer.Rows[0]["ProductId"]);
                }

                btnSave.Text = "Update";

            }
        }

        private void UpdateCustomerData()
        {
            if (CustomerIdToDelete > 0)
            {
                try
                {
                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = @"UPDATE Customer SET Name = @Name,Phone = @Phone,
                                                        Address = @Address,Date = @Date,
                                                        SalesmanId = @Sid, ProductId = @Pid,
                                                        BrandId = @Bid, [Amount] = @Amt,
                                                        AMC_ExpiryDate = @ExpiryDate, AMC_ReminderType = @ReminderType,
                                                        NextServiceDate = @NextDate ,Note = @Note 
                                                        WHERE CustomerId = @Cid";

                    cmd.Parameters.AddWithValue("@Name", Util.UppercaseWords(txtCustomerName.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Phone", txtContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", Util.UppercaseWords(txtAddress.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Date", dtDateTime.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Sid", SalesmanId);
                    cmd.Parameters.AddWithValue("@Pid", ProductId);
                    cmd.Parameters.AddWithValue("@Bid", BrandId);
                    cmd.Parameters.AddWithValue("@Amt", Convert.ToInt32(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@ExpiryDate", dtAmcDuration.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@ReminderType", ReminderType());
                    cmd.Parameters.AddWithValue("@NextDate", dtNextServiceDate.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Note", Util.UppercaseWords(txtNote.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Cid", CustomerIdToDelete);


                    dbWrapper.UpdateData(cmd);
                    
                    btnSave.Text = "Save";
                    btnDelete.Enabled = false;

                    cboAmcDuration.Visible = true; ;
                    lblAmcDuration.Text = "AMC Duration:";
                    dtAmcDuration.Visible = false;
                    dtDateTime.Text = DateTime.Now.Date.ToLongDateString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                
            }
        }

        private void lnkNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerIdToDelete = 0;

            ResetControls();
            btnSave.Text = "Save";
            btnDelete.Enabled = false;

            cboAmcDuration.Visible = true; ;
            lblAmcDuration.Text = "AMC Duration:";
            dtAmcDuration.Visible = false;
            dtDateTime.Text = DateTime.Now.Date.ToLongDateString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Are you sure you want to delete this customer ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "DELETE FROM Customer WHERE CustomerId = @Id";
                cmd.Parameters.AddWithValue("@Id", CustomerIdToDelete);

                dbWrapper.DeleteData(cmd);

                txtSearch.Text = "";
                cboSearch.Text = "All";
                ResetControls();
                LoadCustomers();

                CustomerIdToDelete = 0;
                btnSave.Text = "Save";

                cboAmcDuration.Visible = true; ;
                lblAmcDuration.Text = "AMC Duration:";
                dtAmcDuration.Visible = false;

                dtDateTime.Text = DateTime.Now.Date.ToLongDateString();
            }
        }

        private void cboReminder_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime NextServiceDate = dtDateTime.Value.Date;
            if (cboReminder.Text == "Yearly")
            {
                NextServiceDate = NextServiceDate.AddYears(1);
            }
            else
            {
               NextServiceDate = NextServiceDate.AddMonths(Util.ServiceAfterMonths);
            }

            dtNextServiceDate.Text = NextServiceDate.ToLongDateString();
        }

        private DateTime MakeExpiryDate()
        {
            DateTime Expirydate = dtDateTime.Value.Date;
            switch (cboAmcDuration.Text)
            {
                case "1 Year": Expirydate = Expirydate.AddYears(1);
                    break;
                case "2 Years": Expirydate = Expirydate.AddYears(2);
                    break;
                case "3 Years": Expirydate = Expirydate.AddYears(3);
                    break;
                case "4 Years": Expirydate = Expirydate.AddYears(4);
                    break;
                case "5 Years": Expirydate = Expirydate.AddYears(5);
                    break;
                case "6 Years": Expirydate = Expirydate.AddYears(6);
                    break;
                case "7 Years": Expirydate = Expirydate.AddYears(7);
                    break;
                case "8 Years": Expirydate = Expirydate.AddYears(8);
                    break;
                case "9 Years": Expirydate = Expirydate.AddYears(9);
                    break;
                case "10 Years": Expirydate = Expirydate.AddYears(10);
                    break;
            }

            return Expirydate;
        }

        private short ReminderType()
        {
            if (cboReminder.Text == "Yearly")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtSearch.Text = "";
            if(cboSearch.Text == "All")
            {
                txtSearch.Enabled = false;
                LoadCustomers();
            }
            else
            {
                txtSearch.Enabled =true;
                txtSearch.Focus();
            }
            //LoadCustomers();
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void dtDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (cboReminder.Text != "")
            {
                DateTime NextServiceDate = dtDateTime.Value.Date;
                if (cboReminder.Text == "Yearly")
                {
                    NextServiceDate = NextServiceDate.AddYears(1);
                }
                else
                {
                    NextServiceDate = NextServiceDate.AddMonths(Util.ServiceAfterMonths);
                }

                dtNextServiceDate.Text = NextServiceDate.ToLongDateString();
            }
        }

        
        
    }
}
