using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Forms;

namespace Progress_Manager.UserControls
{
    public partial class CalculatorsControl : UserControl
    {
        public CalculatorsControl()
        {
            InitializeComponent();
        }

        private void OneRepMaxButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["oneRepMaxControl"].BringToFront();
        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["bMIControl"].BringToFront();
        }

        private void CPMButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["cPMControl"].BringToFront();
        }
    }
}
