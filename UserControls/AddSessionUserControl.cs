using System;
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
    public partial class AddSessionUserControl : UserControl
    {
        BodyPart []bodyPartTab = new BodyPart[9];
        DaysOfWeek[] daysOfWeekTab = new DaysOfWeek[7];
        WorkOutSession workOutSession = null;
        public AddSessionUserControl()
        {
            InitializeComponent();
            UpdateControls();
            ResetControls();
            RoutineManager.MainWorkOutRoutine = null;
            workOutSession = null;

            BodyPartComboBox.Items.Add(BodyPart.LEGS.ToString());
            BodyPartComboBox.Items.Add(BodyPart.CALVES.ToString());
            BodyPartComboBox.Items.Add(BodyPart.BACK.ToString());
            BodyPartComboBox.Items.Add(BodyPart.CHEST.ToString());
            BodyPartComboBox.Items.Add(BodyPart.SHOULDERS.ToString());
            BodyPartComboBox.Items.Add(BodyPart.BICEPS.ToString());
            BodyPartComboBox.Items.Add(BodyPart.TRICEPS.ToString());
            BodyPartComboBox.Items.Add(BodyPart.FOREARM.ToString());
            BodyPartComboBox.Items.Add(BodyPart.STOMACH.ToString());
            BodyPartComboBox.Text = BodyPart.LEGS.ToString();

            bodyPartTab[0] = BodyPart.LEGS;
            bodyPartTab[1] = BodyPart.CALVES;
            bodyPartTab[2] = BodyPart.BACK;
            bodyPartTab[3] = BodyPart.CHEST;
            bodyPartTab[4] = BodyPart.SHOULDERS;
            bodyPartTab[5] = BodyPart.BICEPS;
            bodyPartTab[6] = BodyPart.TRICEPS;
            bodyPartTab[7] = BodyPart.FOREARM;
            bodyPartTab[8] = BodyPart.STOMACH;

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
            InitialRepsNumericUpDown.Value = 1;
            FinalRepsNumericUpDown.Value = 1;
            SetsNumericUpDown.Value = 1;
        
        }

        private void SetControlsVisibility(bool isSessionExist)
        {
            if(isSessionExist==true)
            {
                CreateButton.Enabled = false;
                SessionNameTextBox.Enabled = false;
                DayComboBox.Enabled = false;
                ExerciseNameTextBox.Enabled = true;
                RestDatePicker.Enabled = true;
                SetsNumericUpDown.Enabled = true;
                BodyPartComboBox.Enabled = true;
                InitialRepsNumericUpDown.Enabled = true;
                FinalRepsNumericUpDown.Enabled = true;
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
                SetsNumericUpDown.Enabled = false;
                BodyPartComboBox.Enabled = false;
                InitialRepsNumericUpDown.Enabled = false;
                FinalRepsNumericUpDown.Enabled = false;
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

            if(workOutSession == null)
                isConfirmed = false;
            else
                isConfirmed = true;

            SetControlsVisibility(isConfirmed);
        }
        private bool CheckControls()
        {
            bool isConfirmed = true;

            if(SessionNameTextBox.Enabled && SessionNameTextBox.Text == "")
            {
                IncorrectNameLabel.Visible = true;
                SessionNameTextBox.ForeColor = Color.White;
                SessionNameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if(ExerciseNameTextBox.Enabled && ExerciseNameTextBox.Text == "")
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

            if (RoutineManager.MainWorkOutRoutine == null)
                isConfirmed = false;

 
            if(isConfirmed == true)
            {
                int index = DayComboBox.SelectedIndex;
                workOutSession = new WorkOutSession(SessionNameTextBox.Text, daysOfWeekTab[index]);

                bool isNameAndDayCorrect = RoutineManager.MainWorkOutRoutine.CheckDayAndName(workOutSession);

                if(isNameAndDayCorrect == true)
                {
                    SetControlsVisibility(true);
                }
                else
                {
                    workOutSession = null;
                    SetControlsVisibility(false);
                }

            }
        }

        private void AddExercise()
        {
            ResetControls();

            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                int index = BodyPartComboBox.SelectedIndex;
                WorkOutExercise workOutExercise = new WorkOutExercise(ExerciseNameTextBox.Text, ExerciseTypes.WORKOUT_EXERCISE,
                bodyPartTab[index], (byte)InitialRepsNumericUpDown.Value, (byte)FinalRepsNumericUpDown.Value, (byte)SetsNumericUpDown.Value, RestDatePicker.Value);
                workOutSession.Add(workOutExercise);

                if(workOutSession.ExercisesList.Contains(workOutExercise))
                {
                    ListViewItem item = new ListViewItem(ExerciseNameTextBox.Text);
                    item.SubItems.Add(bodyPartTab[index].ToString());
                    item.SubItems.Add(InitialRepsNumericUpDown.Value.ToString());
                    item.SubItems.Add(FinalRepsNumericUpDown.Value.ToString());
                    item.SubItems.Add(SetsNumericUpDown.Value.ToString());
                    item.SubItems.Add(RestDatePicker.Value.ToString("T"));
                    ExercisesListView.Items.Add(item);

                    UpdateControls();
                    ResetControls();
                }

            }
        }

        private void Back()
        {
            ExercisesListView.Items.Clear();
            workOutSession = null;
            ResetControls();
            UpdateControls();
            this.Parent.Controls["addRoutineUserControl"].BringToFront();

        }

        private void Save()
        {
            bool isConfirmed = true;

            if (RoutineManager.MainWorkOutRoutine == null)
                isConfirmed = false;


            if(isConfirmed == true)
            {
                RoutineManager.MainWorkOutRoutine.Add(workOutSession);
                ExercisesListView.Items.Clear();
                workOutSession = null;
                ResetControls();
                UpdateControls();
                this.Parent.Controls["addRoutineUserControl"].BringToFront();
            }


        }

        private void SetValuesFromListView()
        {
            ExerciseNameTextBox.Text = ExercisesListView.SelectedItems[0].Text;
            BodyPartComboBox.Text = ExercisesListView.SelectedItems[0].SubItems[0].Text;
            InitialRepsNumericUpDown.Value = Convert.ToDecimal(ExercisesListView.SelectedItems[0].SubItems[1].Text);
            FinalRepsNumericUpDown.Value = Convert.ToDecimal(ExercisesListView.SelectedItems[0].SubItems[2].Text);
            SetsNumericUpDown.Value = Convert.ToDecimal(ExercisesListView.SelectedItems[0].SubItems[3].Text);
            RestDatePicker.Value = Convert.ToDateTime(ExercisesListView.SelectedItems[0].SubItems[4].Text);
        }
        private void Delete()
        {

            ResetControls();

            try
            {
                ExercisesListView.SelectedItems[0].Remove();
            }
            catch(ArgumentOutOfRangeException)
            {
                IncorrectExerciseToDeletingLabel.Visible = true;
            }
                     
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateSession();
        }

        private void AddExerciseButton_Click(object sender, EventArgs e)
        {
            AddExercise();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void InitialRepsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FinalRepsNumericUpDown.Minimum = InitialRepsNumericUpDown.Value;
            FinalRepsNumericUpDown.Value = InitialRepsNumericUpDown.Value;
        }

        private void SaveSessionButton_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void DeleteExerciseButton_Click(object sender, EventArgs e)
        {
            Delete();
        }


    }
}
