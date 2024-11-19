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
    public partial class Developer : Form
    {
        public Developer(string username)
        {
            string devID = username;
            InfoDAO infoDAO = new InfoDAO();
            string fname = (String)infoDAO.getValue("login", "username", "fName", "'" + username + "'");
            string lname = (String)infoDAO.getValue("login", "username", "lName", "'" + username + "'");
            InitializeComponent();
            FirstNameLabel.Text = fname;
            LastNameLabel.Text = lname;
        }
        private void CreateAdminBtn_Click(object sender, EventArgs e)
        {
            CreateAccount userCreateAccount = new CreateAccount("Admin");
            userCreateAccount.ShowDialog();
        }
        private void CreateDevBtn_Click(object sender, EventArgs e)
        {
            CreateAccount userCreateAccount = new CreateAccount("Developer");
            userCreateAccount.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
