namespace Progress_Manager.UserControls
{
    partial class ModifyProfileControl
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
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.IncorrectSurnameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.BodyTypeLabel = new System.Windows.Forms.Label();
            this.BodyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.White;
            this.ProfileLabel.Location = new System.Drawing.Point(20, 20);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(157, 34);
            this.ProfileLabel.TabIndex = 2;
            this.ProfileLabel.Text = "Edit Profile";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(25, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NameTextBox.Location = new System.Drawing.Point(29, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(191, 28);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameLabel.Location = new System.Drawing.Point(25, 154);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(101, 23);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SurnameTextBox.Location = new System.Drawing.Point(29, 189);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(191, 28);
            this.SurnameTextBox.TabIndex = 7;
            this.SurnameTextBox.Text = "Surname";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(25, 238);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(77, 23);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightLabel.ForeColor = System.Drawing.Color.White;
            this.WeightLabel.Location = new System.Drawing.Point(25, 322);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(80, 23);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight:";
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(25, 136);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(271, 19);
            this.IncorrectNameLabel.TabIndex = 15;
            this.IncorrectNameLabel.Text = "Name, which you entered is incorrect.";
            this.IncorrectNameLabel.Visible = false;
            // 
            // IncorrectSurnameLabel
            // 
            this.IncorrectSurnameLabel.AutoSize = true;
            this.IncorrectSurnameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSurnameLabel.Location = new System.Drawing.Point(25, 220);
            this.IncorrectSurnameLabel.Name = "IncorrectSurnameLabel";
            this.IncorrectSurnameLabel.Size = new System.Drawing.Size(290, 19);
            this.IncorrectSurnameLabel.TabIndex = 16;
            this.IncorrectSurnameLabel.Text = "Surname, which you entered is incorrect.";
            this.IncorrectSurnameLabel.Visible = false;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(400, 70);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(126, 23);
            this.DateOfBirthLabel.TabIndex = 6;
            this.DateOfBirthLabel.Text = "DateOfBirth:";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfBirthPicker.CalendarForeColor = System.Drawing.Color.Gray;
            this.DateOfBirthPicker.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.DateOfBirthPicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthPicker.Location = new System.Drawing.Point(404, 105);
            this.DateOfBirthPicker.MaxDate = new System.DateTime(2019, 10, 29, 0, 0, 0, 0);
            this.DateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 28);
            this.DateOfBirthPicker.TabIndex = 19;
            this.DateOfBirthPicker.Value = new System.DateTime(2019, 10, 15, 0, 0, 0, 0);
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BodyTypeLabel.ForeColor = System.Drawing.Color.White;
            this.BodyTypeLabel.Location = new System.Drawing.Point(400, 154);
            this.BodyTypeLabel.Name = "BodyTypeLabel";
            this.BodyTypeLabel.Size = new System.Drawing.Size(192, 23);
            this.BodyTypeLabel.TabIndex = 6;
            this.BodyTypeLabel.Text = "Type of your body:";
            // 
            // BodyTypeComboBox
            // 
            this.BodyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyTypeComboBox.FormattingEnabled = true;
            this.BodyTypeComboBox.Location = new System.Drawing.Point(404, 189);
            this.BodyTypeComboBox.Name = "BodyTypeComboBox";
            this.BodyTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.BodyTypeComboBox.TabIndex = 20;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.HeightNumericUpDown.Location = new System.Drawing.Point(29, 273);
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.HeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(194, 28);
            this.HeightNumericUpDown.TabIndex = 23;
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.WeightNumericUpDown.Location = new System.Drawing.Point(29, 357);
            this.WeightNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.WeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(194, 28);
            this.WeightNumericUpDown.TabIndex = 24;
            this.WeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.Location = new System.Drawing.Point(314, 430);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(142, 47);
            this.ConfirmButton.TabIndex = 21;
            this.ConfirmButton.Text = "Confirm!";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ModifyProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.WeightNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BodyTypeComboBox);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.IncorrectSurnameLabel);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BodyTypeLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ProfileLabel);
            this.Name = "ModifyProfileControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.Label IncorrectSurnameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label BodyTypeLabel;
        private System.Windows.Forms.ComboBox BodyTypeComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
