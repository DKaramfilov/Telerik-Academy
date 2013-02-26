using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            double[] nums = new double[50];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (i + 1) * 1.23456;
                
            }
            Console.WriteLine(String.Join(";",nums));
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Product());
            Console.WriteLine(nums.Average());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
        }
    }
}
