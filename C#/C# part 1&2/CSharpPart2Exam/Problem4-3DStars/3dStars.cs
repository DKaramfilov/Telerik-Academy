using System;

class Program
{
    static char[, ,] cube;
    static int starsCount = 0;
    static int[] coloursCount = new int[91];
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
        CalcStars();
        Console.WriteLine(starsCount);
        for (int i = 0; i < coloursCount.Length; i++)
        {
            if(coloursCount[i] !=0)
                Console.WriteLine("{0} {1}",(char)i,coloursCount[i]);
        }
        
    }
    static void CalcStars()
    {
        for (int w = 1; w < cube.GetLength(0)-1; w++)
        {
            for (int h = 1; h < cube.GetLength(1)-1; h++)
            {
                for (int d = 1; d < cube.GetLength(2)-1; d++)
                {
                    if (IsStar(w, h, d) == true)
                    {
                        starsCount++;
                        coloursCount[cube[w, h, d]]++;
                    }
                }
            }
        }
    }

    private static bool IsStar(int w, int h, int d)
    {
        int CC = cube[w, h, d];

        if (CC == cube[w - 1, h, d] && 
            CC == cube[w + 1, h, d] && 
            CC == cube[w, h - 1, d] && 
            CC == cube[w, h + 1, d] && 
            CC == cube[w, h, d - 1] && 
            CC == cube[w, h, d + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

