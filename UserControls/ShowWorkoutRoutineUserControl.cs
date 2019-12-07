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
    public partial class ShowWorkoutRoutineUserControl : UserControl
    {
        public ShowWorkoutRoutineUserControl()
        {
            InitializeComponent();
        }

        public void ResetControls()
        {
            ExercisesListView.Items.Clear();
            ExercisesListView.Groups.Clear();

            TotalExercisesLabel.Text = "Total Exercises: ";
            TotalSetsLabel.Text = "Total Sets: ";
            StartLabel.Text = "Start: ";
            DurationLabel.Text = "Duration: ";
        }

        public void ShowRoutine()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;
            openFileDialog.Title = "Open routine";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    WorkOutRoutine workOutRoutine = RoutineManager.LoadWorkOutRoutine(openFileDialog.FileName);
                    MessageBox.Show("Workout Routine (" + workOutRoutine.RoutineName + ") was opened succesfully.");
                    FillListView(workOutRoutine);

                    workOutRoutine.UpdateRoutine();
                    TotalExercisesLabel.Text = "Total Exercises: " + workOutRoutine.TotalExercises;
                    TotalSetsLabel.Text = "Total Sets: " + workOutRoutine.TotalSets;
                    StartLabel.Text = "Start: " + workOutRoutine.Start.ToShortDateString();
                    if (workOutRoutine.Duration.TotalDays >= 2)
                        DurationLabel.Text = "Duration: " + workOutRoutine.Duration.TotalDays.ToString("F0") + " days";
                    else
                        DurationLabel.Text = "Duration: " + workOutRoutine.Duration.TotalDays.ToString("F0") + " day";
                }
            }
            catch(NullReferenceException)
            {

            }

        }

        private void FillListView(WorkOutRoutine workOutRoutine)
        {
            ResetControls();

            int groupIndex, itemIndex;
            ListViewGroup group;
            ListViewItem item;

            foreach (OneDaySession session in workOutRoutine.SessionsList)
            {
                group = new ListViewGroup(session.SessionName + "(" + session.Day + ")", HorizontalAlignment.Left);
                ExercisesListView.Groups.Add(group);
                groupIndex = ExercisesListView.Groups.IndexOf(group);

                foreach(WorkOutExercise exercise in session.ExercisesList)
                {
                    item = new ListViewItem(exercise.ExerciseName);
                    item.SubItems.Add(exercise.BodyPart.ToString());
                    item.SubItems.Add(exercise.InitialReps.ToString());
                    item.SubItems.Add(exercise.FinalReps.ToString());
                    item.SubItems.Add(exercise.Sets.ToString());
                    item.SubItems.Add(exercise.Rest.ToLongTimeString());
                    ExercisesListView.Items.Add(item);
                    itemIndex = ExercisesListView.Items.IndexOf(item);
                    ExercisesListView.Items[itemIndex].Group = ExercisesListView.Groups[groupIndex];
                }
            }
        }

        private void Back()
        {
            ResetControls();
            this.Parent.Controls["routinesManagerControl"].BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            ShowRoutine();
        }


    }
}
