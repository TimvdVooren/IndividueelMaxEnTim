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
    partial class HistoricDataForm : Form
    {
        private DoctorClient DoctorClient;

        public HistoricDataForm(DoctorClient DoctorClient)
        {
            InitializeComponent();
            this.DoctorClient = DoctorClient;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string patientName = requestedPatientName.Text;
            Patient requestedPatient = DoctorClient.GetPatientData(patientName);
            if (requestedPatient != null)
                historicData.Text = "Historic data found from: " + requestedPatient.ToString();
            else
                historicData.Text = "No file could be located for this patient";
        }
    }
}
