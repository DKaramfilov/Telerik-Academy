using System;

namespace GenericMatrix
{
    class MainClass
    {
        static void Main()
        {
            Matrix<int> matrix1 = new Matrix<int>(5);
            Matrix<int> matrix2 = new Matrix<int>(5);

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i,j]= j;
                }
                
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = j+2;
                }

            }

            if (matrix1)
            {
                Console.WriteLine("No null elments");
            }
        }
    }
}
