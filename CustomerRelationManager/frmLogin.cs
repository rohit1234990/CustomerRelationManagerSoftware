using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Configuration;

namespace CustomerRelationManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = "SELECT COUNT(UserId) FROM [User] WHERE Name = @name AND Password = @pass";
                cmd.Parameters.AddWithValue("@name", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                int result = (int)dbWrapper.ExecureScaler(cmd);
                if (result == 1)
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password, Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
