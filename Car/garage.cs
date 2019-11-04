using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Garage
    {
        private int _capacity;

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
        
        public Garage(int capacity)
        {
            _capacity = capacity;
        }

        Garage[] data;

        //Add some indexator;
        public Garage this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        //override ToString method
        public override string ToString ()
        {
            return string.Format("Garage capacity is {0} cars", _capacity);
        }
    }
}
