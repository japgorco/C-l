using System;
using System.Collections.Generic;
using System.Linq;

namespace Car
{
    internal class Program
    {

        private static readonly Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static void Main(string[] args)
        {
            int count = 10;

            string strCount = count.ToString();
            strCount = 676.ToString();
            
            count = Convert.ToInt32("767");

            Car car = new Car();

            Car car1 = new Car(2500);

            Car car2 = new Car(3000, "Dodge");

            Car car3 = new Car(3000, "Dodge", "1FMYU95HX5KA01996");

            car.Move(5);

            car1.Move(10);

            List<Car> cars = new List<Car>(15);

            for (int i = 0; i < 15; i++)
            {
                cars.Add(new Car() { carModel = "Lada", weight = 2000, VIN = RandomString(17)  });
            }

            Console.WriteLine("Speed is " + car.CheckSpeed());

            car.Stop();

            car.KineticEnergyOfaCar(5, 2500);

            car1.KineticEnergyOfaCar(10, 2500);

            Console.WriteLine("Kinetic Energy of a car model {0} is {1} J.", car2.carModel, car2.KineticEnergyOfaCar(5, car2.weight));

            foreach (var c in cars)
            {
                Console.WriteLine("Car {0} weight is {1} and VIN is {2}", c.carModel, c.weight, c.VIN);
            }

            Console.ReadKey();

        }



    }
}
