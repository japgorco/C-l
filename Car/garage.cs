using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Car
{
    internal class Garage
        {
        //private ListDictionary carDictionary = new ListDictionary();

        private List<Car> _carList = new List<Car>(1000);

        // This indexator returns appropriate car instance by index
        public Car this[int pos]

        {
            get
            {
                return _carList[pos];
            }
            set
            {
                _carList.Add(value);
            }
        }
        public int Length
        { get
            {
                return _carList.Count;
            }
        }
        public IEnumerator GetEnumerator()
            {
            return _carList.GetEnumerator();
            }


        //override ToString method
        public override string ToString()
        {
            return string.Format("There are (is) now {0} cars (car) in the garage, at {1} position stays {2} ", _carList.Count, _carList.IndexOf(_carList[0]), _carList[0].ToString());
        }

        private void PutCarInGarage(Car car)
        {
            _carList.Add(car);
        }

        public void ShowCarsInGarage()
        {
            foreach (Car car in _carList)
            {
                Console.WriteLine("At {0} position stays {1} \n", _carList.IndexOf(car), car.ToString());
            }
        }
    }
}
