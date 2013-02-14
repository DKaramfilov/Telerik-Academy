using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int countZero = 0;
        int countOne = 0;
        bool firstNOTzeroBit = false;

        for (int i = 0; i < n; i++)
        {
            uint temp = uint.Parse(Console.ReadLine());

            firstNOTzeroBit = false;
            countZero = 0;
            countOne = 0;

            for (int j = 31; j >=0; j--)
            {
                if ((((1<<j) & temp) >>j )==1)
                {
                    countOne++;
                    firstNOTzeroBit = true;
                }
                else if (firstNOTzeroBit == true)
                {
                    countZero++;
                }
            }
            if (b==1)
            {
                Console.WriteLine(countOne);
            }
            else
            {
                Console.WriteLine(countZero);
            }
        }     
    }
}

