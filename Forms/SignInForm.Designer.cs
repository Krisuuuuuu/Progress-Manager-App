namespace Progress_Manager
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.SignInLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignInRightPanel = new System.Windows.Forms.Panel();
            this.IncorrectPasswordLabel2 = new System.Windows.Forms.Label();
            this.NoCheckLabel = new System.Windows.Forms.Label();
            this.IncorrectEmailLabel = new System.Windows.Forms.Label();
            this.IncorrectReEnteredLabel = new System.Windows.Forms.Label();
            this.IncorrectPasswordLabel = new System.Windows.Forms.Label();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.CancelSignInButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.LicenseTermCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.RePassTextBox = new System.Windows.Forms.TextBox();
            this.RePassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignInLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SignInRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignInLeft
            // 
            this.SignInLeft.Controls.Add(this.pictureBox1);
            this.SignInLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.SignInLeft.Location = new System.Drawing.Point(0, 0);
            this.SignInLeft.Name = "SignInLeft";
            this.SignInLeft.Size = new System.Drawing.Size(394, 553);
            this.SignInLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignInRightPanel
            // 
            this.SignInRightPanel.BackColor = System.Drawing.Color.White;
            this.SignInRightPanel.Controls.Add(this.IncorrectPasswordLabel2);
            this.SignInRightPanel.Controls.Add(this.NoCheckLabel);
            this.SignInRightPanel.Controls.Add(this.IncorrectEmailLabel);
            this.SignInRightPanel.Controls.Add(this.IncorrectReEnteredLabel);
            this.SignInRightPanel.Controls.Add(this.IncorrectPasswordLabel);
            this.SignInRightPanel.Controls.Add(this.IncorrectLoginLabel);
            this.SignInRightPanel.Controls.Add(this.CancelSignInButton);
            this.SignInRightPanel.Controls.Add(this.SignInButton);
            this.SignInRightPanel.Controls.Add(this.LicenseTermCheckBox);
            this.SignInRightPanel.Controls.Add(this.EmailTextBox);
            this.SignInRightPanel.Controls.Add(this.EmailLabel);
            this.SignInRightPanel.Controls.Add(this.RePassTextBox);
            this.SignInRightPanel.Controls.Add(this.RePassLabel);
            this.SignInRightPanel.Controls.Add(this.PassTextBox);
            this.SignInRightPanel.Controls.Add(this.PassLabel);
            this.SignInRightPanel.Controls.Add(this.LoginTextBox);
            this.SignInRightPanel.Controls.Add(this.Loginlabel);
            this.SignInRightPanel.Controls.Add(this.SignInLabel);
            this.SignInRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SignInRightPanel.Location = new System.Drawing.Point(394, 0);
            this.SignInRightPanel.Name = "SignInRightPanel";
            this.SignInRightPanel.Size = new System.Drawing.Size(388, 553);
            this.SignInRightPanel.TabIndex = 1;
            // 
            // IncorrectPasswordLabel2
            // 
            this.IncorrectPasswordLabel2.AutoSize = true;
            this.IncorrectPasswordLabel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel2.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel2.Location = new System.Drawing.Point(11, 296);
            this.IncorrectPasswordLabel2.Name = "IncorrectPasswordLabel2";
            this.IncorrectPasswordLabel2.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel2.TabIndex = 20;
            this.IncorrectPasswordLabel2.Text = "Password, which you entered is incorrect.";
            this.IncorrectPasswordLabel2.Visible = false;
            // 
            // NoCheckLabel
            // 
            this.NoCheckLabel.AutoSize = true;
            this.NoCheckLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NoCheckLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.NoCheckLabel.Location = new System.Drawing.Point(11, 430);
            this.NoCheckLabel.Name = "NoCheckLabel";
            this.NoCheckLabel.Size = new System.Drawing.Size(243, 19);
            this.NoCheckLabel.TabIndex = 19;
            this.NoCheckLabel.Text = "You have to accept license terms.";
            this.NoCheckLabel.Visible = false;
            // 
            // IncorrectEmailLabel
            // 
            this.IncorrectEmailLabel.AutoSize = true;
            this.IncorrectEmailLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncorrectEmailLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectEmailLabel.Location = new System.Drawing.Point(11, 380);
            this.IncorrectEmailLabel.Name = "IncorrectEmailLabel";
            this.IncorrectEmailLabel.Size = new System.Drawing.Size(266, 19);
            this.IncorrectEmailLabel.TabIndex = 18;
            this.IncorrectEmailLabel.Text = "Email, which you entered is incorrect.";
            this.IncorrectEmailLabel.Visible = false;
            // 
            // IncorrectReEnteredLabel
            // 
            this.IncorrectReEnteredLabel.AutoSize = true;
            this.IncorrectReEnteredLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncorrectReEnteredLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectReEnteredLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectReEnteredLabel.Location = new System.Drawing.Point(11, 296);
            this.IncorrectReEnteredLabel.Name = "IncorrectReEnteredLabel";
            this.IncorrectReEnteredLabel.Size = new System.Drawing.Size(308, 19);
            this.IncorrectReEnteredLabel.TabIndex = 17;
            this.IncorrectReEnteredLabel.Text = "Passwords, which you entered are different.";
            this.IncorrectReEnteredLabel.Visible = false;
            // 
            // IncorrectPasswordLabel
            // 
            this.IncorrectPasswordLabel.AutoSize = true;
            this.IncorrectPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel.Location = new System.Drawing.Point(11, 212);
            this.IncorrectPasswordLabel.Name = "IncorrectPasswordLabel";
            this.IncorrectPasswordLabel.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel.TabIndex = 16;
            this.IncorrectPasswordLabel.Text = "Password, which you entered is incorrect.";
            this.IncorrectPasswordLabel.Visible = false;
            // 
            // IncorrectLoginLabel
            // 
            this.IncorrectLoginLabel.AutoSize = true;
            this.IncorrectLoginLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginLabel.Location = new System.Drawing.Point(11, 128);
            this.IncorrectLoginLabel.Name = "IncorrectLoginLabel";
            this.IncorrectLoginLabel.Size = new System.Drawing.Size(265, 19);
            this.IncorrectLoginLabel.TabIndex = 15;
            this.IncorrectLoginLabel.Text = "Login, which you entered is incorrect.";
            this.IncorrectLoginLabel.Visible = false;
            // 
            // CancelSignInButton
            // 
            this.CancelSignInButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelSignInButton.Location = new System.Drawing.Point(163, 450);
            this.CancelSignInButton.Name = "CancelSignInButton";
            this.CancelSignInButton.Size = new System.Drawing.Size(142, 47);
            this.CancelSignInButton.TabIndex = 11;
            this.CancelSignInButton.Text = "Cancel";
            this.CancelSignInButton.UseVisualStyleBackColor = true;
            this.CancelSignInButton.Click += new System.EventHandler(this.CancelSignInButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignInButton.Location = new System.Drawing.Point(15, 450);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(142, 47);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "Sign In!";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LicenseTermCheckBox
            // 
            this.LicenseTermCheckBox.AutoSize = true;
            this.LicenseTermCheckBox.BackColor = System.Drawing.Color.Silver;
            this.LicenseTermCheckBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LicenseTermCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LicenseTermCheckBox.Location = new System.Drawing.Point(15, 399);
            this.LicenseTermCheckBox.Name = "LicenseTermCheckBox";
            this.LicenseTermCheckBox.Size = new System.Drawing.Size(331, 23);
            this.LicenseTermCheckBox.TabIndex = 9;
            this.LicenseTermCheckBox.Text = "I Agree License Term and Conditions";
            this.LicenseTermCheckBox.UseVisualStyleBackColor = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailTextBox.Location = new System.Drawing.Point(15, 349);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(351, 28);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.Text = "Email";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Gray;
            this.EmailLabel.Location = new System.Drawing.Point(11, 314);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(67, 23);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email:";
            // 
            // RePassTextBox
            // 
            this.RePassTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RePassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.RePassTextBox.Location = new System.Drawing.Point(15, 265);
            this.RePassTextBox.Name = "RePassTextBox";
            this.RePassTextBox.Size = new System.Drawing.Size(351, 28);
            this.RePassTextBox.TabIndex = 6;
            this.RePassTextBox.Text = "Password:";
            this.RePassTextBox.UseSystemPasswordChar = true;
            // 
            // RePassLabel
            // 
            this.RePassLabel.AutoSize = true;
            this.RePassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RePassLabel.ForeColor = System.Drawing.Color.Gray;
            this.RePassLabel.Location = new System.Drawing.Point(11, 230);
            this.RePassLabel.Name = "RePassLabel";
            this.RePassLabel.Size = new System.Drawing.Size(234, 23);
            this.RePassLabel.TabIndex = 5;
            this.RePassLabel.Text = "Re - Entered Password:";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PassTextBox.Location = new System.Drawing.Point(15, 181);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(351, 28);
            this.PassTextBox.TabIndex = 4;
            this.PassTextBox.Text = "Password:";
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassLabel.ForeColor = System.Drawing.Color.Gray;
            this.PassLabel.Location = new System.Drawing.Point(11, 146);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(108, 23);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.Location = new System.Drawing.Point(15, 97);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(351, 28);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.Text = "Login";
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Loginlabel.ForeColor = System.Drawing.Color.Gray;
            this.Loginlabel.Location = new System.Drawing.Point(11, 62);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(111, 23);
            this.Loginlabel.TabIndex = 1;
            this.Loginlabel.Text = "User Login:";
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignInLabel.ForeColor = System.Drawing.Color.Gray;
            this.SignInLabel.Location = new System.Drawing.Point(6, 9);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(103, 34);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign In";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.SignInRightPanel);
            this.Controls.Add(this.SignInLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.SignInLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SignInRightPanel.ResumeLayout(false);
            this.SignInRightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignInLeft;
        private System.Windows.Forms.Panel SignInRightPanel;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.TextBox RePassTextBox;
        private System.Windows.Forms.Label RePassLabel;
        private System.Windows.Forms.CheckBox LicenseTermCheckBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button CancelSignInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel;
        private System.Windows.Forms.Label IncorrectEmailLabel;
        private System.Windows.Forms.Label IncorrectReEnteredLabel;
        private System.Windows.Forms.Label NoCheckLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel2;
    }
}