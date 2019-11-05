using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Car
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 10;

            string strCount = count.ToString();
            strCount = 676.ToString();
            
            count = Convert.ToInt32("767");

            Car car = new Car();

            Car car1 = new Car(2500);

            Car car2 = new Car(3000, "Dodge");

            Car car3 = new Car(3000, "Dodge", Car.RandomString(17), 55);

           // Truck truck = new Truck();

          //  truck.Move(speed:25, carModel:"BELAZ");

            car.Move(5);

            car1.Move(55, "LADA");

            List<Car> cars = new List<Car>(15);

            for (int i = 0; i < 3; i++)
            {
                cars.Add(new Car() { CarModel = "Lada", Weight = Car.RandomWeight(), VIN = Car.RandomString(17)  });
            }


            Console.WriteLine("Kinetic Energy of a car model {0} is {1} J.", car2.CarModel, car2.KineticEnergyOfaCar(5, car2.Weight));

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("Before sort Car {0} weight is {1} and VIN is {2}", cars[i].CarModel, cars[i].Weight, cars[i].VIN);
            }

            //Call Sort on the list. This will use the default comparer, which is the Compare method implemented on Car
            cars.Sort();

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("After sort Car {0} weight is {1} and VIN is {2}", cars[i].CarModel, cars[i].Weight, cars[i].VIN);
            }

            //Count sum of vovels at cars' VIN
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("Sum of vovels at car's {0} VIN is {1}", cars[i].VIN, cars[i].CountVovelsInVin(cars[i].VIN));
            }
            //check overrided ToString

            Car truck1 = new Truck(3000, "BELAZ", Car.RandomString(17), 55);

            Console.WriteLine(car3.ToString());
            
            //demonstrates String overload at Truck class
            Console.WriteLine(truck1.ToString());

            //demonstrates typeof working
            Console.WriteLine("An {0} instance of the Car class is {1}", car1.CarModel, typeof(Car));
            Console.WriteLine("An {0} instance of the Car class is {1}", truck1.CarModel, typeof(Truck));

            //demonstrates how is working

            bool a = car is Truck;

            string z = a == true ? "car is Truck" : "car is not a Truck";

            Console.WriteLine(z);

            //if (car is Truck)
            //{
            //    Console.WriteLine("car is Truck");
            //}
            //else
            //{
            //    Console.WriteLine("car is not a Truck");
            //}

            //demonstrates how as working
            Car truck2 = new Car(3000, "BELAZ", Car.RandomString(17), 55);

            Truck car5 = truck2 as Truck;

            if (car5 == null)
            {
                Console.WriteLine("Truck is not a Car");
            }
            else
            {
                Console.WriteLine("Truck is a Car");

            }
            


            Stack <Car> carsInGarage = new Stack<Car>();

            //for (int i = 0; i < garage. ; i++)
            //{
            //    garage.Add
            //}
            for (int i = 0; i < cars.Count; i++)
            {
                Garage.PutCarInGarage(cars[i], carsInGarage);
            }

            Garage garage = new Garage(cars.Count, carsInGarage);
 
            Console.ReadKey();


         }
    }
}
