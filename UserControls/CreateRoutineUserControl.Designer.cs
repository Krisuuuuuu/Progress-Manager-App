namespace Progress_Manager.UserControls
{
    partial class CreateRoutineUserControl
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
            this.CreateRoutineLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IncorrectDateLabel1 = new System.Windows.Forms.Label();
            this.IncorrectDateLabel2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateRoutineLabel
            // 
            this.CreateRoutineLabel.AutoSize = true;
            this.CreateRoutineLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateRoutineLabel.ForeColor = System.Drawing.Color.White;
            this.CreateRoutineLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateRoutineLabel.Name = "CreateRoutineLabel";
            this.CreateRoutineLabel.Size = new System.Drawing.Size(306, 34);
            this.CreateRoutineLabel.TabIndex = 3;
            this.CreateRoutineLabel.Text = "Add Workout Routine";
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(22, 135);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(271, 19);
            this.IncorrectNameLabel.TabIndex = 18;
            this.IncorrectNameLabel.Text = "Name, which you entered is incorrect.";
            this.IncorrectNameLabel.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NameTextBox.Location = new System.Drawing.Point(26, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(191, 28);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.Text = "Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(22, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndDatePicker.CalendarForeColor = System.Drawing.Color.Gray;
            this.EndDatePicker.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.EndDatePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(26, 280);
            this.EndDatePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 28);
            this.EndDatePicker.TabIndex = 21;
            this.EndDatePicker.Value = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndLabel.ForeColor = System.Drawing.Color.White;
            this.EndLabel.Location = new System.Drawing.Point(22, 245);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(52, 23);
            this.EndLabel.TabIndex = 20;
            this.EndLabel.Text = "End:";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartLabel.ForeColor = System.Drawing.Color.White;
            this.StartLabel.Location = new System.Drawing.Point(22, 155);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(59, 23);
            this.StartLabel.TabIndex = 20;
            this.StartLabel.Text = "Start:";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartDatePicker.CalendarForeColor = System.Drawing.Color.Gray;
            this.StartDatePicker.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.StartDatePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(26, 190);
            this.StartDatePicker.MaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 28);
            this.StartDatePicker.TabIndex = 21;
            this.StartDatePicker.Value = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            // 
            // IncorrectDateLabel1
            // 
            this.IncorrectDateLabel1.AutoSize = true;
            this.IncorrectDateLabel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectDateLabel1.ForeColor = System.Drawing.Color.Red;
            this.IncorrectDateLabel1.Location = new System.Drawing.Point(22, 225);
            this.IncorrectDateLabel1.Name = "IncorrectDateLabel1";
            this.IncorrectDateLabel1.Size = new System.Drawing.Size(227, 19);
            this.IncorrectDateLabel1.TabIndex = 18;
            this.IncorrectDateLabel1.Text = "Enter routine duration correctly.";
            this.IncorrectDateLabel1.Visible = false;
            // 
            // IncorrectDateLabel2
            // 
            this.IncorrectDateLabel2.AutoSize = true;
            this.IncorrectDateLabel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectDateLabel2.ForeColor = System.Drawing.Color.Red;
            this.IncorrectDateLabel2.Location = new System.Drawing.Point(22, 310);
            this.IncorrectDateLabel2.Name = "IncorrectDateLabel2";
            this.IncorrectDateLabel2.Size = new System.Drawing.Size(227, 19);
            this.IncorrectDateLabel2.TabIndex = 18;
            this.IncorrectDateLabel2.Text = "Enter routine duration correctly.";
            this.IncorrectDateLabel2.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmButton.Location = new System.Drawing.Point(314, 430);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(142, 47);
            this.ConfirmButton.TabIndex = 23;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CreateRoutineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.IncorrectDateLabel2);
            this.Controls.Add(this.IncorrectDateLabel1);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CreateRoutineLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateRoutineUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateRoutineLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label IncorrectDateLabel1;
        private System.Windows.Forms.Label IncorrectDateLabel2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
