namespace Progress_Manager.UserControls
{
    partial class CPMControl
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
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.ReductionCheckBox = new System.Windows.Forms.CheckBox();
            this.CPMLabel = new System.Windows.Forms.Label();
            this.CPMValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.AutoSize = true;
            this.BMICalculatorLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMICalculatorLabel.ForeColor = System.Drawing.Color.White;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(20, 20);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(232, 34);
            this.BMICalculatorLabel.TabIndex = 4;
            this.BMICalculatorLabel.Text = "CPM Calculator";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 34;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculateButton.Location = new System.Drawing.Point(314, 430);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(142, 47);
            this.CalculateButton.TabIndex = 33;
            this.CalculateButton.Text = "Calculate it!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter your weight in kilograms.";
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.White;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(25, 136);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(230, 19);
            this.IncorrectNameLabel.TabIndex = 39;
            this.IncorrectNameLabel.Text = "Enter your height in centimeters.";
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.WeightNumericUpDown.Location = new System.Drawing.Point(29, 189);
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
            this.WeightNumericUpDown.TabIndex = 38;
            this.WeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.HeightNumericUpDown.Location = new System.Drawing.Point(28, 105);
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
            this.HeightNumericUpDown.TabIndex = 37;
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightLabel.ForeColor = System.Drawing.Color.White;
            this.WeightLabel.Location = new System.Drawing.Point(25, 154);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(80, 23);
            this.WeightLabel.TabIndex = 35;
            this.WeightLabel.Text = "Weight:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(25, 70);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(77, 23);
            this.HeightLabel.TabIndex = 36;
            this.HeightLabel.Text = "Height:";
            // 
            // AgeNumericUpDown
            // 
            this.AgeNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AgeNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.AgeNumericUpDown.Location = new System.Drawing.Point(29, 273);
            this.AgeNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.AgeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeNumericUpDown.Name = "AgeNumericUpDown";
            this.AgeNumericUpDown.Size = new System.Drawing.Size(194, 28);
            this.AgeNumericUpDown.TabIndex = 42;
            this.AgeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(25, 238);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(56, 23);
            this.AgeLabel.TabIndex = 41;
            this.AgeLabel.Text = "Age:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(404, 105);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(121, 29);
            this.SexComboBox.TabIndex = 44;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SexLabel.ForeColor = System.Drawing.Color.White;
            this.SexLabel.Location = new System.Drawing.Point(400, 70);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(48, 23);
            this.SexLabel.TabIndex = 43;
            this.SexLabel.Text = "Sex:";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(404, 189);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(121, 29);
            this.ActivityComboBox.TabIndex = 46;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActivityLabel.ForeColor = System.Drawing.Color.White;
            this.ActivityLabel.Location = new System.Drawing.Point(400, 154);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(87, 23);
            this.ActivityLabel.TabIndex = 45;
            this.ActivityLabel.Text = "Activity:";
            // 
            // ReductionCheckBox
            // 
            this.ReductionCheckBox.AutoSize = true;
            this.ReductionCheckBox.ForeColor = System.Drawing.Color.White;
            this.ReductionCheckBox.Location = new System.Drawing.Point(404, 239);
            this.ReductionCheckBox.Name = "ReductionCheckBox";
            this.ReductionCheckBox.Size = new System.Drawing.Size(187, 25);
            this.ReductionCheckBox.TabIndex = 47;
            this.ReductionCheckBox.Text = "Body fat reduction";
            this.ReductionCheckBox.UseVisualStyleBackColor = true;
            // 
            // CPMLabel
            // 
            this.CPMLabel.AutoSize = true;
            this.CPMLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPMLabel.ForeColor = System.Drawing.Color.White;
            this.CPMLabel.Location = new System.Drawing.Point(128, 334);
            this.CPMLabel.Name = "CPMLabel";
            this.CPMLabel.Size = new System.Drawing.Size(444, 34);
            this.CPMLabel.TabIndex = 48;
            this.CPMLabel.Text = "You daily calories requirment is:";
            // 
            // CPMValueLabel
            // 
            this.CPMValueLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPMValueLabel.ForeColor = System.Drawing.Color.White;
            this.CPMValueLabel.Location = new System.Drawing.Point(128, 368);
            this.CPMValueLabel.Name = "CPMValueLabel";
            this.CPMValueLabel.Size = new System.Drawing.Size(438, 51);
            this.CPMValueLabel.TabIndex = 49;
            this.CPMValueLabel.Text = "Value";
            this.CPMValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.CPMLabel);
            this.Controls.Add(this.CPMValueLabel);
            this.Controls.Add(this.ReductionCheckBox);
            this.Controls.Add(this.ActivityComboBox);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.AgeNumericUpDown);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.WeightNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CPMControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown AgeNumericUpDown;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.CheckBox ReductionCheckBox;
        private System.Windows.Forms.Label CPMLabel;
        private System.Windows.Forms.Label CPMValueLabel;
    }
}
