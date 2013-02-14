using System;

class average
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] range = str.Split(' ');

        int m = int.Parse(range[0]);
        int n = int.Parse(range[1]);

        int count = 0;
        int sum = 0;
        if (m % 2 != 0) m++;
        if (n % 2 != 0) n--;

        sum = (m + n) /2;
        Console.WriteLine(sum);
    }
}

