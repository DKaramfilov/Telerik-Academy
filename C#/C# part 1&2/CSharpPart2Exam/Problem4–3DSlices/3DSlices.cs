using System;

class Program
{
    static int[, ,] cube;
    static void Main()
    {
        string cubeSize = Console.ReadLine();
        string[] sizes = cubeSize.Split();
        int w = int.Parse(sizes[0]);
        int h = int.Parse(sizes[1]);
        int d = int.Parse(sizes[2]);

        cube = new int[w, h, d];
        long totalSum = 0;

        for (int i = 0; i < h; i++)
        {
            string line = Console.ReadLine();
            string[] sequences = line.Split('|');
            for (int k = 0; k < d; k++)
            {
                string[] numbers = sequences[k].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int l = 0; l < w; l++)
                {
                    int cubeValue = int.Parse(numbers[l]);
                    cube[l, i, k] = cubeValue;
                    totalSum += cubeValue;
                }
            }
        }
        // PrintCube();
        long sum = 0;
        int count = 0;
        for (int x = 0; x < cube.GetLength(0)-1;x++)
        {
            for (int y = 0; y < cube.GetLength(1); y++)
            {
                for (int z = 0; z < cube.GetLength(2); z++)
                {
                    sum += cube[x, y, z];
                }

            }
            if ((sum + sum) == totalSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int y = 0; y < cube.GetLength(1)-1; y++)
        {
            for (int x = 0; x < cube.GetLength(0);x++)
            {
                for (int z = 0; z < cube.GetLength(2); z++)
                {
                    sum += cube[x, y, z];
                }

            }
            if ((sum + sum) == totalSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int z = 0; z < cube.GetLength(2)-1; z++)
        {
            for (int y = 0; y < cube.GetLength(1); y++)
            {
                for (int x = 0; x < cube.GetLength(0); x++)
                {
                    sum += cube[x, y, z];
                }

            }
            if ((sum + sum) == totalSum)
            {
                count++; 
            }
        }
        Console.WriteLine(count);
    }
    static void PrintCube()
    {
        for (int w = 0; w < cube.GetLength(0); w++)
        {
            for (int h = 0; h < cube.GetLength(1); h++)
            {
                for (int d = 0; d < cube.GetLength(2); d++)
                {
                    Console.Write(cube[w,h,d]);
                }
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
   
}

