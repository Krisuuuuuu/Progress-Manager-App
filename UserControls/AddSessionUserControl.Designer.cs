namespace Progress_Manager.UserControls
{
    partial class AddSessionUserControl
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
            this.CreateSessionLabel = new System.Windows.Forms.Label();
            this.SessionNameTextBox = new System.Windows.Forms.TextBox();
            this.SetLabel = new System.Windows.Forms.Label();
            this.ExercisesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BodyPartColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IRepsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FRepsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateButton = new System.Windows.Forms.Button();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.ExerciseDetailsLabel = new System.Windows.Forms.Label();
            this.ExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.IRepsLabel = new System.Windows.Forms.Label();
            this.InitialRepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FRepsLabel = new System.Windows.Forms.Label();
            this.FinalRepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetsLabel = new System.Windows.Forms.Label();
            this.RestLabel = new System.Windows.Forms.Label();
            this.SetsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddExerciseButton = new System.Windows.Forms.Button();
            this.DeleteExerciseButton = new System.Windows.Forms.Button();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.SaveSessionButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BodyPartComboBox = new System.Windows.Forms.ComboBox();
            this.IncorrectExerciseToDeletingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InitialRepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalRepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateSessionLabel
            // 
            this.CreateSessionLabel.AutoSize = true;
            this.CreateSessionLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateSessionLabel.ForeColor = System.Drawing.Color.White;
            this.CreateSessionLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateSessionLabel.Name = "CreateSessionLabel";
            this.CreateSessionLabel.Size = new System.Drawing.Size(335, 34);
            this.CreateSessionLabel.TabIndex = 4;
            this.CreateSessionLabel.Text = "Create Wor Out Session";
            // 
            // SessionNameTextBox
            // 
            this.SessionNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SessionNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SessionNameTextBox.Location = new System.Drawing.Point(25, 94);
            this.SessionNameTextBox.Name = "SessionNameTextBox";
            this.SessionNameTextBox.Size = new System.Drawing.Size(191, 28);
            this.SessionNameTextBox.TabIndex = 19;
            this.SessionNameTextBox.Text = "Session name";
            // 
            // SetLabel
            // 
            this.SetLabel.AutoSize = true;
            this.SetLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetLabel.ForeColor = System.Drawing.Color.White;
            this.SetLabel.Location = new System.Drawing.Point(22, 68);
            this.SetLabel.Name = "SetLabel";
            this.SetLabel.Size = new System.Drawing.Size(200, 23);
            this.SetLabel.TabIndex = 18;
            this.SetLabel.Text = "Set name and day:";
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
            this.ExercisesListView.Location = new System.Drawing.Point(25, 240);
            this.ExercisesListView.MultiSelect = false;
            this.ExercisesListView.Name = "ExercisesListView";
            this.ExercisesListView.Size = new System.Drawing.Size(528, 250);
            this.ExercisesListView.TabIndex = 21;
            this.ExercisesListView.UseCompatibleStateImageBehavior = false;
            this.ExercisesListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 147;
            // 
            // BodyPartColumn
            // 
            this.BodyPartColumn.Text = "Body Part";
            this.BodyPartColumn.Width = 111;
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
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(26, 199);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 35);
            this.CreateButton.TabIndex = 24;
            this.CreateButton.Text = "Create Session";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DayComboBox
            // 
            this.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(26, 128);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(191, 31);
            this.DayComboBox.TabIndex = 25;
            // 
            // ExerciseDetailsLabel
            // 
            this.ExerciseDetailsLabel.AutoSize = true;
            this.ExerciseDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExerciseDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.ExerciseDetailsLabel.Location = new System.Drawing.Point(238, 68);
            this.ExerciseDetailsLabel.Name = "ExerciseDetailsLabel";
            this.ExerciseDetailsLabel.Size = new System.Drawing.Size(200, 23);
            this.ExerciseDetailsLabel.TabIndex = 18;
            this.ExerciseDetailsLabel.Text = "Set exercise details:";
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExerciseNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(242, 94);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(191, 28);
            this.ExerciseNameTextBox.TabIndex = 19;
            this.ExerciseNameTextBox.Text = "Exercise name";
            // 
            // IRepsLabel
            // 
            this.IRepsLabel.AutoSize = true;
            this.IRepsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IRepsLabel.ForeColor = System.Drawing.Color.White;
            this.IRepsLabel.Location = new System.Drawing.Point(470, 128);
            this.IRepsLabel.Name = "IRepsLabel";
            this.IRepsLabel.Size = new System.Drawing.Size(103, 21);
            this.IRepsLabel.TabIndex = 18;
            this.IRepsLabel.Text = "Initial Reps:";
            // 
            // InitialRepsNumericUpDown
            // 
            this.InitialRepsNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InitialRepsNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.InitialRepsNumericUpDown.Location = new System.Drawing.Point(577, 126);
            this.InitialRepsNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.InitialRepsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InitialRepsNumericUpDown.Name = "InitialRepsNumericUpDown";
            this.InitialRepsNumericUpDown.Size = new System.Drawing.Size(86, 28);
            this.InitialRepsNumericUpDown.TabIndex = 26;
            this.InitialRepsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InitialRepsNumericUpDown.ValueChanged += new System.EventHandler(this.InitialRepsNumericUpDown_ValueChanged);
            // 
            // FRepsLabel
            // 
            this.FRepsLabel.AutoSize = true;
            this.FRepsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FRepsLabel.ForeColor = System.Drawing.Color.White;
            this.FRepsLabel.Location = new System.Drawing.Point(475, 160);
            this.FRepsLabel.Name = "FRepsLabel";
            this.FRepsLabel.Size = new System.Drawing.Size(96, 21);
            this.FRepsLabel.TabIndex = 18;
            this.FRepsLabel.Text = "Final Reps:";
            // 
            // FinalRepsNumericUpDown
            // 
            this.FinalRepsNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinalRepsNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.FinalRepsNumericUpDown.Location = new System.Drawing.Point(577, 158);
            this.FinalRepsNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.FinalRepsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FinalRepsNumericUpDown.Name = "FinalRepsNumericUpDown";
            this.FinalRepsNumericUpDown.Size = new System.Drawing.Size(86, 28);
            this.FinalRepsNumericUpDown.TabIndex = 26;
            this.FinalRepsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetsLabel
            // 
            this.SetsLabel.AutoSize = true;
            this.SetsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetsLabel.ForeColor = System.Drawing.Color.White;
            this.SetsLabel.Location = new System.Drawing.Point(238, 160);
            this.SetsLabel.Name = "SetsLabel";
            this.SetsLabel.Size = new System.Drawing.Size(48, 21);
            this.SetsLabel.TabIndex = 18;
            this.SetsLabel.Text = "Sets:";
            // 
            // RestLabel
            // 
            this.RestLabel.AutoSize = true;
            this.RestLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestLabel.ForeColor = System.Drawing.Color.White;
            this.RestLabel.Location = new System.Drawing.Point(238, 128);
            this.RestLabel.Name = "RestLabel";
            this.RestLabel.Size = new System.Drawing.Size(50, 21);
            this.RestLabel.TabIndex = 18;
            this.RestLabel.Text = "Rest:";
            // 
            // SetsNumericUpDown
            // 
            this.SetsNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetsNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.SetsNumericUpDown.Location = new System.Drawing.Point(289, 158);
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
            this.SetsNumericUpDown.TabIndex = 26;
            this.SetsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RestDatePicker
            // 
            this.RestDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.RestDatePicker.Location = new System.Drawing.Point(289, 124);
            this.RestDatePicker.Name = "RestDatePicker";
            this.RestDatePicker.Size = new System.Drawing.Size(144, 32);
            this.RestDatePicker.TabIndex = 28;
            this.RestDatePicker.Value = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            // 
            // AddExerciseButton
            // 
            this.AddExerciseButton.Enabled = false;
            this.AddExerciseButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddExerciseButton.ForeColor = System.Drawing.Color.Black;
            this.AddExerciseButton.Location = new System.Drawing.Point(552, 240);
            this.AddExerciseButton.Name = "AddExerciseButton";
            this.AddExerciseButton.Size = new System.Drawing.Size(145, 35);
            this.AddExerciseButton.TabIndex = 24;
            this.AddExerciseButton.Text = "Add Exercise";
            this.AddExerciseButton.UseVisualStyleBackColor = true;
            this.AddExerciseButton.Click += new System.EventHandler(this.AddExerciseButton_Click);
            // 
            // DeleteExerciseButton
            // 
            this.DeleteExerciseButton.Enabled = false;
            this.DeleteExerciseButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteExerciseButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteExerciseButton.Location = new System.Drawing.Point(552, 281);
            this.DeleteExerciseButton.Name = "DeleteExerciseButton";
            this.DeleteExerciseButton.Size = new System.Drawing.Size(145, 35);
            this.DeleteExerciseButton.TabIndex = 24;
            this.DeleteExerciseButton.Text = "Delete Exercise";
            this.DeleteExerciseButton.UseVisualStyleBackColor = true;
            this.DeleteExerciseButton.Click += new System.EventHandler(this.DeleteExerciseButton_Click);
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(22, 167);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(157, 19);
            this.IncorrectNameLabel.TabIndex = 29;
            this.IncorrectNameLabel.Text = "Enter name correctly.";
            this.IncorrectNameLabel.Visible = false;
            // 
            // SaveSessionButton
            // 
            this.SaveSessionButton.Enabled = false;
            this.SaveSessionButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveSessionButton.ForeColor = System.Drawing.Color.Black;
            this.SaveSessionButton.Location = new System.Drawing.Point(182, 199);
            this.SaveSessionButton.Name = "SaveSessionButton";
            this.SaveSessionButton.Size = new System.Drawing.Size(150, 35);
            this.SaveSessionButton.TabIndex = 24;
            this.SaveSessionButton.Text = "Save Session";
            this.SaveSessionButton.UseVisualStyleBackColor = true;
            this.SaveSessionButton.Click += new System.EventHandler(this.SaveSessionButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(338, 199);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 35);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Set body part:";
            // 
            // BodyPartComboBox
            // 
            this.BodyPartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyPartComboBox.FormattingEnabled = true;
            this.BodyPartComboBox.Location = new System.Drawing.Point(472, 92);
            this.BodyPartComboBox.Name = "BodyPartComboBox";
            this.BodyPartComboBox.Size = new System.Drawing.Size(191, 31);
            this.BodyPartComboBox.TabIndex = 25;
            // 
            // IncorrectExerciseToDeletingLabel
            // 
            this.IncorrectExerciseToDeletingLabel.AutoSize = true;
            this.IncorrectExerciseToDeletingLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectExerciseToDeletingLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectExerciseToDeletingLabel.Location = new System.Drawing.Point(494, 208);
            this.IncorrectExerciseToDeletingLabel.Name = "IncorrectExerciseToDeletingLabel";
            this.IncorrectExerciseToDeletingLabel.Size = new System.Drawing.Size(188, 19);
            this.IncorrectExerciseToDeletingLabel.TabIndex = 30;
            this.IncorrectExerciseToDeletingLabel.Text = "Choose exercise correctly.";
            this.IncorrectExerciseToDeletingLabel.Visible = false;
            // 
            // AddSessionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.IncorrectExerciseToDeletingLabel);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.RestDatePicker);
            this.Controls.Add(this.FinalRepsNumericUpDown);
            this.Controls.Add(this.SetsNumericUpDown);
            this.Controls.Add(this.InitialRepsNumericUpDown);
            this.Controls.Add(this.BodyPartComboBox);
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
            this.Controls.Add(this.FRepsLabel);
            this.Controls.Add(this.SetsLabel);
            this.Controls.Add(this.IRepsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExerciseDetailsLabel);
            this.Controls.Add(this.SetLabel);
            this.Controls.Add(this.CreateSessionLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSessionUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.InitialRepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalRepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateSessionLabel;
        private System.Windows.Forms.TextBox SessionNameTextBox;
        private System.Windows.Forms.Label SetLabel;
        private System.Windows.Forms.ListView ExercisesListView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Label ExerciseDetailsLabel;
        private System.Windows.Forms.TextBox ExerciseNameTextBox;
        private System.Windows.Forms.Label IRepsLabel;
        private System.Windows.Forms.NumericUpDown InitialRepsNumericUpDown;
        private System.Windows.Forms.Label FRepsLabel;
        private System.Windows.Forms.NumericUpDown FinalRepsNumericUpDown;
        private System.Windows.Forms.Label SetsLabel;
        private System.Windows.Forms.Label RestLabel;
        private System.Windows.Forms.NumericUpDown SetsNumericUpDown;
        private System.Windows.Forms.DateTimePicker RestDatePicker;
        private System.Windows.Forms.Button AddExerciseButton;
        private System.Windows.Forms.Button DeleteExerciseButton;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.Button SaveSessionButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader BodyPartColumn;
        private System.Windows.Forms.ColumnHeader IRepsColumn;
        private System.Windows.Forms.ColumnHeader FRepsColumn;
        private System.Windows.Forms.ColumnHeader Sets;
        private System.Windows.Forms.ColumnHeader RestColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BodyPartComboBox;
        private System.Windows.Forms.Label IncorrectExerciseToDeletingLabel;
    }
}
