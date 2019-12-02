namespace Progress_Manager.UserControls
{
    partial class AddCardioSessionUserControl
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
            this.IncorrectExerciseToDeletingLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.RestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SetsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteExerciseButton = new System.Windows.Forms.Button();
            this.AddExerciseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveSessionButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ExercisesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.SessionNameTextBox = new System.Windows.Forms.TextBox();
            this.RestLabel = new System.Windows.Forms.Label();
            this.SetsLabel = new System.Windows.Forms.Label();
            this.ExerciseDetailsLabel = new System.Windows.Forms.Label();
            this.SetLabel = new System.Windows.Forms.Label();
            this.CreateSessionLabel = new System.Windows.Forms.Label();
            this.DurationPicker = new System.Windows.Forms.DateTimePicker();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IncorrectExerciseToDeletingLabel
            // 
            this.IncorrectExerciseToDeletingLabel.AutoSize = true;
            this.IncorrectExerciseToDeletingLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectExerciseToDeletingLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectExerciseToDeletingLabel.Location = new System.Drawing.Point(494, 209);
            this.IncorrectExerciseToDeletingLabel.Name = "IncorrectExerciseToDeletingLabel";
            this.IncorrectExerciseToDeletingLabel.Size = new System.Drawing.Size(188, 19);
            this.IncorrectExerciseToDeletingLabel.TabIndex = 72;
            this.IncorrectExerciseToDeletingLabel.Text = "Choose exercise correctly.";
            this.IncorrectExerciseToDeletingLabel.Visible = false;
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(22, 165);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(157, 19);
            this.IncorrectNameLabel.TabIndex = 71;
            this.IncorrectNameLabel.Text = "Enter name correctly.";
            this.IncorrectNameLabel.Visible = false;
            // 
            // RestDatePicker
            // 
            this.RestDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.RestDatePicker.Location = new System.Drawing.Point(517, 95);
            this.RestDatePicker.Name = "RestDatePicker";
            this.RestDatePicker.Size = new System.Drawing.Size(144, 32);
            this.RestDatePicker.TabIndex = 70;
            this.RestDatePicker.Value = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            // 
            // SetsNumericUpDown
            // 
            this.SetsNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetsNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.SetsNumericUpDown.Location = new System.Drawing.Point(292, 132);
            this.SetsNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.SetsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetsNumericUpDown.Name = "SetsNumericUpDown";
            this.SetsNumericUpDown.Size = new System.Drawing.Size(86, 28);
            this.SetsNumericUpDown.TabIndex = 69;
            this.SetsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DayComboBox
            // 
            this.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(26, 129);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(191, 31);
            this.DayComboBox.TabIndex = 68;
            // 
            // DeleteExerciseButton
            // 
            this.DeleteExerciseButton.Enabled = false;
            this.DeleteExerciseButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteExerciseButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteExerciseButton.Location = new System.Drawing.Point(552, 282);
            this.DeleteExerciseButton.Name = "DeleteExerciseButton";
            this.DeleteExerciseButton.Size = new System.Drawing.Size(145, 35);
            this.DeleteExerciseButton.TabIndex = 66;
            this.DeleteExerciseButton.Text = "Delete Exercise";
            this.DeleteExerciseButton.UseVisualStyleBackColor = true;
            this.DeleteExerciseButton.Click += new System.EventHandler(this.DeleteExerciseButton_Click);
            // 
            // AddExerciseButton
            // 
            this.AddExerciseButton.Enabled = false;
            this.AddExerciseButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddExerciseButton.ForeColor = System.Drawing.Color.Black;
            this.AddExerciseButton.Location = new System.Drawing.Point(552, 241);
            this.AddExerciseButton.Name = "AddExerciseButton";
            this.AddExerciseButton.Size = new System.Drawing.Size(145, 35);
            this.AddExerciseButton.TabIndex = 65;
            this.AddExerciseButton.Text = "Add Exercise";
            this.AddExerciseButton.UseVisualStyleBackColor = true;
            this.AddExerciseButton.Click += new System.EventHandler(this.AddExerciseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(338, 200);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 35);
            this.BackButton.TabIndex = 67;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveSessionButton
            // 
            this.SaveSessionButton.Enabled = false;
            this.SaveSessionButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveSessionButton.ForeColor = System.Drawing.Color.Black;
            this.SaveSessionButton.Location = new System.Drawing.Point(182, 200);
            this.SaveSessionButton.Name = "SaveSessionButton";
            this.SaveSessionButton.Size = new System.Drawing.Size(150, 35);
            this.SaveSessionButton.TabIndex = 64;
            this.SaveSessionButton.Text = "Save Session";
            this.SaveSessionButton.UseVisualStyleBackColor = true;
            this.SaveSessionButton.Click += new System.EventHandler(this.SaveSessionButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(26, 200);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 35);
            this.CreateButton.TabIndex = 63;
            this.CreateButton.Text = "Create Session";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ExercisesListView
            // 
            this.ExercisesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.DurationColumn,
            this.SetsColumn,
            this.RestsColumn});
            this.ExercisesListView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExercisesListView.FullRowSelect = true;
            this.ExercisesListView.GridLines = true;
            this.ExercisesListView.HideSelection = false;
            this.ExercisesListView.Location = new System.Drawing.Point(25, 241);
            this.ExercisesListView.MultiSelect = false;
            this.ExercisesListView.Name = "ExercisesListView";
            this.ExercisesListView.Size = new System.Drawing.Size(528, 250);
            this.ExercisesListView.TabIndex = 62;
            this.ExercisesListView.UseCompatibleStateImageBehavior = false;
            this.ExercisesListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 240;
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExerciseNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(242, 95);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(191, 28);
            this.ExerciseNameTextBox.TabIndex = 61;
            this.ExerciseNameTextBox.Text = "Exercise name";
            // 
            // SessionNameTextBox
            // 
            this.SessionNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SessionNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SessionNameTextBox.Location = new System.Drawing.Point(25, 95);
            this.SessionNameTextBox.Name = "SessionNameTextBox";
            this.SessionNameTextBox.Size = new System.Drawing.Size(191, 28);
            this.SessionNameTextBox.TabIndex = 60;
            this.SessionNameTextBox.Text = "Session name";
            // 
            // RestLabel
            // 
            this.RestLabel.AutoSize = true;
            this.RestLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestLabel.ForeColor = System.Drawing.Color.White;
            this.RestLabel.Location = new System.Drawing.Point(466, 99);
            this.RestLabel.Name = "RestLabel";
            this.RestLabel.Size = new System.Drawing.Size(50, 21);
            this.RestLabel.TabIndex = 58;
            this.RestLabel.Text = "Rest:";
            // 
            // SetsLabel
            // 
            this.SetsLabel.AutoSize = true;
            this.SetsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetsLabel.ForeColor = System.Drawing.Color.White;
            this.SetsLabel.Location = new System.Drawing.Point(241, 134);
            this.SetsLabel.Name = "SetsLabel";
            this.SetsLabel.Size = new System.Drawing.Size(48, 21);
            this.SetsLabel.TabIndex = 57;
            this.SetsLabel.Text = "Sets:";
            // 
            // ExerciseDetailsLabel
            // 
            this.ExerciseDetailsLabel.AutoSize = true;
            this.ExerciseDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExerciseDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.ExerciseDetailsLabel.Location = new System.Drawing.Point(238, 68);
            this.ExerciseDetailsLabel.Name = "ExerciseDetailsLabel";
            this.ExerciseDetailsLabel.Size = new System.Drawing.Size(200, 23);
            this.ExerciseDetailsLabel.TabIndex = 56;
            this.ExerciseDetailsLabel.Text = "Set exercise details:";
            // 
            // SetLabel
            // 
            this.SetLabel.AutoSize = true;
            this.SetLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetLabel.ForeColor = System.Drawing.Color.White;
            this.SetLabel.Location = new System.Drawing.Point(22, 68);
            this.SetLabel.Name = "SetLabel";
            this.SetLabel.Size = new System.Drawing.Size(200, 23);
            this.SetLabel.TabIndex = 59;
            this.SetLabel.Text = "Set name and day:";
            // 
            // CreateSessionLabel
            // 
            this.CreateSessionLabel.AutoSize = true;
            this.CreateSessionLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateSessionLabel.ForeColor = System.Drawing.Color.White;
            this.CreateSessionLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateSessionLabel.Name = "CreateSessionLabel";
            this.CreateSessionLabel.Size = new System.Drawing.Size(215, 34);
            this.CreateSessionLabel.TabIndex = 55;
            this.CreateSessionLabel.Text = "Create Session";
            // 
            // DurationPicker
            // 
            this.DurationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DurationPicker.Location = new System.Drawing.Point(517, 134);
            this.DurationPicker.Name = "DurationPicker";
            this.DurationPicker.Size = new System.Drawing.Size(144, 32);
            this.DurationPicker.TabIndex = 74;
            this.DurationPicker.Value = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(430, 138);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(86, 21);
            this.DurationLabel.TabIndex = 73;
            this.DurationLabel.Text = "Duration:";
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            this.DurationColumn.Width = 105;
            // 
            // SetsColumn
            // 
            this.SetsColumn.Text = "Sets";
            this.SetsColumn.Width = 74;
            // 
            // RestsColumn
            // 
            this.RestsColumn.Text = "Rest";
            this.RestsColumn.Width = 105;
            // 
            // AddCardioSessionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.DurationPicker);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.IncorrectExerciseToDeletingLabel);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.RestDatePicker);
            this.Controls.Add(this.SetsNumericUpDown);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.DeleteExerciseButton);
            this.Controls.Add(this.AddExerciseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveSessionButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ExercisesListView);
            this.Controls.Add(this.ExerciseNameTextBox);
            this.Controls.Add(this.SessionNameTextBox);
            this.Controls.Add(this.RestLabel);
            this.Controls.Add(this.SetsLabel);
            this.Controls.Add(this.ExerciseDetailsLabel);
            this.Controls.Add(this.SetLabel);
            this.Controls.Add(this.CreateSessionLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCardioSessionUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IncorrectExerciseToDeletingLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.DateTimePicker RestDatePicker;
        private System.Windows.Forms.NumericUpDown SetsNumericUpDown;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Button DeleteExerciseButton;
        private System.Windows.Forms.Button AddExerciseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveSessionButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListView ExercisesListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.TextBox ExerciseNameTextBox;
        private System.Windows.Forms.TextBox SessionNameTextBox;
        private System.Windows.Forms.Label RestLabel;
        private System.Windows.Forms.Label SetsLabel;
        private System.Windows.Forms.Label ExerciseDetailsLabel;
        private System.Windows.Forms.Label SetLabel;
        private System.Windows.Forms.Label CreateSessionLabel;
        private System.Windows.Forms.DateTimePicker DurationPicker;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader SetsColumn;
        private System.Windows.Forms.ColumnHeader RestsColumn;
    }
}
