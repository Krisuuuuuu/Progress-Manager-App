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
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void ModifyProfileButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["modifyProfileControl"].BringToFront();
        }

        private void ShowProfileButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["showProfileControl"].BringToFront();
        }
    }
}
