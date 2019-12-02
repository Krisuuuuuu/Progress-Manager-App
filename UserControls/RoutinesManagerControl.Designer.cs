namespace Progress_Manager.UserControls
{
    partial class RoutinesManagerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutinesManagerControl));
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.DeleteRoutineButton = new System.Windows.Forms.Button();
            this.ShowRoutineButton = new System.Windows.Forms.Button();
            this.CreateRoutineButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.DeleteRoutineButton);
            this.CentralPanel.Controls.Add(this.ShowRoutineButton);
            this.CentralPanel.Controls.Add(this.CreateRoutineButton);
            this.CentralPanel.Controls.Add(this.MainPictureBox);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.TabIndex = 0;
            // 
            // DeleteRoutineButton
            // 
            this.DeleteRoutineButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRoutineButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteRoutineButton.Location = new System.Drawing.Point(423, 409);
            this.DeleteRoutineButton.Name = "DeleteRoutineButton";
            this.DeleteRoutineButton.Size = new System.Drawing.Size(142, 47);
            this.DeleteRoutineButton.TabIndex = 30;
            this.DeleteRoutineButton.Text = "Delete";
            this.DeleteRoutineButton.UseVisualStyleBackColor = true;
            this.DeleteRoutineButton.Click += new System.EventHandler(this.DeleteRoutineButton_Click);
            // 
            // ShowRoutineButton
            // 
            this.ShowRoutineButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowRoutineButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowRoutineButton.Location = new System.Drawing.Point(275, 409);
            this.ShowRoutineButton.Name = "ShowRoutineButton";
            this.ShowRoutineButton.Size = new System.Drawing.Size(142, 47);
            this.ShowRoutineButton.TabIndex = 29;
            this.ShowRoutineButton.Text = "Show";
            this.ShowRoutineButton.UseVisualStyleBackColor = true;
            this.ShowRoutineButton.Click += new System.EventHandler(this.ShowRoutineButton_Click);
            // 
            // CreateRoutineButton
            // 
            this.CreateRoutineButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateRoutineButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateRoutineButton.Location = new System.Drawing.Point(127, 409);
            this.CreateRoutineButton.Name = "CreateRoutineButton";
            this.CreateRoutineButton.Size = new System.Drawing.Size(142, 47);
            this.CreateRoutineButton.TabIndex = 28;
            this.CreateRoutineButton.Text = "Create";
            this.CreateRoutineButton.UseVisualStyleBackColor = true;
            this.CreateRoutineButton.Click += new System.EventHandler(this.CreateRoutineButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(145, 53);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(370, 320);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 2;
            this.MainPictureBox.TabStop = false;
            // 
            // RoutinesManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.CentralPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoutinesManagerControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.CentralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button DeleteRoutineButton;
        private System.Windows.Forms.Button ShowRoutineButton;
        private System.Windows.Forms.Button CreateRoutineButton;
    }
}
