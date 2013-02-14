using System;

class FallDown
{
    static void Main()
    {

        int[,] matrix = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int temp = int.Parse(Console.ReadLine());

            string str = Convert.ToString(temp, 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                if (str[col] == '1')
                {
                    matrix[row, col] = 1;
                }
            }
        }

        int prevRow = 0;

        for (int col = 0; col < 8; col++)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int row = 6; row >= 0; row--)
                {
                    prevRow = matrix[row, col];
                    if (matrix[row + 1, col] == 1 && prevRow == 0)
                    {
                        matrix[row, col] = 1;
                        matrix[row + 1, col] = 0;
                    }

                }
            }

        }
        string str1 = "";

        for (int i = 7; i >= 0; i--)
        {
            for (int j = 0; j < 8; j++)
            {
                str1 += matrix[i, j].ToString();
            }
            //Console.WriteLine(str1);
            Console.WriteLine(Convert.ToUInt32(str1, 2));

            str1 = "";

        }


    }
}



