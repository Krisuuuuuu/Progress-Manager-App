namespace Progress_Manager.UserControls
{
    partial class OneRepMaxControl
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
            this.OneRepMaxCalculatorLabel = new System.Windows.Forms.Label();
            this.WeightInfoLabel = new System.Windows.Forms.Label();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BodyPartLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BodyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OneRepMaxLabel = new System.Windows.Forms.Label();
            this.OneRepMaxValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OneRepMaxCalculatorLabel
            // 
            this.OneRepMaxCalculatorLabel.AutoSize = true;
            this.OneRepMaxCalculatorLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneRepMaxCalculatorLabel.ForeColor = System.Drawing.Color.White;
            this.OneRepMaxCalculatorLabel.Location = new System.Drawing.Point(20, 20);
            this.OneRepMaxCalculatorLabel.Name = "OneRepMaxCalculatorLabel";
            this.OneRepMaxCalculatorLabel.Size = new System.Drawing.Size(353, 34);
            this.OneRepMaxCalculatorLabel.TabIndex = 4;
            this.OneRepMaxCalculatorLabel.Text = "One Rep Max Calculator";
            // 
            // WeightInfoLabel
            // 
            this.WeightInfoLabel.AutoSize = true;
            this.WeightInfoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightInfoLabel.ForeColor = System.Drawing.Color.White;
            this.WeightInfoLabel.Location = new System.Drawing.Point(25, 136);
            this.WeightInfoLabel.Name = "WeightInfoLabel";
            this.WeightInfoLabel.Size = new System.Drawing.Size(433, 19);
            this.WeightInfoLabel.TabIndex = 35;
            this.WeightInfoLabel.Text = "Enter weight which you use to work out (4-6 reps) in kilograms.";
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.WeightNumericUpDown.Location = new System.Drawing.Point(29, 105);
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
            this.WeightNumericUpDown.TabIndex = 33;
            this.WeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BodyPartLabel
            // 
            this.BodyPartLabel.AutoSize = true;
            this.BodyPartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BodyPartLabel.ForeColor = System.Drawing.Color.White;
            this.BodyPartLabel.Location = new System.Drawing.Point(25, 154);
            this.BodyPartLabel.Name = "BodyPartLabel";
            this.BodyPartLabel.Size = new System.Drawing.Size(185, 23);
            this.BodyPartLabel.TabIndex = 31;
            this.BodyPartLabel.Text = "Part of your body:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightLabel.ForeColor = System.Drawing.Color.White;
            this.WeightLabel.Location = new System.Drawing.Point(25, 70);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(80, 23);
            this.WeightLabel.TabIndex = 32;
            this.WeightLabel.Text = "Weight:";
            // 
            // BodyTypeComboBox
            // 
            this.BodyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyTypeComboBox.FormattingEnabled = true;
            this.BodyTypeComboBox.Location = new System.Drawing.Point(29, 189);
            this.BodyTypeComboBox.Name = "BodyTypeComboBox";
            this.BodyTypeComboBox.Size = new System.Drawing.Size(121, 29);
            this.BodyTypeComboBox.TabIndex = 37;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 39;
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
            this.CalculateButton.TabIndex = 38;
            this.CalculateButton.Text = "Calculate it!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OneRepMaxLabel
            // 
            this.OneRepMaxLabel.AutoSize = true;
            this.OneRepMaxLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneRepMaxLabel.ForeColor = System.Drawing.Color.White;
            this.OneRepMaxLabel.Location = new System.Drawing.Point(79, 283);
            this.OneRepMaxLabel.Name = "OneRepMaxLabel";
            this.OneRepMaxLabel.Size = new System.Drawing.Size(536, 34);
            this.OneRepMaxLabel.TabIndex = 40;
            this.OneRepMaxLabel.Text = "The maximum value of your one rep is:";
            // 
            // OneRepMaxValueLabel
            // 
            this.OneRepMaxValueLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneRepMaxValueLabel.ForeColor = System.Drawing.Color.White;
            this.OneRepMaxValueLabel.Location = new System.Drawing.Point(168, 328);
            this.OneRepMaxValueLabel.Name = "OneRepMaxValueLabel";
            this.OneRepMaxValueLabel.Size = new System.Drawing.Size(329, 51);
            this.OneRepMaxValueLabel.TabIndex = 41;
            this.OneRepMaxValueLabel.Text = "Value";
            this.OneRepMaxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneRepMaxControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.OneRepMaxLabel);
            this.Controls.Add(this.OneRepMaxValueLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BodyTypeComboBox);
            this.Controls.Add(this.WeightInfoLabel);
            this.Controls.Add(this.WeightNumericUpDown);
            this.Controls.Add(this.BodyPartLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.OneRepMaxCalculatorLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "OneRepMaxControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OneRepMaxCalculatorLabel;
        private System.Windows.Forms.Label WeightInfoLabel;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
        private System.Windows.Forms.Label BodyPartLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.ComboBox BodyTypeComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label OneRepMaxLabel;
        private System.Windows.Forms.Label OneRepMaxValueLabel;
    }
}
