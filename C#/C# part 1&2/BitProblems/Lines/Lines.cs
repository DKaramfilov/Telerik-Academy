using System;

class Lines
{
    static void Main()
    {
        int[] matrix = new int[8];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = int.Parse(Console.ReadLine());

        }

        int lineLen = 0;
        int maxLen = 0;
        int linesCount=0;

        for (int i = 0; i < 8; i++)
        {
            

            for (int bitNum = 7; bitNum >=0; bitNum--)
            {
                lineLen = 0;
                
                while (bitNum >=0 && ((matrix[i] >> bitNum) & 1)==1)
                {
                    lineLen++;
                    bitNum--;
                }
                if (maxLen == lineLen)
                {
                    linesCount++;
                }
                if (maxLen < lineLen)
                {
                    maxLen = lineLen;
                    linesCount = 1;
                }                               
            }            
            
            
        }
       
       
       
        for (int bitNum = 7; bitNum >=0 ; bitNum--)
        {         
            for (int i = 0; i < 8; i++)
            {
                lineLen = 0;
                
                while (i < 8 && ((matrix[i] >> bitNum) & 1) == 1)
                {
                    lineLen++;
                    i++;
                }
                if (maxLen == lineLen)
                {
                    linesCount++;
                }
                if (maxLen < lineLen)
                {
                    maxLen = lineLen;
                    linesCount = 1;
                }
            }
            
        }
        Console.WriteLine(maxLen);
        if (maxLen == 1) linesCount /= 2;

        Console.WriteLine(linesCount);
    }
}

