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
    partial class SpecialistForm : Form
    {
        private DoctorClient DoctorClient;

        public SpecialistForm(DoctorClient DoctorClient)
        {
            InitializeComponent();
            this.DoctorClient = DoctorClient;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatient = new AddPatientForm(DoctorClient);
            addPatient.Show();
        }

        private void HistoricalDataButton_Click(object sender, EventArgs e)
        {
            //GUI VOOR INPUT PATIENTNAME
        }
    }
}
