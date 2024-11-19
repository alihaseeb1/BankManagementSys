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
    public partial class BankAccount : Form
    {
        private string customer;
        private string nationalid;
        private InfoDAO info = new InfoDAO();
        private int accountNum;
        public int rowClicked;
        BindingSource infobindingsource = new BindingSource();
        public DataTable thisBankAccount { get; set; }

        public BankAccount(string username, string nationalID)
        {
            customer = username;
            nationalid = nationalID;
            thisBankAccount = info.GetRecords("bankaccount", "accountNumber, interestRate, accountType, balance", "nationalID", nationalID);
            InitializeComponent();
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            //BankAccDataGrid.
            Transfer transfer = new Transfer(accountNum);
            transfer.ShowDialog();
            RefreshDataGrid();
        }

        private void LoanRequestBtn_Click(object sender, EventArgs e)
        {
            LoanRequest loan = new LoanRequest(accountNum);
            loan.ShowDialog();
        }

        private void DebtBtn_Click(object sender, EventArgs e)
        {
            Debt debt = new Debt(accountNum);
            debt.ShowDialog();
        }

        private void TransactionLogBtn_Click(object sender, EventArgs e)
        {
            TransactionLog log = new TransactionLog(accountNum);
            log.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RefreshDataGrid()
        {
            // Re-fetch the updated data from the database
            thisBankAccount = info.GetRecords("bankaccount", "accountNumber, interestRate, accountType, balance", "nationalID", nationalid);

            // Rebind the DataTable to the BindingSource and refresh DataGridView
            infobindingsource.DataSource = thisBankAccount;
            BankAccDataGrid.DataSource = infobindingsource;
            infobindingsource.ResetBindings(false); // Refresh the BindingSource
        }

        private void BankAccount_Load(object sender, EventArgs e)
        {
            infobindingsource.DataSource = thisBankAccount;
            BankAccDataGrid.DataSource = infobindingsource;
            DataGridViewRow row = BankAccDataGrid.Rows[0];
            accountNum = Convert.ToInt32(row.Cells[0].Value);
        }

        private void BankAccDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = BankAccDataGrid.Rows[e.RowIndex];

                // Assuming the account number is in the second column (index 1)
                accountNum = Convert.ToInt32(row.Cells[0].Value);
                rowClicked = e.RowIndex; // Update rowClicked if needed
            }
        }
    }
}
