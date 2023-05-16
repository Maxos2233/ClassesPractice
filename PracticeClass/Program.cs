using System.Numerics;
using System.Reflection;
using PracticeClass;




List<Engine> listOfEngines = new List<Engine>()
{
    new Engine(732452, 6, 7),
    new Engine(152372, 4, 9),
    new Engine(487524, 5, 8),
    new Engine(735431, 1, 7),
    new Engine(192787, 10, 6),
    new Engine(341244, 7, 9),
    new Engine(814532, 4, 7),
    new Engine(489714, 7, 8),
    new Engine(701684, 3, 5),
    new Engine(688480, 9, 9)
};

List<Car> listOfCars = new List<Car>()
{
    new Car("BMW", 130000, 4, 4, listOfEngines[0]),
    new Car("Honda", 70000, 2, 4, listOfEngines[1]),
    new Car("Mercedes-Benz", 100000, 4, 4, listOfEngines[2]),
    new Car("Acura", 2500, 2, 4, listOfEngines[3]),
    new Car("Dodge", 400000, 4, 4, listOfEngines[4]),
    new Car("Renault", 370000, 4, 4, listOfEngines[5]),
    new Car("Mazda", 85000, 4, 4, listOfEngines[6]),
    new Car("Seat", 280000, 4, 4, listOfEngines[7]),
    new Car("Chrysler", 69000, 4, 4, listOfEngines[8]),
    new Car("Volkswagen", 250000, 4, 4, listOfEngines[9])
};




for (int i = 0; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].GetInfoOfCar());
}
    
for (int z = 0; z <  listOfEngines.Count; z++)
{
    Console.WriteLine(listOfCars[z].GetInfoOfEngine());
}

double mostReliable = listOfCars[0].reliabilityOfCar();
double leastReliable = listOfCars[0].reliabilityOfCar();

for (int i = 1; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].reliabilityOfCar());
    var number = listOfCars[i].reliabilityOfCar();
    for (int j = 0; j < listOfCars.Count; j++)
    {
        var number2 = listOfCars[j].reliabilityOfCar();
        if (number < number2 && mostReliable > number)
        {
            mostReliable = number;
        }
        else if (number2 < number && mostReliable > number2)
        {
            mostReliable = number2;
        }
    }
}

for (int i = 1; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].reliabilityOfCar());
    var number = listOfCars[i].reliabilityOfCar();
    for (int j = 0; j < listOfCars.Count; j++)
    {
        var number2 = listOfCars[j].reliabilityOfCar();
        if (number > number2 && leastReliable < number)
        {
            leastReliable = number;
        }
        else if (number2 > number && leastReliable < number2)
        {
            leastReliable = number2;
        }
    }
}

var amountOfCharacters = listOfCars[0].Brand.Length;
var indexOfCar = 0;
for (int i = 1; i < listOfCars.Count;i++)
{
    if (amountOfCharacters < listOfCars[i].Brand.Length)
    {
        amountOfCharacters = listOfCars[i].Brand.Length;
        indexOfCar = i;
    }
}


var mostMileage = listOfCars[0].Milage;
for (int i = 1; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].Milage);
    var number = listOfCars[i].Milage;
    for (int j = 0; j < listOfCars.Count; j++)
    {
        var number2 = listOfCars[j].Milage;
        if (number > number2 && mostMileage < number)
        {
            mostMileage = number;
        }
        else if (number2 > number && mostMileage < number2)
        {
            mostMileage = number2;
        }
    }
}

var numberOfWheels = listOfCars[0].NumberOfWheels;
var numberOfDoors = listOfCars[0].NumberOfDoors;
for (int i = 1; i < listOfCars.Count; i++)
{
    numberOfWheels += listOfCars[i].NumberOfWheels;
    numberOfDoors += listOfCars[i].NumberOfDoors;
}


Console.WriteLine(mostReliable);
Console.WriteLine(leastReliable);
Console.WriteLine(listOfCars[indexOfCar].Brand);
Console.WriteLine(mostMileage);
Console.WriteLine(numberOfDoors);
Console.WriteLine(numberOfWheels);

