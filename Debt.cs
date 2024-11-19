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
    public partial class Debt : Form
    {
        private double currentDebt;
        private InfoDAO info;
        private int accountNumber;
        public Debt(int accNum)
        {
            info = new InfoDAO();
            currentDebt = info.getDebt(accNum);
            accountNumber = accNum;
            InitializeComponent();
            DebtAmountLabel.Text = currentDebt.ToString();
        }

        private void Debt_Load(object sender, EventArgs e)
        {

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PayDebtTxtBox.Text))
            {
                MessageBox.Show("Enter A Debt amount to repay!");
                return;
            }
            double repayAmt;
            Double.TryParse(PayDebtTxtBox.Text, out repayAmt);
            // invalid value or string entered
            if (repayAmt <= 0)
            {
                MessageBox.Show("Enter a Valid Amount to repay");
                return;
            }
            double currentBalance = (double)(decimal)info.getValue("bankaccount", "accountNumber", "balance", accountNumber.ToString());
            if (currentBalance < repayAmt)
            {
                MessageBox.Show($"You do not have sufficient funds to repay this much, your balance is only {currentBalance}");
                return;
            }
            if (repayAmt > currentDebt)
            {
                MessageBox.Show($"Your repay amount is higher than your debt of {currentDebt}");
                return;
            }
            // reduce the debt amount from the debt table, if zero then just delete it
            double newDebt = currentDebt - repayAmt;
            double newBalance = currentBalance - repayAmt;
            int deleted = 0;
            if (newDebt == 0)
            {
                // clear debt
                deleted = info.clearDebt(accountNumber);
            }
            else
            {
                deleted = info.repayDebt(accountNumber, (decimal)repayAmt);
            }
            currentDebt = info.getDebt(accountNumber);
            DebtAmountLabel.Text = currentDebt.ToString();
            // add debt to debtlog
            info.createDebtLog(accountNumber.ToString(), repayAmt.ToString());

            // update balance
            info.updateValue("bankaccount", "balance", newBalance.ToString(), "accountNumber", accountNumber.ToString());
            MessageBox.Show($"{deleted} loans were returned.\nTotal Amount repaid: {repayAmt}\nNew Account Balance is: {newBalance}");
        }
    }
}
