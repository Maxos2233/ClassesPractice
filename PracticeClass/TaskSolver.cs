using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    public class TaskSolver
    {
        
        public List<Car> Cars { get; private set; }

        public TaskSolver(List<Car> listOfCars)
        {
            Cars = listOfCars;
        }

        public double GetMostReliableCar()
        {
            var mostReliable = Cars[0].reliabilityOfCar();
            var number = Cars[0].reliabilityOfCar();
            var number2 = Cars[0].reliabilityOfCar();
            for (int i = 1; i < Cars.Count; i++)
            {
                number = Cars[i].reliabilityOfCar();
                number2 = Cars[i - 1].reliabilityOfCar();
                if (mostReliable > number)
                {
                    mostReliable = number;
                }
                else if (mostReliable > number2)
                {
                    mostReliable = number2;
                }
                
            }
            return mostReliable;
        }

        public double GetLeastReliableCar()
        {
            var leastReliable = Cars[0].reliabilityOfCar();
            var number = Cars[0].reliabilityOfCar();
            var number2 = Cars[0].reliabilityOfCar();
            for (int i = 1; i < Cars.Count; i++)
            {
                number = Cars[i].reliabilityOfCar();
                number2 = Cars[i - 1].reliabilityOfCar();
                if (leastReliable < number)
                {
                    leastReliable = number;
                }
                else if (leastReliable < number2)
                {
                    leastReliable = number2;
                }
                
            }
            return leastReliable;
        }
        public string GetLongestBrandName()
        {
            var amountOfCharactersOfName = Cars[0].Brand.Length;
            var indexOfName = 0;
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
            var mostMileage = Cars[0].Milage;
            var number = Cars[0].Milage;
            var number2 = Cars[0].Milage;
            for (int i = 1; i < Cars.Count; i++)
            {
                number = Cars[i].Milage;
                number2 = Cars[i - 1].Milage;
                if (mostMileage < number)
                {
                    mostMileage = number;
                }
                else if (mostMileage < number2)
                {
                    mostMileage = number2;
                }

            }
            return mostMileage;
        }
        public int GetSummOfWheels()
        {
            var amountOfWheels = Cars[0].NumberOfWheels;
            for (int i = 1; i < Cars.Count; i++)
            {
                amountOfWheels += Cars[i].NumberOfWheels;
            }
            return amountOfWheels;
        }
        public int GetSummOfDoors()
        {
            var amountOfDoors = Cars[0].NumberOfDoors;
            for (int i = 1; i < Cars.Count; i++)
            {
                amountOfDoors += Cars[i].NumberOfDoors;
            }
            return amountOfDoors;
        }
    }
}
