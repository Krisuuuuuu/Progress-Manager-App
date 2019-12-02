namespace Progress_Manager.UserControls
{
    partial class BMIControl
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
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMIValueLabel = new System.Windows.Forms.Label();
            this.BMIDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.AutoSize = true;
            this.BMICalculatorLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMICalculatorLabel.ForeColor = System.Drawing.Color.White;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(20, 20);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(214, 34);
            this.BMICalculatorLabel.TabIndex = 3;
            this.BMICalculatorLabel.Text = "BMI Calculator";
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
            this.WeightNumericUpDown.TabIndex = 28;
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
            this.HeightNumericUpDown.Location = new System.Drawing.Point(29, 105);
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
            this.HeightNumericUpDown.TabIndex = 27;
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
            this.WeightLabel.TabIndex = 25;
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
            this.HeightLabel.TabIndex = 26;
            this.HeightLabel.Text = "Height:";
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.White;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(25, 136);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(230, 19);
            this.IncorrectNameLabel.TabIndex = 29;
            this.IncorrectNameLabel.Text = "Enter your height in centimeters.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter your weight in kilograms.";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 32;
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
            this.CalculateButton.TabIndex = 31;
            this.CalculateButton.Text = "Calculate it!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMILabel.ForeColor = System.Drawing.Color.White;
            this.BMILabel.Location = new System.Drawing.Point(308, 96);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(335, 34);
            this.BMILabel.TabIndex = 3;
            this.BMILabel.Text = "The value of your BMI is:";
            // 
            // BMIValueLabel
            // 
            this.BMIValueLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMIValueLabel.ForeColor = System.Drawing.Color.White;
            this.BMIValueLabel.Location = new System.Drawing.Point(314, 145);
            this.BMIValueLabel.Name = "BMIValueLabel";
            this.BMIValueLabel.Size = new System.Drawing.Size(329, 51);
            this.BMIValueLabel.TabIndex = 3;
            this.BMIValueLabel.Text = "Value";
            this.BMIValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIDescription
            // 
            this.BMIDescription.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMIDescription.ForeColor = System.Drawing.Color.White;
            this.BMIDescription.Location = new System.Drawing.Point(23, 317);
            this.BMIDescription.Name = "BMIDescription";
            this.BMIDescription.Size = new System.Drawing.Size(654, 88);
            this.BMIDescription.TabIndex = 3;
            this.BMIDescription.Text = "BMI Description";
            this.BMIDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.WeightNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.BMIDescription);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.BMIValueLabel);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BMIControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label BMIValueLabel;
        private System.Windows.Forms.Label BMIDescription;
    }
}
