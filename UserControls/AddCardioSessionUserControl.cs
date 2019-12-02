﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Enums;
using Progress_Manager.Classes;

namespace Progress_Manager.UserControls
{
    public partial class AddCardioSessionUserControl : UserControl
    {
        DaysOfWeek[] daysOfWeekTab = new DaysOfWeek[7];
        CardioSession cardioSession = null;
        public AddCardioSessionUserControl()
        {
            InitializeComponent();

            UpdateControls();
            ResetControls();
            RoutineManager.MainCardioRoutine = null;
            cardioSession = null;

            DayComboBox.Items.Add(DaysOfWeek.MONDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.TUESDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.WEDNESDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.THURSDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.FRIDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.SATURDAY.ToString());
            DayComboBox.Items.Add(DaysOfWeek.SUNDAY.ToString());
            DayComboBox.Text = DaysOfWeek.MONDAY.ToString();

            daysOfWeekTab[0] = DaysOfWeek.MONDAY;
            daysOfWeekTab[1] = DaysOfWeek.TUESDAY;
            daysOfWeekTab[2] = DaysOfWeek.WEDNESDAY;
            daysOfWeekTab[3] = DaysOfWeek.THURSDAY;
            daysOfWeekTab[4] = DaysOfWeek.FRIDAY;
            daysOfWeekTab[5] = DaysOfWeek.SATURDAY;
            daysOfWeekTab[6] = DaysOfWeek.SUNDAY;
        }
        private void UpdateControls()
        {
            SessionNameTextBox.Text = "Session name";
            ExerciseNameTextBox.Text = "Exercise name";
            RestDatePicker.Value = RestDatePicker.MinDate;
            SetsNumericUpDown.Value = 1;

        }

        private void SetControlsVisibility(bool isSessionExist)
        {
            if (isSessionExist == true)
            {
                CreateButton.Enabled = false;
                SessionNameTextBox.Enabled = false;
                DayComboBox.Enabled = false;
                ExerciseNameTextBox.Enabled = true;
                RestDatePicker.Enabled = true;
                DurationPicker.Enabled = true;
                SetsNumericUpDown.Enabled = true;
                SaveSessionButton.Enabled = true;
                AddExerciseButton.Enabled = true;
                DeleteExerciseButton.Enabled = true;
            }
            else
            {
                CreateButton.Enabled = true;
                SessionNameTextBox.Enabled = true;
                DayComboBox.Enabled = true;
                ExerciseNameTextBox.Enabled = false;
                RestDatePicker.Enabled = false;
                DurationPicker.Enabled = false;
                SetsNumericUpDown.Enabled = false;
                SaveSessionButton.Enabled = false;
                AddExerciseButton.Enabled = false;
                DeleteExerciseButton.Enabled = false;
            }

        }
        private void ResetControls()
        {
            bool isConfirmed;

            IncorrectNameLabel.Visible = false;
            IncorrectExerciseToDeletingLabel.Visible = false;
            SessionNameTextBox.ForeColor = Color.DarkGray;
            SessionNameTextBox.BackColor = Color.White;
            ExerciseNameTextBox.ForeColor = Color.DarkGray;
            ExerciseNameTextBox.BackColor = Color.White;

            if (cardioSession == null)
                isConfirmed = false;
            else
                isConfirmed = true;

            SetControlsVisibility(isConfirmed);
        }
        private bool CheckControls()
        {
            bool isConfirmed = true;

            if (SessionNameTextBox.Enabled && SessionNameTextBox.Text == "")
            {
                IncorrectNameLabel.Visible = true;
                SessionNameTextBox.ForeColor = Color.White;
                SessionNameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (ExerciseNameTextBox.Enabled && ExerciseNameTextBox.Text == "")
            {
                IncorrectNameLabel.Visible = true;
                ExerciseNameTextBox.ForeColor = Color.White;
                ExerciseNameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }


            if (isConfirmed == true)
                return true;
            else
                return false;
        }
        private void CreateSession()
        {
            ResetControls();

            bool isConfirmed = CheckControls();

            if (RoutineManager.MainCardioRoutine == null)
                isConfirmed = false;


            if (isConfirmed == true)
            {
                int index = DayComboBox.SelectedIndex;
                cardioSession = new CardioSession(SessionNameTextBox.Text, daysOfWeekTab[index]);

                bool isNameAndDayCorrect = RoutineManager.MainCardioRoutine.CheckDayAndName(cardioSession);

                if (isNameAndDayCorrect == true)
                {
                    SetControlsVisibility(true);
                }
                else
                {
                    cardioSession = null;
                    SetControlsVisibility(false);
                }

            }
        }
        private void AddExercise()
        {
            ResetControls();

            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                CardioExercise cardioExercise = new CardioExercise(ExerciseNameTextBox.Text, ExerciseTypes.STRETCHING,
                    DurationPicker.Value, (byte)SetsNumericUpDown.Value, RestDatePicker.Value);
                cardioSession.Add(cardioExercise);

                if (cardioSession.ExercisesList.Contains(cardioExercise))
                {
                    ListViewItem item = new ListViewItem(ExerciseNameTextBox.Text);
                    item.SubItems.Add(DurationPicker.Value.ToString());
                    item.SubItems.Add(SetsNumericUpDown.Value.ToString());
                    item.SubItems.Add(RestDatePicker.Value.ToString());
                    ExercisesListView.Items.Add(item);

                    ResetControls();
                }

            }
        }
        private void Back()
        {
            ExercisesListView.Items.Clear();
            cardioSession = null;
            ResetControls();
            UpdateControls();
            this.Parent.Controls["addCardioRoutineUserControl"].BringToFront();
        }

        private void Save()
        {
            bool isConfirmed = true;

            if (RoutineManager.MainCardioRoutine == null)
                isConfirmed = false;

            if (isConfirmed == true)
            {
                RoutineManager.MainCardioRoutine.Add(cardioSession);
                ExercisesListView.Items.Clear();
                cardioSession = null;
                ResetControls();
                UpdateControls();
                this.Parent.Controls["addCardioRoutineUserControl"].BringToFront();
            }


        }
        private void SetValuesFromListView()
        {
            ExerciseNameTextBox.Text = ExercisesListView.SelectedItems[0].Text;
            SetsNumericUpDown.Value = Convert.ToDecimal(ExercisesListView.SelectedItems[0].SubItems[1].Text);
            RestDatePicker.Value = Convert.ToDateTime(ExercisesListView.SelectedItems[0].SubItems[2].Text);
        }
        private void Delete()
        {

            ResetControls();

            try
            {
                ExercisesListView.SelectedItems[0].Remove();
            }
            catch (ArgumentOutOfRangeException e)
            {
                IncorrectExerciseToDeletingLabel.Visible = true;
            }

        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateSession();
        }

        private void SaveSessionButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void AddExerciseButton_Click(object sender, EventArgs e)
        {
            AddExercise();
        }

        private void DeleteExerciseButton_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
