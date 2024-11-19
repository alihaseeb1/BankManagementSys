namespace CSS326_Bank_Project
{
    partial class ApproveLoan
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
            this.DenyBtn = new System.Windows.Forms.Button();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.ActiveRequestDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveRequestDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.DenyBtn);
            this.groupBox1.Controls.Add(this.ApproveBtn);
            this.groupBox1.Controls.Add(this.ActiveRequestDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Request";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(590, 366);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(95, 30);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DenyBtn
            // 
            this.DenyBtn.Location = new System.Drawing.Point(348, 366);
            this.DenyBtn.Name = "DenyBtn";
            this.DenyBtn.Size = new System.Drawing.Size(95, 30);
            this.DenyBtn.TabIndex = 2;
            this.DenyBtn.Text = "Deny";
            this.DenyBtn.UseVisualStyleBackColor = true;
            this.DenyBtn.Click += new System.EventHandler(this.DenyBtn_Click);
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Location = new System.Drawing.Point(128, 366);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(95, 30);
            this.ApproveBtn.TabIndex = 1;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // ActiveRequestDataGrid
            // 
            this.ActiveRequestDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ActiveRequestDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ActiveRequestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveRequestDataGrid.Location = new System.Drawing.Point(6, 29);
            this.ActiveRequestDataGrid.Name = "ActiveRequestDataGrid";
            this.ActiveRequestDataGrid.Size = new System.Drawing.Size(778, 331);
            this.ActiveRequestDataGrid.TabIndex = 0;
            // 
            // ApproveLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 426);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ApproveLoan";
            this.Text = "ApproveLoan";
            this.Load += new System.EventHandler(this.ApproveLoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveRequestDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ActiveRequestDataGrid;
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.Button DenyBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}