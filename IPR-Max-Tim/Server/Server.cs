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
        public static List<ServerClient> Clients = new List<ServerClient>();
        public static SortedList<string, string> DoctorAccounts;
        public static int PatientCount = 0;
        public static int DoctorCount = 0;

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
            Clients.Add(serverClient);
            Thread clientThread = new Thread(() => serverClient.HandleClientThread());
            clientThread.Start();
            Listener.BeginAcceptTcpClient(new AsyncCallback(OnPersonConnect), null);
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
                DoctorAccounts = new SortedList<string, string>();

            if (!DoctorAccounts.ContainsKey(encryptedData))
                DoctorAccounts.Add(encryptedData, encryptedData);

            Patient testPatient = new Patient("test", 18, "male", 90);
            WritePatientToFile(testPatient);
            Patient p1 = new Patient("Tim", 18, "male", 95);
            p1.Vo2 = 3.3152922;
            WritePatientToFile(p1);
            Patient p2 = new Patient("Max", 19, "male", 95);
            p2.Vo2 = 3.5024143;
            WritePatientToFile(p2);

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
