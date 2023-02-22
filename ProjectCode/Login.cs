using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace partBproject
{
    public partial class Login : Form
    {
        private Boolean loginClicked;
        public Login()
        {
            loginClicked = false;
            InitializeComponent();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void approveLogin_Click(object sender, EventArgs e)
        {
            loginClicked = true;
            Customer cus = Program.seekCustomer(userName.Text);
            Employee emp = Program.seekEmployee(userName.Text);
            if (cus != null)
            {
                Program.seekCustomer(userName.Text);
                if (userName.Text.Equals(cus.get_id()))
                {


                    if (password.Text.Equals(cus.get_password()))
                    {
                        HomePage f = new HomePage(userName.Text, true);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {

                        string text = "Wrong password !";
                        MessageBox.Show(text);
                    }
                }

            }
            else if (emp != null)
            {
                if (userName.Text.Equals(emp.get_id()))

                {
                    if (password.Text.Equals(emp.get_password()))
                    {
                        HomePage f = new HomePage(userName.Text, false);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {

                        string text = "Wrong password !";
                        MessageBox.Show(text);
                    }

                }

            }
            else
            {
                string text = "User Not Found";
                MessageBox.Show(text);
            }

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            {
                if (password.Text == string.Empty && loginClicked)
                {
                    wrongPassword.SetError(password, "not valid password");
                }
                else
                {
                    wrongPassword.SetError(password, "");

                }
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.MaxLength = 30;
        }

        private void approveLogin_Validating(object sender, CancelEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                showPassword.BringToFront();
                password.PasswordChar = '*';

            }
        }
        private void showPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void showPassword_Click_1(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                hidePassword.BringToFront();
                password.PasswordChar = '\0';
            }
        }
    }
}
