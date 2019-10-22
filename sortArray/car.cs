using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortArray
{
    class Car
    {
        public int weight;

        protected double _win;

        private int _speed;

        public void move (int speed)
        {
            _speed = speed;
            Console.WriteLine("I'm driving with speed {0}", speed);

            Console.WriteLine("I'm driving with speed " + speed.ToString());
        }

        public void Stop()
        {
            _speed = 0;

            Console.WriteLine("I'm stopped");
        }

        public int checkSpeed ()
        {

            return _speed;
        }

    }
}
