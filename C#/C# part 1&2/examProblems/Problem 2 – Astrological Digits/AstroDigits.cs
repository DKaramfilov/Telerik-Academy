using System;

class AstroDigits
{
    static void Main()
    {

        string n = Console.ReadLine();
        string[] n1 = n.Split('.');
        ulong sum=0;
        int j;

        if (n1[0][0] == '-')
        {
            j = 1;

        }
        else
        {
            j = 0;
        }

        for (int i = 0; i < n1.Length; i++)
        {
            for ( ; j  < n1[i].Length; j ++)
            {
                sum += ulong.Parse(n1[i][j].ToString());                
            }                     
        }
        while (sum > 9)
        {
            ulong newSum = 0;
            while (sum > 0)
            {
                ulong lastDigit = sum % 10;
                newSum += lastDigit ;
                sum /= 10;
            }
            sum = newSum;
        }
        Console.WriteLine(sum);
    }
}

