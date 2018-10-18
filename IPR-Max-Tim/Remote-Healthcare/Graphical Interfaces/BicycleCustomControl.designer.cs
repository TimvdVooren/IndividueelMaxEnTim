﻿namespace Remote_Healthcare
{
    partial class BicycleCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chatbutton = new System.Windows.Forms.Button();
            this.bttnStart1 = new System.Windows.Forms.Button();
            this.bttnEnd1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistance1 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPower1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblusername1 = new System.Windows.Forms.Label();
            this.circlePowerBar = new Remote_Healthcare.CircularProgressBar();
            this.circleSpeedBar = new Remote_Healthcare.CircularProgressBar();
            this.circleDistanceBar = new Remote_Healthcare.CircularProgressBar();
            this.circleTimeBar = new Remote_Healthcare.CircularProgressBar();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.Chatbutton);
            this.panel1.Controls.Add(this.bttnStart1);
            this.panel1.Controls.Add(this.bttnEnd1);
            this.panel1.Controls.Add(this.circlePowerBar);
            this.panel1.Controls.Add(this.circleSpeedBar);
            this.panel1.Controls.Add(this.circleDistanceBar);
            this.panel1.Controls.Add(this.circleTimeBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDistance1);
            this.panel1.Controls.Add(this.lblTime1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPower1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 633);
            this.panel1.TabIndex = 0;
            // 
            // Chatbutton
            // 
            this.Chatbutton.BackColor = System.Drawing.Color.DarkGray;
            this.Chatbutton.FlatAppearance.BorderSize = 0;
            this.Chatbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chatbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chatbutton.Location = new System.Drawing.Point(0, 567);
            this.Chatbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chatbutton.Name = "Chatbutton";
            this.Chatbutton.Size = new System.Drawing.Size(384, 35);
            this.Chatbutton.TabIndex = 2;
            this.Chatbutton.Text = "Chat";
            this.Chatbutton.UseVisualStyleBackColor = false;
            this.Chatbutton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // bttnStart1
            // 
            this.bttnStart1.BackColor = System.Drawing.Color.DarkGray;
            this.bttnStart1.FlatAppearance.BorderSize = 0;
            this.bttnStart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStart1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart1.Location = new System.Drawing.Point(0, 51);
            this.bttnStart1.Name = "bttnStart1";
            this.bttnStart1.Size = new System.Drawing.Size(384, 35);
            this.bttnStart1.TabIndex = 0;
            this.bttnStart1.Text = "Start Course";
            this.bttnStart1.UseVisualStyleBackColor = false;
            this.bttnStart1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnEnd1
            // 
            this.bttnEnd1.BackColor = System.Drawing.Color.Firebrick;
            this.bttnEnd1.FlatAppearance.BorderSize = 0;
            this.bttnEnd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnd1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEnd1.Location = new System.Drawing.Point(0, 93);
            this.bttnEnd1.Name = "bttnEnd1";
            this.bttnEnd1.Size = new System.Drawing.Size(384, 35);
            this.bttnEnd1.TabIndex = 1;
            this.bttnEnd1.Text = "End Course";
            this.bttnEnd1.UseVisualStyleBackColor = false;
            this.bttnEnd1.Click += new System.EventHandler(this.bttnEnd1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speed";
            // 
            // lblDistance1
            // 
            this.lblDistance1.AutoSize = true;
            this.lblDistance1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance1.Location = new System.Drawing.Point(63, 357);
            this.lblDistance1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance1.Name = "lblDistance1";
            this.lblDistance1.Size = new System.Drawing.Size(69, 19);
            this.lblDistance1.TabIndex = 7;
            this.lblDistance1.Text = "Distance";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(267, 146);
            this.lblTime1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(39, 19);
            this.lblTime1.TabIndex = 6;
            this.lblTime1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Power";
            // 
            // lblPower1
            // 
            this.lblPower1.AutoSize = true;
            this.lblPower1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower1.Location = new System.Drawing.Point(79, 178);
            this.lblPower1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPower1.Name = "lblPower1";
            this.lblPower1.Size = new System.Drawing.Size(51, 19);
            this.lblPower1.TabIndex = 5;
            this.lblPower1.Text = "Power";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.lblusername1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 51);
            this.panel4.TabIndex = 0;
            // 
            // lblusername1
            // 
            this.lblusername1.AutoSize = true;
            this.lblusername1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername1.Location = new System.Drawing.Point(167, 17);
            this.lblusername1.Name = "lblusername1";
            this.lblusername1.Size = new System.Drawing.Size(44, 19);
            this.lblusername1.TabIndex = 0;
            this.lblusername1.Text = "User1";
            // 
            // circlePowerBar
            // 
            this.circlePowerBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circlePowerBar.AnimationSpeed = 500;
            this.circlePowerBar.BackColor = System.Drawing.Color.Transparent;
            this.circlePowerBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circlePowerBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circlePowerBar.InnerColor = System.Drawing.SystemColors.WindowFrame;
            this.circlePowerBar.InnerMargin = 2;
            this.circlePowerBar.InnerWidth = -1;
            this.circlePowerBar.Location = new System.Drawing.Point(13, 168);
            this.circlePowerBar.MarqueeAnimationSpeed = 2000;
            this.circlePowerBar.Name = "circlePowerBar";
            this.circlePowerBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circlePowerBar.OuterMargin = -25;
            this.circlePowerBar.OuterWidth = 25;
            this.circlePowerBar.ProgressColor = System.Drawing.Color.Blue;
            this.circlePowerBar.ProgressWidth = 20;
            this.circlePowerBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlePowerBar.Size = new System.Drawing.Size(175, 175);
            this.circlePowerBar.StartAngle = 270;
            this.circlePowerBar.SubscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circlePowerBar.SubscriptMargin = new System.Windows.Forms.Padding(5, -25, 0, 0);
            this.circlePowerBar.SubscriptText = "";
            this.circlePowerBar.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circlePowerBar.SuperscriptMargin = new System.Windows.Forms.Padding(20, 35, 0, -25);
            this.circlePowerBar.SuperscriptText = "Kw/h";
            this.circlePowerBar.TabIndex = 13;
            this.circlePowerBar.Text = "0";
            this.circlePowerBar.TextMargin = new System.Windows.Forms.Padding(-2, 8, 0, 0);
            this.circlePowerBar.Value = 68;
            // 
            // circleSpeedBar
            // 
            this.circleSpeedBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleSpeedBar.AnimationSpeed = 500;
            this.circleSpeedBar.BackColor = System.Drawing.Color.Transparent;
            this.circleSpeedBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circleSpeedBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleSpeedBar.InnerColor = System.Drawing.SystemColors.WindowFrame;
            this.circleSpeedBar.InnerMargin = 2;
            this.circleSpeedBar.InnerWidth = -1;
            this.circleSpeedBar.Location = new System.Drawing.Point(194, 379);
            this.circleSpeedBar.MarqueeAnimationSpeed = 2000;
            this.circleSpeedBar.Name = "circleSpeedBar";
            this.circleSpeedBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circleSpeedBar.OuterMargin = -25;
            this.circleSpeedBar.OuterWidth = 26;
            this.circleSpeedBar.ProgressColor = System.Drawing.Color.Red;
            this.circleSpeedBar.ProgressWidth = 20;
            this.circleSpeedBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circleSpeedBar.Size = new System.Drawing.Size(175, 175);
            this.circleSpeedBar.StartAngle = 270;
            this.circleSpeedBar.SubscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleSpeedBar.SubscriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circleSpeedBar.SubscriptText = ".0";
            this.circleSpeedBar.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleSpeedBar.SuperscriptMargin = new System.Windows.Forms.Padding(20, 35, 0, -20);
            this.circleSpeedBar.SuperscriptText = "Km/h";
            this.circleSpeedBar.TabIndex = 12;
            this.circleSpeedBar.Text = "0";
            this.circleSpeedBar.TextMargin = new System.Windows.Forms.Padding(-2, 8, 0, 0);
            this.circleSpeedBar.Value = 68;
            // 
            // circleDistanceBar
            // 
            this.circleDistanceBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleDistanceBar.AnimationSpeed = 500;
            this.circleDistanceBar.BackColor = System.Drawing.Color.Transparent;
            this.circleDistanceBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circleDistanceBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleDistanceBar.InnerColor = System.Drawing.SystemColors.WindowFrame;
            this.circleDistanceBar.InnerMargin = 2;
            this.circleDistanceBar.InnerWidth = -1;
            this.circleDistanceBar.Location = new System.Drawing.Point(13, 379);
            this.circleDistanceBar.MarqueeAnimationSpeed = 2000;
            this.circleDistanceBar.Name = "circleDistanceBar";
            this.circleDistanceBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.circleDistanceBar.OuterMargin = -25;
            this.circleDistanceBar.OuterWidth = 26;
            this.circleDistanceBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circleDistanceBar.ProgressWidth = 20;
            this.circleDistanceBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circleDistanceBar.Size = new System.Drawing.Size(175, 175);
            this.circleDistanceBar.StartAngle = 270;
            this.circleDistanceBar.SubscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleDistanceBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -25, 0, 0);
            this.circleDistanceBar.SubscriptText = ".0";
            this.circleDistanceBar.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleDistanceBar.SuperscriptMargin = new System.Windows.Forms.Padding(20, 35, 0, -25);
            this.circleDistanceBar.SuperscriptText = "Km";
            this.circleDistanceBar.TabIndex = 11;
            this.circleDistanceBar.Text = "0";
            this.circleDistanceBar.TextMargin = new System.Windows.Forms.Padding(-2, 8, 0, 0);
            this.circleDistanceBar.Value = 68;
            // 
            // circleTimeBar
            // 
            this.circleTimeBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleTimeBar.AnimationSpeed = 500;
            this.circleTimeBar.BackColor = System.Drawing.Color.Transparent;
            this.circleTimeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circleTimeBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleTimeBar.InnerColor = System.Drawing.SystemColors.WindowFrame;
            this.circleTimeBar.InnerMargin = 2;
            this.circleTimeBar.InnerWidth = -1;
            this.circleTimeBar.Location = new System.Drawing.Point(194, 168);
            this.circleTimeBar.MarqueeAnimationSpeed = 2000;
            this.circleTimeBar.Name = "circleTimeBar";
            this.circleTimeBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circleTimeBar.OuterMargin = -25;
            this.circleTimeBar.OuterWidth = 26;
            this.circleTimeBar.ProgressColor = System.Drawing.Color.Lime;
            this.circleTimeBar.ProgressWidth = 20;
            this.circleTimeBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circleTimeBar.Size = new System.Drawing.Size(175, 175);
            this.circleTimeBar.StartAngle = 270;
            this.circleTimeBar.SubscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleTimeBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -25, 0, 0);
            this.circleTimeBar.SubscriptText = ".0";
            this.circleTimeBar.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circleTimeBar.SuperscriptMargin = new System.Windows.Forms.Padding(20, 35, 0, -25);
            this.circleTimeBar.SuperscriptText = "Min";
            this.circleTimeBar.TabIndex = 10;
            this.circleTimeBar.Text = "0";
            this.circleTimeBar.TextMargin = new System.Windows.Forms.Padding(-2, 8, 0, 0);
            this.circleTimeBar.Value = 68;
            // 
            // BicycleCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BicycleCustomControl";
            this.Size = new System.Drawing.Size(384, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblusername1;
        private System.Windows.Forms.Button bttnEnd1;
        private System.Windows.Forms.Button bttnStart1;
        private CircularProgressBar cirpSpeed1;
        private CircularProgressBar cirpDistance1;
        private CircularProgressBar cirpTime1;
        private CircularProgressBar cirpPower1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblPower1;
        private System.Windows.Forms.Label lblDistance1;
        private CircularProgressBar cirpSpeed2;
        private CircularProgressBar cripDistance2;
        private CircularProgressBar cirpTime2;
        private CircularProgressBar cirpPower2;
        private CircularProgressBar cirpSpeed3;
        private CircularProgressBar cirpDistance3;
        private CircularProgressBar cirpTime3;
        private CircularProgressBar cirpPower3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar circlePowerBar;
        private CircularProgressBar circleDistanceBar;
        private CircularProgressBar circleTimeBar;
        private CircularProgressBar circleSpeedBar;
        private System.Windows.Forms.Button Chatbutton;
    }
}
