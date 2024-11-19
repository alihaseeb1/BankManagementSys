namespace CSS326_Bank_Project
{
    partial class Developer
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDevBtn = new System.Windows.Forms.Button();
            this.CreateAdminBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 662);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer Page";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.LastNameLabel.Location = new System.Drawing.Point(338, 26);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(157, 40);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "LastName";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.FirstNameLabel.Location = new System.Drawing.Point(170, 26);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(162, 40);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // CreateDevBtn
            // 
            this.CreateDevBtn.Location = new System.Drawing.Point(522, 100);
            this.CreateDevBtn.Name = "CreateDevBtn";
            this.CreateDevBtn.Size = new System.Drawing.Size(110, 60);
            this.CreateDevBtn.TabIndex = 1;
            this.CreateDevBtn.Text = "Create Developer";
            this.CreateDevBtn.UseVisualStyleBackColor = true;
            this.CreateDevBtn.Click += new System.EventHandler(this.CreateDevBtn_Click);
            // 
            // CreateAdminBtn
            // 
            this.CreateAdminBtn.Location = new System.Drawing.Point(177, 100);
            this.CreateAdminBtn.Name = "CreateAdminBtn";
            this.CreateAdminBtn.Size = new System.Drawing.Size(110, 60);
            this.CreateAdminBtn.TabIndex = 1;
            this.CreateAdminBtn.Text = "Create Admin";
            this.CreateAdminBtn.UseVisualStyleBackColor = true;
            this.CreateAdminBtn.Click += new System.EventHandler(this.CreateAdminBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.ExitBtn);
            this.groupBox2.Controls.Add(this.CreateAdminBtn);
            this.groupBox2.Controls.Add(this.CreateDevBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 246);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(827, 100);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 60);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Developer";
            this.Text = "Developer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateAdminBtn;
        private System.Windows.Forms.Button CreateDevBtn;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExitBtn;
    }
}