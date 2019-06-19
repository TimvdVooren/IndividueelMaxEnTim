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
        private Patient patient;
        public double Power;
        public int Rpm;
        private int Minutes;
        private int Seconds;
        private int steadySeconds = 0;
        public double Heartrate;
        public double HeartratePer15 = 0;
        private bool courseStarted = false;

        public PatientGUI(DoctorClient DoctorClient, Patient patient)
        {
            this.DoctorClient = DoctorClient;
            this.patient = patient;
            InitializeComponent();
            this.RPMWChart.ChartAreas[0].AxisX.LabelStyle.Format = "";
            this.RPMWChart.Series[0].Name = "RPM";
            this.RPMWChart.Series[1].Name = "Heartbeat";
            this.RPMWChart.Series[2].Name = "Power";
            RPMWChartTimer.Start();
            rpmHintLabel.Visible = false;
        }

        bool notSteady = false;
        public void BikeDataToGUI(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);

            Power = receivedData.power;
            Minutes = receivedData.minutes;
            Seconds = receivedData.seconds;
            Heartrate = receivedData.heartrate;
            Rpm = receivedData.rpm;

            
            Rpm = Rpm- 6;
            rpmLabel.Text = "RPM: " + Rpm;
            
            powerLabel.Text = "Power: " + Power + " Watt";
            if(Seconds > 9)
                timeLabel.Text = "Time: " + Minutes + ":" + Seconds;
            else
                timeLabel.Text = "Time: " + Minutes + ":0" + Seconds;
            heartrateLabel.Text = "Heartrate: " + Heartrate + " BPM";
            heartratePerFifteen.Text = "Heartrate per 15 s: " + HeartratePer15 + " BPM";
        }

        double totalheartrate = 0;
        private void StartAstrandTest()
        {

            if(counter % 15 == 0)
            {
                HeartratePer15 = Heartrate;
            }

            if(counter >= 0 && counter < 120)
            {
                StateLabel.Text = "Warming up";
            }

            if (counter >= 120 && counter < 360)
            {
                if (Rpm < 60)
                {
                    rpmHintLabel.Visible = true;
                }
                else
                {
                    rpmHintLabel.Visible = false;
                }
                if (Heartrate >= 130)
                {
                    StateLabel.Text = "Steady";
                    StateLabel.ForeColor = Color.Green;
                    steadySeconds++;
                    totalheartrate += Heartrate;
                }
                else
                {
                    StateLabel.Text = "Not Steady";
                    StateLabel.ForeColor = Color.Red;
                }
            }

            if (counter >= 360 && counter < 420)
            {
                if (steadySeconds < 120)
                {
                    notSteady = true;
                }
                StateLabel.ForeColor = Color.Black;
                StateLabel.Text = "Cooling down";
            }

            if(counter >= 420)
            {
                courseStarted = false;
                if (!notSteady)
                {
                    totalheartrate = totalheartrate / steadySeconds;
                    double VO2 = CalulateVO2(totalheartrate);
                    VO2label.Text = "VO2: " + VO2.ToString().Substring(0, 4) + " L/min";
                    patient.Vo2 = VO2;
                    DoctorClient.SavePatientData(patient.Name, VO2);
                }
                else
                {
                    VO2label.Text = "Geen steady state bereikt";
                }
            }

        }

        private double CalulateVO2(double totalHeartrate)
        {
            double VO2 = 0;
            
                if (patient.Gender == "male")
                {
                    VO2 = (0.00212 * (patient.Weight * 6.1182972778676) + 0.299) / (0.769 * totalHeartrate - 48.5) * 100;
                }
                else
                {
                    VO2 = (0.00193 * (patient.Weight * 6.1182972778676) + 0.326) / (0.769 * totalHeartrate - 56.1) * 100;
                }

            
            if (patient.Age >= 65) { VO2 = VO2 * 0.65; }
            else if (patient.Age >= 60) { VO2 = VO2 * 0.68; }
            else if (patient.Age >= 55) { VO2 = VO2 * 0.71; }
            else if (patient.Age >= 50) { VO2 = VO2 * 0.75; }
            else if (patient.Age >= 45) { VO2 = VO2 * 0.78; }
            else if (patient.Age >= 40) { VO2 = VO2 * 0.83; }
            else if (patient.Age >= 35) { VO2 = VO2 * 0.87; }
            else if (patient.Age >= 25) { VO2 = VO2 * 1; }
            else if(patient.Age >= 15) { VO2 = VO2 * 1.1; }

            if (VO2 < 0.0)
                VO2 = -1.0 * VO2;

            return VO2;
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            courseStarted = true;
            DoctorClient.StartCourse();
        }

        private void powerUp_Click(object sender, EventArgs e)
        {
            DoctorClient.ChangePower(1);
        }

        private void powerDown_Click(object sender, EventArgs e)
        {
            DoctorClient.ChangePower(-1);
        }

        private int counter = 1;

        private void RPMWChartTimer_Tick_1(object sender, EventArgs e)
        {
            if(courseStarted == true && Rpm > 0)
            {
                counter = Minutes * 60 + Seconds;
                RPMWChart.Series[0].Points.AddXY(counter, Rpm);
                RPMWChart.Series[1].Points.AddXY(counter, Heartrate);
                RPMWChart.Series[2].Points.AddXY(counter, Power);
                //counter++;
                StartAstrandTest();
            }

           
        }
    }
}

