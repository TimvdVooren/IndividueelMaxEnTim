using IPR.Client;
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

namespace IPR.GUI_s
{
    public partial class DoctorLoginForm : Form
    {
        private DoctorClient DoctorClient;

        public DoctorLoginForm()
        {
            InitializeComponent();
            Thread clientThread = new Thread(StartClient);
            clientThread.Start();
        }

        private void StartClient()
        {
            DoctorClient = new DoctorClient();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            {
                string Username = UsernameTextBox.Text;
                string Password = PasswordTextBox.Text;
                if (DoctorClient.GuiDataToServer("login", Username, Password))
                {
                    this.Visible = false;
                }
                else
                    MessageBox.Show("The username/password combination was\r\nincorrect, please try again");
            }
            else
                MessageBox.Show("Please fill in all required fields");
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            {
                string Username = UsernameTextBox.Text;
                string Password = PasswordTextBox.Text;
                if (DoctorClient.GuiDataToServer("create_account", Username, Password))
                    MessageBox.Show("Your account has succesfully been created");
                else
                    MessageBox.Show("There is already an account with this username,\r\nplease choose a different one");
            }
            else
                MessageBox.Show("Please fill in all required fields");
        }

        private void CancelLoginButton_Click(object sender, EventArgs e)
        {
            DoctorClient.Disconnect();
            this.Dispose();
        }
    }
}
