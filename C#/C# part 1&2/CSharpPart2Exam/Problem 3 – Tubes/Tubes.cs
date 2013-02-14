using System;

class Program
{
    static void Main()
    {
        int n = int.Parse( Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        
        int[] martoTubes = new int[n];
        for (int i = 0; i < n; i++)
        {
            martoTubes[i] = int.Parse(Console.ReadLine());          
        }
        int left = 1;
        int right = 2000000000;
        int posAnswer = (left + right) / 2;
        int coutnTubes = 0;
        int maxtube = -1;
        
        while (left <right)
        {
            coutnTubes = 0;
            for (int i = 0; i < n; i++)
            {
                coutnTubes += martoTubes[i] / posAnswer;
            }
            if (coutnTubes >=m)
            {
                left = posAnswer+1;
                maxtube = posAnswer;
            }
            else
            {
                right = posAnswer ;
            }
            posAnswer = (left + right) / 2;
        }
        Console.WriteLine(maxtube);
    }
}

