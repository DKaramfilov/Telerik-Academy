using System;

class Guitar
{
    static void Main()
    {
        string input = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[] intervals = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] volume = new int[intervals.Length];

        for (int i = 0; i < intervals.Length; i++)
        {
            volume[i] = int.Parse(intervals[i]);
        }
        Console.WriteLine(MaxVolume(b,m,volume));

    }
    static int MaxVolume(int start, int max, int[] intervals)
    {
        int maxVol = -1;
        int[,] path = new int [intervals.Length+1,max+1];
        path[0,start] = 1;

        for (int row = 1; row <intervals.Length+1 ; row++)
        {
            int nextVol = intervals[row - 1];
            for (int col = 0; col < max+1; col++)
            {
                if (path[row - 1, col] == 1)
                {
                    if ((col - nextVol) >= 0)
                    {
                        path[row, col - nextVol] = 1;
                    }
                    if ((col + nextVol) <= max)
                    {
                        path[row, col + nextVol] = 1;
                    }
                }
                
            }
        }
        for (int i= max; i >=0; i--)
        {
            if (path[intervals.Length, i] == 1) 
            {
                maxVol=i;
                break;
            }
        }
        return maxVol;
    }
}

