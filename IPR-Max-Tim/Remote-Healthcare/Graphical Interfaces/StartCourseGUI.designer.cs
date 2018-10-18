﻿namespace Remote_Healthcare
{
    partial class StartCourseGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param bikeID="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startCoursePowerTextfield = new System.Windows.Forms.TextBox();
            this.startCourseTimeTextfield = new System.Windows.Forms.TextBox();
            this.startCourseDistanceTextfield = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VeldenNietJuistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(37, 18);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 34);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Startpower:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label3.Location = new System.Drawing.Point(44, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label4.Location = new System.Drawing.Point(44, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance:";
            // 
            // startCoursePowerTextfield
            // 
            this.startCoursePowerTextfield.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.startCoursePowerTextfield.Location = new System.Drawing.Point(168, 67);
            this.startCoursePowerTextfield.Margin = new System.Windows.Forms.Padding(4);
            this.startCoursePowerTextfield.Name = "startCoursePowerTextfield";
            this.startCoursePowerTextfield.Size = new System.Drawing.Size(67, 23);
            this.startCoursePowerTextfield.TabIndex = 0;
            // 
            // startCourseTimeTextfield
            // 
            this.startCourseTimeTextfield.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.startCourseTimeTextfield.Location = new System.Drawing.Point(168, 111);
            this.startCourseTimeTextfield.Margin = new System.Windows.Forms.Padding(4);
            this.startCourseTimeTextfield.Name = "startCourseTimeTextfield";
            this.startCourseTimeTextfield.Size = new System.Drawing.Size(67, 23);
            this.startCourseTimeTextfield.TabIndex = 1;
            // 
            // startCourseDistanceTextfield
            // 
            this.startCourseDistanceTextfield.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.startCourseDistanceTextfield.Location = new System.Drawing.Point(168, 154);
            this.startCourseDistanceTextfield.Margin = new System.Windows.Forms.Padding(4);
            this.startCourseDistanceTextfield.Name = "startCourseDistanceTextfield";
            this.startCourseDistanceTextfield.Size = new System.Drawing.Size(67, 23);
            this.startCourseDistanceTextfield.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.DarkGray;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.confirmButton.Location = new System.Drawing.Point(42, 207);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 28);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.cancelButton.Location = new System.Drawing.Point(218, 207);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label5.Location = new System.Drawing.Point(251, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label6.Location = new System.Drawing.Point(251, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label7.Location = new System.Drawing.Point(251, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Km";
            // 
            // VeldenNietJuistLabel
            // 
            this.VeldenNietJuistLabel.AutoSize = true;
            this.VeldenNietJuistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeldenNietJuistLabel.Location = new System.Drawing.Point(15, 218);
            this.VeldenNietJuistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VeldenNietJuistLabel.Name = "VeldenNietJuistLabel";
            this.VeldenNietJuistLabel.Size = new System.Drawing.Size(0, 17);
            this.VeldenNietJuistLabel.TabIndex = 13;
            // 
            // StartCourseGUI
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(365, 287);
            this.ControlBox = false;
            this.Controls.Add(this.VeldenNietJuistLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.startCourseDistanceTextfield);
            this.Controls.Add(this.startCourseTimeTextfield);
            this.Controls.Add(this.startCoursePowerTextfield);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartCourseGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startCoursePowerTextfield;
        private System.Windows.Forms.TextBox startCourseTimeTextfield;
        private System.Windows.Forms.TextBox startCourseDistanceTextfield;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label VeldenNietJuistLabel;
    }
}