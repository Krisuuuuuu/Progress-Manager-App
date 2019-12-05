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
    public partial class ShowCardioRoutineUserControl : UserControl
    {
        public ShowCardioRoutineUserControl()
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = RoutineManager.routineDirectoryPath;
            openFileDialog.Title = "Open routine";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CardioRoutine cardioRoutine = RoutineManager.LoadCardioRoutine(openFileDialog.FileName);
                MessageBox.Show("Cardio Routine (" + cardioRoutine.RoutineName + ") was opened succesfully.");
                FillListView(cardioRoutine);

                cardioRoutine.UpdateRoutine();
                TotalSetsLabel.Text = "Total Sets: " + cardioRoutine.TotalSets;
                StartLabel.Text = "Start: " + cardioRoutine.Start.ToShortDateString();
                if(cardioRoutine.Duration.TotalDays >= 2)
                    DurationLabel.Text = "Duration: " + cardioRoutine.Duration.TotalDays.ToString("F0") + " days";
                else
                    DurationLabel.Text = "Duration: " + cardioRoutine.Duration.TotalDays.ToString("F0") + " day";
            }

        }
        private void FillListView(CardioRoutine cardioRoutine)
        {
            ResetControls();

            int groupIndex, itemIndex;
            ListViewGroup group;
            ListViewItem item;

            foreach (OneDaySession session in cardioRoutine.SessionsList)
            {
                group = new ListViewGroup(session.SessionName + "(" + session.Day + ")", HorizontalAlignment.Left);
                ExercisesListView.Groups.Add(group);
                groupIndex = ExercisesListView.Groups.IndexOf(group);

                foreach (CardioExercise exercise in session.ExercisesList)
                {
                    item = new ListViewItem(exercise.ExerciseName);
                    item.SubItems.Add(exercise.Duration.ToLongTimeString());
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
            this.Parent.Controls["cardioRoutineManagerUserControl"].BringToFront();
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            ShowRoutine();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
