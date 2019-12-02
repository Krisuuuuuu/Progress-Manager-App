using Progress_Manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Manager
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }


        private void CancelSignInButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            ResetLabelsAndTextBoxes();
            SignIn(LoginTextBox.Text, PassTextBox.Text, EmailTextBox.Text);
            
        }

        private void ResetLabelsAndTextBoxes()
        {
            IncorrectLoginLabel.Visible = false;
            LoginTextBox.BackColor = Color.White;
            LoginTextBox.ForeColor = Color.Gray;

            IncorrectPasswordLabel.Visible = false;
            PassTextBox.BackColor = Color.White;
            PassTextBox.ForeColor = Color.Gray;

            IncorrectPasswordLabel2.Visible = false;
            RePassTextBox.BackColor = Color.White;
            RePassTextBox.ForeColor = Color.Gray;

            IncorrectReEnteredLabel.Visible = false;
            RePassTextBox.BackColor = Color.White;
            RePassTextBox.ForeColor = Color.Gray;

            IncorrectEmailLabel.Visible = false;
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.ForeColor = Color.Gray;

            NoCheckLabel.Visible = false;
        }

        private bool CheckControls()
        {
            bool checkConfirmed = true;

            if (LoginTextBox.Text == "")
            {
                IncorrectLoginLabel.Visible = true;
                LoginTextBox.BackColor = Color.Red;
                LoginTextBox.ForeColor = Color.White;
                checkConfirmed = false;
            }

            if (PassTextBox.Text == "")
            {
                IncorrectPasswordLabel.Visible = true;
                PassTextBox.BackColor = Color.Red;
                PassTextBox.ForeColor = Color.White;
                checkConfirmed = false;
            }

            if (RePassTextBox.Text == "")
            {
                IncorrectReEnteredLabel.Visible = true;
                RePassTextBox.BackColor = Color.Red;
                RePassTextBox.ForeColor = Color.White;
                checkConfirmed = false;
            }

            if (EmailTextBox.Text == "")
            {
                IncorrectEmailLabel.Visible = true;
                EmailTextBox.BackColor = Color.Red;
                RePassLabel.ForeColor = Color.White;
                checkConfirmed = false;
            }

            if (!LicenseTermCheckBox.Checked)
            {
                NoCheckLabel.Visible = true;
                checkConfirmed = false;
            }

            if (checkConfirmed == true)
                return true;
            else
                return false;
        }

        private void SignIn(string login, string password, string email)
        {
            UserManager.CreateDirectories();

            bool checkConfirmed = CheckControls();

            if(checkConfirmed == true)
            {
                bool isExist = UserManager.IsUserExist(login);

                if (!isExist)
                {

                    if (PassTextBox.Text != RePassTextBox.Text)
                    {
                        IncorrectPasswordLabel2.Visible = true;
                        PassTextBox.BackColor = Color.Red;
                        PassTextBox.ForeColor = Color.White;
                        RePassTextBox.BackColor = Color.Red;
                        RePassTextBox.ForeColor = Color.White;
                    }
                    else
                    {
                        User user = new User(login, password, email);
                        UserManager.SaveUser(user);
                        Person person = new Person();
                        UserManager.SaveProfile(person, user.Login);
                    }
                }
                else
                {
                    IncorrectLoginLabel.Visible = true;
                    LoginTextBox.BackColor = Color.Red;
                    LoginTextBox.ForeColor = Color.White;
                }
            }            
            
        }
    }
}
