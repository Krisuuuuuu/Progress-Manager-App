namespace Progress_Manager.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.CancelLogInButton = new System.Windows.Forms.Button();
            this.LogInRightPanel = new System.Windows.Forms.Panel();
            this.IncorrectPasswordLabel = new System.Windows.Forms.Label();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogInRightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(902, 167);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInLabel.Location = new System.Drawing.Point(6, 9);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(104, 34);
            this.LogInLabel.TabIndex = 1;
            this.LogInLabel.Text = "Log In ";
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserLoginLabel.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginLabel.Location = new System.Drawing.Point(11, 62);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(111, 23);
            this.UserLoginLabel.TabIndex = 5;
            this.UserLoginLabel.Text = "User Login:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.Location = new System.Drawing.Point(15, 97);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(351, 28);
            this.LoginTextBox.TabIndex = 6;
            this.LoginTextBox.Text = "Login";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassLabel.ForeColor = System.Drawing.Color.Gray;
            this.PassLabel.Location = new System.Drawing.Point(11, 146);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(108, 23);
            this.PassLabel.TabIndex = 7;
            this.PassLabel.Text = "Password:";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PassTextBox.Location = new System.Drawing.Point(15, 181);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(351, 28);
            this.PassTextBox.TabIndex = 8;
            this.PassTextBox.Text = "Password:";
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.Location = new System.Drawing.Point(15, 450);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(142, 47);
            this.LogInButton.TabIndex = 12;
            this.LogInButton.Text = "Log In!";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CancelLogInButton
            // 
            this.CancelLogInButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelLogInButton.Location = new System.Drawing.Point(163, 450);
            this.CancelLogInButton.Name = "CancelLogInButton";
            this.CancelLogInButton.Size = new System.Drawing.Size(142, 47);
            this.CancelLogInButton.TabIndex = 13;
            this.CancelLogInButton.Text = "Cancel";
            this.CancelLogInButton.UseVisualStyleBackColor = true;
            this.CancelLogInButton.Click += new System.EventHandler(this.CancelLogInButton_Click);
            // 
            // LogInRightPanel
            // 
            this.LogInRightPanel.Controls.Add(this.IncorrectPasswordLabel);
            this.LogInRightPanel.Controls.Add(this.IncorrectLoginLabel);
            this.LogInRightPanel.Controls.Add(this.CancelLogInButton);
            this.LogInRightPanel.Controls.Add(this.LogInButton);
            this.LogInRightPanel.Controls.Add(this.PassTextBox);
            this.LogInRightPanel.Controls.Add(this.PassLabel);
            this.LogInRightPanel.Controls.Add(this.LoginTextBox);
            this.LogInRightPanel.Controls.Add(this.UserLoginLabel);
            this.LogInRightPanel.Controls.Add(this.LogInLabel);
            this.LogInRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogInRightPanel.Location = new System.Drawing.Point(394, 0);
            this.LogInRightPanel.Name = "LogInRightPanel";
            this.LogInRightPanel.Size = new System.Drawing.Size(388, 553);
            this.LogInRightPanel.TabIndex = 2;
            // 
            // IncorrectPasswordLabel
            // 
            this.IncorrectPasswordLabel.AutoSize = true;
            this.IncorrectPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel.Location = new System.Drawing.Point(11, 212);
            this.IncorrectPasswordLabel.Name = "IncorrectPasswordLabel";
            this.IncorrectPasswordLabel.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel.TabIndex = 15;
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
            this.IncorrectLoginLabel.TabIndex = 14;
            this.IncorrectLoginLabel.Text = "Login, which you entered is incorrect.";
            this.IncorrectLoginLabel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 553);
            this.panel3.TabIndex = 4;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LogInRightPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogInRightPanel.ResumeLayout(false);
            this.LogInRightPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label UserLoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button CancelLogInButton;
        private System.Windows.Forms.Panel LogInRightPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel;
        private System.Windows.Forms.Panel panel3;
    }
}