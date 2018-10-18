using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Remote_Healthcare.Client;
using Remote_Healthcare.Graphical_Interfaces;

namespace Remote_Healthcare
{
    partial class BicycleCustomControl : UserControl
    {
        public string bikeID { get; }
        DoctorClient doctorClient;
        public string patientnaam { get; }
        private bool chatButtonPressed = false;
        ChatForm chatform;

        public BicycleCustomControl(string patientNaam, string bikeID, DoctorClient doctorClient)
        {
            InitializeComponent();
            this.patientnaam = patientNaam;
            bttnEnd1.Enabled = false;

            circleSpeedBar.Value = 0;
            circleTimeBar.Value = 0;
            circlePowerBar.Value = 0;
            circleDistanceBar.Value = 0;

            this.bikeID = bikeID;
            lblusername1.Text = patientNaam;
            this.doctorClient = doctorClient;
        }
        
        public void ChangePower(int fullValue, int brokenValue)
        {
            circlePowerBar.SubscriptText = $".{brokenValue}";
            circlePowerBar.Text = $"{fullValue}";

            if (brokenValue > 50)
                fullValue++;

            circlePowerBar.Value = fullValue;

            circlePowerBar.Update();
        }

        public void ChangeSpeed(int fullValue, int brokenValue)
        {
            circleSpeedBar.SubscriptText = $".{brokenValue}";
            circleSpeedBar.Text = $"{fullValue}";

            if (brokenValue > 50)
                fullValue++;

            circleSpeedBar.Value = fullValue;

            circleSpeedBar.Update();
        }

        public void ChangeDistance(int fullValue, int brokenValue)
        {
            circleDistanceBar.SubscriptText = $".{brokenValue}";
            circleDistanceBar.Text = $"{fullValue}";

            if (brokenValue > 50)
                fullValue++;

            circleDistanceBar.Value = fullValue;

            circleDistanceBar.Update();
        }

        public void ChangeTime(int Minutes, int Seconds)
        {
            circleTimeBar.SubscriptText = $"{Seconds}";
            circleTimeBar.Text = $"{Minutes}";

            if (Seconds > 50)
                Minutes++;

            circleTimeBar.Value = Minutes;

            circleTimeBar.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StartCourseGUI(this).Show();
            this.Enabled = false;
        }

        public void startCourse(double power, double time, double distance)
        {
            int fullvalue = (int) distance;
            int brokenvalue = ((int) distance - fullvalue) * 100;
            ChangeDistance(fullvalue, brokenvalue);

            fullvalue = (int) power;
            brokenvalue = ((int) power - fullvalue) * 100;
            ChangePower(fullvalue, brokenvalue);

            fullvalue = (int) time;
            brokenvalue = ((int) time - fullvalue) * 100;
            ChangeTime(fullvalue, brokenvalue);

            doctorClient.StartCourse(bikeID, power, time, distance);
            

            bttnStart1.Enabled = false;
            bttnEnd1.Enabled = true;

            Refresh();
        }

        public void endCourse()
        {
            ChangeDistance(0, 0);
            ChangePower(0, 0);
            ChangeTime(0, 0);
            ChangeSpeed(0, 0);
            bttnStart1.Enabled = true;
            bttnEnd1.Enabled = false;

            doctorClient.EndCourse(bikeID);

            Refresh();
        }

        private void bttnEnd1_Click(object sender, EventArgs e)
        {
            new EndCourse(this).Show();
            this.Enabled = false;
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            if (chatButtonPressed)
            {
                chatform.BringToFront();
            }
            if (chatButtonPressed == false)
            {
                chatform = new ChatForm(bikeID, doctorClient);
                chatform.Show();
                chatButtonPressed = true;
            }
            
        }
    }
}
