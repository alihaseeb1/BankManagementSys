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
    public partial class CreateBankAccount : Form
    {
        string initiated_by;
        public CreateBankAccount(string admin) // is passed the admin user name, who initiates the request to create an account
        {
            InitializeComponent();
            initiated_by = admin;
        }
        private void createAccBt_Click(object sender, EventArgs e)
        {
            if (accountTypeCmbBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a valid Account Type");
                return;
            }
            else if (string.IsNullOrEmpty(nationalidTxtBox.Text) || nationalidTxtBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter a valid national ID");
                return;
            }
            var initialBal = 0;
            var parsed = int.TryParse(initialBalTxtBox.Text, out initialBal);
            if (parsed == false)
            {
                MessageBox.Show("Please Enter a valid Balance, Note that initial balance cannot be 0!");
                return;
            }
            // all values checked can add to db
            InfoDAO exec = new InfoDAO();
            string accountType = (string)accountTypeCmbBox.SelectedItem;
            exec.createBankAccount(initialBal, accountType, nationalidTxtBox.Text, initiated_by);
            MessageBox.Show($"Bank Account with balance of {initialBal}, for {nationalidTxtBox.Text} is successfully created");
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
