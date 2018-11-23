using IPR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPR.GUI_s
{
    partial class PatientGUI : Form
    {
        private DoctorClient DoctorClient;
        private double power;
        private double speed;
        private bool courseStarted = false;

        public PatientGUI(DoctorClient DoctorClient)
        {
            this.DoctorClient = DoctorClient;
            InitializeComponent();
            this.RPMWChart.ChartAreas[0].AxisX.LabelStyle.Format = "";
            this.RPMWChart.Series[0].Name = "Power";
            this.RPMWChart.Series[1].Name = "Speed";
            //RPMWChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            RPMWChartTimer.Start();
        }

        public void BikeDataToGUI(string data)
        {
            Console.WriteLine(data);
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            powerLabel.Text = "Power: " + receivedData.power;
            this.power = receivedData.power;

            string rpm = receivedData.rpm;

            if (int.Parse(rpm) <= 50 && int.Parse(rpm) != 0)
                DoctorClient.ChangePower(1);
            else if (int.Parse(rpm) >= 60 && int.Parse(rpm) != 0)
                DoctorClient.ChangePower(-1);

            rpmLabel.Text = "RPM: " + rpm;

            string time = receivedData.time;
            string[] timeComponents = time.Split(':');

            int i = 0;
            if (timeComponents.Length == 3)
                i = 1;

            if (int.Parse(timeComponents[i]) < 2)
                time = time + " WARMING UP";
            else if (int.Parse(timeComponents[i]) < 6)
                time = time + " RUNNING TEST";
            else if (int.Parse(timeComponents[i]) < 7)
                time = time + " COOLING DOWN";
            else
                time = time + " TEST FINISHED";

            timeLabel.Text = "Time: " + time;
            distanceLabel.Text = "Distance: " + receivedData.distance;
            energyLabel.Text = "Energy: " + receivedData.energy;
            heartrateLabel.Text = "Heartrate: " + receivedData.heartrate;
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            courseStarted = true;
            DoctorClient.StartCourse();
        }

        int counter = 1;

        private void RPMWChartTimer_Tick(object sender, EventArgs e)
        {
            if (courseStarted == true)
            {
                RPMWChart.Series[0].Points.AddXY(counter, power);
                RPMWChart.Series[1].Points.AddXY(counter, speed);
                counter++;
            }
        }

        private void powerUp_Click(object sender, EventArgs e)
        {
            DoctorClient.ChangePower(1);
        }

        private void powerDown_Click(object sender, EventArgs e)
        {
            DoctorClient.ChangePower(-1);
        }
    }
}
