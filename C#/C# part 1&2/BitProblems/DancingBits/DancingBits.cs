using System;
using System.Collections.Generic;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int len = 0;
        int seqCount = 0;
        int lastBit = -1;

        bool firstOne = false;

        

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            firstOne = false;

            for (int bitnum = 31; bitnum >=0 ; bitnum--)
            {
                int bitValue = (temp >> bitnum) & 1;
                if (bitValue == 1)
                {
                    firstOne = true;
                }
                if (firstOne)
                {
                    
                    
                    if (lastBit == bitValue)
                    {
                        len++;
                    }
                    else
                    {
                        if (len == k)
                        {
                            seqCount++;
                        }
                        len = 1;
                    }
                    lastBit = bitValue;
                }
               
            }
        }
        if (len == k)
        {
            seqCount++;
        }
        Console.WriteLine(seqCount);
    }
}

