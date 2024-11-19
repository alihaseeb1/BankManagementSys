using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class ApproveLoan : Form
    {
        string adminUsername;
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=bankdb;";
        public ApproveLoan(string adminID)
        {
            adminUsername = adminID;
            InitializeComponent();  
        }
        private void LoadLoanRequests()
        {
            InfoDAO infoDAO = new InfoDAO();
            DataTable loanRequests = infoDAO.GetRecords("loanrequest");

            if (loanRequests.Rows.Count > 0)
            {
                ActiveRequestDataGrid.DataSource = loanRequests;
            }
            else
            {
                MessageBox.Show("No active loan requests.");
            }
        }
        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            InfoDAO loanAmmount = new InfoDAO();
            if (ActiveRequestDataGrid.CurrentRow != null)
            {
                string loanId = ActiveRequestDataGrid.CurrentRow.Cells["loanRequestID"].Value.ToString();
                string accountNumber = ActiveRequestDataGrid.CurrentRow.Cells["accountNumber"].Value.ToString();
                string loanType = ActiveRequestDataGrid.CurrentRow.Cells["loanTypeID"].Value.ToString();
                string approvalStatus = ActiveRequestDataGrid.CurrentRow.Cells["approvalStatus"].Value.ToString();

                decimal loanAmount = (decimal)loanAmmount.getValue("loanType", "loanTypeID", "loanAmount", "'"+loanType+"'");

                DateTime dateTime = DateTime.Now;
                string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();

                    // Begin transaction to ensure all operations succeed or fail together
                    MySqlTransaction transaction = connect.BeginTransaction();

                    try
                    {
                        if (approvalStatus != "pending")
                        {
                            MessageBox.Show("loan request is not interactable");
                            return;
                        }
                        MySqlCommand updateBalanceCmd = new MySqlCommand(
                            $"UPDATE bankaccount SET balance = balance + {loanAmount} WHERE accountNumber = @accountNumber", connect, transaction);
                        updateBalanceCmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                        updateBalanceCmd.ExecuteNonQuery();

                        MySqlCommand insertDebtCmd = new MySqlCommand(
                            "INSERT INTO debt (loanRequestID, accountNumber, currentAmount, approvalDate) VALUES (@loanRequestID, @accountNumber, @currentAmount, @approvalDate)", connect, transaction);
                        insertDebtCmd.Parameters.AddWithValue("@loanRequestID", loanId);
                        insertDebtCmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                        insertDebtCmd.Parameters.AddWithValue("@currentAmount", loanAmount);
                        insertDebtCmd.Parameters.AddWithValue("@approvalDate", formattedDateTime);
                        insertDebtCmd.ExecuteNonQuery();

                        MySqlCommand deleteLoanRequestCmd = new MySqlCommand(
                            "update loanrequest set approved_admin = @adminID WHERE loanRequestID = @loanId", connect, transaction);
                        deleteLoanRequestCmd.Parameters.AddWithValue("@adminID", adminUsername);
                        deleteLoanRequestCmd.Parameters.AddWithValue("@loanId", loanId);
                        deleteLoanRequestCmd.ExecuteNonQuery();

                        MySqlCommand approvedLoanRequestCmd = new MySqlCommand(
                            "update loanrequest set approvalStatus = 'approved' WHERE loanRequestID = @loanId", connect, transaction);
                        approvedLoanRequestCmd.Parameters.AddWithValue("@loanId", loanId);
                        approvedLoanRequestCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Loan approved and amount added to customer account.");
                        LoadLoanRequests(); // Reload to reflect changes
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction in case of error
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a loan request to approve.");
            }
        }

        private void DenyBtn_Click(object sender, EventArgs e)
        {
            if (ActiveRequestDataGrid.CurrentRow != null)
            {
                string loanId = ActiveRequestDataGrid.CurrentRow.Cells["loanRequestID"].Value.ToString();

                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();

                    try
                    {
                        MySqlCommand deleteLoanRequestCmd = new MySqlCommand(
                            "update loanrequest set approvalStatus = 'denied' WHERE loanRequestID = @loanRequestID", connect);
                        deleteLoanRequestCmd.Parameters.AddWithValue("@loanRequestID", loanId);
                        deleteLoanRequestCmd.ExecuteNonQuery();

                        MessageBox.Show("Loan request denied.");
                        LoadLoanRequests();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a loan request to deny.");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApproveLoan_Load(object sender, EventArgs e)
        {
            LoadLoanRequests();
        }
    }
}
