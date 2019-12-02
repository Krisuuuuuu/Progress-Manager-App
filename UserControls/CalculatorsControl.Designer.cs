namespace Progress_Manager.UserControls
{
    partial class CalculatorsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorsControl));
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.CPMButton = new System.Windows.Forms.Button();
            this.OneRepMaxButton = new System.Windows.Forms.Button();
            this.BMIButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.CPMButton);
            this.CentralPanel.Controls.Add(this.OneRepMaxButton);
            this.CentralPanel.Controls.Add(this.BMIButton);
            this.CentralPanel.Controls.Add(this.MainPictureBox);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.ForeColor = System.Drawing.Color.Gray;
            this.CentralPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.TabIndex = 0;
            // 
            // CPMButton
            // 
            this.CPMButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPMButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPMButton.Location = new System.Drawing.Point(423, 409);
            this.CPMButton.Name = "CPMButton";
            this.CPMButton.Size = new System.Drawing.Size(142, 47);
            this.CPMButton.TabIndex = 27;
            this.CPMButton.Text = "CPM";
            this.CPMButton.UseVisualStyleBackColor = true;
            this.CPMButton.Click += new System.EventHandler(this.CPMButton_Click);
            // 
            // OneRepMaxButton
            // 
            this.OneRepMaxButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneRepMaxButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OneRepMaxButton.Location = new System.Drawing.Point(275, 409);
            this.OneRepMaxButton.Name = "OneRepMaxButton";
            this.OneRepMaxButton.Size = new System.Drawing.Size(142, 47);
            this.OneRepMaxButton.TabIndex = 26;
            this.OneRepMaxButton.Text = "One Rep Max";
            this.OneRepMaxButton.UseVisualStyleBackColor = true;
            this.OneRepMaxButton.Click += new System.EventHandler(this.OneRepMaxButton_Click);
            // 
            // BMIButton
            // 
            this.BMIButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMIButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMIButton.Location = new System.Drawing.Point(127, 409);
            this.BMIButton.Name = "BMIButton";
            this.BMIButton.Size = new System.Drawing.Size(142, 47);
            this.BMIButton.TabIndex = 25;
            this.BMIButton.Text = "BMI";
            this.BMIButton.UseVisualStyleBackColor = true;
            this.BMIButton.Click += new System.EventHandler(this.BMIButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(155, 53);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(370, 320);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            // 
            // CalculatorsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.CentralPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CalculatorsControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button CPMButton;
        private System.Windows.Forms.Button OneRepMaxButton;
        private System.Windows.Forms.Button BMIButton;
    }
}
