using System;

class MiniPoker
{
    static void Main()
    {
        string temp = Console.ReadLine();
        string[] input = temp.Split(' ');

        int[] nums = new int[5];
        bool isConsecutive = true;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        Array.Sort(nums);
        for (int i = 0; i < nums.Length-1; i++)
        {
            if ((nums[i + 1] - 1) != nums[i]) isConsecutive = false;
        }
        if (isConsecutive == false)
        {
            Console.WriteLine(nums[nums.Length-1]);
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }
        }
    }

}

