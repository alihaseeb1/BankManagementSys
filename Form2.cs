using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS326_Bank_Project
{
    public partial class DeedItem : Form
    {
        public string deed;
        public DeedItem()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(deedTxtBx.Text))
            {
                MessageBox.Show("Enter A Deed Item!");
                return;
            }
            deed = deedTxtBx.Text;
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
