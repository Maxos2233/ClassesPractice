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


var taskSolver = new TaskSolver(listOfCars);


for (int i = 0; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].GetInfoOfCar());
}
    
for (int z = 0; z <  listOfEngines.Count; z++)
{
    Console.WriteLine(listOfCars[z].GetInfoOfEngine());
}

for (int i = 0; i < listOfCars.Count; i++)
{
    Console.WriteLine(listOfCars[i].reliabilityOfCar());
}
Console.WriteLine(taskSolver.GetSolution());
