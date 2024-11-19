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
    public partial class Transfer : Form
    {
        int currAccountNum;
        public Transfer(int accNum)
        {
            InitializeComponent();
            currAccountNum = accNum;
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(receiveAccNumTxtBox.Text))
            {
                MessageBox.Show("Please Enter a Receiver Bank Account.");
                return;
            }
            InfoDAO inf = new InfoDAO();
            bool notExists = inf.checkforUnique("bankaccount", "accountNumber", receiveAccNumTxtBox.Text);
            if (notExists)
            {
                MessageBox.Show("Please Enter a Valid Receiver.");
                return;
            }

            double transferAmt = 0;
            var parsed = double.TryParse(amountTxtBox.Text, out transferAmt);
            if (parsed == false || transferAmt <= 0)
            {
                MessageBox.Show("Please Enter a valid Amount!");
                return;
            }
            if (currAccountNum.ToString().Equals(receiveAccNumTxtBox.Text))
            {
                MessageBox.Show("Cannot transfer to same account!");
                return;
            }
            double balance = -1;
            object balanceObj = inf.getValue("bankaccount", "accountNumber", "balance", currAccountNum.ToString());
            double.TryParse(balanceObj.ToString(), out balance);
            if (balance == -1)
            {
                MessageBox.Show("Balance Retrieval Failed");
                return;
            }
            if (balance < transferAmt)
            {
                MessageBox.Show("Insufficient Funds");
                return;
            }
            // All checks done, transfer money now
            // deduct money from one who is transferring
            inf.updateValue("bankaccount", "balance", (balance - transferAmt).ToString(), "accountNumber", currAccountNum.ToString());

            // add money to one being transferred
            // get current balance first
            object balanceTransfereeObj = inf.getValue("bankaccount", "accountNumber", "balance", receiveAccNumTxtBox.Text);
            double.TryParse(balanceTransfereeObj.ToString(), out double balanceTransferee);
            //add money now
            inf.updateValue("bankaccount", "balance", (balanceTransferee + transferAmt).ToString(), "accountNumber", receiveAccNumTxtBox.Text);

            // update transactionTable as well
            inf.createTransactionRecord(currAccountNum.ToString(), receiveAccNumTxtBox.Text, transferAmt.ToString());

            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
