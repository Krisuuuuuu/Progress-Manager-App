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
    public partial class OneRepMaxControl : UserControl
    {
        OnrBodyParts[] tab = new OnrBodyParts[2];
        public OneRepMaxControl()
        {
            InitializeComponent();
            OneRepMaxValueLabel.Text = "0";
            BodyTypeComboBox.Items.Add(OnrBodyParts.LOWER.ToString());
            BodyTypeComboBox.Items.Add(OnrBodyParts.UPPER.ToString());
            BodyTypeComboBox.Text = OnrBodyParts.LOWER.ToString();

            tab[0] = OnrBodyParts.LOWER;
            tab[1] = OnrBodyParts.UPPER;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ushort oneRepMax = Calculators.OneRepMaxCalculator((ushort)WeightNumericUpDown.Value, BodyTypeComboBox.Text);
            OneRepMaxValueLabel.Text = oneRepMax.ToString("F1");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["calculatorsControl"].BringToFront();
        }
    }
}
