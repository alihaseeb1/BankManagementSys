namespace CSS326_Bank_Project
{
    partial class Debt
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.PayDebtTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DebtAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.PayBtn);
            this.groupBox1.Controls.Add(this.PayDebtTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DebtAmountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debt Payment";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(351, 296);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(95, 30);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(351, 260);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(95, 30);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // PayDebtTxtBox
            // 
            this.PayDebtTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.PayDebtTxtBox.Location = new System.Drawing.Point(417, 160);
            this.PayDebtTxtBox.Name = "PayDebtTxtBox";
            this.PayDebtTxtBox.Size = new System.Drawing.Size(100, 32);
            this.PayDebtTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label3.Location = new System.Drawing.Point(230, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make a payment: ";
            // 
            // DebtAmountLabel
            // 
            this.DebtAmountLabel.AutoSize = true;
            this.DebtAmountLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.DebtAmountLabel.Location = new System.Drawing.Point(412, 130);
            this.DebtAmountLabel.Name = "DebtAmountLabel";
            this.DebtAmountLabel.Size = new System.Drawing.Size(130, 27);
            this.DebtAmountLabel.TabIndex = 1;
            this.DebtAmountLabel.Text = "Debt Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label1.Location = new System.Drawing.Point(247, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outgoing Debt: ";
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 426);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Debt";
            this.Text = "Debt";
            this.Load += new System.EventHandler(this.Debt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DebtAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.TextBox PayDebtTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackBtn;
    }
}