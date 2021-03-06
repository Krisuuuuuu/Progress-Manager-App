﻿namespace Progress_Manager.UserControls
{
    partial class AddStretchingRoutineUserControl
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
            this.NoRoutineLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SessionListLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddSessionButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StepTwoLabel = new System.Windows.Forms.Label();
            this.StepOneLabel = new System.Windows.Forms.Label();
            this.AddRoutineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoRoutineLabel
            // 
            this.NoRoutineLabel.AutoSize = true;
            this.NoRoutineLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoRoutineLabel.ForeColor = System.Drawing.Color.Red;
            this.NoRoutineLabel.Location = new System.Drawing.Point(22, 304);
            this.NoRoutineLabel.Name = "NoRoutineLabel";
            this.NoRoutineLabel.Size = new System.Drawing.Size(290, 19);
            this.NoRoutineLabel.TabIndex = 41;
            this.NoRoutineLabel.Text = "Stretching routine has not been created.";
            this.NoRoutineLabel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(462, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 47);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(314, 430);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(142, 47);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SessionListLabel
            // 
            this.SessionListLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SessionListLabel.ForeColor = System.Drawing.Color.White;
            this.SessionListLabel.Location = new System.Drawing.Point(411, 68);
            this.SessionListLabel.Name = "SessionListLabel";
            this.SessionListLabel.Size = new System.Drawing.Size(275, 308);
            this.SessionListLabel.TabIndex = 38;
            this.SessionListLabel.Text = "Stretching routine cointains:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Black;
            this.RefreshButton.Location = new System.Drawing.Point(26, 266);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(200, 35);
            this.RefreshButton.TabIndex = 37;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddSessionButton
            // 
            this.AddSessionButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddSessionButton.ForeColor = System.Drawing.Color.Black;
            this.AddSessionButton.Location = new System.Drawing.Point(26, 180);
            this.AddSessionButton.Name = "AddSessionButton";
            this.AddSessionButton.Size = new System.Drawing.Size(200, 35);
            this.AddSessionButton.TabIndex = 36;
            this.AddSessionButton.Text = "Add";
            this.AddSessionButton.UseVisualStyleBackColor = true;
            this.AddSessionButton.Click += new System.EventHandler(this.AddSessionButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(26, 100);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(200, 35);
            this.CreateButton.TabIndex = 35;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Step 3. Refresh list of your stretching sessions.";
            // 
            // StepTwoLabel
            // 
            this.StepTwoLabel.AutoSize = true;
            this.StepTwoLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.StepTwoLabel.ForeColor = System.Drawing.Color.White;
            this.StepTwoLabel.Location = new System.Drawing.Point(22, 150);
            this.StepTwoLabel.Name = "StepTwoLabel";
            this.StepTwoLabel.Size = new System.Drawing.Size(319, 21);
            this.StepTwoLabel.TabIndex = 33;
            this.StepTwoLabel.Text = "Step 2. Add a new stretching session.";
            // 
            // StepOneLabel
            // 
            this.StepOneLabel.AutoSize = true;
            this.StepOneLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.StepOneLabel.ForeColor = System.Drawing.Color.White;
            this.StepOneLabel.Location = new System.Drawing.Point(22, 70);
            this.StepOneLabel.Name = "StepOneLabel";
            this.StepOneLabel.Size = new System.Drawing.Size(343, 21);
            this.StepOneLabel.TabIndex = 34;
            this.StepOneLabel.Text = "Step 1. Create a new stretching routine.";
            // 
            // AddRoutineLabel
            // 
            this.AddRoutineLabel.AutoSize = true;
            this.AddRoutineLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRoutineLabel.ForeColor = System.Drawing.Color.White;
            this.AddRoutineLabel.Location = new System.Drawing.Point(20, 20);
            this.AddRoutineLabel.Name = "AddRoutineLabel";
            this.AddRoutineLabel.Size = new System.Drawing.Size(377, 34);
            this.AddRoutineLabel.TabIndex = 31;
            this.AddRoutineLabel.Text = "Create Stretching Routine ";
            // 
            // AddStretchingRoutineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.NoRoutineLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SessionListLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddSessionButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StepTwoLabel);
            this.Controls.Add(this.StepOneLabel);
            this.Controls.Add(this.AddRoutineLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStretchingRoutineUserControl";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoRoutineLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SessionListLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AddSessionButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StepTwoLabel;
        private System.Windows.Forms.Label StepOneLabel;
        private System.Windows.Forms.Label AddRoutineLabel;
    }
}
