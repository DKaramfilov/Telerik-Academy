using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class DivisibleBy
    {
        static void Main()
        {
            int[] someNums = new int[200];

            for (int i = 0; i < someNums.Length; i++)
            {
                someNums[i] = i; 
            }
            //using lambda
            var lambdaDivisible = someNums.Where(x => (x % 7 == 0 && x % 3 == 0));
            Console.WriteLine("Using Lambda ............................");
            foreach (int num in lambdaDivisible)
            {
                Console.WriteLine(num);
            }
            //using LINQ
            Console.WriteLine("\nUsing Linq ............................");
           
            var divisible = from n in someNums where n % 7 == 0 && n % 3 == 0 select n;

            foreach (int num in divisible)
            {
                Console.WriteLine(num);
            }
        }
    }
}
