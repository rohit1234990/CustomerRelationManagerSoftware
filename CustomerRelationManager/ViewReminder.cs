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
    public partial class ViewReminder : Form
    {
        Point PT;
        DataTable dtReminders = new DataTable();
        long ReminderIdToDelete;


        public ViewReminder()
        {
            InitializeComponent();
        }

        private void ViewReminder_Load(object sender, EventArgs e)
        {
            LoadReminder();
        }

        private void LoadReminder()
        {
//            string query = @"SELECT ReminderId as [Reminder ID], Title, Note, 
//                             CONVERT(nVARCHAR(19), Date, 106) as [Reminder Date] 
//                             FROM Reminder WHERE IsActive = 1 AND Date <= '" + DateTime.Now.Date.AddDays(15).ToShortDateString() + "'"; ;

            string query = @"SELECT ReminderId as [Reminder ID], Title, Note, 
                             CONVERT(nVARCHAR(19), Date, 106) as [Reminder Date] 
                             FROM Reminder WHERE IsActive = 1 ORDER BY Date ASC";
            dtReminders = dbWrapper.SelectData(query);

            gridReminder.DataSource = dtReminders;
            gridReminder.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void gridReminder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReminderIdToDelete = Convert.ToInt64(dtReminders.Rows[e.RowIndex]["Reminder ID"]);
                txtNote.Text = dtReminders.Rows[e.RowIndex]["Note"].ToString();
                dpDateTime.Text = Convert.ToDateTime(dtReminders.Rows[e.RowIndex]["Reminder Date"]).ToLongDateString();
            }
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReminderIdToDelete > 0 && MessageBox.Show("Are you sure you want to dismiss this Reminder ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = "UPDATE Reminder SET IsActive = 0 WHERE ReminderId = @Id";
                    cmd.Parameters.AddWithValue("@Id", ReminderIdToDelete);

                    dbWrapper.UpdateData(cmd);
                    LoadReminder();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPostpond_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReminderIdToDelete > 0 && MessageBox.Show("Are you sure you want to postpond this Reminder ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = "UPDATE Reminder SET [Date] = @date WHERE ReminderId = @Id";
                    cmd.Parameters.AddWithValue("@date", dpDateTime.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Id", ReminderIdToDelete);

                    dbWrapper.UpdateData(cmd);
                    LoadReminder();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}


       

        