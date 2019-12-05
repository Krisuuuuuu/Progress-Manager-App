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
    public partial class CPMControl : UserControl
    {
        double[] activityTab = new double[5];
        public CPMControl()
        {
            InitializeComponent();

            InitializeControls();
            
        }

        private void InitializeControls()
        {

            CPMValueLabel.Text = "0";

            SexComboBox.Items.Add(Sex.FEMALE.ToString());
            SexComboBox.Items.Add(Sex.MALE.ToString());
            SexComboBox.Text = Sex.FEMALE.ToString();

            double noActivity = 1.2;
            double lowActivity = 1.35;
            double mediumActivity = 1.55;
            double highActivity = 1.75;
            double veryHighActivity = 2.05;

            ActivityComboBox.Items.Add("No activity");
            ActivityComboBox.Items.Add("Low activity");
            ActivityComboBox.Items.Add("Medium activity");
            ActivityComboBox.Items.Add("High activity");
            ActivityComboBox.Items.Add("Very high activity");
            ActivityComboBox.Text = "No activity";

            activityTab[0] = noActivity;
            activityTab[1] = lowActivity;
            activityTab[2] = mediumActivity;
            activityTab[3] = highActivity;
            activityTab[4] = veryHighActivity;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateCPM();
        }

        private void CalculateCPM()
        {
            int index = ActivityComboBox.SelectedIndex;
            double activity = activityTab[index];

            ushort cPM = Calculators.CPMCalculator((ushort)HeightNumericUpDown.Value, (double)WeightNumericUpDown.Value, (byte)AgeNumericUpDown.Value,
                SexComboBox.Text, activity, ReductionCheckBox.Checked);

            CPMValueLabel.Text = cPM.ToString("F0");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["calculatorsControl"].BringToFront();
        }
    }
}
