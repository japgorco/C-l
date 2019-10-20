using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //form one-dimension array with length 50
            //array members are random from -100 to 100
            Random r = new Random();

            var a = FormArray(r);

            PrintArray(a);

            SortArray(a);

            PrintArray(a);

            System.Threading.Thread.Sleep(500000);
        }

        private static int[] FormArray(Random r)
        {
            //int[] a = new int[5];

            int[] a = new int[8] { 6,5,3,1,8,7,2,4};

            //for(int i = 0;i<a.Length;i++)
            //{
            //    a[i] = r.Next(-100, 100);
            //}

            return a;

        }

        private static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Array member at index = {0} is equal to {1}", i, a[i]);
            }
        }

        private static int[] SortArray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                int counter = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        int b = a[i];
                        int c = a[j];
                        a[i] = c;
                        a[j] = b;
                        counter++;
                    }
                }
            }

            return a;
        }
    }
}
