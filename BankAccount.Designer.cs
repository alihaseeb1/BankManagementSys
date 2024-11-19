namespace CSS326_Bank_Project
{
    partial class BankAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TransactionLogBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BankAccDataGrid = new System.Windows.Forms.DataGridView();
            this.DebtBtn = new System.Windows.Forms.Button();
            this.LoanRequestBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.TransactionLogBtn);
            this.groupBox1.Controls.Add(this.ExitBtn);
            this.groupBox1.Controls.Add(this.BankAccDataGrid);
            this.groupBox1.Controls.Add(this.DebtBtn);
            this.groupBox1.Controls.Add(this.LoanRequestBtn);
            this.groupBox1.Controls.Add(this.TransferBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 691);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Page";
            // 
            // TransactionLogBtn
            // 
            this.TransactionLogBtn.Location = new System.Drawing.Point(716, 602);
            this.TransactionLogBtn.Name = "TransactionLogBtn";
            this.TransactionLogBtn.Size = new System.Drawing.Size(95, 60);
            this.TransactionLogBtn.TabIndex = 7;
            this.TransactionLogBtn.Text = "History";
            this.TransactionLogBtn.UseVisualStyleBackColor = true;
            this.TransactionLogBtn.Click += new System.EventHandler(this.TransactionLogBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(923, 602);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(95, 60);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BankAccDataGrid
            // 
            this.BankAccDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BankAccDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BankAccDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankAccDataGrid.Location = new System.Drawing.Point(6, 29);
            this.BankAccDataGrid.Name = "BankAccDataGrid";
            this.BankAccDataGrid.Size = new System.Drawing.Size(1129, 567);
            this.BankAccDataGrid.TabIndex = 5;
            // 
            // DebtBtn
            // 
            this.DebtBtn.Location = new System.Drawing.Point(523, 602);
            this.DebtBtn.Name = "DebtBtn";
            this.DebtBtn.Size = new System.Drawing.Size(95, 60);
            this.DebtBtn.TabIndex = 4;
            this.DebtBtn.Text = "Debt";
            this.DebtBtn.UseVisualStyleBackColor = true;
            this.DebtBtn.Click += new System.EventHandler(this.DebtBtn_Click);
            // 
            // LoanRequestBtn
            // 
            this.LoanRequestBtn.Location = new System.Drawing.Point(319, 602);
            this.LoanRequestBtn.Name = "LoanRequestBtn";
            this.LoanRequestBtn.Size = new System.Drawing.Size(95, 60);
            this.LoanRequestBtn.TabIndex = 3;
            this.LoanRequestBtn.Text = "Loan Request";
            this.LoanRequestBtn.UseVisualStyleBackColor = true;
            this.LoanRequestBtn.Click += new System.EventHandler(this.LoanRequestBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(123, 602);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(95, 60);
            this.TransferBtn.TabIndex = 2;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 686);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BankAccount";
            this.Text = "BankAccount";
            this.Load += new System.EventHandler(this.BankAccount_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BankAccDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DebtBtn;
        private System.Windows.Forms.Button LoanRequestBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.DataGridView BankAccDataGrid;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button TransactionLogBtn;
    }
}