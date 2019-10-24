using System;

namespace Car
{
    internal class Car
    {
        public int Weight;

        protected double Vin;

        private int _speed;

        //add car model
        private string _carModel;

        //add car type
        private readonly string _carType;

        //add constructor w/out parameters
        public Car()
        {

        }

        //add constructor with one parameter (weight)

        public Car(int weight)
        {
            weight = 2500;
        }

        //add constructor with two parameters (weight & car model)

        public Car(int weight, string carModel)
        {
            weight = 2500;
            carModel = _carModel;
        }


        //add method Move
        public void Move(int speed)
        {
            _speed = speed;
            Console.WriteLine("I'm driving with speed {0}", speed);
        }

        public void CarModel(string carModel)
        {
            _carModel = carModel;
            Console.WriteLine("I'm driving with speed {0}", speed);
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
            var kineticEnergy = (weight * Math.Pow(speed, 2)) / 2;

            return kineticEnergy;
        }

    }
}
