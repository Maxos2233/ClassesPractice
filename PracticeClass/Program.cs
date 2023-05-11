using System.Numerics;
using System.Reflection;
using PracticeClass;

var engine = new Engine(732452, 6, 7);
Car car = new Car("BMW", 130000, 4, 4, engine);


string z = Convert.ToString(car.reliabilityOfCar());


Console.WriteLine(car.GetInfoOfCar());
Console.WriteLine(car.GetInfoOfEngine());
Console.WriteLine(z);