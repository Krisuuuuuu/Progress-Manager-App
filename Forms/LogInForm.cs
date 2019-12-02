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

namespace Progress_Manager.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void CancelLogInButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            ResetLabelsAndTextBoxes();
            LogIn(LoginTextBox.Text, PassTextBox.Text);
        }

        private void ResetLabelsAndTextBoxes()
        {
            IncorrectLoginLabel.Visible = false;
            LoginTextBox.BackColor = Color.White;
            LoginTextBox.ForeColor = Color.Gray;

            IncorrectPasswordLabel.Visible = false;
            PassTextBox.BackColor = Color.White;
            PassTextBox.ForeColor = Color.Gray;
        }
        
        private void LogIn(string login, string password)
        {
            bool isExist = UserManager.IsUserExist(login);

            if (!isExist)
            {
                IncorrectLoginLabel.Visible = true;
                LoginTextBox.BackColor = Color.Red;
                LoginTextBox.ForeColor = Color.White;
                return;
            }
            else
            {
                User user = UserManager.LoadUser(login);

                if(password==user.Password)
                {
                    UserManager.WhoIsCurrentLoged = login;
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                    
                }
                else
                {
                    IncorrectPasswordLabel.Visible = true;
                    PassTextBox.BackColor = Color.Red;
                    PassTextBox.ForeColor = Color.White;
                    return;
                }
            }
        }
    }
}
