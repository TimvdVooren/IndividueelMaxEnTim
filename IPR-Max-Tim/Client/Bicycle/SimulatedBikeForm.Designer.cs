namespace Client.Bicycle
{
    partial class SimulatedBikeForm
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
            this.startCourseButton = new System.Windows.Forms.Button();
            this.endCourseButton = new System.Windows.Forms.Button();
            this.rpmTrackBar = new System.Windows.Forms.TrackBar();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.heartRateTrackbar = new System.Windows.Forms.TrackBar();
            this.heartRateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // startCourseButton
            // 
            this.startCourseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startCourseButton.Location = new System.Drawing.Point(106, 27);
            this.startCourseButton.Name = "startCourseButton";
            this.startCourseButton.Size = new System.Drawing.Size(75, 23);
            this.startCourseButton.TabIndex = 0;
            this.startCourseButton.Text = "Start Course";
            this.startCourseButton.UseVisualStyleBackColor = true;
            this.startCourseButton.Click += new System.EventHandler(this.startCourseButton_Click);
            // 
            // endCourseButton
            // 
            this.endCourseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.endCourseButton.Location = new System.Drawing.Point(245, 27);
            this.endCourseButton.Name = "endCourseButton";
            this.endCourseButton.Size = new System.Drawing.Size(75, 23);
            this.endCourseButton.TabIndex = 1;
            this.endCourseButton.Text = "End Course";
            this.endCourseButton.UseVisualStyleBackColor = true;
            this.endCourseButton.Click += new System.EventHandler(this.endCourseButton_Click);
            // 
            // rpmTrackBar
            // 
            this.rpmTrackBar.Location = new System.Drawing.Point(106, 78);
            this.rpmTrackBar.Name = "rpmTrackBar";
            this.rpmTrackBar.Size = new System.Drawing.Size(247, 45);
            this.rpmTrackBar.TabIndex = 2;
            this.rpmTrackBar.Scroll += new System.EventHandler(this.rpmTrackBar_Scroll);
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Location = new System.Drawing.Point(57, 88);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(34, 13);
            this.rpmLabel.TabIndex = 3;
            this.rpmLabel.Text = "RPM:";
            // 
            // heartRateTrackbar
            // 
            this.heartRateTrackbar.Location = new System.Drawing.Point(106, 145);
            this.heartRateTrackbar.Name = "heartRateTrackbar";
            this.heartRateTrackbar.Size = new System.Drawing.Size(247, 45);
            this.heartRateTrackbar.TabIndex = 4;
            this.heartRateTrackbar.Scroll += new System.EventHandler(this.heartRateTrackbar_Scroll);
            // 
            // heartRateLabel
            // 
            this.heartRateLabel.AutoSize = true;
            this.heartRateLabel.Location = new System.Drawing.Point(37, 145);
            this.heartRateLabel.Name = "heartRateLabel";
            this.heartRateLabel.Size = new System.Drawing.Size(54, 13);
            this.heartRateLabel.TabIndex = 5;
            this.heartRateLabel.Text = "Heartrate:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(183, 193);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(63, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time: 00:00";
            // 
            // SimulatedBikeForm
            // 
            this.AcceptButton = this.startCourseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.endCourseButton;
            this.ClientSize = new System.Drawing.Size(409, 224);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.heartRateLabel);
            this.Controls.Add(this.heartRateTrackbar);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.rpmTrackBar);
            this.Controls.Add(this.endCourseButton);
            this.Controls.Add(this.startCourseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SimulatedBikeForm";
            this.Text = "SimulatedBikeForm";
            ((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startCourseButton;
        private System.Windows.Forms.Button endCourseButton;
        private System.Windows.Forms.TrackBar rpmTrackBar;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.TrackBar heartRateTrackbar;
        private System.Windows.Forms.Label heartRateLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}