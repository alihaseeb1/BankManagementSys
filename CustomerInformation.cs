using MySql.Data.MySqlClient;
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
    public partial class CustomerInformation : Form
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            InfoDAO ret = new InfoDAO();
            DataTable CustomerInfo;
            CustomerInfo = ret.GetRecords("login", "nationalID, occupation, phoneNumber, concat(fName,lName) as fullName, addressLine1, addressLine2, city, province, postalCode", "userType", "customer");
            if (CustomerInfo.Rows.Count <= 0)
            {
                MessageBox.Show("No transaction logs found.");
                return;
            }
            else
            {
                CustomerDataGrid.DataSource = CustomerInfo;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }
            InfoDAO delete = new InfoDAO();
            string nationalID = CustomerDataGrid.SelectedRows[0].Cells["nationalID"].Value.ToString();
            object balanceObj = delete.getValue("bankaccount", "nationalID", "balance", "'"+nationalID+"'");
            if (balanceObj == null)
            {
                MessageBox.Show("Unable to retrieve the balance. Please try again.");
                return;
            }
            decimal balance = Convert.ToDecimal(balanceObj);
            if (balance > 0)
            {
                MessageBox.Show("Cannot delete customer with non-zero balance.");
                return;
            }
            MySqlCommand deleteQuery = new MySqlCommand($"DELETE FROM bankaccount WHERE nationalID = '{nationalID}'");
            try
            {
                int rowsAffected = deleteQuery.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bank account deleted successfully.");
                    object remainingAccounts = delete.getValue("bankaccount", "nationalID", "COUNT(*)", $"'{nationalID}'");
                    int remainingAccountsCount = Convert.ToInt32(remainingAccounts);
                    if (remainingAccountsCount == 0)
                    {
                        MySqlCommand deleteLoginQuery = new MySqlCommand($"DELETE FROM bankaccount WHERE nationalID = '{nationalID}'");
                        int loginRowAffected = deleteLoginQuery.ExecuteNonQuery();
                        if (loginRowAffected > 0)
                        {
                            MessageBox.Show("Customer and associated bank account(s) deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting customer record from login table.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bank account deleted successfully.");
                    }
                    CustomerInformation_Load(sender, e);
                }
                    else
                {
                    MessageBox.Show("No customer was deleted. Please check the information and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CustomerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
