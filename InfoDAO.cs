using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSS326_Bank_Project
{
    internal class InfoDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=bankdb;";

        internal int addOneRecord(Info a1)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO login (username, password, nationalID, userType, occupation, phoneNumber, fName, lName, addressLine1, addressLine2, city, province, postalCode) " +
                    "VALUES (@username, @password, @nationalID, @usertype, @occupation, @phoneNumber, @fName, @lName, @addressLine1, @addressLine2, @city, @province, @postalCode)", connect))
                {
                    cmd.Parameters.AddWithValue("@username", a1.username);
                    cmd.Parameters.AddWithValue("@password", a1.password);  
                    cmd.Parameters.AddWithValue("@nationalID", a1.nationalID);
                    cmd.Parameters.AddWithValue("@usertype", a1.usertype);
                    cmd.Parameters.AddWithValue("@occupation", a1.occupation);
                    cmd.Parameters.AddWithValue("@phoneNumber", a1.phoneNumber);
                    cmd.Parameters.AddWithValue("@fName", a1.fName);
                    cmd.Parameters.AddWithValue("@lName", a1.lName);
                    cmd.Parameters.AddWithValue("@addressLine1", a1.addressLine1);
                    cmd.Parameters.AddWithValue("@addressLine2", a1.addressLine2);
                    cmd.Parameters.AddWithValue("@city", a1.city);
                    cmd.Parameters.AddWithValue("@province", a1.province);
                    cmd.Parameters.AddWithValue("@postalCode", a1.postalCode);

                    return cmd.ExecuteNonQuery(); // Returns the number of rows affected
                }
            }
        }
        public bool Login(string username, string password)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT password FROM login WHERE username = @Username", connect))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    string storedPassword = cmd.ExecuteScalar() as string;

                    // If no password is found, return false
                    return storedPassword != null && password == storedPassword; // Use hashing in real applications
                }
            }
        }
        internal bool checkforUnique(string table, string attribute, string value)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM {table} WHERE {attribute} = @val;", connect))
                {
                    cmd.Parameters.AddWithValue("@val", value);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; // Returns true if count is 0 (unique)
                }
            }
        }
        internal object getValue(string table, string condition, string getCol, string conditionVal)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand($"SELECT {getCol} FROM {table} where {condition} = {conditionVal};", connect))
                {
                    cmd.Parameters.AddWithValue("@conditionVal", conditionVal);

                    object ret = cmd.ExecuteScalar();
                    connect.Close();
                    if (ret != null)
                    {
                        return ret; //value that we want
                    }
                }
            }
            return null; // not found
        }

        internal object updateValue(string table, string updateCol, string updateVal, string conditionCol, string conditionVal)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand($"Update {table} set {updateCol} = {updateVal} where {conditionCol} = {conditionVal};", connect))
                {
                    int ret = cmd.ExecuteNonQuery();
                    connect.Close();
                    return ret;
                }
            }
        }
        internal int createBankAccount(int balance, string accountType, string nationalID, string admin)
        {

            // default values for interestRate, if Savings then 3% else 0%
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into bankaccount (nationalID, balance, interestRate, accountType, admin_username) " +
                    "values (@id, @bal, @rate, @type, @admin)", connect))
                {
                    cmd.Parameters.AddWithValue("@id", nationalID);
                    cmd.Parameters.AddWithValue("@bal", balance);
                    cmd.Parameters.AddWithValue("@rate", accountType.Equals("Savings") ? 0.03 : 0);
                    cmd.Parameters.AddWithValue("@type", accountType);
                    cmd.Parameters.AddWithValue("@admin", admin);
                    cmd.ExecuteNonQuery();
                    int newRows = 1;
                    connect.Close();
                    return newRows;
                }
            }
        }
        internal int createTransactionRecord(string from, string to, string amount)
        {

            // default values for interestRate, if Savings then 3% else 0%
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into transaction (from_account, to_account, amount, date) " +
                    $"values (@from, @to, @amount, @datetime)", connect))
                {
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    int rows = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rows;
                }
            }
        }
        public DataTable GetRecords(string tableName, string columns = "*", string condition = null, string conditionVal = null)
        {
            DataTable records = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();

                // Build the query with optional condition
                string query = $"SELECT {columns} FROM {tableName}";
                if (!string.IsNullOrEmpty(condition) && !string.IsNullOrEmpty(conditionVal))
                {
                    query += $" WHERE {condition} = '{conditionVal}'";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(records); // Fill DataTable with the query result
                    }
                }
            }
            return records;
        }
        public int createLoanRequestRecord(int accountNum, int loanTypeID, string deedItem)
        {
            // default values for interestRate, if Savings then 3% else 0%
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into loanrequest (accountNumber, loanTypeID, deedItem, requestDate) " +
                    $"values (@accountNumber, @loanTypeID, @deedItem, @datetime)", connect))
                {
                    cmd.Parameters.AddWithValue("@accountNumber", accountNum);
                    cmd.Parameters.AddWithValue("@loanTypeID", loanTypeID);
                    cmd.Parameters.AddWithValue("@deedItem", deedItem);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    int rows = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rows;
                }
            }
        }
        public double getDebt(int accNum)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT SUM(currentAmount) from debt where accountNumber = @acc group by accountNumber;", connect))
                {
                    cmd.Parameters.AddWithValue("@acc", accNum);

                    double ret = (double)(decimal)cmd.ExecuteScalar();
                    connect.Close();
                    return ret;
                }
            }
        }
        public int clearDebt(int accNum)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("Delete from debt where accountNumber = @acc;", connect))
                {
                    cmd.Parameters.AddWithValue("@acc", accNum);

                    int ret = cmd.ExecuteNonQuery();
                    connect.Close();
                    return ret;
                }
            }
        }

        public int repayDebt(int accountNumber, decimal repayAmount)
        {
            int deleted = 0;
            // Set up your MySQL connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Start a transaction to ensure all updates are atomic
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Retrieve debt records associated with the accountNumber
                        MySqlCommand selectCommand = new MySqlCommand(
                            "SELECT debtID, currentAmount FROM debt WHERE accountNumber = @AccountNumber ORDER BY currentAmount ASC",
                            connection, transaction);
                        selectCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        // Use a list to store debt records temporarily
                        var debts = new List<(int DebtID, decimal Amount)>();

                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int debtID = reader.GetInt32("debtID");
                                decimal debtAmount = reader.GetDecimal("currentAmount");
                                debts.Add((debtID, debtAmount));
                            }
                        }

                        // Process each debt in the list and apply repayment
                        foreach (var (debtID, debtAmount) in debts)
                        {
                            if (repayAmount <= 0) break;

                            decimal amountToRepay = Math.Min(debtAmount, repayAmount);
                            decimal newDebtAmount = debtAmount - amountToRepay;
                            repayAmount -= amountToRepay;

                            if (newDebtAmount > 0)
                            {
                                // Update the debt amount in the database
                                MySqlCommand updateCommand = new MySqlCommand(
                                    "UPDATE debt SET currentAmount = @NewAmount WHERE debtID = @DebtID",
                                    connection, transaction);
                                updateCommand.Parameters.AddWithValue("@NewAmount", newDebtAmount);
                                updateCommand.Parameters.AddWithValue("@DebtID", debtID);
                                updateCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                // Delete the debt record if the amount is zero
                                MySqlCommand deleteCommand = new MySqlCommand(
                                    "DELETE FROM debt WHERE debtID = @DebtID",
                                    connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@DebtID", debtID);
                                deleteCommand.ExecuteNonQuery();
                                deleted++;
                            }
                        }

                        // Commit the transaction after all updates are successful
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of any error
                        transaction.Rollback();
                        Console.WriteLine("An error occurred: " + ex.Message);
                        throw;
                    }
                    return deleted;
                }
            }
        }
        public int createDebtLog(string accountNumber, string amount)
        {

            // default values for interestRate, if Savings then 3% else 0%
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into debtlog (accountNumber, amount, repayDate) " +
                    $"values (@accountNumber, @amount, @datetime)", connect))
                {
                    cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    int rows = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rows;
                }
            }
        }
    }
}
