using IPR.GUI_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static string _SERVER_IP = "localhost";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DoctorLoginForm(_SERVER_IP));
        }
    }
}
