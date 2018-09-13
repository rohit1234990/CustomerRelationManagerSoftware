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
    public partial class frmAMC : Form
    {
        Point PT;
        DataTable dtServices = new DataTable();
        DataTable dtExpiredServices = new DataTable();
        DataTable dtElapsedServices = new DataTable();


        long CustomerId;

        public frmAMC()
        {
            InitializeComponent();
        }

        private void frmAMC_Load(object sender, EventArgs e)
        {
            cboFilter.Text = "2 Weeks";
            LoadUpcommingAMC();
        }

        public void LoadUpcommingAMC()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = MakeQuery();

            dtServices = dbWrapper.SelectData(cmd);
            gridUpcommng.DataSource = dtServices;
            gridUpcommng.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void gridUpcommng_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                CustomerId = Convert.ToInt64(dtServices.Rows[e.RowIndex]["Customer ID"]);
                this.cntService.Show(this.gridUpcommng, PT);
            }
        }

        private void gridUpcommng_MouseDown(object sender, MouseEventArgs e)
        {
             PT.X = e.X;
             PT.Y = e.Y;
        }

        private void gridElapsed_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                CustomerId = Convert.ToInt64(dtElapsedServices.Rows[e.RowIndex]["Customer ID"]);
                this.cntService.Show(this.gridElapsed, PT);
            }
        }

        private void gridElapsed_MouseDown(object sender, MouseEventArgs e)
        {
            PT.X = e.X;
            PT.Y = e.Y;
        }

        private void gridExpired_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                CustomerId = Convert.ToInt64(dtExpiredServices.Rows[e.RowIndex]["Customer ID"]);
                this.cntExpiredService.Show(this.gridExpired, PT);
            }
        }

        private void gridExpired_MouseDown(object sender, MouseEventArgs e)
        {
            PT.X = e.X;
            PT.Y = e.Y;
        }

        private void resolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor frm = new frmEditor(this, CustomerId, tabControl1.SelectedIndex);
            frm.ShowDialog();

        }

        private string MakeQuery()
        {

            string Append = "";
            string query = @"SELECT  c.CustomerId AS [Customer ID], c.Name, c.Phone as [Contact No.], 
                             CONVERT(nVARCHAR(19), c.Date, 106) as [Inst. Date], CONVERT(nVARCHAR(19), c.NextServiceDate,106) as [Next Service On] , b.BrandName as [Brand Name], p.ProductName as [Product Name] 
                             FROM Customer AS c LEFT OUTER JOIN
                             Brand AS b ON c.BrandId = b.BrandId LEFT OUTER JOIN
                             Product AS p ON c.ProductId = p.ProductId LEFT OUTER JOIN
                             Salesman AS s ON c.SalesmanId = s.SalesmanId";
            switch (cboFilter.Text)
            {
                case "All":
                    break;
                case "1 Week":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddDays(7) + "'";
                    break;
                case "2 Weeks":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddDays(14) + "'";
                    break;
                case "1 Month":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddMonths(1) + "'";
                    break;
                case "2 Months":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddMonths(2) + "'";
                    break;
                case "3 Months":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddMonths(3) + "'";
                    break;
                case "6 Months":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddMonths(6) + "'";
                    break;
                case "1 Year":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddYears(1) + "'";
                    break;
                case "2 Years":
                    Append = " WHERE c.NextServiceDate BETWEEN '" + DateTime.Now.Date + "'" + " AND '" + DateTime.Now.Date.AddYears(1) + "'";
                    break;
            }

            return query + Append + " ORDER BY c.NextServiceDate Asc";
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUpcommingAMC();
        }

        public void ElapsedAMC()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT  c.CustomerId AS [Customer ID], c.Name, c.Phone as [Contact No.], 
                               CONVERT(nVARCHAR(19), c.Date, 106) as [Inst. Date], CONVERT(nVARCHAR(19), c.NextServiceDate,106) as [AMC Elapsed On] , b.BrandName as [Brand Name], p.ProductName as [Product Name] 
                               FROM Customer AS c LEFT OUTER JOIN
                               Brand AS b ON c.BrandId = b.BrandId LEFT OUTER JOIN
                               Product AS p ON c.ProductId = p.ProductId LEFT OUTER JOIN
                               Salesman AS s ON c.SalesmanId = s.SalesmanId WHERE c.NextServiceDate < '" + DateTime.Now.Date + "'  ORDER BY c.NextServiceDate Asc";
            dtElapsedServices  = dbWrapper.SelectData(cmd);
            gridElapsed.DataSource = dtElapsedServices;
            gridElapsed.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void ExpiredAMC()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = @"SELECT  c.CustomerId AS [Customer ID], c.Name, c.Phone as [Contact No.], 
                               CONVERT(nVARCHAR(19), c.Date, 106) as [Inst. Date], CONVERT(nVARCHAR(19), 
                               c.AMC_ExpiryDate,106) as [AMC Expired On] , b.BrandName as [Brand Name], p.ProductName as [Product Name] 
                               FROM Customer AS c LEFT OUTER JOIN
                               Brand AS b ON c.BrandId = b.BrandId LEFT OUTER JOIN
                               Product AS p ON c.ProductId = p.ProductId LEFT OUTER JOIN
                               Salesman AS s ON c.SalesmanId = s.SalesmanId";

            switch (cboWithin.Text)
            {
                case "1 Week":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddDays(7) + "'";
                    break;
                case "2 Weeks":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddDays(14) + "'";
                    break;
                case "1 Month":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddMonths(1) + "'";
                    break;
                case "2 Months":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddMonths(2) + "'";
                    break;
                case "3 Months":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddMonths(3) + "'";
                    break;
                case "6 Months":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddMonths(6) + "'";
                    break;
                case "1 Year":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddYears(1) + "'";
                    break;
                case "2 Years":
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date.AddYears(2) + "'";
                    break;
                default:
                    cboWithin.Text = "Expired";
                    cmd.CommandText = cmd.CommandText + " WHERE AMC_ExpiryDate < '" + DateTime.Now.Date + "'";
                    break;
            }

            cmd.CommandText = cmd.CommandText + " ORDER BY c.AMC_ExpiryDate Asc";
            dtExpiredServices = dbWrapper.SelectData(cmd);
            gridExpired.DataSource = dtExpiredServices;
            gridExpired.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElapsedAMC();
            ExpiredAMC();
        }

        private void cboWithin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpiredAMC();
        }

        private void scheduleNextVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleNextVisit frm = new frmScheduleNextVisit(this,CustomerId,2);
            frm.ShowDialog();
        }

        private void editAMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleNextVisit frm = new frmScheduleNextVisit(this,CustomerId, 1);
            frm.ShowDialog();
        }

    }
}
