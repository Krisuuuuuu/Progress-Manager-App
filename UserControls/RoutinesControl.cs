using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Manager.UserControls
{
    public partial class RoutinesControl : UserControl
    {
        public RoutinesControl()
        {
            InitializeComponent();
        }

        private void WorkoutButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["routinesManagerControl"].BringToFront();
        }

        private void StretchingButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["stretchingRoutinesManagerControl"].BringToFront();
        }

        private void CardioButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["cardioRoutineManagerUserControl"].BringToFront();
        }
    }
}
