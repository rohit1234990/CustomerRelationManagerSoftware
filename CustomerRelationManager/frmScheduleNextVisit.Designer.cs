namespace CustomerRelationManager
{
    partial class frmScheduleNextVisit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleNextVisit));
            this.label2 = new System.Windows.Forms.Label();
            this.gridVisits = new System.Windows.Forms.DataGridView();
            this.txtInstallationDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNextVisit = new System.Windows.Forms.DateTimePicker();
            this.lblUpcommingVisit = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.lblAMCTill = new System.Windows.Forms.Label();
            this.dtAMCTill = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Service Visits:";
            // 
            // gridVisits
            // 
            this.gridVisits.AllowUserToAddRows = false;
            this.gridVisits.AllowUserToOrderColumns = true;
            this.gridVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVisits.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridVisits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridVisits.EnableHeadersVisualStyles = false;
            this.gridVisits.Location = new System.Drawing.Point(14, 106);
            this.gridVisits.Name = "gridVisits";
            this.gridVisits.ReadOnly = true;
            this.gridVisits.RowTemplate.Height = 25;
            this.gridVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVisits.Size = new System.Drawing.Size(352, 199);
            this.gridVisits.TabIndex = 16;
            // 
            // txtInstallationDate
            // 
            this.txtInstallationDate.Location = new System.Drawing.Point(136, 18);
            this.txtInstallationDate.Name = "txtInstallationDate";
            this.txtInstallationDate.ReadOnly = true;
            this.txtInstallationDate.Size = new System.Drawing.Size(229, 21);
            this.txtInstallationDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Installation Date:";
            // 
            // dtNextVisit
            // 
            this.dtNextVisit.Location = new System.Drawing.Point(140, 345);
            this.dtNextVisit.Name = "dtNextVisit";
            this.dtNextVisit.Size = new System.Drawing.Size(226, 21);
            this.dtNextVisit.TabIndex = 19;
            // 
            // lblUpcommingVisit
            // 
            this.lblUpcommingVisit.AutoSize = true;
            this.lblUpcommingVisit.Location = new System.Drawing.Point(12, 349);
            this.lblUpcommingVisit.Name = "lblUpcommingVisit";
            this.lblUpcommingVisit.Size = new System.Drawing.Size(122, 13);
            this.lblUpcommingVisit.TabIndex = 18;
            this.lblUpcommingVisit.Text = "Schedule Next Visit:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(291, 385);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 20;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Expiry Date:";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(137, 47);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ReadOnly = true;
            this.txtExpiryDate.Size = new System.Drawing.Size(229, 21);
            this.txtExpiryDate.TabIndex = 15;
            // 
            // lblAMCTill
            // 
            this.lblAMCTill.AutoSize = true;
            this.lblAMCTill.Location = new System.Drawing.Point(12, 319);
            this.lblAMCTill.Name = "lblAMCTill";
            this.lblAMCTill.Size = new System.Drawing.Size(101, 13);
            this.lblAMCTill.TabIndex = 18;
            this.lblAMCTill.Text = "Extend AMC Till:";
            // 
            // dtAMCTill
            // 
            this.dtAMCTill.Location = new System.Drawing.Point(140, 315);
            this.dtAMCTill.Name = "dtAMCTill";
            this.dtAMCTill.Size = new System.Drawing.Size(223, 21);
            this.dtAMCTill.TabIndex = 19;
            // 
            // frmScheduleNextVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 422);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dtAMCTill);
            this.Controls.Add(this.lblAMCTill);
            this.Controls.Add(this.dtNextVisit);
            this.Controls.Add(this.lblUpcommingVisit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVisits);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstallationDate);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScheduleNextVisit";
            this.Text = "Edit AMC/Schedule Next Visit";
            this.Load += new System.EventHandler(this.frmScheduleNextVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridVisits;
        private System.Windows.Forms.TextBox txtInstallationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNextVisit;
        private System.Windows.Forms.Label lblUpcommingVisit;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblAMCTill;
        private System.Windows.Forms.DateTimePicker dtAMCTill;
    }
}