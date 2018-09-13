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
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Please enter old password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
                return;
            }

            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please enter new password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return;
            }

            if (txtConfirm.Text == "")
            {
                MessageBox.Show("Please enter password again.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirm.Focus();
                return;
            }

            if (string.Compare(txtNewPassword.Text, txtConfirm.Text, true) != 0)
            {
                MessageBox.Show("Password do not match, enter again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Text = "";
                txtConfirm.Text = "";
                txtNewPassword.Focus();
                return;
            }

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT Password FROM [User] WHERE Name = 'Ajay'";

            string password = (string)dbWrapper.ExecureScaler(cmd);
            if (string.Compare(password, txtOldPassword.Text, true) != 0)
            {
                MessageBox.Show("Invalid old password, enter again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return;
            }

            try
            {
                cmd = new SqlCeCommand();
                cmd.CommandText = "UPDATE [User] SET Password = @pwd WHERE Name = 'Ajay'";
                cmd.Parameters.AddWithValue("@pwd", txtNewPassword.Text);
                dbWrapper.UpdateData(cmd);
                MessageBox.Show("Password updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
