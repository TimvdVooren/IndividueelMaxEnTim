using IPR.Client;
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
    partial class AddPatientForm : Form
    {
        private SpecialistForm specialistForm;
        private DoctorClient DoctorClient;

        public AddPatientForm(SpecialistForm specialistForm, DoctorClient DoctorClient)
        {
            InitializeComponent();
            this.specialistForm = specialistForm;
            this.DoctorClient = DoctorClient;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            string patientName = name.Text;
            int patientAge;
            int.TryParse(age.Text, out patientAge);
            string patientGender = gender.Text;
            int patientWeight;
            int.TryParse(weight.Text, out patientWeight);

            if (name.Text != string.Empty && age.Text != string.Empty && gender.Text != string.Empty && weight.Text != string.Empty && patientAge != 0 && patientWeight != 0)
            {
                Patient patient = new Patient(patientName, patientAge, patientGender, patientWeight);
                DoctorClient.AddPatient(patient);
                PatientGUI patientGUI = new PatientGUI(DoctorClient, patient);
                specialistForm.AddPatientGUI(patientGUI);
                patientGUI.Show();
                this.Dispose();
            }
            else
                MessageBox.Show("Please fill in all required fields with valid data");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
