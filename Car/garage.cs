using System;
using System.Collections;
using System.Collections.Generic;

namespace Car
{
    internal class Garage
    {
        private int _capacity;

        private object _car;

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Garage capacity can not be smaller than 0 ");
                }
                else
                {
                    _capacity = value;
                }
            }
        }

        public Garage (int capacity, object car)
        {
            _capacity = capacity;
            _car = car;
        }

        //override ToString method
        public override string ToString ()
        {
            return string.Format("Garage capacity is {0} cars, now are (is) {1} cars (car) in garage", _capacity, Pu);
        }

        //Add some methods
        protected internal static Stack<Car> PutCarInGarage(Car car, Stack<Car> carsInGarage)
        {
            carsInGarage.Push(car);
            return carsInGarage;
        }

        protected internal static int CountCarsInGarage(Garage garage)
        {
            return garage.
        }
    }
}
