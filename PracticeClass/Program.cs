using System.Numerics;
using PracticeClass;

Cars car = new Cars("BMW", 271989, 4, 4);
Engines engine = new Engines(73428565, 5, 7);

double reliabilityOfCar()
{
    return engine._reliability * car.Milage / 1000;
}

string n = car.GetInfoOfCar();
string m = engine.GetInfoOfEngine();
string z = Convert.ToString(reliabilityOfCar());


Console.WriteLine(n);
Console.WriteLine(m);
Console.WriteLine(z);