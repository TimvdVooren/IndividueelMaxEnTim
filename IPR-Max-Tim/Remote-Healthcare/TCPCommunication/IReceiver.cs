﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Healthcare.TCPCommunication
{
    interface IReceiver
    {
        void IsStringReceived(String message);
    }
}
