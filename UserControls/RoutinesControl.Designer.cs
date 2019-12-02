namespace Progress_Manager.UserControls
{
    partial class RoutinesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutinesControl));
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.StretchingButton = new System.Windows.Forms.Button();
            this.CardioButton = new System.Windows.Forms.Button();
            this.WorkoutButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.StretchingButton);
            this.CentralPanel.Controls.Add(this.CardioButton);
            this.CentralPanel.Controls.Add(this.WorkoutButton);
            this.CentralPanel.Controls.Add(this.MainPictureBox);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.TabIndex = 0;
            // 
            // StretchingButton
            // 
            this.StretchingButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StretchingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StretchingButton.Location = new System.Drawing.Point(423, 409);
            this.StretchingButton.Name = "StretchingButton";
            this.StretchingButton.Size = new System.Drawing.Size(142, 47);
            this.StretchingButton.TabIndex = 30;
            this.StretchingButton.Text = "Stretching";
            this.StretchingButton.UseVisualStyleBackColor = true;
            this.StretchingButton.Click += new System.EventHandler(this.StretchingButton_Click);
            // 
            // CardioButton
            // 
            this.CardioButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CardioButton.Location = new System.Drawing.Point(275, 409);
            this.CardioButton.Name = "CardioButton";
            this.CardioButton.Size = new System.Drawing.Size(142, 47);
            this.CardioButton.TabIndex = 29;
            this.CardioButton.Text = "Cardio";
            this.CardioButton.UseVisualStyleBackColor = true;
            this.CardioButton.Click += new System.EventHandler(this.CardioButton_Click);
            // 
            // WorkoutButton
            // 
            this.WorkoutButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WorkoutButton.Location = new System.Drawing.Point(127, 409);
            this.WorkoutButton.Name = "WorkoutButton";
            this.WorkoutButton.Size = new System.Drawing.Size(142, 47);
            this.WorkoutButton.TabIndex = 28;
            this.WorkoutButton.Text = "Work Out ";
            this.WorkoutButton.UseVisualStyleBackColor = true;
            this.WorkoutButton.Click += new System.EventHandler(this.WorkoutButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(155, 53);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(370, 320);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 2;
            this.MainPictureBox.TabStop = false;
            // 
            // RoutinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.CentralPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoutinesControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button StretchingButton;
        private System.Windows.Forms.Button CardioButton;
        private System.Windows.Forms.Button WorkoutButton;
    }
}
