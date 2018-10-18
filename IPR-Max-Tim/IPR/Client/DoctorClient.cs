using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IPR.Client
{
    class DoctorClient
    {
        private static TcpClient client;
        
        public DoctorClient()
        {
            client = new TcpClient(GetLocalIPAddress(), 6666);
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

            WriteTextMessage(createJsonCommand(command, loginData));

            string responseFromServer = ReadTextMessage();
            if (responseFromServer == "AccountExists" && command == "login")
                loginCorrect = true;
            if (responseFromServer == "AccountCreated")
                loginCorrect = true;

            return loginCorrect;
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
        
        public void GetPatientData(string patientName)
        {
            string data = JsonConvert.SerializeObject(new
            {
                patientName = patientName,
            });

            WriteTextMessage(createJsonCommand("patient_data", data));
            decodeJsonCommand(ReadTextMessage());
        }

        public void Disconnect()
        {
            WriteTextMessage(createJsonCommand("client_disconnect", ""));
            client.Close();
        }

        private string createJsonCommand(string command, string data)
        {
            string output = JsonConvert.SerializeObject(new
            {
                command = command,
                data = data,

            });
            return output;
        }

        private void decodeJsonCommand(string jsonString)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(jsonString);
            String command = receivedData.command;
            String data = receivedData.data;

            if (command == "patient_data")
            {
                Patient searchedPatient = JsonConvert.DeserializeObject<Patient>(data);
            }
        }

        private static string ReadTextMessage()
        {
            StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            return streamReader.ReadLine();
        }

        public static void WriteTextMessage(string message)
        {
            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
