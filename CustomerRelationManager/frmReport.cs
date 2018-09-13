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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT LogId,Item, Qty as [Quantity], Name as [Person Name],  Action, CONVERT(nVARCHAR(19), Date, 106) as [Transaction Date], InStock as [Availaible], Note FROM Log";
            gridCustomer.DataSource = dbWrapper.SelectData(cmd);
        }
    }
}
