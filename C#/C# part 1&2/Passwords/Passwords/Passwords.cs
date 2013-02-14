using System;

class Passwords
{
    static void Main()
    {
        string str = Console.ReadLine();
        int count =0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '*') count++; 
        }
        Console.WriteLine(Math.Pow(2,count));

    }
}

