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
        private static TcpListener listener;
        public static List<Patient> patients = new List<Patient>();
        public static SortedList<string, string> doctorAccounts;

        public Server()
        {
            Console.WriteLine("Started a server at port 6666");
            listener = new TcpListener(IPAddress.Any, 6666);
            listener.Start();

            listener.BeginAcceptTcpClient(new AsyncCallback(OnPersonConnect), null);

            CheckPatientDataFile();
            CheckDoctorDataFile();

            AddTestAccount();

            Console.ReadKey();
        }

        private static void OnPersonConnect(IAsyncResult ar)
        {
            TcpClient client = listener.EndAcceptTcpClient(ar);
            ServerClient serverClient = new ServerClient(client);
            serverClient.HandleClientThread();
            listener.BeginAcceptTcpClient(new AsyncCallback(OnPersonConnect), null);
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
            if (doctorAccounts == null)
            {
                doctorAccounts = new SortedList<string, string>();
            }
            if (!doctorAccounts.ContainsKey(Username))
            {
                doctorAccounts.Add(Username, Password);
            }

            string JsonAccounts = JsonConvert.SerializeObject(doctorAccounts);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "DoctorData.txt");
            File.WriteAllText(path, JsonAccounts);
        }

        private void AddTestAccount()
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes("test");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string encryptedData = System.Text.Encoding.ASCII.GetString(data);

            if (doctorAccounts == null)
            {
                doctorAccounts = new SortedList<string, string>();
            }
            if (!doctorAccounts.ContainsKey(encryptedData))
            {
                doctorAccounts.Add(encryptedData, encryptedData);
            }

            string JsonAccounts = JsonConvert.SerializeObject(doctorAccounts);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "DoctorData.txt");
            File.WriteAllText(path, JsonAccounts);
        }
        
        public static void WritePatientsToFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "PatientData.txt");
            string data = JsonConvert.SerializeObject(patients);
            File.WriteAllText(path, data);
        }

        private void CheckPatientDataFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "PatientData.txt");
            if (!File.Exists(path))
            {
                Console.WriteLine("Er is nog geen File gevonden waarin de al aangemaakte patienten data staat, dus deze wordt aangemaakt!");
                FileStream myFile = File.Create(path);
                myFile.Close();
                patients = new List<Patient>();
            }
            else if (File.Exists(path))
            {
                Console.WriteLine("Er is een bestand gevonden met bestaande patienten data");
                string patientData = File.ReadAllText(path);
                patients = JsonConvert.DeserializeObject<List<Patient>>(patientData);
                if (patients == null)
                {
                    patients = new List<Patient>();
                    patients.Add(new Patient(18, "male", 95));
                }
            }
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
                doctorAccounts = JsonConvert.DeserializeObject<SortedList<string, string>>(doctorData);
            }
        }
    }
}
