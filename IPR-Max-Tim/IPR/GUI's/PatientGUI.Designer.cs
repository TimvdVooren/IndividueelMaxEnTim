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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.heartrateLabel = new System.Windows.Forms.Label();
            this.powerDown = new System.Windows.Forms.Button();
            this.powerUp = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.RPMWChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startTest = new System.Windows.Forms.Button();
            this.RPMWChartTimer = new System.Windows.Forms.Timer(this.components);
            this.StateLabel = new System.Windows.Forms.Label();
            this.VO2label = new System.Windows.Forms.Label();
            this.heartratePerFifteen = new System.Windows.Forms.Label();
            this.rpmHintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RPMWChart)).BeginInit();
            this.SuspendLayout();
            // 
            // heartrateLabel
            // 
            this.heartrateLabel.AutoSize = true;
            this.heartrateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.heartrateLabel.Location = new System.Drawing.Point(22, 246);
            this.heartrateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heartrateLabel.Name = "heartrateLabel";
            this.heartrateLabel.Size = new System.Drawing.Size(78, 17);
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
            this.powerDown.Location = new System.Drawing.Point(429, 88);
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
            this.powerUp.Location = new System.Drawing.Point(210, 88);
            this.powerUp.Margin = new System.Windows.Forms.Padding(2);
            this.powerUp.Name = "powerUp";
            this.powerUp.Size = new System.Drawing.Size(111, 31);
            this.powerUp.TabIndex = 14;
            this.powerUp.Text = "Power up";
            this.powerUp.UseVisualStyleBackColor = false;
            this.powerUp.Click += new System.EventHandler(this.powerUp_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.timeLabel.Location = new System.Drawing.Point(22, 195);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(49, 17);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Time: ";
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.rpmLabel.Location = new System.Drawing.Point(22, 164);
            this.rpmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(47, 17);
            this.rpmLabel.TabIndex = 10;
            this.rpmLabel.Text = "Rpm: ";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.powerLabel.Location = new System.Drawing.Point(22, 132);
            this.powerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(57, 17);
            this.powerLabel.TabIndex = 9;
            this.powerLabel.Text = "Power: ";
            // 
            // RPMWChart
            // 
            this.RPMWChart.BackColor = System.Drawing.Color.Transparent;
            this.RPMWChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RPMWChart.BorderlineWidth = 10;
            this.RPMWChart.BorderSkin.BorderWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.RPMWChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RPMWChart.Legends.Add(legend1);
            this.RPMWChart.Location = new System.Drawing.Point(224, 144);
            this.RPMWChart.Name = "RPMWChart";
            this.RPMWChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "RPM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Heartbeat";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Power";
            this.RPMWChart.Series.Add(series1);
            this.RPMWChart.Series.Add(series2);
            this.RPMWChart.Series.Add(series3);
            this.RPMWChart.Size = new System.Drawing.Size(564, 294);
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
            this.startTest.Location = new System.Drawing.Point(280, 32);
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
            this.RPMWChartTimer.Interval = 1000;
            this.RPMWChartTimer.Tick += new System.EventHandler(this.RPMWChartTimer_Tick_1);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.StateLabel.Location = new System.Drawing.Point(22, 301);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(45, 17);
            this.StateLabel.TabIndex = 19;
            this.StateLabel.Text = "State:";
            // 
            // VO2label
            // 
            this.VO2label.AutoSize = true;
            this.VO2label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.VO2label.Location = new System.Drawing.Point(22, 328);
            this.VO2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VO2label.Name = "VO2label";
            this.VO2label.Size = new System.Drawing.Size(42, 17);
            this.VO2label.TabIndex = 20;
            this.VO2label.Text = "VO2:";
            // 
            // heartratePerFifteen
            // 
            this.heartratePerFifteen.AutoSize = true;
            this.heartratePerFifteen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.heartratePerFifteen.Location = new System.Drawing.Point(22, 273);
            this.heartratePerFifteen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heartratePerFifteen.Name = "heartratePerFifteen";
            this.heartratePerFifteen.Size = new System.Drawing.Size(134, 17);
            this.heartratePerFifteen.TabIndex = 21;
            this.heartratePerFifteen.Text = "Heartrate per 15 s: ";
            // 
            // rpmHintLabel
            // 
            this.rpmHintLabel.AutoSize = true;
            this.rpmHintLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.rpmHintLabel.Location = new System.Drawing.Point(24, 372);
            this.rpmHintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rpmHintLabel.Name = "rpmHintLabel";
            this.rpmHintLabel.Size = new System.Drawing.Size(177, 17);
            this.rpmHintLabel.TabIndex = 22;
            this.rpmHintLabel.Text = "Probeer sneller te fietsen!";
            // 
            // PatientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpmHintLabel);
            this.Controls.Add(this.heartratePerFifteen);
            this.Controls.Add(this.VO2label);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.startTest);
            this.Controls.Add(this.RPMWChart);
            this.Controls.Add(this.heartrateLabel);
            this.Controls.Add(this.powerDown);
            this.Controls.Add(this.powerUp);
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
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RPMWChart;
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.Timer RPMWChartTimer;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label VO2label;
        private System.Windows.Forms.Label heartratePerFifteen;
        private System.Windows.Forms.Label rpmHintLabel;
    }
}