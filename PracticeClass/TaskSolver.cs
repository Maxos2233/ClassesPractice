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
            for (int i = 1; i < Cars.Count; i++)
            {
                if (mostReliable > Cars[i].reliabilityOfCar())
                {
                    mostReliable = Cars[i].reliabilityOfCar();
                }
                else if (mostReliable > Cars[i - 1].reliabilityOfCar())
                {
                    mostReliable = Cars[i - 1].reliabilityOfCar();
                }
                
            }
            return mostReliable;
        }

        public double GetLeastReliableCar()
        {
            var leastReliable = Cars[0].reliabilityOfCar();
            for (int i = 1; i < Cars.Count; i++)
            {
                if (leastReliable < Cars[i].reliabilityOfCar())
                {
                    leastReliable = Cars[i].reliabilityOfCar();
                }
                else if (leastReliable < Cars[i - 1].reliabilityOfCar())
                {
                    leastReliable = Cars[i - 1].reliabilityOfCar();
                }
                
            }
            return leastReliable;
        }
        public string GetLongestBrandName()
        {
            var amountOfCharactersOfName = Cars[0].Brand.Length;
            var indexOfName = 0;
            for (int i = 1; i < Cars.Count; i++)
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
            for (int i = 1; i < Cars.Count; i++)
            {
                if (mostMileage < Cars[i].Milage)
                {
                    mostMileage = Cars[i].Milage;
                }
                else if (mostMileage < Cars[i - 1].Milage)
                {
                    mostMileage = Cars[i - 1].Milage;
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

        public string PrintSolution()
        {
            return $"Most reliability of car is {GetMostReliableCar()}, least reliability of car is {GetLeastReliableCar()}, longest name of car brand is {GetLongestBrandName()}, most mileage is {GetMostMileage()}, summ of wheels is {GetSummOfWheels()} and summ of doors is {GetSummOfDoors()}";
        }
    }
}
