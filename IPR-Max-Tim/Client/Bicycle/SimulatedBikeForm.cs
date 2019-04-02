using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Bicycle
{
    public partial class SimulatedBikeForm : Form
    {
        private int rpm;
        private int power;
        private String time;
        private int minutes;
        private int seconds;
        private int distance;
        private int energy;
        private int heartrate;
        private Thread courseThread;

        public SimulatedBikeForm()
        {
            InitializeComponent();
            endCourseButton.Enabled = false;
        }

        public void Reset()
        {
            rpmTrackBar.Value = 0;
            startCourseButton.Enabled = true;
        }

        public void SetPower(int power)
        {
            this.power = power;
        }

        public void SetTime(int time)
        {
            minutes = time;
            seconds = 0;
            ConvertTime();
        }

        public void SetDistance(int distance)
        {
            this.distance = distance;
        }

        public String[] ReadBikeData()
        {
            String[] values = new String[7];
            values[0] = heartrate.ToString();
            values[1] = rpm.ToString();
            values[3] = distance.ToString();
            values[4] = power.ToString();
            values[5] = energy.ToString();
            values[6] = time;
            return values;
        }

        private void RunningCourse()
        {
            Boolean countingUp = true;
            while (true)
            {
                if(rpm == 65)
                {
                    countingUp = false;
                } else if(rpm == 55)
                {
                    countingUp = true;
                }
                if (countingUp)
                {
                    rpm++;
                } else
                {
                    rpm--;
                }

                seconds--;
                if(seconds == -1)
                {
                    seconds = 59;
                    minutes--;
                }

                if(minutes == -1)
                {
                    minutes = 0;
                    seconds = 0;
                }

                Invoke(new Action(() => CourseInvoke()));
                Thread.Sleep(1000);
            }
        }

        public void CourseInvoke()
        {
            ConvertTime();
            rpmTrackBar.Value = rpm;
            timeLabel.Text = "Time: " + time;
        }

        private void ConvertTime()
        {
            if(minutes > 9 && seconds > 9)
                time = minutes + ":" + seconds;
            else if(minutes > 9 && seconds < 9)
                time = minutes + ":0" + seconds;
            else if (minutes < 9 && seconds > 9)
                time = "0" + minutes + ":" + seconds;
            else if (minutes < 9 && seconds < 9)
                time = "0" + minutes + ":0" + seconds;
        }

        private void startCourseButton_Click(object sender, EventArgs e)
        {
            int maxRPM = rpmTrackBar.Maximum;
            rpmTrackBar.Value = maxRPM / 3;

            startCourseButton.Enabled = false;
            endCourseButton.Enabled = true;

            courseThread = new Thread(RunningCourse);
            courseThread.Start();
        }

        private void endCourseButton_Click(object sender, EventArgs e)
        {
            endCourseButton.Enabled = false;
            Reset();
            courseThread.Abort();
        }

        private void rpmTrackBar_Scroll(object sender, EventArgs e)
        {
            rpm = rpmTrackBar.Value;
        }

        private void heartRateTrackbar_Scroll(object sender, EventArgs e)
        {
            heartrate = heartRateTrackbar.Value;
        }

        private void SimulatedBikeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
