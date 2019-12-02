﻿using System;
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
    public partial class CardioRoutineManagerUserControl : UserControl
    {
        public CardioRoutineManagerUserControl()
        {
            InitializeComponent();
        }

        private void Delete()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;
            openFileDialog.Title = "Select routine";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                RoutineManager.routineFilePath = openFileDialog.FileName;
                RoutineManager.DeleteRoutine();
            }

        }

        private void DeleteRoutineButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CreateRoutineButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["addCardioRoutineUserControl"].BringToFront();
        }

        private void ShowRoutineButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["showCardioRoutineUserControl"].BringToFront();
        }
    }
}
