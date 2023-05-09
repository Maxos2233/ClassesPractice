using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{

    public class Car
    {
        public string Brand;
        public int Milage;
        public int NumberOfDoors;
        public int NumberOfWheels;
        public Engine EngineOfCar;


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
            return $"Serial number of engine is {EngineOfCar.SerialNumber}, age of engine is {EngineOfCar.AgeOfEngine} and coefficient of reliability is {EngineOfCar.Reliability}";
        }

        public string GetInfoOfCar()
        {
            return $"Brand of car is {Brand}, mileage of car is {Milage}, number of doors is {NumberOfDoors} and number of wheels is {NumberOfWheels}";
        }
        
    }
}
