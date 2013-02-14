using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        

        for (int i = 0; i < n; i++)
        {
            string dots1 = new string('.', i);
            string dots2 = new string('.', (n-1)-i);
            Console.WriteLine("{0}*{1}",dots1,dots2);
        }

        for (int i = n-2; i >=0; i--)
        {
            string dots1 = new string('.', i);
            string dots2 = new string('.', (n-1)-i);
            Console.WriteLine("{0}*{1}",dots1,dots2);
        }
    }
}

