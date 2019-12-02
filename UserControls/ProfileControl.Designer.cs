namespace Progress_Manager.UserControls
{
    partial class ProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowProfileButton = new System.Windows.Forms.Button();
            this.ModifyProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(155, 53);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(370, 320);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 3;
            this.MainPictureBox.TabStop = false;
            // 
            // ShowProfileButton
            // 
            this.ShowProfileButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowProfileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowProfileButton.Location = new System.Drawing.Point(344, 409);
            this.ShowProfileButton.Name = "ShowProfileButton";
            this.ShowProfileButton.Size = new System.Drawing.Size(142, 47);
            this.ShowProfileButton.TabIndex = 31;
            this.ShowProfileButton.Text = "Show";
            this.ShowProfileButton.UseVisualStyleBackColor = true;
            this.ShowProfileButton.Click += new System.EventHandler(this.ShowProfileButton_Click);
            // 
            // ModifyProfileButton
            // 
            this.ModifyProfileButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModifyProfileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModifyProfileButton.Location = new System.Drawing.Point(196, 409);
            this.ModifyProfileButton.Name = "ModifyProfileButton";
            this.ModifyProfileButton.Size = new System.Drawing.Size(142, 47);
            this.ModifyProfileButton.TabIndex = 30;
            this.ModifyProfileButton.Text = "Modify";
            this.ModifyProfileButton.UseVisualStyleBackColor = true;
            this.ModifyProfileButton.Click += new System.EventHandler(this.ModifyProfileButton_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.ShowProfileButton);
            this.Controls.Add(this.ModifyProfileButton);
            this.Controls.Add(this.MainPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button ShowProfileButton;
        private System.Windows.Forms.Button ModifyProfileButton;
    }
}
