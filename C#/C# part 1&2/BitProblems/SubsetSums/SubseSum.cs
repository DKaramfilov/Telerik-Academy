using System;

class SubseSum
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] nums = new long[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        int maxI=((int)Math.Pow(2,n)) -1;

        long sum = 0;
        int countSums = 0 ;

        for (int i = 1; i <= maxI; i++)
        {
            sum = 0;
            for (int bitPos = 0; bitPos <n ; bitPos++)
            {
                int bitValue = (i >> bitPos) & 1;
                if (bitValue == 1)
                {
                    sum += nums[bitPos];
                }
            }
            if (sum == s)
            {
                countSums++;
            }
        }
        Console.WriteLine(countSums);
    }
}

