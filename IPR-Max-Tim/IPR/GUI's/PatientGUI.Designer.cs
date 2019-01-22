namespace IPR.GUI_s
{
    partial class PatientGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.heartrateLabel = new System.Windows.Forms.Label();
            this.powerDown = new System.Windows.Forms.Button();
            this.powerUp = new System.Windows.Forms.Button();
            this.energyLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.RPMWChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startTest = new System.Windows.Forms.Button();
            this.RPMWChartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RPMWChart)).BeginInit();
            this.SuspendLayout();
            // 
            // heartrateLabel
            // 
            this.heartrateLabel.AutoSize = true;
            this.heartrateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.heartrateLabel.Location = new System.Drawing.Point(22, 293);
            this.heartrateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heartrateLabel.Name = "heartrateLabel";
            this.heartrateLabel.Size = new System.Drawing.Size(83, 19);
            this.heartrateLabel.TabIndex = 16;
            this.heartrateLabel.Text = "Heartrate: ";
            // 
            // powerDown
            // 
            this.powerDown.BackColor = System.Drawing.Color.Silver;
            this.powerDown.FlatAppearance.BorderSize = 0;
            this.powerDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerDown.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.powerDown.Location = new System.Drawing.Point(534, 143);
            this.powerDown.Margin = new System.Windows.Forms.Padding(2);
            this.powerDown.Name = "powerDown";
            this.powerDown.Size = new System.Drawing.Size(111, 31);
            this.powerDown.TabIndex = 15;
            this.powerDown.Text = "Power down";
            this.powerDown.UseVisualStyleBackColor = false;
            this.powerDown.Click += new System.EventHandler(this.powerDown_Click);
            // 
            // powerUp
            // 
            this.powerUp.BackColor = System.Drawing.Color.Silver;
            this.powerUp.FlatAppearance.BorderSize = 0;
            this.powerUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerUp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.powerUp.Location = new System.Drawing.Point(389, 143);
            this.powerUp.Margin = new System.Windows.Forms.Padding(2);
            this.powerUp.Name = "powerUp";
            this.powerUp.Size = new System.Drawing.Size(111, 31);
            this.powerUp.TabIndex = 14;
            this.powerUp.Text = "Power up";
            this.powerUp.UseVisualStyleBackColor = false;
            this.powerUp.Click += new System.EventHandler(this.powerUp_Click);
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.energyLabel.Location = new System.Drawing.Point(22, 261);
            this.energyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(64, 19);
            this.energyLabel.TabIndex = 13;
            this.energyLabel.Text = "Energy: ";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.distanceLabel.Location = new System.Drawing.Point(22, 232);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(77, 19);
            this.distanceLabel.TabIndex = 12;
            this.distanceLabel.Text = "Distance: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.timeLabel.Location = new System.Drawing.Point(22, 195);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 19);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Time: ";
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.rpmLabel.Location = new System.Drawing.Point(22, 164);
            this.rpmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(49, 19);
            this.rpmLabel.TabIndex = 10;
            this.rpmLabel.Text = "Rpm: ";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.powerLabel.Location = new System.Drawing.Point(22, 132);
            this.powerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(59, 19);
            this.powerLabel.TabIndex = 9;
            this.powerLabel.Text = "Power: ";
            // 
            // RPMWChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RPMWChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RPMWChart.Legends.Add(legend1);
            this.RPMWChart.Location = new System.Drawing.Point(311, 232);
            this.RPMWChart.Name = "RPMWChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.RPMWChart.Series.Add(series1);
            this.RPMWChart.Series.Add(series2);
            this.RPMWChart.Size = new System.Drawing.Size(467, 206);
            this.RPMWChart.TabIndex = 17;
            this.RPMWChart.Text = "chart1";
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.Silver;
            this.startTest.FlatAppearance.BorderSize = 0;
            this.startTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTest.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startTest.Location = new System.Drawing.Point(296, 43);
            this.startTest.Margin = new System.Windows.Forms.Padding(2);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(204, 31);
            this.startTest.TabIndex = 18;
            this.startTest.Text = "Start Test";
            this.startTest.UseVisualStyleBackColor = false;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // RPMWChartTimer
            // 
            this.RPMWChartTimer.Interval = 500;
            // 
            // PatientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTest);
            this.Controls.Add(this.RPMWChart);
            this.Controls.Add(this.heartrateLabel);
            this.Controls.Add(this.powerDown);
            this.Controls.Add(this.powerUp);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.powerLabel);
            this.Name = "PatientGUI";
            this.Text = "PatientGUI";
            ((System.ComponentModel.ISupportInitialize)(this.RPMWChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heartrateLabel;
        private System.Windows.Forms.Button powerDown;
        private System.Windows.Forms.Button powerUp;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RPMWChart;
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.Timer RPMWChartTimer;
    }
}