namespace Progress_Manager.UserControls
{
    partial class ShowWorkoutRoutineUserControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowSessionLabel = new System.Windows.Forms.Label();
            this.ExercisesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BodyPartColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IRepsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FRepsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.TotalSetsLabel = new System.Windows.Forms.Label();
            this.TotalExercisesLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowSessionLabel
            // 
            this.ShowSessionLabel.AutoSize = true;
            this.ShowSessionLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowSessionLabel.ForeColor = System.Drawing.Color.White;
            this.ShowSessionLabel.Location = new System.Drawing.Point(20, 20);
            this.ShowSessionLabel.Name = "ShowSessionLabel";
            this.ShowSessionLabel.Size = new System.Drawing.Size(335, 34);
            this.ShowSessionLabel.TabIndex = 5;
            this.ShowSessionLabel.Text = "Show Work Out Routine";
            // 
            // ExercisesListView
            // 
            this.ExercisesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.BodyPartColumn,
            this.IRepsColumn,
            this.FRepsColumn,
            this.Sets,
            this.RestColumn});
            this.ExercisesListView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExercisesListView.FullRowSelect = true;
            this.ExercisesListView.GridLines = true;
            this.ExercisesListView.HideSelection = false;
            this.ExercisesListView.Location = new System.Drawing.Point(20, 70);
            this.ExercisesListView.MultiSelect = false;
            this.ExercisesListView.Name = "ExercisesListView";
            this.ExercisesListView.Size = new System.Drawing.Size(660, 244);
            this.ExercisesListView.TabIndex = 22;
            this.ExercisesListView.UseCompatibleStateImageBehavior = false;
            this.ExercisesListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 216;
            // 
            // BodyPartColumn
            // 
            this.BodyPartColumn.Text = "Body Part";
            this.BodyPartColumn.Width = 127;
            // 
            // IRepsColumn
            // 
            this.IRepsColumn.Text = "I.Reps";
            this.IRepsColumn.Width = 70;
            // 
            // FRepsColumn
            // 
            this.FRepsColumn.Text = "F.Reps";
            this.FRepsColumn.Width = 75;
            // 
            // Sets
            // 
            this.Sets.Text = "Sets";
            // 
            // RestColumn
            // 
            this.RestColumn.Text = "Rest";
            this.RestColumn.Width = 108;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 33;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(314, 430);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(142, 47);
            this.OpenButton.TabIndex = 33;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // TotalSetsLabel
            // 
            this.TotalSetsLabel.AutoSize = true;
            this.TotalSetsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalSetsLabel.ForeColor = System.Drawing.Color.White;
            this.TotalSetsLabel.Location = new System.Drawing.Point(16, 340);
            this.TotalSetsLabel.Name = "TotalSetsLabel";
            this.TotalSetsLabel.Size = new System.Drawing.Size(113, 23);
            this.TotalSetsLabel.TabIndex = 34;
            this.TotalSetsLabel.Text = "Total Sets: ";
            // 
            // TotalExercisesLabel
            // 
            this.TotalExercisesLabel.AutoSize = true;
            this.TotalExercisesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalExercisesLabel.ForeColor = System.Drawing.Color.White;
            this.TotalExercisesLabel.Location = new System.Drawing.Point(240, 340);
            this.TotalExercisesLabel.Name = "TotalExercisesLabel";
            this.TotalExercisesLabel.Size = new System.Drawing.Size(160, 23);
            this.TotalExercisesLabel.TabIndex = 34;
            this.TotalExercisesLabel.Text = "Total Exercises: ";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartLabel.ForeColor = System.Drawing.Color.White;
            this.StartLabel.Location = new System.Drawing.Point(16, 387);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(67, 23);
            this.StartLabel.TabIndex = 34;
            this.StartLabel.Text = "Start: ";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(240, 387);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(104, 23);
            this.DurationLabel.TabIndex = 34;
            this.DurationLabel.Text = "Duration: ";
            // 
            // ShowWorkoutRoutineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TotalExercisesLabel);
            this.Controls.Add(this.TotalSetsLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExercisesListView);
            this.Controls.Add(this.ShowSessionLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowWorkoutRoutineUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowSessionLabel;
        private System.Windows.Forms.ListView ExercisesListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader BodyPartColumn;
        private System.Windows.Forms.ColumnHeader IRepsColumn;
        private System.Windows.Forms.ColumnHeader FRepsColumn;
        private System.Windows.Forms.ColumnHeader Sets;
        private System.Windows.Forms.ColumnHeader RestColumn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label TotalSetsLabel;
        private System.Windows.Forms.Label TotalExercisesLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label DurationLabel;
    }
}
