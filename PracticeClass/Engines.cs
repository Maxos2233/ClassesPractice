using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    public class Engines
    {
        public int _serialNumber { get; private set; }
        public int _ageOfEngine { get; private set; }
        public int _reliability { get; private set; }

        public Engines(int serialNumber, int ageOfEngine, int reliability)
        {
            _serialNumber = serialNumber;
            _ageOfEngine = ageOfEngine;
            _reliability = reliability;
        }

        public string GetInfoOfEngine()
        {
            return $"Serial number of engine is {_serialNumber}, age of engine is {_ageOfEngine} and coefficient of reliability is {_reliability}";
        }
    }
}
