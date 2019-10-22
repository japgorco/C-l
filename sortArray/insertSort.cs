using System;
using sortArray;

namespace sortArray
{
    class InsertSort
    {
        static void Main(string[] args)
        {
            //form one-dimension array with length 50
            //array members are random from -100 to 100
            Random r = new Random();

         //   var a = FormArray(r);

            var car = new Car();

            car.move(5);

            Console.WriteLine("Speed is " +car.checkSpeed().ToString());

            car.Stop();



            Console.ReadKey();

            // PrintArray(a);

            //  SortArray(a);

            // PrintArray(a);

            // System.Threading.Thread.Sleep(500000);
        }

        private static int[] FormArray(Random r)
        {
            int[] a = new int[50];

            //int[] a = new int[8] { 6,5,3,1,8,7,2,4};
            // 
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-100, 100);
            }

            return a;

        }

        private void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Array member at index = {0} is equal to {1}", i, a[i]);
            }
            Console.ReadKey();
        }

        private static int[] SortArray(int[] a)
        {
            for(int left = 0; left < a.Length; left++)
            {
                //берем значение текущего элемента
                int value = a[left];
                //перемещаемся по элементам кот. находятся перед текущим элементом
                int i = left - 1;

                for (; i >=0; i--)
                {
                    //если вытащили меньшее значение - передвигаем больший элемент дальше на одну позицию
                    if (value < a[i])
                    {
                        a[i + 1] = a[i];
                    }
                    //иначе если вытащенный элемент больше - выходим из внутреннего цикла
                    else break;
                }
                //в освободившееся место вставляем текущее значение
                a[i+1] = value;
            }

            return a;
        }
    }
}
