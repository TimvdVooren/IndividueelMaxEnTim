using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPR.SerialCommunication
{
    interface IX7DataListener
    {
        void OnDataReceived(String e);
    }
}

