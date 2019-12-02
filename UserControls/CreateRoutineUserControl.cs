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
    public partial class CreateRoutineUserControl : UserControl
    {
        public CreateRoutineUserControl()
        {
            InitializeComponent();
            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
            StartDatePicker.MinDate = DateTime.Now;
            EndDatePicker.MinDate = DateTime.Now;
        }

        private void ResetControls()
        {
            IncorrectNameLabel.Visible = false;
            IncorrectDateLabel1.Visible = false;
            IncorrectDateLabel2.Visible = false;

            NameTextBox.ForeColor = Color.DarkGray;
            NameTextBox.BackColor = Color.White;
           
        }

        private bool CheckControls()
        {
            bool isConfirmed = true;

            if(NameTextBox.Text == "")
            {
                NameTextBox.ForeColor = Color.White;
                NameTextBox.BackColor = Color.Red;
                IncorrectNameLabel.Visible = true;
                isConfirmed = false;
            }

            if(StartDatePicker.Value >= EndDatePicker.Value)
            {
                IncorrectDateLabel1.Visible = true;
                IncorrectDateLabel2.Visible = true;
                isConfirmed = false;
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
        }

        private void Create(string name, DateTime start, DateTime end)
        {
            RoutineManager.MainWorkOutRoutine = null;

            ResetControls();

            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                RoutineManager.MainWorkOutRoutine = new WorkOutRoutine(name, start, end);
                this.Parent.Controls["addRoutineUserControl"].BringToFront();
            }
        }
        private void Back()
        {
            ResetControls();
            this.Parent.Controls["addRoutineUserControl"].BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Create(NameTextBox.Text, StartDatePicker.Value, EndDatePicker.Value);
        }
    }
}
