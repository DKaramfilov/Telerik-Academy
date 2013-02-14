using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
         

        BigInteger prev = int.Parse(Console.ReadLine());
        BigInteger mid = int.Parse(Console.ReadLine());
        BigInteger next = int.Parse(Console.ReadLine());

        BigInteger n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(prev);
        }
        else if (n==2)
        {
            Console.WriteLine(mid);
        }
        else if (n==3)
        {
            Console.WriteLine(next);
        }
        else
        {
            for (int i = 3; i < n; i++)
            {
                BigInteger sum = prev + mid + next;
                prev = mid;
                mid = next;
                next = sum;
            }
            Console.WriteLine(next);   
        }
        
    }
}

