using RouletteNeoLibrary.DataAccess;
using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoUI.Forms
{
    public partial class SignUpForm : Form
    {
        readonly List<UserModel> userList = SQLiteDataAccess.GetUsers();

        public SignUpForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Username.Length > 0)
            {
                loginUsernameValue.Text = Properties.Settings.Default.Username;
                loginPasswordValue.Text = Properties.Settings.Default.Password;
            }
        }



        private bool LoginGranted(UserModel user)
        {
            bool loginGranted = true;

            if (user == null)
            {
                loginGranted = false;
            }

            if (user.Password != loginPasswordValue.Text)
            {
                loginGranted = false;
            }

            return loginGranted;
        }



        private bool SignUpValid()
        {
            bool signUpValid = true;

            if (firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0)
            {
                signUpValid = false;
                MessageBox.Show("We need you to enter your First and Lastname. Please try again.");
            }

            if (emailAdressValue.Text.Length == 0 || signupUsernameValue.Text.Length == 0 || signupPasswordValue.Text.Length == 0)
            {
                signUpValid = false;
                MessageBox.Show("We need you to enter an Email Adress, a Username and a Password. Please try again.");
            }

            if (confirmPasswordValue.Text.Length == 0)
            {
                signUpValid = false;
                MessageBox.Show("We need you to confirm your Password before creating an account. Please try again.");
            }

            if (!emailAdressValue.Text.Contains('@'))
            {
                signUpValid = false;
                MessageBox.Show("We need you to provide a proper Email Adress. Please try again.");
            }

            if (signupPasswordValue.Text != confirmPasswordValue.Text)
            {
                signUpValid = false;
                MessageBox.Show("Your Passwords do not match. Please try again.");
            }

            return signUpValid;
        }



        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (SignUpValid())
            {
                UserModel user = new UserModel(firstNameValue.Text, lastNameValue.Text,
                    emailAdressValue.Text, signupUsernameValue.Text, signupPasswordValue.Text);

                SQLiteDataAccess.CreateNewUser(user);

                userList.Add(user);

                loginUsernameValue.Text = signupUsernameValue.Text;
                loginPasswordValue.Text = signupPasswordValue.Text;

                firstNameValue.Clear();
                lastNameValue.Clear();
                emailAdressValue.Clear();
                signupUsernameValue.Clear();
                signupPasswordValue.Clear();
                confirmPasswordValue.Clear();
            }
        }



        private void signInButton_Click(object sender, EventArgs e)
        {
            UserModel user = userList.Find(tempUser => tempUser.Username == loginUsernameValue.Text);

            if (LoginGranted(user))
            {
                if (rememberMeCheckBox.Checked)
                {
                    Properties.Settings.Default.Username = user.Username;
                    Properties.Settings.Default.Password = user.Password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                RouletteSessionForm neoForm = new RouletteSessionForm(user);
                this.Hide();
                neoForm.ShowDialog();
                this.Close();
            }
            else
            {
                invalidCredentialsLabel.Visible = true;
            }
        }
    }
}
