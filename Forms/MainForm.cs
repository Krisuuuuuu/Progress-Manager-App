using Progress_Manager.Classes;
using Progress_Manager.UserControls;
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
    public partial class MainForm : Form
    {
        private  MainForm instance;

        public MainForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainForm();

                return instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UserNameLabel.Text = UserManager.WhoIsCurrentLoged;
            CheckControls();
            RoutineManager.ResetPaths();
            CentralPanel.Controls["defaultControl"].BringToFront(); 
        }

        public Panel Container   
        {
            get
            {
                return CentralPanel;
            }
            set
            {
                CentralPanel = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            instance = this;

        }

        private void CheckControls()
        {
            DefaultControl defaultControl = new DefaultControl();
            defaultControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(defaultControl);

            CalculatorsControl calculatorsControl = new CalculatorsControl();
            calculatorsControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(calculatorsControl);

            OneRepMaxControl oneRepMaxControl = new OneRepMaxControl();
            oneRepMaxControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(oneRepMaxControl);

            BMIControl bMIControl = new BMIControl();
            bMIControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(bMIControl);

            CPMControl cPMControl = new CPMControl();
            cPMControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(cPMControl);

            RoutinesControl routinesControl = new RoutinesControl();
            routinesControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(routinesControl);

            RoutinesManagerControl routinesManagerControl = new RoutinesManagerControl();
            routinesManagerControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(routinesManagerControl);

            ProfileControl profileControl = new ProfileControl();
            profileControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(profileControl);

            ModifyProfileControl modifyProfilControl = new ModifyProfileControl();
            modifyProfilControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(modifyProfilControl);

            ShowProfileControl showProfileControl = new ShowProfileControl();
            showProfileControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(showProfileControl);

            CreateRoutineUserControl createRoutineUserControl = new CreateRoutineUserControl();
            createRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(createRoutineUserControl);

            AddSessionUserControl addSessionUserControl = new AddSessionUserControl();
            addSessionUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addSessionUserControl);

            AddRoutineUserControl addRoutineUserControl = new AddRoutineUserControl();
            addRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addRoutineUserControl);

            ShowWorkoutRoutineUserControl showWorkoutRoutineUserControl = new ShowWorkoutRoutineUserControl();
            showWorkoutRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(showWorkoutRoutineUserControl);

            AddStretchingRoutineUserControl addStretchingRoutineUserControl = new AddStretchingRoutineUserControl();
            addStretchingRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addStretchingRoutineUserControl);

            AddStretchingSessionUserControl addStretchingSessionUserControl = new AddStretchingSessionUserControl();
            addStretchingSessionUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addStretchingSessionUserControl);

            ShowStretchingRoutineUserControls showStretchingRoutineUserControls = new ShowStretchingRoutineUserControls();
            showStretchingRoutineUserControls.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(showStretchingRoutineUserControls);

            StretchingRoutinesManagerControl stretchingRoutinesManagerControl = new StretchingRoutinesManagerControl();
            stretchingRoutinesManagerControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(stretchingRoutinesManagerControl);

            CreateStretchingRoutineUserControl createStretchingRoutineUserControl = new CreateStretchingRoutineUserControl();
            createStretchingRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(createStretchingRoutineUserControl);

            CardioRoutineManagerUserControl cardioRoutineManagerUserControl = new CardioRoutineManagerUserControl();
            cardioRoutineManagerUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(cardioRoutineManagerUserControl);

            AddCardioRoutineUserControl addCardioRoutineUserControl = new AddCardioRoutineUserControl();
            addCardioRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addCardioRoutineUserControl);

            CreateCardioRoutineUserControl createCardioRoutineUserControl = new CreateCardioRoutineUserControl();
            createCardioRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(createCardioRoutineUserControl);

            AddCardioSessionUserControl addCardioSessionUserControl = new AddCardioSessionUserControl();
            addCardioSessionUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addCardioSessionUserControl);

            ShowCardioRoutineUserControl showCardioRoutineUserControl = new ShowCardioRoutineUserControl();
            showCardioRoutineUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(showCardioRoutineUserControl);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void ProfileButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["profileControl"].BringToFront();
        }

        private void CalculatorsButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["calculatorsControl"].BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
            UserManager.WhoIsCurrentLoged = "";
        }

        private void RoutinesButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["routinesControl"].BringToFront();
        }
    }
}
