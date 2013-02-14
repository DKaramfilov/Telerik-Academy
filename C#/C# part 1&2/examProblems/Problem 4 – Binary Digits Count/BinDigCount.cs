using System;

class BinDigCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            uint temp = uint.Parse(Console.ReadLine());

            string str = Convert.ToString(temp, 2);

            int countZeroes = 0;
            int countOnes = 0;

            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '1') countOnes++;
                else countZeroes++;
            }
            if (b == 0) Console.WriteLine(countZeroes);
            else Console.WriteLine(countOnes);     
        }
        
    }
}

