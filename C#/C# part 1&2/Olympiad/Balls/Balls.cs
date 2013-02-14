using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();

        string[] nk = str.Split(' ');

        ulong n = ulong.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        ulong[] nums = new ulong[k];

        for (int i = 0; i < k; i++)
        {
            nums[i] = ulong.Parse(Console.ReadLine());
        }
        Array.Sort(nums);
        uint count = (uint)k;

        for (int i = 1; i < k; i++)
        {
            while (i < k && nums[i - 1] == nums[i])
            {
                count--;
                i++;
            }
            
        }
        Console.WriteLine(n-count);

    }
}

