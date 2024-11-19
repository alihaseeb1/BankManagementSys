using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CSS326_Bank_Project
{
    public partial class TransactionLog : Form
    {
        string accountNum = null;

        public TransactionLog()
        {
            InitializeComponent();
        }

        public TransactionLog(int accNum)
        {
            accountNum = Convert.ToString(accNum);
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionLog_Load(object sender, EventArgs e)
        {
            InfoDAO infoDAO = new InfoDAO();
            DataTable transactionData, fromTransactionData, toTransactionData;

            // Retrieve data based on whether accountNum is provided
            if (accountNum == null)
            {
                // Get all transactions if no account number is specified
                transactionData = infoDAO.GetRecords("transaction");
            }
            else
            {
                // Get transactions for the specified account number
                //string condition = "from_account"; // or "to_account" if needed


                // combines both records where account is found in the from_account and to_account column
                fromTransactionData = infoDAO.GetRecords("transaction", "*", "from_account", accountNum);
                toTransactionData = infoDAO.GetRecords("transaction", "*", "to_account", accountNum);
                fromTransactionData.Merge(toTransactionData);
                transactionData = fromTransactionData;

            }

            // Display the data in the DataGridView or show a message if empty
            if (transactionData.Rows.Count > 0)
            {
                TransDataGrid.DataSource = transactionData;
            }
            else
            {
                MessageBox.Show("No transaction logs found.");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            accountNum = SearchTxtBox.Text;
            InfoDAO infoDAO = new InfoDAO();
            DataTable transactionData;

            if (fromRadio.Checked)
            {
                
                transactionData = infoDAO.GetRecords("transaction", "*", "from_account", accountNum);
            }
            else if (toRadio.Checked)
            {
                
                transactionData = infoDAO.GetRecords("transaction", "*", "to_account", accountNum);
            }
            else
            {
                MessageBox.Show("Please select either 'From Account' or 'To Account' to search.");
                return;
            }

            
            if (transactionData.Rows.Count <= 0)
            {
                MessageBox.Show("No transaction logs found for the specified account.");
            }
            else
            {
                TransDataGrid.DataSource = transactionData;
            }
        }


        private void TransDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
