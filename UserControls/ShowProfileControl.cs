using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Classes;

namespace Progress_Manager.UserControls
{
    public partial class ShowProfileControl : UserControl
    {
        public ShowProfileControl()
        {
            InitializeComponent();
            UpdateLabels();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["profileControl"].BringToFront();
        }

        private void UpdateLabels()
        {
            bool isExists = UserManager.IsUserExist(UserManager.WhoIsCurrentLoged);

            if(isExists == true)
            {
                Person person = UserManager.LoadProfile();

                NameLabel.Text = "Name: " + person.Name;
                SurnameLabel.Text = "Surname: " + person.Surname;
                DateOfBirthdayLabel.Text = "Date of Birthday: " + person.DateOfBirth.ToString("d");
                HeightLabel.Text = "Height: " + person.Height.ToString();
                WeightLabel.Text = "Weight: " + person.Weight.ToString();
                BodyTypeLabel.Text = "Body Type: " + person.BodyType.ToString();
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
