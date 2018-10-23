using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ServerConnection
{
    interface IReceiver
    {
        void IsStringReceived(String message);
    }
}
