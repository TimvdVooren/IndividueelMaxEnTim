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
            this.rpm_trackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.heartrate_trackbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rpm_value = new System.Windows.Forms.Label();
            this.heartrate_value = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rpm_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartrate_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // rpm_trackbar
            // 
            this.rpm_trackbar.Location = new System.Drawing.Point(105, 28);
            this.rpm_trackbar.Maximum = 80;
            this.rpm_trackbar.Name = "rpm_trackbar";
            this.rpm_trackbar.Size = new System.Drawing.Size(405, 45);
            this.rpm_trackbar.TabIndex = 0;
            this.rpm_trackbar.Scroll += new System.EventHandler(this.rpm_trackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RPM:";
            // 
            // heartrate_trackbar
            // 
            this.heartrate_trackbar.Location = new System.Drawing.Point(105, 89);
            this.heartrate_trackbar.Maximum = 150;
            this.heartrate_trackbar.Name = "heartrate_trackbar";
            this.heartrate_trackbar.Size = new System.Drawing.Size(405, 45);
            this.heartrate_trackbar.TabIndex = 1;
            this.heartrate_trackbar.Scroll += new System.EventHandler(this.heartrate_trackbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heartrate:";
            // 
            // rpm_value
            // 
            this.rpm_value.AutoSize = true;
            this.rpm_value.Location = new System.Drawing.Point(527, 37);
            this.rpm_value.Name = "rpm_value";
            this.rpm_value.Size = new System.Drawing.Size(22, 13);
            this.rpm_value.TabIndex = 4;
            this.rpm_value.Text = "= 0";
            // 
            // heartrate_value
            // 
            this.heartrate_value.AutoSize = true;
            this.heartrate_value.Location = new System.Drawing.Point(527, 98);
            this.heartrate_value.Name = "heartrate_value";
            this.heartrate_value.Size = new System.Drawing.Size(22, 13);
            this.heartrate_value.TabIndex = 5;
            this.heartrate_value.Text = "= 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simulate patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimulatedBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heartrate_value);
            this.Controls.Add(this.rpm_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heartrate_trackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpm_trackbar);
            this.Name = "SimulatedBikeForm";
            this.Text = "SimulatedBikeForm";
            this.Load += new System.EventHandler(this.SimulatedBikeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpm_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartrate_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar rpm_trackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar heartrate_trackbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rpm_value;
        private System.Windows.Forms.Label heartrate_value;
        private System.Windows.Forms.Button button1;
    }
}