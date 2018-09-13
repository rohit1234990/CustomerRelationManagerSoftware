using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerRelationManager
{
    public partial class frmMain : Form
    {
        List<string> formNames = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void newSalesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesman frm = new frmSalesman();
            frm.MdiParent = this;
            frm.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aMCServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAMC frm = new frmAMC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateReminder frm = new frmCreateReminder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void remindersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReminder frm = new ViewReminder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItems frm = new frmItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditQty frm = new frmEditQty();
            frm.MdiParent = this;
            frm.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void queryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuery frm = new frmQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReset frm = new frmReset();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

             
    }
}
