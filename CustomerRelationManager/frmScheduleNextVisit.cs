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
    public partial class frmScheduleNextVisit : Form
    {
        long CurrentCustomerId;
        frmAMC previousForm;

        // Marker = 1 : Edit AMC
        // Market = 2 : Schedule next visit
        short Marker;

        public frmScheduleNextVisit()
        {
            InitializeComponent();
        }

        public frmScheduleNextVisit(frmAMC prevForm, long CustomerId, short code)
        {
            InitializeComponent();
            CurrentCustomerId = CustomerId;
            Marker = code;
            previousForm = prevForm;

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT  Date, AMC_ExpiryDate, NextServiceDate      
                                FROM Customer WHERE CustomerId = @Id";

            cmd.Parameters.AddWithValue("@Id", CustomerId);
            DataTable dt = dbWrapper.SelectData(cmd);
            if (dt.Rows.Count > 0)
            {
                txtInstallationDate.Text = Convert.ToDateTime(dt.Rows[0]["Date"]).ToLongDateString();
                txtExpiryDate.Text = Convert.ToDateTime(dt.Rows[0]["AMC_ExpiryDate"]).ToLongDateString();
                dtNextVisit.Text = Convert.ToDateTime(dt.Rows[0]["NextServiceDate"]).ToLongDateString();

            }
            LoadPreviousServiceData();
        }

        private void LoadPreviousServiceData()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT ServiceId, CONVERT(nVARCHAR(19), PreviousService, 106) as [Service Date] FROM Service WHERE CustomerId = @Id";
            cmd.Parameters.AddWithValue("@Id", CurrentCustomerId);
            DataTable dt = dbWrapper.SelectData(cmd);
            gridVisits.DataSource = dt;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Marker == 1) // Edit
                {
                    if (dtAMCTill.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please enter a valid AMC Extention date.\n You have selected todays date as AMC Extention date", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtAMCTill.Focus();
                        return;
                    }

                    if (dtNextVisit.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please enter a valid next visit date", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (dtNextVisit.Value.Date > dtAMCTill.Value.Date)
                    {
                        MessageBox.Show("Next Visit date can't be greater than AMC Expiring date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtNextVisit.Focus();
                        return;
                    }


                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = @"UPDATE Customer SET NextServiceDate = @date,
                                    AMC_ExpiryDate = @exdate WHERE CustomerId = @Id";
                    cmd.Parameters.AddWithValue("@date", dtNextVisit.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@exdate", dtAMCTill.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Id", CurrentCustomerId);
                    dbWrapper.UpdateData(cmd);

                }
                else // Marker = 2 :Schedule
                {
                    if (dtNextVisit.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please enter a valid upcomming date", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = "UPDATE Customer SET NextServiceDate = @date WHERE CustomerId = @Id";
                    cmd.Parameters.AddWithValue("@date", dtNextVisit.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Id", CurrentCustomerId);
                    dbWrapper.UpdateData(cmd);
                }

                previousForm.ExpiredAMC();
                MessageBox.Show("Task completed successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmScheduleNextVisit_Load(object sender, EventArgs e)
        {
            if (Marker == 1) // Edit
            {

            }
            else
            {
                lblAMCTill.Visible = false;
                dtAMCTill.Visible = false;
            }
        }
    }
}
