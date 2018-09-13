namespace CustomerRelationManager
{
    partial class frmAMC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAMC));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridUpcommng = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridElapsed = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboWithin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridExpired = new System.Windows.Forms.DataGridView();
            this.cntService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntExpiredService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleNextVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUpcommng)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridElapsed)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpired)).BeginInit();
            this.cntService.SuspendLayout();
            this.cntExpiredService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 530);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboFilter);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gridUpcommng);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upcomming Visits";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "All",
            "1 Week",
            "2 Weeks",
            "1 Month",
            "2 Months",
            "3 Months",
            "6 Months",
            "1 Year",
            "2 Years"});
            this.cboFilter.Location = new System.Drawing.Point(742, 12);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(121, 21);
            this.cboFilter.TabIndex = 14;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter:";
            // 
            // gridUpcommng
            // 
            this.gridUpcommng.AllowUserToAddRows = false;
            this.gridUpcommng.AllowUserToOrderColumns = true;
            this.gridUpcommng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUpcommng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUpcommng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUpcommng.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUpcommng.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridUpcommng.EnableHeadersVisualStyles = false;
            this.gridUpcommng.Location = new System.Drawing.Point(15, 41);
            this.gridUpcommng.Name = "gridUpcommng";
            this.gridUpcommng.ReadOnly = true;
            this.gridUpcommng.RowTemplate.Height = 25;
            this.gridUpcommng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUpcommng.Size = new System.Drawing.Size(848, 444);
            this.gridUpcommng.TabIndex = 12;
            this.gridUpcommng.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridUpcommng_CellMouseDown);
            this.gridUpcommng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridUpcommng_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridElapsed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Elapsed Visits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridElapsed
            // 
            this.gridElapsed.AllowUserToAddRows = false;
            this.gridElapsed.AllowUserToOrderColumns = true;
            this.gridElapsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridElapsed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridElapsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridElapsed.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridElapsed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridElapsed.EnableHeadersVisualStyles = false;
            this.gridElapsed.Location = new System.Drawing.Point(15, 41);
            this.gridElapsed.Name = "gridElapsed";
            this.gridElapsed.ReadOnly = true;
            this.gridElapsed.RowTemplate.Height = 25;
            this.gridElapsed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridElapsed.Size = new System.Drawing.Size(848, 444);
            this.gridElapsed.TabIndex = 13;
            this.gridElapsed.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridElapsed_CellMouseDown);
            this.gridElapsed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridElapsed_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboWithin);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.gridExpired);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(879, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Expired AMC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboWithin
            // 
            this.cboWithin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWithin.FormattingEnabled = true;
            this.cboWithin.Items.AddRange(new object[] {
            "Expired",
            "1 Week",
            "2 Weeks",
            "1 Month",
            "2 Months",
            "3 Months",
            "6 Months",
            "1 Year",
            "2 Years"});
            this.cboWithin.Location = new System.Drawing.Point(740, 14);
            this.cboWithin.Name = "cboWithin";
            this.cboWithin.Size = new System.Drawing.Size(121, 21);
            this.cboWithin.TabIndex = 15;
            this.cboWithin.SelectedIndexChanged += new System.EventHandler(this.cboWithin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expired/About to:";
            // 
            // gridExpired
            // 
            this.gridExpired.AllowUserToAddRows = false;
            this.gridExpired.AllowUserToOrderColumns = true;
            this.gridExpired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridExpired.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridExpired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridExpired.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridExpired.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridExpired.EnableHeadersVisualStyles = false;
            this.gridExpired.Location = new System.Drawing.Point(15, 41);
            this.gridExpired.Name = "gridExpired";
            this.gridExpired.ReadOnly = true;
            this.gridExpired.RowTemplate.Height = 25;
            this.gridExpired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExpired.Size = new System.Drawing.Size(848, 444);
            this.gridExpired.TabIndex = 13;
            this.gridExpired.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridExpired_CellMouseDown);
            this.gridExpired.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridExpired_MouseDown);
            // 
            // cntService
            // 
            this.cntService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolveToolStripMenuItem});
            this.cntService.Name = "cntService";
            this.cntService.Size = new System.Drawing.Size(115, 26);
            // 
            // resolveToolStripMenuItem
            // 
            this.resolveToolStripMenuItem.Name = "resolveToolStripMenuItem";
            this.resolveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.resolveToolStripMenuItem.Text = "Resolve";
            this.resolveToolStripMenuItem.Click += new System.EventHandler(this.resolveToolStripMenuItem_Click);
            // 
            // cntExpiredService
            // 
            this.cntExpiredService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAMCToolStripMenuItem,
            this.scheduleNextVisitToolStripMenuItem});
            this.cntExpiredService.Name = "cntExpiredService";
            this.cntExpiredService.Size = new System.Drawing.Size(175, 48);
            // 
            // editAMCToolStripMenuItem
            // 
            this.editAMCToolStripMenuItem.Name = "editAMCToolStripMenuItem";
            this.editAMCToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editAMCToolStripMenuItem.Text = "Edit AMC";
            this.editAMCToolStripMenuItem.Click += new System.EventHandler(this.editAMCToolStripMenuItem_Click);
            // 
            // scheduleNextVisitToolStripMenuItem
            // 
            this.scheduleNextVisitToolStripMenuItem.Name = "scheduleNextVisitToolStripMenuItem";
            this.scheduleNextVisitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.scheduleNextVisitToolStripMenuItem.Text = "Schedule Next Visit";
            this.scheduleNextVisitToolStripMenuItem.Click += new System.EventHandler(this.scheduleNextVisitToolStripMenuItem_Click);
            // 
            // frmAMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(916, 563);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAMC";
            this.Text = "Manage AMC";
            this.Load += new System.EventHandler(this.frmAMC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUpcommng)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridElapsed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpired)).EndInit();
            this.cntService.ResumeLayout(false);
            this.cntExpiredService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridUpcommng;
        private System.Windows.Forms.ContextMenuStrip cntService;
        private System.Windows.Forms.ToolStripMenuItem resolveToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridElapsed;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridExpired;
        private System.Windows.Forms.ComboBox cboWithin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cntExpiredService;
        private System.Windows.Forms.ToolStripMenuItem editAMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleNextVisitToolStripMenuItem;

    }
}