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
using System.IO;

namespace Progress_Manager.UserControls
{
    public partial class AddRoutineUserControl : UserControl
    {
        public AddRoutineUserControl()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            SessionListLabel.Text = "Workout routine cointains: \n";
            if (RoutineManager.MainWorkOutRoutine != null)
            {
                foreach (WorkOutSession w in RoutineManager.MainWorkOutRoutine.SessionsList)
                {
                    SessionListLabel.Text += w.SessionName + " (" + w.Day + ")" + "\n";
                }
            }
        }

        private void ResetControls()
        {
            NoRoutineLabel.Visible = false;
        }

        private bool CheckControls()
        {

            if(RoutineManager.MainWorkOutRoutine == null)
            {
                NoRoutineLabel.Visible = true;
                return false;
            }
            else
            {
                NoRoutineLabel.Visible = false;
                return true;
            }
        }


        private void Create()
        {
            ResetControls();
            this.Parent.Controls["createRoutineUserControl"].BringToFront();
        }

        private void Back()
        {
            ResetControls();
            RoutineManager.MainWorkOutRoutine = null;
            UpdateLabel();
            this.Parent.Controls["routinesManagerControl"].BringToFront();
        }

        private void Save()
        {
            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                RoutineManager.CheckPaths();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save work out routine";
                saveFileDialog.FileName = RoutineManager.MainWorkOutRoutine.RoutineName + " Workout Routine";
                saveFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;

                DialogResult dialogResult = saveFileDialog.ShowDialog();

                if(dialogResult == DialogResult.OK)
                {
                    RoutineManager.routineFilePath = saveFileDialog.FileName;
                    RoutineManager.SerializeRoutine(RoutineManager.MainWorkOutRoutine);
                }
            }
        }

        private void Add()
        {
            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                this.Parent.Controls["addSessionUserControl"].BringToFront();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}
