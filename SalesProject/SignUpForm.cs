using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    public partial class SignUpForm : Form
    {
        private StoreDBDataContext db = new StoreDBDataContext();
        private bool validUser = false;
        private bool validPass = false;
        
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            // remove spaces
            messageLabel.Text = messageLabel.Text.Replace(" ", "");

            if (db.CUSTOMERs.Any(u => u.userID == userTextBox.Text))
            {
                validUser = false;
                messageLabel.Text = "username is already taken";
            }
            else if (userTextBox.Text == null)
            {
                validUser = false;
            }
            else
            {
                validUser = true;
                messageLabel.Text = "";
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            // remove spaces
            passTextBox.Text.Replace(" ", "");

            if (passTextBox.Text.Equals(passTextBox2.Text) && passTextBox != null)
            {
                validPass = true;
            }
            else
            {
                validPass = false;
            }
        }

        private void passTextBox2_TextChanged(object sender, EventArgs e)
        {
            // remove spaces
            passTextBox2.Text.Replace(" ", "");

            if (passTextBox.Text.Equals(passTextBox2.Text) && passTextBox != null)
            {
                validPass = true;
            }
            else
            {
                validPass = false;
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (!passTextBox.Text.Equals(passTextBox2.Text))
            {
                validPass = false;
                messageLabel.Text = "passwords do not match";
            }
            else if (passTextBox.Text == null)
            {
                validPass = false;
                messageLabel.Text = "enter a password";
            }
            else if (validUser && validPass)
            {
                CUSTOMER user = new CUSTOMER()
                {
                    userID = userTextBox.Text,
                    password = passTextBox.Text
                };

                db.CUSTOMERs.InsertOnSubmit(user);

                try
                {
                    db.SubmitChanges();
                    LoginPage login = new LoginPage();
                    login.Show();
                    Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            



        }

        
    }
}
