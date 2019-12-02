namespace Progress_Manager.UserControls
{
    partial class ShowCardioRoutineUserControl
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
            this.DurationLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.TotalSetsLabel = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExercisesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowSessionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(237, 340);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(181, 23);
            this.DurationLabel.TabIndex = 47;
            this.DurationLabel.Text = "Routine Duration: ";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartLabel.ForeColor = System.Drawing.Color.White;
            this.StartLabel.Location = new System.Drawing.Point(16, 387);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(65, 23);
            this.StartLabel.TabIndex = 48;
            this.StartLabel.Text = "Start: ";
            // 
            // TotalSetsLabel
            // 
            this.TotalSetsLabel.AutoSize = true;
            this.TotalSetsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalSetsLabel.ForeColor = System.Drawing.Color.White;
            this.TotalSetsLabel.Location = new System.Drawing.Point(16, 340);
            this.TotalSetsLabel.Name = "TotalSetsLabel";
            this.TotalSetsLabel.Size = new System.Drawing.Size(112, 23);
            this.TotalSetsLabel.TabIndex = 50;
            this.TotalSetsLabel.Text = "Total Sets: ";
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(314, 430);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(142, 47);
            this.OpenButton.TabIndex = 45;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 46;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.ExercisesListView.Location = new System.Drawing.Point(20, 70);
            this.ExercisesListView.MultiSelect = false;
            this.ExercisesListView.Name = "ExercisesListView";
            this.ExercisesListView.Size = new System.Drawing.Size(660, 244);
            this.ExercisesListView.TabIndex = 44;
            this.ExercisesListView.UseCompatibleStateImageBehavior = false;
            this.ExercisesListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 374;
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            this.DurationColumn.Width = 110;
            // 
            // SetsColumn
            // 
            this.SetsColumn.Text = "Sets";
            // 
            // RestsColumn
            // 
            this.RestsColumn.Text = "Rest";
            this.RestsColumn.Width = 110;
            // 
            // ShowSessionLabel
            // 
            this.ShowSessionLabel.AutoSize = true;
            this.ShowSessionLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowSessionLabel.ForeColor = System.Drawing.Color.White;
            this.ShowSessionLabel.Location = new System.Drawing.Point(20, 20);
            this.ShowSessionLabel.Name = "ShowSessionLabel";
            this.ShowSessionLabel.Size = new System.Drawing.Size(302, 34);
            this.ShowSessionLabel.TabIndex = 43;
            this.ShowSessionLabel.Text = "Show Cardio Routine";
            // 
            // ShowCardioRoutineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TotalSetsLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExercisesListView);
            this.Controls.Add(this.ShowSessionLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowCardioRoutineUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label TotalSetsLabel;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ExercisesListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.Label ShowSessionLabel;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader SetsColumn;
        private System.Windows.Forms.ColumnHeader RestsColumn;
    }
}
