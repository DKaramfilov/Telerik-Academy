using System;

class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int temp = int.Parse(Console.ReadLine());

            string str = Convert.ToString(temp, 2).PadLeft(8, '0');

            for (int col = 7; col >= 0; col--)
            {
                if (str[col] == '1')
                {
                    matrix[row, col] = 1;
                }
            }
        }     
        int maxLen=0;
        int count = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col=0; col < 8; col++)
            {
                int len = 0;
                while (col < 8 && matrix[row, col] == 1)
                {
                    col++;
                    len++;
                    
                }
                if (len == maxLen) count++;
                if (len > maxLen)
                {
                    maxLen = len;
                    count = 1;
                }
            }
        }

      
        int max2 = maxLen;
        int count2 = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int len2 = 0;
                while (col < 8 && matrix[col, row] == 1)
                {
                    col++;
                    len2++;

                }
                if (len2 == max2) count++;
                if (max2 < len2)
                {
                    max2 = len2;
                    count = 1;
                }
            }
        }
        Console.WriteLine(max2);
        if (max2 == 1) Console.WriteLine(count/2);
        else Console.WriteLine(count );
       
       
        
        
    }
}

