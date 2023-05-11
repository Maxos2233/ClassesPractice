using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    public class Engine
    {
        private int SerialNumber;
        private int AgeOfEngine;
        private int Reliability;


        public Engine(int serialNumber, int ageOfEngine, int reliability)
        {
            SerialNumber = serialNumber;
            AgeOfEngine = ageOfEngine;
            Reliability = reliability;
        }
        public int GetReliability
        {
            get { return Reliability; }
        }
        public int GetAgeOfEngine
        {
            get { return AgeOfEngine; }
        }
        public int GetSerialNumber
        {
            get { return SerialNumber; }
        }
    }
}
