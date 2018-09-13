namespace CustomerRelationManager
{
    partial class frmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.label6 = new System.Windows.Forms.Label();
            this.txtInstallationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.gridVisits = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpcommingVisit = new System.Windows.Forms.Label();
            this.dtNextVisit = new System.Windows.Forms.DateTimePicker();
            this.btnResolve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.dtCurrentVisit = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Installation Date:";
            // 
            // txtInstallationDate
            // 
            this.txtInstallationDate.Location = new System.Drawing.Point(123, 16);
            this.txtInstallationDate.Name = "txtInstallationDate";
            this.txtInstallationDate.ReadOnly = true;
            this.txtInstallationDate.Size = new System.Drawing.Size(197, 21);
            this.txtInstallationDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expiry Date:";
            // 
            // dtExpiryDate
            // 
            this.dtExpiryDate.Enabled = false;
            this.dtExpiryDate.Location = new System.Drawing.Point(451, 13);
            this.dtExpiryDate.Name = "dtExpiryDate";
            this.dtExpiryDate.Size = new System.Drawing.Size(230, 21);
            this.dtExpiryDate.TabIndex = 7;
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
            this.gridVisits.Location = new System.Drawing.Point(18, 70);
            this.gridVisits.Name = "gridVisits";
            this.gridVisits.ReadOnly = true;
            this.gridVisits.RowTemplate.Height = 25;
            this.gridVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVisits.Size = new System.Drawing.Size(302, 199);
            this.gridVisits.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Service Visits:";
            // 
            // lblUpcommingVisit
            // 
            this.lblUpcommingVisit.AutoSize = true;
            this.lblUpcommingVisit.Location = new System.Drawing.Point(336, 253);
            this.lblUpcommingVisit.Name = "lblUpcommingVisit";
            this.lblUpcommingVisit.Size = new System.Drawing.Size(107, 13);
            this.lblUpcommingVisit.TabIndex = 5;
            this.lblUpcommingVisit.Text = "Upcomming Visit:";
            // 
            // dtNextVisit
            // 
            this.dtNextVisit.Location = new System.Drawing.Point(444, 247);
            this.dtNextVisit.Name = "dtNextVisit";
            this.dtNextVisit.Size = new System.Drawing.Size(237, 21);
            this.dtNextVisit.TabIndex = 7;
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(606, 282);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 15;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scheduled Visit:";
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(447, 274);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(69, 17);
            this.chkAgree.TabIndex = 16;
            this.chkAgree.Text = "I Agree";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.Visible = false;
            this.chkAgree.CheckedChanged += new System.EventHandler(this.chkAgree_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(15, 292);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(263, 13);
            this.lblMsg.TabIndex = 17;
            this.lblMsg.Text = "*AMC Service for this customer has expired.";
            this.lblMsg.Visible = false;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(444, 192);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(47, 17);
            this.chkEdit.TabIndex = 18;
            this.chkEdit.Text = "Edit";
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkExit_CheckedChanged);
            // 
            // dtCurrentVisit
            // 
            this.dtCurrentVisit.Enabled = false;
            this.dtCurrentVisit.Location = new System.Drawing.Point(444, 214);
            this.dtCurrentVisit.Name = "dtCurrentVisit";
            this.dtCurrentVisit.Size = new System.Drawing.Size(237, 21);
            this.dtCurrentVisit.TabIndex = 19;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 317);
            this.Controls.Add(this.dtCurrentVisit);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVisits);
            this.Controls.Add(this.dtNextVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtExpiryDate);
            this.Controls.Add(this.lblUpcommingVisit);
            this.Controls.Add(this.txtInstallationDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInstallationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtExpiryDate;
        private System.Windows.Forms.DataGridView gridVisits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpcommingVisit;
        private System.Windows.Forms.DateTimePicker dtNextVisit;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.DateTimePicker dtCurrentVisit;

    }
}