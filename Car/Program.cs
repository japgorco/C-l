using System;

namespace Car
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Car car = new Car();

            Car car1 = new Car(2500);

            car.Move(5);

            car1.Move(10);

            Console.WriteLine("Speed is " + car.CheckSpeed());

            car.Stop();



            car.KineticEnergyOfaCar(5, 2500);

            car1.KineticEnergyOfaCar(10, 2500);

            Console.WriteLine("Kinetic Energy Of a {0} is {1}", car.);

            Console.ReadKey();
        }
    }
}
