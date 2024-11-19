namespace CSS326_Bank_Project
{
    partial class AdminPage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransferLogBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CustomerDataBtn = new System.Windows.Forms.Button();
            this.OpenBankAccBtn = new System.Windows.Forms.Button();
            this.ApproveLoanBtn = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 691);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Page";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.TransferLogBtn);
            this.groupBox2.Controls.Add(this.ExitBtn);
            this.groupBox2.Controls.Add(this.CustomerDataBtn);
            this.groupBox2.Controls.Add(this.OpenBankAccBtn);
            this.groupBox2.Controls.Add(this.ApproveLoanBtn);
            this.groupBox2.Location = new System.Drawing.Point(0, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 246);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // TransferLogBtn
            // 
            this.TransferLogBtn.Location = new System.Drawing.Point(713, 85);
            this.TransferLogBtn.Name = "TransferLogBtn";
            this.TransferLogBtn.Size = new System.Drawing.Size(105, 80);
            this.TransferLogBtn.TabIndex = 3;
            this.TransferLogBtn.Text = "Transfer Log";
            this.TransferLogBtn.UseVisualStyleBackColor = true;
            this.TransferLogBtn.Click += new System.EventHandler(this.TransferLogBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(911, 85);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(105, 80);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomerDataBtn
            // 
            this.CustomerDataBtn.Location = new System.Drawing.Point(315, 85);
            this.CustomerDataBtn.Name = "CustomerDataBtn";
            this.CustomerDataBtn.Size = new System.Drawing.Size(105, 80);
            this.CustomerDataBtn.TabIndex = 1;
            this.CustomerDataBtn.Text = "Customer Data";
            this.CustomerDataBtn.UseVisualStyleBackColor = true;
            this.CustomerDataBtn.Click += new System.EventHandler(this.CustomerDataBtn_Click);
            // 
            // OpenBankAccBtn
            // 
            this.OpenBankAccBtn.Location = new System.Drawing.Point(119, 85);
            this.OpenBankAccBtn.Name = "OpenBankAccBtn";
            this.OpenBankAccBtn.Size = new System.Drawing.Size(105, 80);
            this.OpenBankAccBtn.TabIndex = 1;
            this.OpenBankAccBtn.Text = "Open a bank account";
            this.OpenBankAccBtn.UseVisualStyleBackColor = true;
            this.OpenBankAccBtn.Click += new System.EventHandler(this.OpenBankAccBtn_Click);
            // 
            // ApproveLoanBtn
            // 
            this.ApproveLoanBtn.Location = new System.Drawing.Point(523, 85);
            this.ApproveLoanBtn.Name = "ApproveLoanBtn";
            this.ApproveLoanBtn.Size = new System.Drawing.Size(105, 80);
            this.ApproveLoanBtn.TabIndex = 2;
            this.ApproveLoanBtn.Text = "Approve Loan";
            this.ApproveLoanBtn.UseVisualStyleBackColor = true;
            this.ApproveLoanBtn.Click += new System.EventHandler(this.ApproveLoanBtn_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.LastNameLabel.Location = new System.Drawing.Point(338, 26);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(157, 40);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "LastName";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.FirstNameLabel.Location = new System.Drawing.Point(170, 26);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(162, 40);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome!";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 686);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ApproveLoanBtn;
        private System.Windows.Forms.Button OpenBankAccBtn;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CustomerDataBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button TransferLogBtn;
    }
}