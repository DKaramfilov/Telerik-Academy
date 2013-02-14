using System;

class picnic
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] input = str.Split(' ');
        int k = int.Parse(input[0]);
        int l = int.Parse(input[1]);
        int ml = int.Parse(input[2]);

        int result = (k * 400) / (l * 1000 + ml);
        if ((k * 400) % (l * 1000 + ml) != 0) result++;

        Console.WriteLine(result);

        
        
    }
}

