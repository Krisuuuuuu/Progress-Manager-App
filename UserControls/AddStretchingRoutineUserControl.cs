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
    public partial class AddStretchingRoutineUserControl : UserControl
    {
        public AddStretchingRoutineUserControl()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            SessionListLabel.Text = "Stretching routine cointains: \n";
            if (RoutineManager.MainStretchingRoutine != null)
            {
                foreach (StretchingSession s in RoutineManager.MainStretchingRoutine.SessionsList)
                {
                    SessionListLabel.Text += s.SessionName + " (" + s.Day + ")" + "\n";
                }
            }
        }
        private void ResetControls()
        {
            NoRoutineLabel.Visible = false;
        }

        private bool CheckControls()
        {

            if (RoutineManager.MainStretchingRoutine == null)
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
            this.Parent.Controls["createStretchingRoutineUserControl"].BringToFront();
        }
        private void Back()
        {
            ResetControls();
            RoutineManager.MainStretchingRoutine = null;
            UpdateLabel();
            this.Parent.Controls["stretchingRoutinesManagerControl"].BringToFront();
        }
        private void Save()
        {
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                if (!Directory.Exists(RoutineManager.routineDirectoryPath))
                    Directory.CreateDirectory(RoutineManager.routineDirectoryPath);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save stretching routine";
                saveFileDialog.FileName = RoutineManager.MainStretchingRoutine.RoutineName;
                saveFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;

                DialogResult dialogResult = saveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    RoutineManager.routineFilePath = saveFileDialog.FileName;
                    RoutineManager.SerializeRoutine(RoutineManager.MainStretchingRoutine);
                    this.Parent.Controls["stretchingRoutinesManagerControl"].BringToFront();
                }
            }
        }
        private void Add()
        {
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                this.Parent.Controls["addStretchingSessionUserControl"].BringToFront();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
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
    }
}
