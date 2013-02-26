using System;

namespace GenericMatrix
{
    class MainClass                         // look for task info in SolutionItems TaskInfo.txt
    {
        static void Main()
        {
            TestMatrixInt.Testing();
            TestMatrixDouble.Testing();

        }
        class TestMatrixInt
        {
            public static void Testing()
            {
                Matrix<int> matrix1 = new Matrix<int>(5);
                Matrix<int> matrix2 = new Matrix<int>(5);

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix1[i, j] = j;
                    }

                }
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix2[i, j] = j + 2;
                    }

                }
                Console.WriteLine(matrix1);
                Console.WriteLine();
                Console.WriteLine(matrix2);
                Console.WriteLine();
                //testing true operator
                if (matrix2)
                {
                    Console.WriteLine("No null elments");
                }
                Console.WriteLine();
                //testing +
                Console.WriteLine(matrix1 + matrix2);
                Console.WriteLine();
                //testing -
                Console.WriteLine(matrix2 - matrix2);
                Console.WriteLine();
                //testing *
                matrix2[3, 3] = 12345;
                Console.WriteLine(matrix1 * matrix2);
                Console.WriteLine();
            }
        }
        class TestMatrixDouble
        {
            public static void Testing()
            {
                Matrix<double> matrix1 = new Matrix<double>(5);
                Matrix<double> matrix2 = new Matrix<double>(5);

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix1[i, j] = j+ 0.12;
                    }

                }
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix2[i, j] = j + 2.56;
                    }

                }
                Console.WriteLine(matrix1);
                Console.WriteLine();
                Console.WriteLine(matrix2);
                Console.WriteLine();
                //testing true operator
                if (matrix2)
                {
                    Console.WriteLine("No null elments");
                }
                Console.WriteLine();
                //testing +
                Console.WriteLine(matrix1 + matrix2);
                Console.WriteLine();
                //testing -
                Console.WriteLine(matrix2 - matrix2);
                Console.WriteLine();
                //testing *
                matrix2[3, 3] = 12345;
                Console.WriteLine(matrix1 * matrix2);
                Console.WriteLine();
            }
        }
    }
}
