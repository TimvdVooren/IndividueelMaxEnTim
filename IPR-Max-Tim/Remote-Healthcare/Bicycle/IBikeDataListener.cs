﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Healthcare.Bicycle
{
    interface IBikeDataListener
    {
        void OnBikeDataReceived(BikeDataPackage e);

    }
}
