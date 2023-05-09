using System.Numerics;
using PracticeClass;

Engine engine = new Engine(73428565, 3, 7);
Car car = new Car("BMW", 130000, 4, 4, engine);


double reliabilityOfCar()
{
    return engine.Reliability * car.Milage / 1000;
}


string z = Convert.ToString(reliabilityOfCar());


Console.WriteLine(car.GetInfoOfCar());
Console.WriteLine(car.GetInfoOfEngine());
Console.WriteLine(z);