using System;

class SubsetSum
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long[] nNums = new long[n];

        for (int i = 0; i < nNums.Length; i++)
        {
            nNums[i] = long.Parse(Console.ReadLine());
        }

        
        int countSums = 0;
        int maxI=((int)Math.Pow(2,n)) -1;
        


        for (int i = 1; i <= maxI; i++)
        {
            long curSum = 0;
            for (int j = 0; j <n; j++)
            {
                int mask = 1 << j;
                int nMask = i & mask;
                int bit = nMask >> j;
                if (bit == 1) curSum += nNums[j];
            }
            if (curSum == s)
            {
                countSums++;
            }
        }
        Console.WriteLine(countSums);
    }
}

