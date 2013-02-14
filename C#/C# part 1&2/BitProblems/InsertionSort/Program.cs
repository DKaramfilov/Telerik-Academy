using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] array = new int[10];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                // Console.WriteLine(array[i]);
            }

            int j;

            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
