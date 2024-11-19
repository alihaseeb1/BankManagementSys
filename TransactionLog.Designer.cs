namespace CSS326_Bank_Project
{
    partial class TransactionLog
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.TransDataGrid = new System.Windows.Forms.DataGridView();
            this.fromRadio = new System.Windows.Forms.RadioButton();
            this.toRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.toRadio);
            this.groupBox1.Controls.Add(this.fromRadio);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.SearchTxtBox);
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.TransDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transcation Log";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(192, 366);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(95, 30);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(6, 366);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(180, 30);
            this.SearchTxtBox.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(593, 366);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(95, 30);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TransDataGrid
            // 
            this.TransDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TransDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransDataGrid.Location = new System.Drawing.Point(6, 29);
            this.TransDataGrid.Name = "TransDataGrid";
            this.TransDataGrid.Size = new System.Drawing.Size(778, 331);
            this.TransDataGrid.TabIndex = 0;
            this.TransDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransDataGrid_CellContentClick);
            // 
            // fromRadio
            // 
            this.fromRadio.AutoSize = true;
            this.fromRadio.Location = new System.Drawing.Point(293, 368);
            this.fromRadio.Name = "fromRadio";
            this.fromRadio.Size = new System.Drawing.Size(71, 28);
            this.fromRadio.TabIndex = 5;
            this.fromRadio.Text = "From";
            this.fromRadio.UseVisualStyleBackColor = true;
            // 
            // toRadio
            // 
            this.toRadio.AutoSize = true;
            this.toRadio.Location = new System.Drawing.Point(370, 368);
            this.toRadio.Name = "toRadio";
            this.toRadio.Size = new System.Drawing.Size(47, 28);
            this.toRadio.TabIndex = 6;
            this.toRadio.Text = "To";
            this.toRadio.UseVisualStyleBackColor = true;
            // 
            // TransactionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 446);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TransactionLog";
            this.Text = "TransactionLog";
            this.Load += new System.EventHandler(this.TransactionLog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TransDataGrid;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.RadioButton toRadio;
        private System.Windows.Forms.RadioButton fromRadio;
    }
}