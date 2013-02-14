using System;

class FiveDigit
{
    static void Main()
    {
        string compar = Console.ReadLine();

        int num = 0;
        string[] str = new string[99999];
        string[] resultNums = new string[500];

        for (int i = 10000; i < 99999; i++)
        {
            str[i] = i.ToString().PadLeft(5,'0');
        }
        for (int i = 10000; i < 99999; i++)
        {
            if (((str[i][0] - '0' + str[i][2] - '0') == str[i][1] - '0') && ((str[i][2] - '0' + str[i][4] - '0') == str[i][3] - '0'))
            {
                //Console.WriteLine(i);

                num++;
                resultNums[num] = str[i];
                if (compar == str[i])
                {
                    break;
                }
            }
        }
        Console.WriteLine(num);
    }
}

