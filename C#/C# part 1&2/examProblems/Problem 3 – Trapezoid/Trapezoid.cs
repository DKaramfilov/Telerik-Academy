using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string stars = new string('*', n );
        string dot = new string('.', n );
        Console.WriteLine(dot+ stars);

        for (int i = 1; i <= n-1; i++)
        {
            
            string dots = new string('.', n - i);
            string indots = new string('.', (n - 2) + i);
            Console.WriteLine(dots+"*"+indots+"*");

        }
        stars = new string('*', n * 2);
        Console.WriteLine(stars);
    }
}

