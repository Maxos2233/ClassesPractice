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
        public string EngineOfCar;

        public Car(string brand, int milage, int numberOfDoors, int numberOfWheels, Engine engineOfCar) 
        {
            Brand = brand;
            Milage = milage;
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
            EngineOfCar = engineOfCar.GetInfoOfEngine();
        }

        public string GetInfoOfCar()
        {
            return $"Brand of car is {Brand}, mileage of car is {Milage}, number of doors is {NumberOfDoors} and number of wheels is {NumberOfWheels}\n{EngineOfCar}";
        }
    }
}
