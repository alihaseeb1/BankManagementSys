using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS326_Bank_Project
{
    public partial class LoginForm : Form
    {

        bool activated;
        public LoginForm()
        {
            InitializeComponent();
            activated = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "account number";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CreateAccount userCreateAccount = new CreateAccount("Customer");
            userCreateAccount.ShowDialog();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.UsernameTxtBox.Text) || string.IsNullOrEmpty(this.PasswordTxtBox.Text))
            {
                MessageBox.Show("Please fill you login details.");
            }
            else
            {
                InfoDAO loginCheck = new InfoDAO();
                if (!loginCheck.checkforUnique("login", "username", UsernameTxtBox.Text))
                {
                    object userType = loginCheck.getValue("login", "username", "usertype", '"' + UsernameTxtBox.Text + '"');
                    string nationalID = (string)loginCheck.getValue("login", "username", "nationalid", "'" + UsernameTxtBox.Text + "'");
                    object accNum = loginCheck.getValue("bankaccount", "nationalid", "accountNumber", nationalID);
                    int accountNumber = Convert.ToInt32(accNum);
                    string userTyping = userType.ToString();
                    object bankAcc = loginCheck.getValue("bankaccount", "nationalid", "*", nationalID);
                    if (userTyping == "Customer" || userTyping == "user")
                    {
                        BankAccount customerBankAccount = new BankAccount(UsernameTxtBox.Text, nationalID);
                        this.Hide();
                        customerBankAccount.ShowDialog();
                        
                    }
                    else if (userTyping == "Admin" || userTyping == "admin")
                    {
                        AdminPage newAdminPage = new AdminPage(UsernameTxtBox.Text);
                        this.Hide();
                        newAdminPage.ShowDialog();
                    }
                    else if (userTyping == "Developer" || userTyping == "developer")
                    {
                        Developer newDevPage = new Developer(UsernameTxtBox.Text);
                        this.Hide();
                        newDevPage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unexpected usertype");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                    return;
                }
            }
        }
    }
}
