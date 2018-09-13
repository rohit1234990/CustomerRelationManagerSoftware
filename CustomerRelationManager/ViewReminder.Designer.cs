namespace CustomerRelationManager
{
    partial class ViewReminder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReminder));
            this.gridReminder = new System.Windows.Forms.DataGridView();
            this.cntReminder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnPostpond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReminder)).BeginInit();
            this.cntReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridReminder
            // 
            this.gridReminder.AllowUserToAddRows = false;
            this.gridReminder.AllowUserToOrderColumns = true;
            this.gridReminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReminder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReminder.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridReminder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridReminder.EnableHeadersVisualStyles = false;
            this.gridReminder.Location = new System.Drawing.Point(12, 101);
            this.gridReminder.Name = "gridReminder";
            this.gridReminder.ReadOnly = true;
            this.gridReminder.RowTemplate.Height = 28;
            this.gridReminder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReminder.Size = new System.Drawing.Size(814, 455);
            this.gridReminder.TabIndex = 12;
            this.gridReminder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridReminder_CellMouseDown);
            // 
            // cntReminder
            // 
            this.cntReminder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem});
            this.cntReminder.Name = "cntReminder";
            this.cntReminder.Size = new System.Drawing.Size(101, 26);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(12, 27);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(814, 64);
            this.txtNote.TabIndex = 14;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(751, 566);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 23);
            this.btnDismiss.TabIndex = 15;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Postpond:";
            // 
            // dpDateTime
            // 
            this.dpDateTime.Location = new System.Drawing.Point(413, 567);
            this.dpDateTime.Name = "dpDateTime";
            this.dpDateTime.Size = new System.Drawing.Size(241, 21);
            this.dpDateTime.TabIndex = 17;
            // 
            // btnPostpond
            // 
            this.btnPostpond.Location = new System.Drawing.Point(660, 566);
            this.btnPostpond.Name = "btnPostpond";
            this.btnPostpond.Size = new System.Drawing.Size(75, 23);
            this.btnPostpond.TabIndex = 18;
            this.btnPostpond.Text = "Postpond";
            this.btnPostpond.UseVisualStyleBackColor = true;
            this.btnPostpond.Click += new System.EventHandler(this.btnPostpond_Click);
            // 
            // ViewReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 605);
            this.Controls.Add(this.btnPostpond);
            this.Controls.Add(this.dpDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.gridReminder);
            this.Controls.Add(this.txtNote);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewReminder";
            this.Text = "ViewReminder";
            this.Load += new System.EventHandler(this.ViewReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReminder)).EndInit();
            this.cntReminder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReminder;
        private System.Windows.Forms.ContextMenuStrip cntReminder;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpDateTime;
        private System.Windows.Forms.Button btnPostpond;
    }
}