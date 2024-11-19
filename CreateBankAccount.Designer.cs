namespace CSS326_Bank_Project
{
    partial class CreateBankAccount
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
            this.button1 = new System.Windows.Forms.Button();
            this.createAccBt = new System.Windows.Forms.Button();
            this.initialBalTxtBox = new System.Windows.Forms.TextBox();
            this.nationalidTxtBox = new System.Windows.Forms.TextBox();
            this.accountTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.createAccBt);
            this.groupBox1.Controls.Add(this.initialBalTxtBox);
            this.groupBox1.Controls.Add(this.nationalidTxtBox);
            this.groupBox1.Controls.Add(this.accountTypeCmbBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 54;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createAccBt
            // 
            this.createAccBt.Location = new System.Drawing.Point(342, 240);
            this.createAccBt.Name = "createAccBt";
            this.createAccBt.Size = new System.Drawing.Size(95, 30);
            this.createAccBt.TabIndex = 53;
            this.createAccBt.Text = "Create";
            this.createAccBt.UseVisualStyleBackColor = true;
            this.createAccBt.Click += new System.EventHandler(this.createAccBt_Click);
            // 
            // initialBalTxtBox
            // 
            this.initialBalTxtBox.Location = new System.Drawing.Point(404, 188);
            this.initialBalTxtBox.Name = "initialBalTxtBox";
            this.initialBalTxtBox.Size = new System.Drawing.Size(100, 30);
            this.initialBalTxtBox.TabIndex = 6;
            // 
            // nationalidTxtBox
            // 
            this.nationalidTxtBox.Location = new System.Drawing.Point(404, 152);
            this.nationalidTxtBox.Name = "nationalidTxtBox";
            this.nationalidTxtBox.Size = new System.Drawing.Size(100, 30);
            this.nationalidTxtBox.TabIndex = 5;
            // 
            // accountTypeCmbBox
            // 
            this.accountTypeCmbBox.FormattingEnabled = true;
            this.accountTypeCmbBox.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accountTypeCmbBox.Location = new System.Drawing.Point(404, 117);
            this.accountTypeCmbBox.Name = "accountTypeCmbBox";
            this.accountTypeCmbBox.Size = new System.Drawing.Size(121, 32);
            this.accountTypeCmbBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label3.Location = new System.Drawing.Point(254, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label2.Location = new System.Drawing.Point(284, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "National ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type";
            // 
            // CreateBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 426);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateBankAccount";
            this.Text = "CreateAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialBalTxtBox;
        private System.Windows.Forms.TextBox nationalidTxtBox;
        private System.Windows.Forms.ComboBox accountTypeCmbBox;
        private System.Windows.Forms.Button createAccBt;
        private System.Windows.Forms.Button button1;
    }
}