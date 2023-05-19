using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    public class TaskSolver
    {
        public double mostReliable;
        public double leastReliable;
        public int amountOfCharactersOfName;
        public int indexOfName;
        public int mostMileage;
        public int amountOfDoors;
        public int amountOfWheels;
        public List<Car> Cars;

        public TaskSolver(double mostReliableCar, double leastReliableCar, List<Car> listOfCars, int amountOfCharacters, int indexOfCar, int mostMileage, int numberOfDoors, int numberOfWheels)
        {
            mostReliable = mostReliableCar;
            leastReliable = leastReliableCar;
            Cars = listOfCars;
            amountOfCharactersOfName = amountOfCharacters;
            indexOfName = indexOfCar;
            this.mostMileage = mostMileage;
            amountOfDoors = numberOfDoors;
            amountOfWheels = numberOfWheels;
        }

        public double GetMostReliableCar()
        {
            for (int i = 1; i < Cars.Count; i++)
            {
                //Console.WriteLine(Cars[i].reliabilityOfCar());
                var number = Cars[i].reliabilityOfCar();
                var number2 = Cars[i - 1].reliabilityOfCar();
                if (number < number2 && mostReliable > number)
                {
                    mostReliable = number;
                }
                else if (number2 < number && mostReliable > number2)
                {
                    mostReliable = number2;
                }
                
            }
            return mostReliable;
        }

        public double GetLeastReliableCar()
        {
            for (int i = 1; i < Cars.Count; i++)
            {
                //Console.WriteLine(Cars[i].reliabilityOfCar());
                var number = Cars[i].reliabilityOfCar();
                var number2 = Cars[i - 1].reliabilityOfCar();
                if (number > number2 && leastReliable < number)
                {
                    leastReliable = number;
                }
                else if (number2 > number && leastReliable < number2)
                {
                    leastReliable = number2;
                }
                
            }
            return leastReliable;
        }
        public string GetLongestBrandName()
        {
            for (int i = 1; i<Cars.Count;i++)
            {
                if (amountOfCharactersOfName < Cars[i].Brand.Length)
                {
                    amountOfCharactersOfName = Cars[i].Brand.Length;
                    indexOfName = i;
                }
            }
            return Cars[indexOfName].Brand;
        }

        public int GetMostMileage()
        {
            for (int i = 1; i < Cars.Count; i++)
            {
                var number = Cars[i].Milage;
                var number2 = Cars[i - 1].Milage;
                if (number > number2 && mostMileage < number)
                {
                    mostMileage = number;
                }
                else if (number2 > number && mostMileage < number2)
                {
                    mostMileage = number2;
                }

            }
            return mostMileage;
        }
        public int GetSummOfWheels()
        {
            for (int i = 1; i < Cars.Count; i++)
            {
                amountOfWheels += Cars[i].NumberOfWheels;
            }
            return amountOfWheels;
        }
        public int GetSummOfDoors()
        {
            for (int i = 1; i < Cars.Count; i++)
            {
                amountOfDoors += Cars[i].NumberOfDoors;
            }
            return amountOfDoors;
        }
    }
}
