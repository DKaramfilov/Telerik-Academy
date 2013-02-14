using System;

class BombingCubes
{
    static char[, ,] cube;
    static int[] lettersHit = new int[91];
    static int totalHit = 0;
    const char Empty = '#'; 
    static void Main()
    {
        string cubeSize = Console.ReadLine();
        string[] sizes = cubeSize.Split();
        int w = int.Parse(sizes[0]);
        int h = int.Parse(sizes[1]);
        int d = int.Parse(sizes[2]);

        cube = new char[w, h, d];

        for (int i = 0; i < h; i++)
        {
            string line = Console.ReadLine();
            string[] sequences = line.Split(' ');
            for (int k = 0; k < d; k++)
            {
                for (int l = 0; l < w; l++)
                {
                    cube[l, i, k] = sequences[k][l];
                }
            }
        }
        int numBoms = int.Parse(Console.ReadLine());
        for (int i = 0; i < numBoms; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int bombW = int.Parse(temp[0]);
            int bombH = int.Parse(temp[1]);
            int bombD = int.Parse(temp[2]);
            int bombPower = int.Parse(temp[3]);

            Execute(bombW, bombH, bombD, bombPower);
            FallDownd();
        }
        PrintResult();
    }

    private static void PrintResult()
    {
        Console.WriteLine(totalHit);

        for (int i = 64; i < lettersHit.Length; i++)
        {
            if (lettersHit[i] != 0)
            {
                Console.WriteLine("{0} {1}",(char)i,lettersHit[i]);
            }
        }
    }
  
    private static void FallDownd()
    {
        for (int w = 0; w < cube.GetLength(0); w++)
        {
            for (int d = 0; d < cube.GetLength(2); d++)
            {
                FallDownPillar(w, d);
            }
        }
    }

    private static void FallDownPillar(int w, int d)
    {
        int h = cube.GetLength(1);
        int bottom = 0;
        for (int currentH = 0; currentH < h; currentH++)
        {
            if(cube[w,currentH,d] != Empty)
            {
                if (currentH != bottom)
                {
                    cube[w, bottom, d] = cube[w, currentH, d];
                    cube[w, currentH, d] = Empty;                  
                }
                bottom++;
            }
        }
    }

    static void Execute(int x, int y, int z, int p)
    {
        for (int w = 0; w < cube.GetLength(0); w++)
        {
            for (int h = 0; h < cube.GetLength(1); h++)
            {
                //if(x -p >=  w && x+p >=w) 
                for (int d = 0; d < cube.GetLength(2); d++)
                {
                    if (cube[w, h, d] != Empty)
                    {
                        int distSquare = GetDistanceSquared(w, h, d, x, y, z);
                        int pSquared = p * p;

                        if (distSquare <= pSquared)
                        {
                            char curent = cube[w, h, d];
                            lettersHit[(int)curent]++;
                            totalHit++;

                            cube[w, h, d] = Empty;
                        }
                    }
                }
            }
        }
    }

    private static int GetDistanceSquared(int w, int h, int d, int x, int y, int z)
    {
        int deltaW = w - x;
        int deltaH = h - y;
        int deltaD = d - z;

        return deltaW * deltaW + deltaH * deltaH + deltaD * deltaD; 
    }
}

