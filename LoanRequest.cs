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
    public partial class LoanRequest : Form
    {
        private InfoDAO info = new InfoDAO();
        private int loanTypeID = -1;
        private int rowClicked = -1;
        private int accountNumber;
        BindingSource infobindingsource = new BindingSource();
        public DataTable loanTypeTable { get; set; }
        public LoanRequest(int accNum)
        {
            accountNumber = accNum;
            loanTypeTable = info.GetRecords("loantype", "loanTypeID, loanName, loanAmount, durationYears, interestRate", "nationalID");
            InitializeComponent();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (loanTypeID == -1)
            {
                MessageBox.Show("Select a loan type first!");
                return;
            }
            // add the loan request
            //first take deedItem
            DeedItem di = new DeedItem();
            di.ShowDialog();
            string deed = di.deed;
            if (String.IsNullOrEmpty(deed))
            {
                MessageBox.Show("No Deed Item Added");
                return;
            }
            //insert record into loanRequest table with approved_admin as null
            int record = info.createLoanRequestRecord(accountNumber, loanTypeID, deed);
            if (record == 0)
            {
                MessageBox.Show("Some Error Occured, Record was not inserted");
            }
            else
            {
                MessageBox.Show("Loan Request Successfully Placed!");
            }
        }

        private void LoanRequest_Load(object sender, EventArgs e)
        {
            infobindingsource.DataSource = loanTypeTable;
            LoanTypeDataGrid.DataSource = infobindingsource;
        }
        private void LoanTypeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = LoanTypeDataGrid.Rows[e.RowIndex];

                // Assuming the account number is in the second column (index 1)
                loanTypeID = Convert.ToInt32(row.Cells[0].Value);
                rowClicked = e.RowIndex; // Update rowClicked if needed
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
