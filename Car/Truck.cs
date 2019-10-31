using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Truck : Car
    {
        private int _carrying;

        //add constructor with three parameters (_weight,  car model, VIN code)
        public Truck(int carrying, string m, string v, int speed)
        {
            CarModel = m;
            VIN = v;
            Speed = speed;
            _carrying = carrying;
        }


        //override ToString method
        public override string ToString()
        {
            return string.Format("Truck model is {0}, it's speed is {1}, VIN is {2}, carrying is {3} tons", base.CarModel, base.Speed, base.VIN, _carrying);
        }

    }
}
