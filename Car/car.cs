﻿using System;
using System.Collections.Generic;

namespace Car
{
    internal class Car : IEquatable<Car>, IComparable<Car>
    {
        private int _weight;

        public int Weight
        {
            get => _weight;

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Car weight can not be smaller than 0 ");
                }
                else
                {
                    _weight = value;
                }
            }
        }

        private string _vin;

        public string VIN
        {
            get => _vin;

            set
            {
                if (value.Length != 17)
                {
                    Console.WriteLine("VIN code length should consists of 17 symbols");
                }
                else
                {
                    _vin = value;
                }
            }
        }


        private int _speed;

        public int Speed
        {
            get => _speed;
            set => _speed = value;
        }


        //add car model
        private string _carModel;

        public string CarModel
        {
            get => _carModel;
            set => _carModel = value;
        }

        //add car type
        private readonly string _carType;

         public bool Equals (Car other)
        {
            if (other == null) return false;
            return Weight.Equals(other.Weight);

        }

        //override Equals method
        public override bool Equals (object obj)
        {
            if (obj == null) return false;
            Car objAsCar = obj as Car;
            if (objAsCar == null) return false;
            //else return Equals(objAsCar);
            else return objAsCar.CarModel == _carModel;
        }

        //override ToString method
        public virtual string ToString ()
        {
            return string.Format("model is {0}, it's speed is {1}, VIN is {2}, Weight is {3}", _carModel, _speed, _vin, _weight);
        }

        public int SortByWeightAscending(string carModel1, string carModel2)
        {
            return carModel1.CompareTo(carModel2);
        }

        //default comparer for Car weight
        public int CompareTo (Car car)
        {
            //A null value means that this object is greater
            if (car == null)
                return 1;
            else
            {
                return Weight.CompareTo(car.Weight);
            }
        }

        #region Constructors
        //add constructor w/out parameters
        public Car()
        {

        }

        //add constructor with one parameter (_weight)

        public Car (int w)
        {
            _weight = w;
        }

        //add constructor with two parameters (_weight & car model)

        public Car (int w, string m)
        {
            _weight = w;
            _carModel = m;
        }

        //add constructor with three parameters (_weight,  car model, VIN code)

        public Car (int w, string m, string v, int speed)
        {
            _weight = w;
            _carModel = m;
            VIN = v;
            _speed = speed;
        }
        #endregion


        #region Methods

        //add method Move
        public void Move (int speed)
        {
            _speed = speed;
            Console.WriteLine("I'm driving with speed {0}", speed);
        }

        //Move method overload

        public void Move (int speed, string carModel)
        {
            _speed = speed;
            _carModel = carModel;
            Console.WriteLine("Car model {0} is driving with speed {1}", carModel, speed);
        }

        //add method Stop
        public void Stop ()
        {
            _speed = 0;

            Console.WriteLine("I stop");
        }

        //add method CheckSpeed
        public int CheckSpeed ()
        {

            return _speed;
        }

        public double KineticEnergyOfaCar (int speed, int weight)
        {
            double kineticEnergy = (weight * Math.Pow(speed, 2)) / 2;

            return kineticEnergy;
        }

        //add method form random string
        private static readonly Random random = new Random();

        protected internal static string RandomString (int length)
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

        protected internal static int RandomWeight ()
        {
            int weight = random.Next(1000, 20000);
            return weight;
        }

        public int CountVovelsInVin (string Vin)
        {
            const string vovels = "aeioyu";
            int SumOfVovels = 0;

            for (int i = 0; i < Vin.Length; i++)
            {
                for (int j = 0; j < vovels.Length; j++)
                {
                    if (Vin[i] == vovels[j] || Vin[i] == Char.ToUpper(Convert.ToChar(vovels[j])))
                    {
                        ++SumOfVovels;
                    }
                }
            }
            return SumOfVovels;
        }


        #endregion
    }
}
