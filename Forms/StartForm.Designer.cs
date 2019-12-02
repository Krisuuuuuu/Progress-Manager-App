namespace Progress_Manager
{
    partial class StartForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.SignInMenuButton = new System.Windows.Forms.Button();
            this.LogInMenuButton = new System.Windows.Forms.Button();
            this.Motto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInMenuButton
            // 
            this.SignInMenuButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignInMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignInMenuButton.Location = new System.Drawing.Point(248, 415);
            this.SignInMenuButton.Name = "SignInMenuButton";
            this.SignInMenuButton.Size = new System.Drawing.Size(250, 60);
            this.SignInMenuButton.TabIndex = 0;
            this.SignInMenuButton.Text = "Sign In";
            this.SignInMenuButton.UseVisualStyleBackColor = true;
            this.SignInMenuButton.Click += new System.EventHandler(this.SignInMenuButton_Click);
            // 
            // LogInMenuButton
            // 
            this.LogInMenuButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInMenuButton.Location = new System.Drawing.Point(248, 481);
            this.LogInMenuButton.Name = "LogInMenuButton";
            this.LogInMenuButton.Size = new System.Drawing.Size(250, 60);
            this.LogInMenuButton.TabIndex = 1;
            this.LogInMenuButton.Text = "Log In";
            this.LogInMenuButton.UseVisualStyleBackColor = true;
            this.LogInMenuButton.Click += new System.EventHandler(this.LogInMenuButton_Click);
            // 
            // Motto
            // 
            this.Motto.AutoSize = true;
            this.Motto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Motto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Motto.Location = new System.Drawing.Point(174, 376);
            this.Motto.Name = "Motto";
            this.Motto.Size = new System.Drawing.Size(394, 23);
            this.Motto.TabIndex = 2;
            this.Motto.Text = "Your Body. Your Decision. Your Success";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(162, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExitPictureBox);
            this.panel1.Controls.Add(this.MinimizePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 50);
            this.panel1.TabIndex = 4;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePictureBox.Image")));
            this.MinimizePictureBox.Location = new System.Drawing.Point(677, 0);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(48, 44);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 3;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click_1);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureBox.Image")));
            this.ExitPictureBox.Location = new System.Drawing.Point(731, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(48, 44);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 4;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click_1);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Motto);
            this.Controls.Add(this.LogInMenuButton);
            this.Controls.Add(this.SignInMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "Progress Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInMenuButton;
        private System.Windows.Forms.Button LogInMenuButton;
        private System.Windows.Forms.Label Motto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
    }
}

