using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] array = new int[100];
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
               // Console.WriteLine(array[i]);
            }
            Array.Sort(array);

            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
