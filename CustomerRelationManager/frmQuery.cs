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
    public partial class frmQuery : Form
    {
        public frmQuery()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandText = txtQuery.Text;
                gridResult.DataSource = dbWrapper.SelectData(cmd);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
