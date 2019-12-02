using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Enums;
using Progress_Manager.Classes;

namespace Progress_Manager.UserControls
{
    public partial class ModifyProfileControl : UserControl
    {
        BodyTypes[] BodyTypesTab = new BodyTypes[3];
        public ModifyProfileControl()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["profileControl"].BringToFront();
        }

        private void ResetLabelsAndTextBoxes()
        {
            IncorrectNameLabel.Visible = false;
            NameTextBox.BackColor = Color.White;
            NameTextBox.ForeColor = Color.Gray;

            IncorrectSurnameLabel.Visible = false;
            SurnameTextBox.BackColor = Color.White;
            SurnameTextBox.ForeColor = Color.Gray;

        }

        private void UpdateControls()
        {

            BodyTypeComboBox.Items.Add(BodyTypes.ECTOMORPH.ToString());
            BodyTypeComboBox.Items.Add(BodyTypes.MESOMORPH.ToString());
            BodyTypeComboBox.Items.Add(BodyTypes.ENDOMORPH.ToString());
            BodyTypeComboBox.Text = BodyTypes.ECTOMORPH.ToString();

            BodyTypesTab[0] = BodyTypes.ECTOMORPH;
            BodyTypesTab[1] = BodyTypes.MESOMORPH;
            BodyTypesTab[2] = BodyTypes.ENDOMORPH;

            DateOfBirthPicker.MaxDate = DateTime.Now;
            DateOfBirthPicker.Value = DateTime.Now;


            bool isExists = UserManager.IsUserExist(UserManager.WhoIsCurrentLoged);

            if (isExists == true)
            {
                Person personFromTheFile = UserManager.LoadProfile();
                NameTextBox.Text = personFromTheFile.Name;
                SurnameTextBox.Text = personFromTheFile.Surname;
                HeightNumericUpDown.Value = personFromTheFile.Height;
                WeightNumericUpDown.Value = (decimal)personFromTheFile.Weight;
                DateOfBirthPicker.Value = personFromTheFile.DateOfBirth;
                BodyTypeComboBox.Text = personFromTheFile.BodyType.ToString();
            }

        }

        private bool CheckControls()
        {
            bool checkConfirmed = true; 

            if (NameTextBox.Text == "")
            {
                IncorrectNameLabel.Visible = true;
                NameTextBox.BackColor = Color.Red;
                NameTextBox.ForeColor = Color.White;
                checkConfirmed = false;
            }

            if (SurnameTextBox.Text == "")
            {
                IncorrectSurnameLabel.Visible = true;
                SurnameTextBox.BackColor = Color.Red;
                SurnameTextBox.ForeColor = Color.White;
                checkConfirmed = false;
            }


            if (checkConfirmed == true)
                return true;
            else
                return false;


        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ResetLabelsAndTextBoxes();
            Confirm(NameTextBox.Text, SurnameTextBox.Text, (ushort)HeightNumericUpDown.Value, (double)WeightNumericUpDown.Value, DateOfBirthPicker.Value, BodyTypeComboBox.SelectedIndex);
        }

        private void Confirm(string name, string surname, ushort height, double weight, DateTime dateOfBirth, int index)
        {
            bool checkConfirmed = CheckControls();

            if (checkConfirmed==true)
            {
                Person person = new Person(name, surname, dateOfBirth, height, weight, BodyTypesTab[index]);
                UserManager.SaveProfile(person);
            }
            else
            {
                return;
            }
        }
    }
}
