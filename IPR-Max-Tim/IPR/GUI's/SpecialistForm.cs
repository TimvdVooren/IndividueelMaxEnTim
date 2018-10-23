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
    partial class SpecialistForm : Form
    {
        private DoctorClient DoctorClient;

        public SpecialistForm(DoctorClient DoctorClient)
        {
            InitializeComponent();
            this.DoctorClient = DoctorClient;
        }

        public void SetBikeData(string data)
        {
            Invoke(new Action(() => BikeDataToGUI(data)));
        }

        private void BikeDataToGUI(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            powerLabel.Text = "Power: " + receivedData.data.power;

            string rpm = receivedData.data.rpm;

            if (int.Parse(rpm) <= 50 && int.Parse(rpm) != 0)
                DoctorClient.ChangePower(1);
            else if (int.Parse(rpm) >= 60 && int.Parse(rpm) != 0)
                DoctorClient.ChangePower(-1);

            rpmLabel.Text = "RPM: " + rpm;

            string time = receivedData.data.time;
            string[] timeComponents = time.Split(':');

            if (int.Parse(timeComponents[1]) < 10)
                time = timeComponents[0] + ":0" + timeComponents[1];
            if (int.Parse(timeComponents[0]) < 2)
                time = time + " WARMING UP";
            else if (int.Parse(timeComponents[0]) < 6)
                time = time + " RUNNING TEST";
            else if (int.Parse(timeComponents[0]) < 7)
                time = time + " COOLING DOWN";
            else
                time = time + " TEST FINISHED";

            timeLabel.Text = "Time: " + time;
            distanceLabel.Text = "Distance: " + receivedData.data.distance;
            energyLabel.Text = "Energy: " + receivedData.data.energy;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatient = new AddPatientForm(DoctorClient);
            addPatient.Show();
        }

        private void HistoricalDataButton_Click(object sender, EventArgs e)
        {
            new HistoricDataForm(DoctorClient).Show();
        }

        private void startTest_Click(object sender, EventArgs e)
        {
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
    }
}
