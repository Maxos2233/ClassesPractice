using System.Numerics;
using PracticeClass;

Engine engine = new Engine(73428565, 5, 7);
Car car = new Car("BMW", 271989, 4, 4, engine);


double reliabilityOfCar()
{
    return engine.Reliability * car.Milage / 1000;
}


string z = Convert.ToString(reliabilityOfCar());


Console.WriteLine(car.GetInfoOfCar());
Console.WriteLine(z);