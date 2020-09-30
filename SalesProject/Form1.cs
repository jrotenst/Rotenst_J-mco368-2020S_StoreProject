using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    public partial class LoginPage : Form
    {
        private StoreDBDataContext db = new StoreDBDataContext();
        private int emailTBClicks = 0;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void userTextBox_Click(object sender, EventArgs e)
        {
            if (emailTBClicks++ == 0)
            {
                userTextBox.Clear();
            }
        }
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userTextBox.ForeColor = Color.DimGray;
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            passwordTextBox.ForeColor = Color.DimGray;
            passwordTextBox.UseSystemPasswordChar = true;
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.ForeColor = Color.DimGray;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.CUSTOMERs.Single(c => c.userID == userTextBox.Text);

                if (user.password != passwordTextBox.Text)
                {
                    messageLabel.Text = "         incorrect password";
                }
                else
                {
                    joeysMain form2 = new joeysMain(user.userID);
                    form2.Show();
                    Visible = false;
                }
            }
            catch(Exception )
            {
                messageLabel.Text = "no account found with this email";
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            Visible = false;
        }

        
    }
}
