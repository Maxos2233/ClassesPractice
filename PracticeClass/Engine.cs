using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    public class Engine
    {
        public int SerialNumber { get; private set; }
        public int AgeOfEngine { get; private set; }
        public int Reliability { get; private set; }

        public Engine(int serialNumber, int ageOfEngine, int reliability)
        {
            SerialNumber = serialNumber;
            AgeOfEngine = ageOfEngine;
            Reliability = reliability;
        }

    }
}
