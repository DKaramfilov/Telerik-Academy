using System;

class FallDown
{
    static void Main()
    {
        int[] nums = new int[8];
        for (int i = 0; i < 8; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
       
        for (int i = 0; i < 8; i++)
        {
            for (int bitPos = 7; bitPos >0; bitPos--)
            {
                for (int bit = 0; bit <= 7; bit++)
                {
                    if ((nums[bitPos] >> bit & 1) == 0 &&
                        (nums[bitPos-1] >> bit & 1) == 1)
                    {
                        nums[bitPos] |= (1 << bit);
                        nums[bitPos-1] &= ~(1 << bit);
                    }
               }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}

