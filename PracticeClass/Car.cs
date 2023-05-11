using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{

    public class Car
    {
        public string Brand { get; private set; }
        public int Milage { get; private set; }
        public int NumberOfDoors { get; private set; }
        public int NumberOfWheels { get; private set; }
        public Engine EngineOfCar { get; private set; }


        public Car(string brand, int milage, int numberOfDoors, int numberOfWheels, Engine engine) 
        {
            Brand = brand;
            Milage = milage;
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
            EngineOfCar = engine;
        }

        public string GetInfoOfEngine()
        {
            return $"Serial number of engine is {EngineOfCar.GetSerialNumber}, age of engine is {EngineOfCar.GetAgeOfEngine} and coefficient of reliability is {EngineOfCar.GetReliability}";
        }

        public string GetInfoOfCar()
        {
            return $"Brand of car is {Brand}, mileage of car is {Milage}, number of doors is {NumberOfDoors} and number of wheels is {NumberOfWheels}";
        }

        public double reliabilityOfCar()
        {
            return EngineOfCar.GetReliability * Milage / 1000;
        }

    }
}
