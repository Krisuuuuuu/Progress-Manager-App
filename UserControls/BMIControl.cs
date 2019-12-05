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
using Progress_Manager.Forms;

namespace Progress_Manager.UserControls
{
    public partial class BMIControl : UserControl
    {
        public BMIControl()
        {
            InitializeComponent();
            ResetLabels();
        }

        private void ResetLabels()
        {
            BMIValueLabel.Visible = false;
            BMIDescription.Visible = false;
        }

        private void Back()
        {
            ResetLabels();
            this.Parent.Controls["calculatorsControl"].BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void SetDescription(double bmi)
        {
            BMIValueLabel.Visible = true;
            BMIDescription.Visible = true;
            BMIValueLabel.Text = bmi.ToString("F");

            if(bmi<16)
            {
                BMIValueLabel.ForeColor = Color.Red;
                BMIDescription.ForeColor = Color.Red;
                BMIDescription.Text = "You are starving. Your weight is dramatic. It is your last wake-up call!";
            }

            if (bmi >= 16 && bmi < 16.99)
            {
                BMIValueLabel.ForeColor = Color.Orange;
                BMIDescription.ForeColor = Color.Orange;
                BMIDescription.Text = "You are emaciated. You are on the border of starving. Don't sleep, start doing!";
            }

            if (bmi >= 17 && bmi < 18.49)
            {
                BMIValueLabel.ForeColor = Color.Yellow;
                BMIDescription.ForeColor = Color.Yellow;
                BMIDescription.Text = "You have underweight. Don't give up - no pain, no gain!";
            }

            if (bmi >= 18.5 && bmi < 24.99)
            {
                BMIValueLabel.ForeColor = Color.Green;
                BMIDescription.ForeColor = Color.Green;
                BMIDescription.Text = "Your weight is correct. Keep it up!";
            }

            if (bmi >= 25 && bmi < 34.99)
            {
                BMIValueLabel.ForeColor = Color.Yellow;
                BMIDescription.ForeColor = Color.Yellow;
                BMIDescription.Text = "You have first degree of obesity. Set one's shoulder to the wheel and get to work!";
            }

            if (bmi >= 35 && bmi < 39.99)
            {
                BMIValueLabel.ForeColor = Color.Orange;
                BMIDescription.ForeColor = Color.Orange;
                BMIDescription.Text = "You have second degree of obesity. It is your last wake up call!";
            }

            if (bmi > 40)
            {
                BMIValueLabel.ForeColor = Color.Red;
                BMIDescription.ForeColor = Color.Red;
                BMIDescription.Text = "You have third degree of obesity. Your health is in danger";
            }


        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            double bmi = Calculators.BMICalculator((double)HeightNumericUpDown.Value, (double)WeightNumericUpDown.Value);
            SetDescription(bmi);

        }

    }
}
