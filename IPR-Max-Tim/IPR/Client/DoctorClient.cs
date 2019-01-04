using IPR.GUI_s;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPR.Client
{
    class DoctorClient
    {
        private static TcpClient client;
        public SpecialistForm DocGUI { get; set; }

        public DoctorClient(string serverIpAddress)
        {
            client = new TcpClient(serverIpAddress, 6666);

            string clientType = JsonConvert.SerializeObject(new
            {
                data = new
                {
                    type = "doctor",
                }
            });

            WriteTextMessage(clientType);
        }

        public bool GuiDataToServer(string command, string username, string password)
        {
            bool loginCorrect = false;

            Tuple<string, string> encryptedLogin = EncryptLoginData(username, password);
            username = encryptedLogin.Item1;
            password = encryptedLogin.Item2;

            string loginData = JsonConvert.SerializeObject(new
            {
                username = username,
                password = password,

            });

            WriteTextMessage(CreateJsonCommand(command, loginData));

            string responseFromServer = ReadTextMessage();
            if (responseFromServer == "AccountExists" && command == "login")
                loginCorrect = true;
            if (responseFromServer == "AccountCreated")
                loginCorrect = true;

            return loginCorrect;
        }

        public void StartCourse()
        {
            string data = JsonConvert.SerializeObject(new
            {
                patientID = "patient_0",
            });
            WriteTextMessage(CreateJsonCommand("course_start", data));
            Thread patientDataThread = new Thread(ReceivePatientData);
            patientDataThread.Start();
        }

        public void ChangePower(int increment)
        {
            //DIT IS HARDCODED PATIENTID
            string data = JsonConvert.SerializeObject(new
            {
                patientID = "patient_0",
                increment = increment,
            });
            WriteTextMessage(CreateJsonCommand("change_power", data));
        }

        private void ReceivePatientData()
        {
            while (true)
            {
                string receivedMessage = ReadTextMessage();
            }
        }

        public void AddPatient(Patient patient)
        {
            string data = JsonConvert.SerializeObject(patient);
            WriteTextMessage(CreateJsonCommand("add_patient", data));
        }
        
        public Patient GetPatientData(string patientName)
        {
            string data = JsonConvert.SerializeObject(new
            {
                patientName = patientName,
            });

            WriteTextMessage(CreateJsonCommand("patient_data", data));
            string patientData = ReadTextMessage();

            if (patientData != "PatientNotFound")
            {
                Patient patient = JsonConvert.DeserializeObject<Patient>(patientData);
                return patient;
            }
            else
                return null;
        }

        public void Disconnect()
        {
            WriteTextMessage(CreateJsonCommand("client_disconnect", ""));
            client.Close();
        }

        private void HandleBikeData(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            string bikeData = receivedData.data;
            DocGUI.SetBikeData(bikeData);
        }

        private string CreateJsonCommand(string command, string data)
        {
            string output = JsonConvert.SerializeObject(new
            {
                command = command,
                data = data,
            });
            return output;
        }

        private string ReadTextMessage()
        {
            StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            string readMessage = streamReader.ReadLine();

            if (readMessage.Contains("bike_data"))
                HandleBikeData(readMessage);
            
            return readMessage;
        }

        public void WriteTextMessage(string message)
        {
            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }

        private Tuple<string, string> EncryptLoginData(string username, string password)
        {
            byte[] usernameData = System.Text.Encoding.ASCII.GetBytes(username);
            usernameData = new System.Security.Cryptography.SHA256Managed().ComputeHash(usernameData);
            string encryptedUsername = System.Text.Encoding.ASCII.GetString(usernameData);

            byte[] passwordData = System.Text.Encoding.ASCII.GetBytes(password);
            passwordData = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordData);
            string encryptedPassword = System.Text.Encoding.ASCII.GetString(passwordData);

            return new Tuple<string, string>(encryptedUsername, encryptedPassword);
        }
    }
}
