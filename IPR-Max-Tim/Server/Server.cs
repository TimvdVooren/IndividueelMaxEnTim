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
    class Server : IDataListener
    {
        private List<ServerClient> Clients = new List<ServerClient>();
        private List<Patient> patients = new List<Patient>();
        private SortedList<string, string> doctorAccounts;
        private List<Connection> connectionList = new List<Connection>(); 
        private int BikeCount = 1;

        public Server()
        {
            Console.WriteLine("Started a server at port 6666");
            TcpListener listener = new TcpListener(IPAddress.Any, 6666);
            listener.Start();

            CheckPatientDataFile();
            CheckDoctorDataFile();

            AddTestAccount();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Connection connection = new Connection(client, this , BikeCount);
                connectionList.Add(connection);
                BikeCount++;
            }
        }

        public Connection FindConnection(int bikeID)
        {
            
            foreach (Connection connection in connectionList)
            {
                if (connection.bikeID == bikeID)
                {
                    return connection;
                }
            }
            return null;
        }

        public void HandleClientThread(object obj)
        {
            TcpClient client = obj as TcpClient;

            string clientSort = ReadTextMessage(client);
            dynamic receivedData = JsonConvert.DeserializeObject(clientSort);

            if (receivedData.sort == "patient")
            {
                HandlePatient(client);
            }
            else if (receivedData.sort == "doctor")
            {
                HandleDoctor(client);
            }
            Console.WriteLine("Client heeft verbinding gemaakt");
        }

        private void HandlePatient(TcpClient client)
        {
            Patient clientPatient = new Patient();

            string bikeName = "Bike" + BikeCount;
            BikeCount++;

            ServerClient CurrentClient = new ServerClient(client);
            CurrentClient.ClientName = bikeName;
            Clients.Add(CurrentClient);
            
            //omdat dit een eeuwige loop is, luistert die maar naar 1 client
            //[TODO] dit verbeteren, hij moet naar meerdere clients luisteren
            bool done = false;
            while (!done && client.Connected)
            {
                if (CurrentClient.PatientName != "")
                {
                    DecodeJsonCommand(CurrentClient, ReadTextMessage(client));
                }
            }

            client.Close();
        }

        private void HandleDoctor(TcpClient client)
        {
            ServerClient CurrentClient = new ServerClient(client);
                
            bool done = false;
            while (!done && client.Connected)
            {
                Console.WriteLine(DecodeJsonCommand(CurrentClient, ReadTextMessage(client)));
            }

            client.Close();
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

        private bool isLoginCorrect(String username, String password)
        {
            bool correctLogin = false;
            if (username != "" && password != "")
            {
                foreach (string userKey in doctorAccounts.Keys)
                {
                    if (userKey == username && doctorAccounts[userKey] == password)
                    {
                        correctLogin = true;
                    }
                }
            }
            return correctLogin;
        }


        private void AddDoctorAccount(string Username, string Password)
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
        
        private string GetAllDataFromUser(string user)
        {
            Patient searchedPatient = null;
            foreach (Patient patient in patients)
            {
                if (patient.name == user)
                {
                    searchedPatient = patient;
                }
            }
            return JsonConvert.SerializeObject(searchedPatient);
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

        private void HandleData(string message)
        {
            dynamic data = JsonConvert.DeserializeObject(message);
            string command = data.command;

            switch (command)
            {
                case "login": ReceivedLogin(data); break;
                case "create_account": ReceivedCreateAccount(data); break;
                case "broadcast": ReceivedBroadcast(data); break;
                case "patient_data": ReceivedPatientData(data); break;
                case "check_bikes": ReceivedCheckBikes(); break;
            }

            /*
             COMMAND OPTIES
                - login
                - create_account
                - broadcast
                - patient_data

                //check_bikes, add_patient, current_PoT, end_course,client_disconnect moet tim zelf maken.
            
                - check_bikes
                - add_patient
                - current_PoT
                - client_disconnect
                - end_course

                - connection_type (patient of doctor)
            */
        }

        //private void ReceivedCheckBikes(string data)
        //{
        //    dynamic CheckBikeData = JsonConvert.DeserializeObject(data);
        //    int origin = CheckBikeData.origin;

        //    string message = "";

        //    foreach (ServerClient Client in Clients)
        //    {
        //        if (Client.ClientName.Contains("Bike") && Client.Available == true)
        //            message = "bike_available";
        //    }
        //    WriteTextMessage(CurrentClient.Client, message);
        //}

        //private void SendCheckedBikes(int origin)
        //{
        //    foreach(Connection connection in connectionList)
        //    {
              
        //    }
        //}

        private void ReceivedLogin(dynamic data)
        {
            dynamic loginData = JsonConvert.DeserializeObject(data);
            string username = loginData.username;
            string password = loginData.password;
            int origin = loginData.origin;

            HandleLogin(username, password, origin);

        }

        private void ReceivedCreateAccount(string data)
        {
            dynamic accountData = JsonConvert.DeserializeObject(data);
            string username = accountData.username;
            string password = accountData.password;
            int origin = accountData.orgin;

            HandleDoctorAccount(username, password, origin);
        }

        private void ReceivedPatientData(string data)
        {
            dynamic patientNameData = JsonConvert.DeserializeObject(data);
            string patientName = patientNameData.patientName;
            int origin = patientNameData.origin;

            SendPatientData(patientName, origin);
        }

        private void ReceivedBroadcast(string data)
        {
            dynamic messageData = JsonConvert.DeserializeObject(data);
            string message = messageData.message;

            SendMessageToAll(message);
        }

        private void ReceivedCheckBikes()
        {
            //string message = "";
            //foreach (ServerClient Client in Clients)
            //{
            //    if (Client.ClientName.Contains("Bike") && Client.Available == true)
            //        message = "bike_available";
            //}
            //WriteTextMessage(client, message);
        }

        private void SendPatientData(string patientName, int origin)
        {
            FindConnection(origin).SendData(patientName);
        }

        private void SendMessageToAll(string message)
        {
            foreach(Connection connection in connectionList)
            {
                connection.SendData(message);
            }
        }


        private void HandleDoctorAccount(string username, string password, int origin)
        {
            if (doctorAccounts.Keys.Contains(username))
                FindConnection(origin).SendData("AccountExists");
            else
            {
                AddDoctorAccount(username, password);
                FindConnection(origin).SendData("AccountCreated");
            }    
        }


        private void HandleLogin(string username,string password,int origin)
        {
            if (isLoginCorrect(username, password))
            {
                FindConnection(origin).SendData("AccountExists");
            }
            else
                FindConnection(origin).SendData("AccountDoesntExist");
        }

        #region depricated
        private string DecodeJsonCommand(ServerClient CurrentClient, string jsonString)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(jsonString);
            String command = receivedData.command;
            String data = receivedData.data;

            if (command == "login")
            {
                dynamic loginData = JsonConvert.DeserializeObject(data);
                string username = loginData.username;
                string password = loginData.password;

                CurrentClient.ClientName = username;
                Clients.Add(CurrentClient);

                Console.WriteLine("gelezen username = {0}", username);

                if (isLoginCorrect(username, password))
                    WriteTextMessage(CurrentClient.Client, "AccountExists");
                else
                    WriteTextMessage(CurrentClient.Client, "AccountDoesntExist");
            }
            else if (command == "create_account")
            {
                dynamic accountData = JsonConvert.DeserializeObject(data);
                string username = accountData.username;
                string password = accountData.password;

                if (doctorAccounts.Keys.Contains(username))
                    WriteTextMessage(CurrentClient.Client, "AccountExists");
                else
                {
                    AddDoctorAccount(username, password);
                    WriteTextMessage(CurrentClient.Client, "AccountCreated");
                }
            }
            else if (command == "broadcast")
            {
                foreach (ServerClient Client in Clients)
                {
                    WriteTextMessage(Client.Client, createJsonCommand(command, data));
                }
            }
            //geeft de historische data van de opgevraagde patient terug
            else if (command == "patient_data")
            {
                dynamic patientNameData = JsonConvert.DeserializeObject(data);
                String patientName = patientNameData.patientName;
                WriteTextMessage(CurrentClient.Client, createJsonCommand(command, GetAllDataFromUser(patientName)));
            }
            //kijkt of er een aangesloten fiets is die nog niet in gebruik is
            else if (command == "check_bikes")
            {
                string message = "";
                foreach (ServerClient Client in Clients)
                {
                    if (Client.ClientName.Contains("Bike") && Client.Available == true)
                        message = "bike_available";
                }
                WriteTextMessage(CurrentClient.Client, message);
            }
            //voegt een patient toe aan een vrije fiets 
            else if (command == "add_patient")
            {
                dynamic patientNameData = JsonConvert.DeserializeObject(data);
                String patientName = patientNameData.patientName;

                bool patientExists = false;
                foreach (Patient patient in patients)
                    if (patient.name == patientName)
                        patientExists = true;

                if (!patientExists)
                {
                    Patient newPatient = new Patient(patientName);
                    patients.Add(newPatient);
                }

                string bikeID = "no_bike";
                foreach (ServerClient Client in Clients)
                {
                    if (Client.ClientName.Contains("Bike") && Client.Available == true)
                    {
                        Client.Available = false;
                        bikeID = Client.ClientName;
                        Client.PatientName = patientName;
                        break;
                    }
                }

                WriteTextMessage(CurrentClient.Client, bikeID);
            }
            //voegt de binnengekregen PointOfTime toe aan de juiste patient
            else if (command == "current_PoT")
            {
                PointOfTime PoT = JsonConvert.DeserializeObject<PointOfTime>(data);
                foreach (Patient patient in patients)
                {
                    if (patient.name == CurrentClient.PatientName)
                    {
                        patient.timeList.Add(PoT);
                    }
                }
            }
            else if (command == "client_disconnect")
            {
                CurrentClient.Client.Close();
                Console.WriteLine(CurrentClient.ClientName + " has disconnected from the server");
            }
            //deze methode wordt gebruikt wanneer variabelen van de fiets worden aangepast, dus bijv. StartCourse, EndCourse en UpdateCourse
            else
            {
                dynamic receivedBikeID = JsonConvert.DeserializeObject(data);
                String bikeID = receivedBikeID.bikeID;

                foreach (ServerClient Client in Clients)
                {
                    Console.WriteLine(Client.ClientName);
                    if (Client.ClientName.Equals(bikeID))
                    {
                        WriteTextMessage(Client.Client, createJsonCommand(command, data));
                    }
                }

                if (command == "end_course")
                    foreach (Patient patient in patients)
                        if (patient.name == CurrentClient.PatientName)
                            WritePatientsToFile();
            }
            return data;
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

        private string ReadTextMessage(TcpClient client)
        {
            string line = "";
            try
            {
                StreamReader stream = new StreamReader(client.GetStream(), Encoding.UTF32);
                if (client.Connected)
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
            if(line == "" || line == null)
                Console.WriteLine(line);
            return line;
        }
        #endregion

        private void WritePatientsToFile()
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
                    patients.Add(new Patient("tim"));
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

        public void OnDataReceived(string data)
        {
            //TODO handle data
        }
    }
}
