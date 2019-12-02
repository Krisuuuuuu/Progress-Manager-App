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
    public partial class DefaultControl : UserControl
    {
        public DefaultControl()
        {
            InitializeComponent();

            HelloLabel.Text = "Good Morning, " + UserManager.WhoIsCurrentLoged + "\n Today is: " + DateTime.Now.ToString("D");
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
