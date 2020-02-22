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
    public partial class AddCardioRoutineUserControl : UserControl
    {
        public AddCardioRoutineUserControl()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            SessionListLabel.Text = "Cardio routine cointains: \n";
            if (RoutineManager.MainCardioRoutine != null)
            {
                foreach (CardioSession s in RoutineManager.MainCardioRoutine.SessionsList)
                {
                    SessionListLabel.Text += s.SessionName + " (" + s.Day + ")" + "\n";
                }
            }
        }
        private bool CheckControls()
        {

            if (RoutineManager.MainCardioRoutine == null)
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
            this.Parent.Controls["createCardioRoutineUserControl"].BringToFront();
        }
        private void ResetControls()
        {
            NoRoutineLabel.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["cardioRoutineManagerUserControl"].BringToFront();
        }
        private void Back()
        {
            ResetControls();
            RoutineManager.MainCardioRoutine = null;
            UpdateLabel();
            this.Parent.Controls["cardioRoutineManagerControl"].BringToFront();
        }
        private void Save()
        {
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                RoutineManager.CheckPaths();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save cardio routine";
                saveFileDialog.FileName = RoutineManager.MainCardioRoutine.RoutineName + " Cardio Routine";
                saveFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;

                DialogResult dialogResult = saveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    RoutineManager.routineFilePath = saveFileDialog.FileName;
                    RoutineManager.SerializeRoutine(RoutineManager.MainCardioRoutine);
                    this.Parent.Controls["cardioRoutineManagerUserControl"].BringToFront();
                }
            }
        }
        private void Add()
        {
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                this.Parent.Controls["addCardioSessionUserControl"].BringToFront();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
