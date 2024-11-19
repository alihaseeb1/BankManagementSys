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
    public partial class CreateAccount : Form
    {

        private string userTypeChecked;

        public CreateAccount(string userType)
        {
            InitializeComponent();
            userTypeChecked = userType;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (!this.PassTxtBox.Text.Equals(this.ConPassTxtBox.Text))
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else if (string.IsNullOrEmpty(this.UsernameTxtBox.Text) ||
                     string.IsNullOrEmpty(this.PassTxtBox.Text) ||
                     string.IsNullOrEmpty(this.ConPassTxtBox.Text) ||
                     string.IsNullOrEmpty(this.FirstNameTxtBox.Text) ||
                     string.IsNullOrEmpty(this.LastNameTxtBox.Text) ||
                     string.IsNullOrEmpty(this.NationalidTxtBox.Text) ||
                     string.IsNullOrEmpty(this.PosTxtBox.Text) ||
                     string.IsNullOrEmpty(this.Address1TxtBox.Text) ||
                     string.IsNullOrEmpty(this.PostCodeTxtBox.Text) ||
                     string.IsNullOrEmpty(this.CityTxtBox.Text) ||
                     string.IsNullOrEmpty(this.ProvinceTxtBox.Text) ||
                     string.IsNullOrEmpty(this.PhoneTxtBox.Text))
            {
                MessageBox.Show("Please fill all details");
                return;
            }
            else
            {
                // Populate the Info object with the form data
                InfoDAO info1 = new InfoDAO();
                if (!info1.checkforUnique("login", "username", UsernameTxtBox.Text))
                {
                    MessageBox.Show("Username is already taken. Please choose a different username.");
                    return;
                }

                if (!info1.checkforUnique("login", "nationalid", NationalidTxtBox.Text))
                {
                    MessageBox.Show("National ID is already in use. Please enter a different National ID.");
                    return;
                }

                // Create new Info object and add it to the database
                Info newUser = new Info
                {
                    username = UsernameTxtBox.Text,
                    password = PassTxtBox.Text, // Consider hashing the password
                    fName = FirstNameTxtBox.Text,
                    lName = LastNameTxtBox.Text,
                    nationalID = NationalidTxtBox.Text,
                    occupation = PosTxtBox.Text,
                    postalCode = PostCodeTxtBox.Text,
                    addressLine1 = Address1TxtBox.Text,
                    addressLine2 = Address2TxtBox.Text,
                    city = CityTxtBox.Text,
                    province = ProvinceTxtBox.Text,
                    phoneNumber = PhoneTxtBox.Text,
                    usertype = userTypeChecked,
                };

                int result = info1.addOneRecord(newUser);
                MessageBox.Show(result > 0 ? "Account created successfully!" : "Error creating account.");
                this.Close();
            }
        }
    }
}