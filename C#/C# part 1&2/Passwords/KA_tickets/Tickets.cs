using System;

class Tickets
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        int num1 = int.Parse(str[0].ToString()) * 10 + int.Parse(str[4].ToString());

        int num2 = (int.Parse(str[1].ToString()) * 10 + int.Parse(str[2].ToString())) * 10 + int.Parse(str[3].ToString());

        if (num2 % num1 == 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(num2/num1);
        }
        else
        {
            Console.WriteLine("Sorry");
        }
        
        
    }
}

