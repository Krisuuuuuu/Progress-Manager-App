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
    public partial class ShowStretchingRoutineUserControls : UserControl
    {
        public ShowStretchingRoutineUserControls()
        {
            InitializeComponent();
        }
        public void ResetControls()
        {
            ExercisesListView.Items.Clear();
            ExercisesListView.Groups.Clear();

            TotalSetsLabel.Text = "Total Sets: ";
            StartLabel.Text = "Start: ";
            DurationLabel.Text = "Routine Duration: ";
        }
        public void ShowRoutine()
        {
            ResetControls();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;
            openFileDialog.Title = "Open routine";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    StretchingRoutine stretchingRoutine = RoutineManager.LoadStretchingtRoutine(openFileDialog.FileName);
                    MessageBox.Show("Stretching routine (" + stretchingRoutine.RoutineName + ") was opened succesfully.");
                    FillListView(stretchingRoutine);

                    stretchingRoutine.UpdateRoutine();
                    TotalExercisesLabel.Text = "Total Exercises: " + stretchingRoutine.TotalExercises;
                    TotalSetsLabel.Text = "Total Sets: " + stretchingRoutine.TotalSets;
                    StartLabel.Text = "Start: " + stretchingRoutine.Start.ToShortDateString();
                    if (stretchingRoutine.Duration.TotalDays >= 2)
                        DurationLabel.Text = "Duration: " + stretchingRoutine.Duration.TotalDays.ToString("F0") + " days";
                    else
                        DurationLabel.Text = "Duration: " + stretchingRoutine.Duration.TotalDays.ToString("F0") + " day";
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Select the proper stretching routine.");
                }

            }

        }

        private void FillListView(StretchingRoutine stretchingRoutine)
        {
            ResetControls();

            int groupIndex, itemIndex;
            ListViewGroup group;
            ListViewItem item;

            foreach (OneDaySession session in stretchingRoutine.SessionsList)
            {
                group = new ListViewGroup(session.SessionName + "(" + session.Day + ")", HorizontalAlignment.Left);
                ExercisesListView.Groups.Add(group);
                groupIndex = ExercisesListView.Groups.IndexOf(group);

                foreach (StretchingExercise exercise in session.ExercisesList)
                {
                    item = new ListViewItem(exercise.ExerciseName);
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
            this.Parent.Controls["stretchingRoutinesManagerControl"].BringToFront();
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
