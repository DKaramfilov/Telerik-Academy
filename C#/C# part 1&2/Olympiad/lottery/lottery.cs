using System;

class Program
{
    static void Main()
    {
        string temp = Console.ReadLine();

        int[] nums = new int[10];
        int lastSeq =0;

        for (int i = 0; i < temp.Length; i++)
        {
            int currDigit = int.Parse(temp[i].ToString());
            #region
            switch (currDigit)
            {
                case 1:
                    {
                        nums[1]++;
                        if (nums[1] == 2)
                        {
                            lastSeq = 1;
                            nums[1] = 0;
                        }
                        break;
                    }
                case 2:
                    {
                        nums[2]++;
                        if (nums[2] == 2)
                        {
                            lastSeq = 2;
                            nums[2] = 0;
                        }
                        break;
                    }
                case 3:
                    {
                        nums[3]++;
                        if (nums[3] == 2)
                        {
                            lastSeq = 3;
                            nums[3] = 0;
                        }
                        break;
                    }
                case 4:
                    {
                        nums[4]++;
                        if (nums[4] == 2)
                        {
                            lastSeq = 4;
                            nums[4] = 0;
                        }
                        break;
                    }
                case 5:
                    {
                        nums[5]++;
                        if (nums[5] == 2)
                        {
                            lastSeq = 5;
                            nums[5] = 0;
                        }
                        break;
                    }
                case 6:
                    {
                        nums[6]++;
                        if (nums[6] == 2)
                        {
                            lastSeq = 6;
                            nums[6] = 0;
                        }
                        break;
                    }
                case 7:
                    {
                        nums[7]++;
                        if (nums[7] == 2)
                        {
                            lastSeq = 7;
                            nums[7] = 0;
                        }
                        break;
                    }
                case 8:
                    {
                        nums[8]++;
                        if (nums[8] == 2)
                        {
                            lastSeq = 8;
                            nums[8] = 0;
                        }
                        break;
                    }
                case 9:
                    {
                        nums[9]++;
                        if (nums[9] == 2)
                        {
                            lastSeq =9;
                            nums[9] = 0;
                        }
                        break;
                    }
                case 0:
                    {
                        nums[0]++;
                        if (nums[0] == 2)
                        {
                            lastSeq = 0;
                            nums[0] = 0;
                        }
                        break;
                    }

            }
            #endregion
        }
        if (lastSeq == 0) Console.WriteLine("No");
        else Console.WriteLine(lastSeq);
    }
}

