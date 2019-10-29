using System;
using System.Dynamic;

namespace Car
{
    internal class Car
    {
        private int _weight;

        public int Weight
        {
            get
            {
                return _weight;
            }

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
            get
            {
                return _vin;
            }

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


        //add car model
        private string _carModel;

        public string CarModel
        {
            get
            {
                return _carModel;

            }
            set
            {
                _carModel = value; 

            }
        }

        //add car type
        private string _carType;

        //override ToString method
        public override string ToString()
        {
            return string.Format("Car model is {0}, it's speed is {1} and VIN is {2}", _carModel, _speed, _vin);
        }

        #region Constructors
        //add constructor w/out parameters
        public Car()
        {
            
        }

        //add constructor with one parameter (_weight)

        public Car(int w)
        {
            _weight = w;
        }

        //add constructor with two parameters (_weight & car model)

        public Car(int w, string m)
        {
            _weight = w;
            _carModel = m;
        }

        //add constructor with three parameters (_weight,  car model, VIN code)

        public Car(int w, string m, string v, int speed)
        {
            _weight = w;
            _carModel = m;
            VIN = v;
            _speed = speed;
        }
        #endregion


        //add method Move
        public void Move(int speed)
        {
            _speed = speed;
            Console.WriteLine("I'm driving with speed {0}", speed);
        }

        //Move method overload

        public void Move(int speed, string carModel)
        {
            _speed = speed;
            _carModel = carModel;
            Console.WriteLine("Car model {0} is driving with speed {1}", carModel, speed);
        }

        //add method Stop
        public void Stop()
        {
            _speed = 0;

            Console.WriteLine("I stop");
        }

        //add method CheckSpeed
        public int CheckSpeed()
        {

            return _speed;
        }

        public double KineticEnergyOfaCar(int speed, int weight)
        {
            double kineticEnergy = (weight * Math.Pow(speed, 2)) / 2;

            return kineticEnergy;
        }

    }
}
