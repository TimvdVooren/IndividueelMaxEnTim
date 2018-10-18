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

namespace Server
{
    class Server
    {
        private static TcpListener Listener;
        public static SortedList<string, string> DoctorAccounts;

        public Server()
        {
            Console.WriteLine("Started a server at port 6666");
            Listener = new TcpListener(IPAddress.Any, 6666);
            Listener.Start();

            Listener.BeginAcceptTcpClient(new AsyncCallback(OnPersonConnect), null);
            
            CheckDoctorDataFile();

            AddTestAccount();

            Console.ReadKey();
        }

        private static void OnPersonConnect(IAsyncResult ar)
        {
            TcpClient client = Listener.EndAcceptTcpClient(ar);
            ServerClient serverClient = new ServerClient(client);
            serverClient.HandleClientThread();
            Listener.BeginAcceptTcpClient(new AsyncCallback(OnPersonConnect), null);
        }

        private void PatientLogin(string receivedData)
        {
            string username = JsonConvert.DeserializeObject<string>(receivedData);
            string patientName = username;

            string fileName = patientName + ".txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), fileName);

            if (!File.Exists(path))
            {
                Console.WriteLine("Er is nog geen dataBestand voor de patient, deze wordt aangemaakt");
                FileStream myFile = File.Create(path);
                myFile.Close();
            }
            else if (File.Exists(path))
            {
                Console.WriteLine("Er is al een dataBestand voor deze patient");
            }
        }

        public static void AddDoctorAccount(string Username, string Password)
        {
            if (DoctorAccounts == null)
            {
                DoctorAccounts = new SortedList<string, string>();
            }
            if (!DoctorAccounts.ContainsKey(Username))
            {
                DoctorAccounts.Add(Username, Password);
            }

            string JsonAccounts = JsonConvert.SerializeObject(DoctorAccounts);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "DoctorData.txt");
            File.WriteAllText(path, JsonAccounts);
        }

        private void AddTestAccount()
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes("test");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string encryptedData = System.Text.Encoding.ASCII.GetString(data);

            if (DoctorAccounts == null)
            {
                DoctorAccounts = new SortedList<string, string>();
            }
            if (!DoctorAccounts.ContainsKey(encryptedData))
            {
                DoctorAccounts.Add(encryptedData, encryptedData);
            }

            string JsonAccounts = JsonConvert.SerializeObject(DoctorAccounts);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "DoctorData.txt");
            File.WriteAllText(path, JsonAccounts);
        }
        
        public static void WritePatientToFile(Patient patient)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), patient.Name + ".txt");
            string data = JsonConvert.SerializeObject(patient);
            File.WriteAllText(path, data);
        }

        public static string ReadPatientFromFile(string patientName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), patientName + ".txt");
            if (File.Exists(path))
                return File.ReadAllText(path);
            else
                return "PatientNotFound";
        }

        private void CheckDoctorDataFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "DoctorData.txt");
            if (!File.Exists(path))
            {
                Console.WriteLine("Er is nog geen File gevonden waarin de al aangemaakte doctorAccounts staan, dus deze wordt aangemaakt!");
                FileStream myFile = File.Create(path);
                myFile.Close();
            }
            else if (File.Exists(path))
            {
                Console.WriteLine("Er is een bestand gevonden met bestaande doctorAccounts");
                string doctorData = File.ReadAllText(path);
                DoctorAccounts = JsonConvert.DeserializeObject<SortedList<string, string>>(doctorData);
            }
        }
    }
}
