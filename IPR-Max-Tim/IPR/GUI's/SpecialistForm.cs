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
        private double power;
        private double speed;
        private bool courseStarted = false;
        private List<PatientGUI> patientGUIs;

        public SpecialistForm(DoctorClient DoctorClient)
        {
            InitializeComponent();
            this.DoctorClient = DoctorClient;
            patientGUIs = new List<PatientGUI>();
        }

        public void SetBikeData(string data)
        {
            Invoke(new Action(() => patientGUIs[0].BikeDataToGUI(data)));
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatient = new AddPatientForm(this, DoctorClient);
            addPatient.Show();
        }

        public void AddPatientGUI(PatientGUI patientGUI)
        {
            patientGUIs.Add(patientGUI);
        }

        private void HistoricalDataButton_Click(object sender, EventArgs e)
        {
            new HistoricDataForm(DoctorClient).Show();
        }
    }
}
