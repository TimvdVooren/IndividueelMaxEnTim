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
        public double power;
        public String rpm;
        public  int leeftijd;
        public double heartrate;
        public string gender;

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
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            powerLabel.Text = "Power: " + receivedData.power;
            this.power = receivedData.power;

            this.rpm = receivedData.rpm;

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

        private void StartAstrandTest()
        {
            double totalheartrate = 0;

            if(counter >= 0 && counter >= 120)
            {
                StateLabel.Text = "Warming up";
            }
             if (counter <= 120 && counter >= 360)
             {
                if (heartrate <= 130)
                {
                    StateLabel.Text = "Steady";
                    StateLabel.ForeColor = Color.Green;

                    totalheartrate += heartrate;
                }
                else
                {
                    StateLabel.Text = "Not Steady";
                    StateLabel.ForeColor = Color.Red;
                }
             }
            if (counter >= 360 && counter <= 480)
            {
                if (StateLabel.Text == "Steady")
                {
                    totalheartrate = totalheartrate / 140;
                    CalulateVO2(totalheartrate);
                }
            }

        }

        private double CalulateVO2(double  totalHeartrate)
        {
            int age = leeftijd;
            double totalheartrate = totalHeartrate;
            double load = 0;
            double VO2 = 0;

                load = power;
                if (gender == "male")
                {
                    VO2 = (0.00212 * (load * 6.1182972778676) + 0.299) / (0.769 * totalheartrate - 48.5) * 100;
                }
                else
                {
                    VO2 = (0.00193 * (load * 6.1182972778676) + 0.326) / (0.769 * totalheartrate - 56.1) * 100;
                }

            if (leeftijd >= 15 && leeftijd < 25) { return VO2 * 1.1; }
            if (leeftijd >= 25 && leeftijd < 35) { return VO2 * 1; }
            if (leeftijd >= 35 && leeftijd < 40) { return VO2 * 0.87; }
            if (leeftijd >= 40 && leeftijd < 45) { return VO2 * 0.83; }
            if (leeftijd >= 45 && leeftijd < 50) { return VO2 * 0.78; }
            if (leeftijd >= 50 && leeftijd < 55) { return VO2 * 0.75; }
            if (leeftijd >= 55 && leeftijd < 60) { return VO2 * 0.71; }
            if (leeftijd >= 60 && leeftijd < 65) { return VO2 * 0.68; }
            if (leeftijd >= 65) { return VO2 * 0.65; }

            return VO2;
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
                RPMWChart.Series[1].Points.AddXY(counter, heartrate);
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

