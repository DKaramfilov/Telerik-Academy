using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n-1; i++)
        {
            string dots = new string('.', (n - i) - 2);
            string stars = new string('*', (i * 2) + 1);
            Console.Write(dots);
            Console.Write(stars);
            Console.Write(dots);
            Console.WriteLine();
        }
        string fdots = new string('.',n-2);
        Console.Write(fdots+"*"+fdots);
    }
}

