using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{

    public class Cars
    {

        public string Brand;
        public int Milage;
        public int NumberOfDoors;
        public int NumberOfWheels;

        public Cars(string brand, int milage, int numberOfDoors, int numberOfWheels) 
        {
            Brand = brand;
            Milage = milage;
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
        }


        public string GetInfoOfCar()
        {
            return $"Brand of car is {Brand}, mileage of car is {Milage}, number of doors is {NumberOfDoors} and number of wheels is {NumberOfWheels}";
        }
    }
}
