using System;

class happyTicket
{
    static void Main()
    {
        string str = Console.ReadLine();

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < 3; i++)
        {
            sum1 += int.Parse(str[i].ToString());
            sum2 += int.Parse(str[i+3].ToString());
        }
        if (sum1 == sum2 && ((str[1]-'0') >(str[3]-'0')))
        {
            Console.WriteLine(sum2);
        }
        else if (sum2 != sum1)
        {
            Console.WriteLine(31);
        }
        else if (str[1] < str[3])
        {
            Console.WriteLine(32);
        }
        else
        {
            Console.WriteLine(30);
        }
    }
}

