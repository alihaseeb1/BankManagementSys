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
    public partial class AdminPage : Form
    {
        string adminID;
        public AdminPage(string username)
        {
            adminID = username;
            InfoDAO infoDAO = new InfoDAO();
            string fname = (String)infoDAO.getValue("login", "username", "fName", "'" + username + "'");
            string lname = (String)infoDAO.getValue("login", "username", "lName", "'" + username + "'");
            InitializeComponent();
            FirstNameLabel.Text = fname;
            LastNameLabel.Text = lname;
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }
        private void OpenBankAccBtn_Click(object sender, EventArgs e)
        {
            CreateBankAccount newBankAcc = new CreateBankAccount(adminID);
            newBankAcc.ShowDialog();
        }
        private void CustomerDataBtn_Click(object sender, EventArgs e)
        {
            CustomerInformation customerInformation = new CustomerInformation();
            customerInformation.ShowDialog();
        }

        private void ApproveLoanBtn_Click(object sender, EventArgs e)
        {
            ApproveLoan approveLoan = new ApproveLoan(adminID);
            approveLoan.ShowDialog();
        }

        private void TransferLogBtn_Click(object sender, EventArgs e)
        {
            TransactionLog transferLog = new TransactionLog();
            transferLog.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
