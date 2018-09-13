namespace CustomerRelationManager
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDateTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSalesMan = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lnkNewCustomer = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblAmcDuration = new System.Windows.Forms.Label();
            this.lblAMCReminder = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboAmcDuration = new System.Windows.Forms.ComboBox();
            this.cboReminder = new System.Windows.Forms.ComboBox();
            this.dtAmcDuration = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.dtNextServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(142, 268);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(299, 21);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact Number(s):";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(142, 299);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContactNumber.Size = new System.Drawing.Size(299, 43);
            this.txtContactNumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(142, 356);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(299, 141);
            this.txtAddress.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Installation Date:";
            // 
            // dtDateTime
            // 
            this.dtDateTime.CustomFormat = "";
            this.dtDateTime.Location = new System.Drawing.Point(142, 515);
            this.dtDateTime.Name = "dtDateTime";
            this.dtDateTime.Size = new System.Drawing.Size(299, 21);
            this.dtDateTime.TabIndex = 4;
            this.dtDateTime.ValueChanged += new System.EventHandler(this.dtDateTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salesman:";
            // 
            // cboSalesMan
            // 
            this.cboSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesMan.FormattingEnabled = true;
            this.cboSalesMan.Location = new System.Drawing.Point(616, 268);
            this.cboSalesMan.Name = "cboSalesMan";
            this.cboSalesMan.Size = new System.Drawing.Size(259, 21);
            this.cboSalesMan.TabIndex = 5;
            this.cboSalesMan.SelectedIndexChanged += new System.EventHandler(this.cboSalesMan_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(719, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product:";
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(616, 326);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(259, 21);
            this.cboProduct.TabIndex = 7;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(800, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brand:";
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(616, 297);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(259, 21);
            this.cboBrand.TabIndex = 6;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCustomer.EnableHeadersVisualStyles = false;
            this.gridCustomer.Location = new System.Drawing.Point(24, 50);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.RowTemplate.Height = 25;
            this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomer.Size = new System.Drawing.Size(848, 200);
            this.gridCustomer.TabIndex = 11;
            this.gridCustomer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCustomer_CellMouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount Paid:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(616, 435);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(259, 21);
            this.txtAmount.TabIndex = 12;
            // 
            // lnkNewCustomer
            // 
            this.lnkNewCustomer.AutoSize = true;
            this.lnkNewCustomer.Location = new System.Drawing.Point(21, 569);
            this.lnkNewCustomer.Name = "lnkNewCustomer";
            this.lnkNewCustomer.Size = new System.Drawing.Size(117, 13);
            this.lnkNewCustomer.TabIndex = 16;
            this.lnkNewCustomer.TabStop = true;
            this.lnkNewCustomer.Text = "Add New Customer";
            this.lnkNewCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewCustomer_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Note:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(618, 465);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(259, 72);
            this.txtNote.TabIndex = 13;
            // 
            // lblAmcDuration
            // 
            this.lblAmcDuration.AutoSize = true;
            this.lblAmcDuration.Location = new System.Drawing.Point(504, 356);
            this.lblAmcDuration.Name = "lblAmcDuration";
            this.lblAmcDuration.Size = new System.Drawing.Size(91, 13);
            this.lblAmcDuration.TabIndex = 0;
            this.lblAmcDuration.Text = "AMC Duration:";
            // 
            // lblAMCReminder
            // 
            this.lblAMCReminder.AutoSize = true;
            this.lblAMCReminder.Location = new System.Drawing.Point(504, 383);
            this.lblAMCReminder.Name = "lblAMCReminder";
            this.lblAMCReminder.Size = new System.Drawing.Size(97, 13);
            this.lblAMCReminder.TabIndex = 0;
            this.lblAMCReminder.Text = "AMC Reminder:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Next Service:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(641, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = ":";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(655, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 21);
            this.txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboAmcDuration
            // 
            this.cboAmcDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAmcDuration.FormattingEnabled = true;
            this.cboAmcDuration.Items.AddRange(new object[] {
            "1 Year",
            "2 Years",
            "3 Years",
            "4 Years",
            "5 Years",
            "6 Years",
            "7 Years",
            "8 Years",
            "9 Years",
            "10 Years"});
            this.cboAmcDuration.Location = new System.Drawing.Point(616, 353);
            this.cboAmcDuration.Name = "cboAmcDuration";
            this.cboAmcDuration.Size = new System.Drawing.Size(259, 21);
            this.cboAmcDuration.TabIndex = 8;
            // 
            // cboReminder
            // 
            this.cboReminder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReminder.FormattingEnabled = true;
            this.cboReminder.Items.AddRange(new object[] {
            "Quarterly",
            "Yearly"});
            this.cboReminder.Location = new System.Drawing.Point(616, 380);
            this.cboReminder.Name = "cboReminder";
            this.cboReminder.Size = new System.Drawing.Size(259, 21);
            this.cboReminder.TabIndex = 10;
            this.cboReminder.SelectedIndexChanged += new System.EventHandler(this.cboReminder_SelectedIndexChanged);
            // 
            // dtAmcDuration
            // 
            this.dtAmcDuration.Location = new System.Drawing.Point(616, 354);
            this.dtAmcDuration.Name = "dtAmcDuration";
            this.dtAmcDuration.Size = new System.Drawing.Size(257, 21);
            this.dtAmcDuration.TabIndex = 9;
            this.dtAmcDuration.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "search by:";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "All",
            "Customer ID",
            "Customer Name",
            "Contact No.",
            "Salesman Name",
            "Brand",
            "Product"});
            this.cboSearch.Location = new System.Drawing.Point(474, 22);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(165, 21);
            this.cboSearch.TabIndex = 17;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // dtNextServiceDate
            // 
            this.dtNextServiceDate.CustomFormat = "";
            this.dtNextServiceDate.Location = new System.Drawing.Point(616, 407);
            this.dtNextServiceDate.Name = "dtNextServiceDate";
            this.dtNextServiceDate.Size = new System.Drawing.Size(261, 21);
            this.dtNextServiceDate.TabIndex = 11;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(24, 33);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 13);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "Count:";
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.lnkNewCustomer;
            this.ClientSize = new System.Drawing.Size(900, 607);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dtNextServiceDate);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtAmcDuration);
            this.Controls.Add(this.cboReminder);
            this.Controls.Add(this.cboAmcDuration);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lnkNewCustomer);
            this.Controls.Add(this.gridCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboSalesMan);
            this.Controls.Add(this.dtDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAMCReminder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmcDuration);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.Text = "-------------------";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSalesMan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.LinkLabel lnkNewCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblAmcDuration;
        private System.Windows.Forms.Label lblAMCReminder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboAmcDuration;
        private System.Windows.Forms.ComboBox cboReminder;
        private System.Windows.Forms.DateTimePicker dtAmcDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.DateTimePicker dtNextServiceDate;
        private System.Windows.Forms.Label lblCount;
    }
}

