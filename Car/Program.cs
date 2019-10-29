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

            string intermediate = "";
            string vin = "";

            for (int i = 0; i < 17; i++)
            {
                int pos = random.Next(0, chars.Length);
                intermediate = chars[pos].ToString();
                vin = vin + intermediate;
            }

            return vin;

            //return new string(Enumerable.Repeat(chars, length)
            //    .Select(s => s[random.Next(s.Length)]).ToArray());
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

            Car car3 = new Car(3000, "Dodge", RandomString(17), 55);

            Truck truck = new Truck();

            truck.Move(speed:25, carModel:"BELAZ");

            car.Move(5);

            car1.Move(55, "LADA");

            List<Car> cars = new List<Car>(15);

            for (int i = 0; i < 15; i++)
            {
                cars.Add(new Car() { CarModel = "Lada", Weight = 2000, VIN = RandomString(17)  });
            }

            Console.WriteLine("Speed is " + car.CheckSpeed());

            car.Stop();

            car.KineticEnergyOfaCar(5, 2500);

            car1.KineticEnergyOfaCar(10, 2500);

            Console.WriteLine("Kinetic Energy of a car model {0} is {1} J.", car2.CarModel, car2.KineticEnergyOfaCar(5, car2.Weight));

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("Car {0} weight is {1} and VIN is {2}", cars[i].CarModel, cars[i].Weight, cars[i].VIN);
            }
 
            //check overrided ToString
            Console.WriteLine(car3.ToString());


            Console.ReadKey();

        }



    }
}
