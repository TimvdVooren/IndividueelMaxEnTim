﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Client.Bicycle
{
    public partial class SimulatedBikeForm : Form
    {
        public int heartrate { get; set; } = 70;
        public int rpm { get; set; } = 50;
        public int power { get; set; } 
        private System.Timers.Timer simulatorTimer;
        private bool runningSim = false;

        public SimulatedBikeForm()
        {
            InitializeComponent();
            rpm_trackbar.Value = rpm;
            rpm_value.Text = "= " + rpm;
            heartrate_trackbar.Value = heartrate;
            heartrate_value.Text = "= " + heartrate;

            simulatorTimer = new System.Timers.Timer(1000);
            simulatorTimer.AutoReset = true;
            simulatorTimer.Elapsed += Timer_Elapsed;
        }

        private void SimulatedBikeForm_Load(object sender, EventArgs e)
        {

        }

        private void rpm_trackbar_Scroll(object sender, EventArgs e)
        {
            rpm = rpm_trackbar.Value;
            rpm_value.Text = "= " + rpm;
        }

        private void heartrate_trackbar_Scroll(object sender, EventArgs e)
        {
            heartrate = heartrate_trackbar.Value;
            heartrate_value.Text = "= " + heartrate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!runningSim)
                simulatorTimer.Start();
            else
                simulatorTimer.Stop();
            runningSim = !runningSim;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random random = new Random();
            int increment = random.Next(-1, 1);
            rpm = rpm + increment;

            //rpm_trackbar.Value = rpm;
            //rpm_value.Text = "= " + rpm;
            //heartrate_trackbar.Value = heartrate;
            //heartrate_value.Text = "= " + heartrate;
        }
    }
}
