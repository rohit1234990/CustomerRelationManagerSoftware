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
    public partial class frmEditor : Form
    {
        long CurrentCustomerId;
        int CurrTabIndex;
        frmAMC previousForm;
        public frmEditor()
        {
            InitializeComponent();
        }

        public frmEditor(frmAMC prevForm, long CustomerId, int TabIndex)
        {
            InitializeComponent();

            CurrentCustomerId = CustomerId;
            CurrTabIndex = TabIndex;
            previousForm = prevForm;
            

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT  Date,NextServiceDate, AMC_ReminderType, AMC_ExpiryDate     
                                FROM Customer WHERE CustomerId = @Id";

            cmd.Parameters.AddWithValue("@Id", CustomerId);
            DataTable dt = dbWrapper.SelectData(cmd);
            if (dt.Rows.Count > 0)
            {
                txtInstallationDate.Text = Convert.ToDateTime(dt.Rows[0]["Date"]).ToLongDateString();
                dtExpiryDate.Text = Convert.ToDateTime(dt.Rows[0]["AMC_ExpiryDate"]).ToLongDateString();

                dtCurrentVisit.Text = Convert.ToDateTime(dt.Rows[0]["NextServiceDate"]).ToLongDateString();

                if (Convert.ToInt16(dt.Rows[0]["AMC_ReminderType"]) == 1)
                {
                    dtNextVisit.Text = Convert.ToDateTime(dt.Rows[0]["NextServiceDate"]).Date.AddYears(1).ToLongDateString();
                }
                else
                {
                    dtNextVisit.Text = Convert.ToDateTime(dt.Rows[0]["NextServiceDate"]).Date.AddMonths(Util.ServiceAfterMonths).ToLongDateString();
                }


                if (dtNextVisit.Value.Date > dtExpiryDate.Value.Date)
                {
                    dtNextVisit.Enabled = false;
                    chkAgree.Visible = ! dtNextVisit.Enabled;
                }

                if (CurrTabIndex == 1)
                {
                    dtCurrentVisit.Text = DateTime.Now.Date.ToLongDateString();
                    dtNextVisit.Text = DateTime.Now.AddMonths(Util.ServiceAfterMonths).ToLongDateString();
                }

            }

        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            btnResolve.Focus();
            LoadPreviousServiceData();
            
        }

       
        private void btnResolve_Click(object sender, EventArgs e)
        {
            if ( DateTime.Now.AddDays(Util.MinimumDaysToResovle) <  dtCurrentVisit.Value.Date)
            {
                MessageBox.Show("You can resolve issue only " + Util.MinimumDaysToResovle + " days prior to scheduled visist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (CurrTabIndex == 0)
            {

                if (dtNextVisit.Enabled == false && chkAgree.Checked == false)
                {
                    MessageBox.Show("Upcomming service date is exceeding the AMC Expiry date.\n Please contact customer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
           
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"UPDATE Customer SET NextServiceDate = @date,
                                   AMC_ExpiryDate = @expirydate WHERE CustomerId = @Id";
                cmd.Parameters.AddWithValue("@date", dtNextVisit.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@expirydate", dtExpiryDate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@Id", CurrentCustomerId);
                dbWrapper.UpdateData(cmd);
                
                // also insert data in Service Table
                cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Service (CustomerId, PreviousService)
                                    VALUES (@Id, @date)";
                cmd.Parameters.AddWithValue("@Id", CurrentCustomerId);
                cmd.Parameters.AddWithValue("@date", dtCurrentVisit.Value.Date.ToShortDateString());
                dbWrapper.UpdateData(cmd);

                // reload data according to selected tab
                if (CurrTabIndex == 0)
                {
                    previousForm.LoadUpcommingAMC();
                }
                else if(CurrTabIndex == 1)
                {
                    previousForm.ElapsedAMC();
                }

                MessageBox.Show("Issue resolved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadPreviousServiceData()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT ServiceId, CONVERT(nVARCHAR(19), PreviousService, 106) as [Service Date] FROM Service WHERE CustomerId = @Id";
            cmd.Parameters.AddWithValue("@Id",CurrentCustomerId);
            DataTable dt = dbWrapper.SelectData(cmd);
            gridVisits.DataSource = dt;
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = chkAgree.Checked;
            dtNextVisit.Enabled = chkAgree.Checked;
        }

        private void chkExit_CheckedChanged(object sender, EventArgs e)
        {
            dtCurrentVisit.Enabled = chkEdit.Checked;
        }
    }
}
