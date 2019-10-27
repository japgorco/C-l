using System;

namespace Car
{
    internal class Car
    {
        public int weight;

        private string vin;

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
                    vin = value;
                }
            }
        }


        private int _speed;

        //internal string CarModel()
        //{
        //    return _carModel;
        //}

        //add car model
        private string _carModel;
        // string carModel;

        //add car type
        private readonly string _carType;

        #region Constructors
        //add constructor w/out parameters
        public Car()
        {
            
        }

        //add constructor with one parameter (weight)

        public Car(int w)
        {
            weight = w;
        }

        //add constructor with two parameters (weight & car model)

        public Car(int w, string cm)
        {
            weight = w;
            //carModel = _carModel;
            //_carModel = carModel;
            _carModel = cm;
        }

        //add constructor with three parameters (weight,  car model, VIN code)

        public Car(int w, string m, string v)
        {
            weight = w;
            //carModel = _carModel;
            _carModel = m;
            VIN = v;
        }
        #endregion


        //add method Move
        public void Move(int speed)
        {
            _speed = speed;
            Console.WriteLine("I'm driving with speed {0}", speed);
        }

        public void CarModel(string cm)
        {
            _carModel = cm;
            Console.WriteLine("I'm driving with speed {0}", _speed);
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
