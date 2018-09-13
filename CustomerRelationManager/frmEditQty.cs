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
    public partial class frmEditQty : Form
    {
        public frmEditQty()
        {
            InitializeComponent();
        }

        private void frmEditQty_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            LoadData();   
        }

        private void gridItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridItems.Rows.Count ; i++)
                {
                    SqlCeCommand cmd = new SqlCeCommand();
                    cmd.CommandText = @"UPDATE Items SET Qty = @qty WHERE ItemId = @Id";
                    cmd.Parameters.AddWithValue("@qty", gridItems.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@Id", gridItems.Rows[i].Cells[0].Value);
                    dbWrapper.UpdateData(cmd);
                }

                LoadData();
                MessageBox.Show("Items updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridItems_KeyDown(object sender, KeyEventArgs e)
        {
                 
        }

        private void gridItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 2)
                {
                    return;
                }
                DataGridViewCell cell = gridItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
                gridItems.CurrentCell = cell;
                gridItems.BeginEdit(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entered value is not in correct format.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void gridItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadData()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM Items";
            gridItems.DataSource = dbWrapper.SelectData(cmd);
            gridItems.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
    }
}
