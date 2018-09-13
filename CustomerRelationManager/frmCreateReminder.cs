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
    public partial class frmCreateReminder : Form
    {
        public frmCreateReminder()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter Title.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Focus();
                return;
            }
            if (txtNote.Text == "")
            {
                MessageBox.Show("Please enter Note.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNote.Focus();
                return;
            }

            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = @"INSERT INTO Reminder (Title, Note, [Date], IsActive)
                                VALUES(@Title, @Note, @date,1)";
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dtDate.Value.Date.ToShortDateString());

                dbWrapper.InsertData(cmd);
                MessageBox.Show("Reminder created successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtTitle.Text = "";
            txtNote.Text = "";
            txtTitle.Focus();
        }
    }
}
