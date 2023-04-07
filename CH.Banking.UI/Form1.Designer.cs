namespace CH.Banking.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCustomers = new ListBox();
            lblID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblSSN = new Label();
            lblBirthDate = new Label();
            lblAge = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSSN = new TextBox();
            txtBirthDate = new TextBox();
            txtAge = new TextBox();
            txtID = new TextBox();
            DGVWithdrawals = new DataGridView();
            DGVDeposits = new DataGridView();
            lblDeposit = new Label();
            lblWithdrawal = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadFromXML = new Button();
            btnSaveToXML = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVWithdrawals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVDeposits).BeginInit();
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(27, 3);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(261, 304);
            lstCustomers.TabIndex = 0;
            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged_1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(373, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(373, 77);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(373, 119);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSSN.Location = new Point(373, 161);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(50, 25);
            lblSSN.TabIndex = 1;
            lblSSN.Text = "SSN:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthDate.Location = new Point(373, 194);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(100, 25);
            lblBirthDate.TabIndex = 1;
            lblBirthDate.Text = "Birth Date:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAge.Location = new Point(373, 239);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(49, 25);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(558, 81);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(558, 121);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtSSN
            // 
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Location = new Point(558, 161);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(100, 23);
            txtSSN.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            txtBirthDate.BorderStyle = BorderStyle.FixedSingle;
            txtBirthDate.Location = new Point(558, 199);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(100, 23);
            txtBirthDate.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(558, 239);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(558, 35);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // DGVWithdrawals
            // 
            DGVWithdrawals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVWithdrawals.Location = new Point(51, 474);
            DGVWithdrawals.Name = "DGVWithdrawals";
            DGVWithdrawals.RowTemplate.Height = 25;
            DGVWithdrawals.Size = new Size(735, 115);
            DGVWithdrawals.TabIndex = 3;
            // 
            // DGVDeposits
            // 
            DGVDeposits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDeposits.Location = new Point(51, 348);
            DGVDeposits.Name = "DGVDeposits";
            DGVDeposits.RowTemplate.Height = 25;
            DGVDeposits.Size = new Size(735, 99);
            DGVDeposits.TabIndex = 3;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposit.Location = new Point(51, 324);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(66, 21);
            lblDeposit.TabIndex = 4;
            lblDeposit.Text = "Deposit:";
            // 
            // lblWithdrawal
            // 
            lblWithdrawal.AutoSize = true;
            lblWithdrawal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWithdrawal.Location = new Point(51, 450);
            lblWithdrawal.Name = "lblWithdrawal";
            lblWithdrawal.Size = new Size(93, 21);
            lblWithdrawal.TabIndex = 4;
            lblWithdrawal.Text = "Withdrawal:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(373, 290);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(106, 33);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(497, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(619, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 33);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromXML
            // 
            btnLoadFromXML.Location = new Point(187, 607);
            btnLoadFromXML.Name = "btnLoadFromXML";
            btnLoadFromXML.Size = new Size(116, 36);
            btnLoadFromXML.TabIndex = 6;
            btnLoadFromXML.Text = "Load from XML";
            btnLoadFromXML.UseVisualStyleBackColor = true;
            // 
            // btnSaveToXML
            // 
            btnSaveToXML.Location = new Point(51, 607);
            btnSaveToXML.Name = "btnSaveToXML";
            btnSaveToXML.Size = new Size(116, 36);
            btnSaveToXML.TabIndex = 6;
            btnSaveToXML.Text = "Save to XML";
            btnSaveToXML.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 655);
            Controls.Add(btnSaveToXML);
            Controls.Add(btnLoadFromXML);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lblWithdrawal);
            Controls.Add(lblDeposit);
            Controls.Add(DGVDeposits);
            Controls.Add(DGVWithdrawals);
            Controls.Add(txtAge);
            Controls.Add(txtBirthDate);
            Controls.Add(txtSSN);
            Controls.Add(txtLastName);
            Controls.Add(txtID);
            Controls.Add(txtFirstName);
            Controls.Add(lblAge);
            Controls.Add(lblBirthDate);
            Controls.Add(lblSSN);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblID);
            Controls.Add(lstCustomers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGVWithdrawals).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVDeposits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomers;
        private Label lblID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSSN;
        private Label lblBirthDate;
        private Label lblAge;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSSN;
        private TextBox txtBirthDate;
        private TextBox txtAge;
        private TextBox txtID;
        private DataGridView DGVWithdrawals;
        private DataGridView DGVDeposits;
        private Label lblDeposit;
        private Label lblWithdrawal;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadFromXML;
        private Button btnSaveToXML;
    }
}