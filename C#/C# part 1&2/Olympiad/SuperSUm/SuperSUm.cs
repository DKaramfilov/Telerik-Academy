using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSUm
{
    class SuperSUm
    {
        static void Main()
        {
            int n =3;
            int k = 2;

            int result = 0;

            for (int i =1; i <=n; i++)
            {
                result += ZeroToN(i);  
            }
            Console.WriteLine(result);
        }
        static int ZeroToN(int a)
        {
            int sum = 0;

            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            return sum;
        }
        

    }
}
