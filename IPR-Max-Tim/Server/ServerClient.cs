using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerClient
    {
        private TcpClient Client;
        private string ClientID;
        private bool StartCourse;

        public ServerClient(TcpClient Client)
        {
            this.Client = Client;
            this.StartCourse = false;
        }

        public void HandleClientThread()
        {
            string clientSort = ReadTextMessage();
            dynamic receivedData = JsonConvert.DeserializeObject(clientSort);
            string type = receivedData.data.type;

            if (type == "patient")
            {
                ClientID = "patient_" + Server.PatientCount;
                Server.PatientCount++;
                Console.WriteLine("Patient has connected");
                HandlePatient();
            }
            else if (type == "doctor")
            {
                ClientID = "doctor_" + Server.DoctorCount;
                Server.DoctorCount++;
                Console.WriteLine("Doctor has connected");
                HandleDoctor();
            }
        }

        private void HandlePatient()
        {
            while (true)
            {
                if (StartCourse)
                {
                    SendDataRequest();
                }
            }
        }

        private void HandleDoctor()
        {
            while (true)
            {
                HandleData(ReadTextMessage());
            }
        }

        private void HandleData(string message)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(message);
            string command = receivedData.command;
            string data = receivedData.data;

            switch (command)
            {
                case "login": ReceivedLogin(data); break;
                case "create_account": ReceivedCreateAccount(data); break;
                case "course_start": ReceivedStartCourse(data); break;
                case "change_power": ReceivedChangePower(data); break;
                case "add_patient": ReceivedAddPatient(data); break;
                case "patient_data": ReceivedPatientData(data); break;
                case "client_disconnect": ReceivedClientDisconnect(); break;
            }
        }

        private void ReceivedLogin(string data)
        {
            dynamic loginData = JsonConvert.DeserializeObject(data);
            string username = loginData.username;
            string password = loginData.password;


            Console.WriteLine("gelezen username = {0}", username);

            if (IsLoginCorrect(username, password))
                WriteTextMessage(this.Client, "AccountExists");
            else
                WriteTextMessage(this.Client, "AccountDoesntExist");
        }

        private void ReceivedCreateAccount(string data)
        {
            dynamic accountData = JsonConvert.DeserializeObject(data);
            string username = accountData.username;
            string password = accountData.password;

            if (Server.DoctorAccounts.Keys.Contains(username))
                WriteTextMessage(this.Client, "AccountExists");
            else
            {
                Server.AddDoctorAccount(username, password);
                WriteTextMessage(this.Client, "AccountCreated");
            }
        }

        private void ReceivedStartCourse(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            string patientID = receivedData.patientID;

            ServerClient client = FindClientByID(patientID);
            if(client != null)
            {
                client.StartCourse = true;
                WriteTextMessage(client.Client, CreateJsonCommand("course_start", ""));
            }
        }
        private void ReceivedChangePower(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            string patientID = receivedData.patientID;

            ServerClient client = FindClientByID(patientID);
            if (client != null)
            {
                WriteTextMessage(client.Client, CreateJsonCommand("change_power", data));
            }
        }

        private void ReceivedAddPatient(string data)
        {
            Patient patient = JsonConvert.DeserializeObject<Patient>(data);
            Server.WritePatientToFile(patient);
        }

        private void ReceivedClientDisconnect()
        {
            Client.Close();
        }

        private void ReceivedPatientData(string data)
        {
            dynamic patientNameData = JsonConvert.DeserializeObject(data);
            string patientName = patientNameData.patientName;

            string patientData = Server.ReadPatientFromFile(patientName);
            WriteTextMessage(this.Client, patientData);
        }

        private void SendDataRequest()
        {
            string receivedData = ReadTextMessage();

            ServerClient client = FindClientByID("doctor_0");
            if (client != null)
                WriteTextMessage(client.Client, receivedData);
        }

        private bool IsLoginCorrect(String username, String password)
        {
            bool correctLogin = false;
            if (username != "" && password != "")
            {
                foreach (string userKey in Server.DoctorAccounts.Keys)
                {
                    if (userKey == username && Server.DoctorAccounts[userKey] == password)
                    {
                        correctLogin = true;
                    }
                }
            }
            return correctLogin;
        }

        private ServerClient FindClientByID(string RequestedClientID)
        {
            ServerClient requestedClient = null;
            foreach (ServerClient client in Server.Clients)
                if (client.ClientID == RequestedClientID)
                    requestedClient = client;
            return requestedClient;
        }

        private string GetAllDataFromUser(string user)
        {
            //Patient searchedPatient = null;
            //foreach (Patient patient in Patients)
            //{
            //    if (patient.name == user)
            //    {
            //        searchedPatient = patient;
            //    }
            //}
            //return JsonConvert.SerializeObject(searchedPatient);
            return "";
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

        private void WriteTextMessage(TcpClient client, string message)
        {
            try
            {
                StreamWriter stream = new StreamWriter(client.GetStream(), Encoding.UTF32);
                stream.WriteLine(message);
                stream.Flush();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Er is een fout opgetreden in de verbinding");
            }
        }

        private string ReadTextMessage()
        {
            string line = "";
            try
            {
                StreamReader stream = new StreamReader(Client.GetStream(), Encoding.UTF32);
                if (Client.Connected)
                    line = stream.ReadLine();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Er is een fout opgetreden in de verbinding");
            }
            catch (IOException e)
            {
                Console.WriteLine("Er is een fout opgetreden in de verbinding");
            }

            if (line == "" || line == null)
                Console.WriteLine(line);
            return line;
        }
    }
}
