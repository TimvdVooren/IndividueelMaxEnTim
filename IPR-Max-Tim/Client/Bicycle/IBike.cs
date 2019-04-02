using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Bicycle
{
    interface IBike
    {
        void Reset();
        BikeDataPackage ReadData();
        void PutDistance(int distance);
        void PutPower(int power);
        void PutTime(int time);
        void Close();
    }
}
