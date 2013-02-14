using System;

class MathExpression
{
    static void Main()
    {
        decimal m, n, p;

        n = decimal.Parse(Console.ReadLine());
        m = decimal.Parse(Console.ReadLine());
        p = decimal.Parse(Console.ReadLine());

        decimal result1 = (n * n) + (1 / (m * p)) + 1337;
        decimal result2 = n - 128.523123123m * p;

        decimal result3 = (decimal)Math.Sin(((int)m % 180));
        

        Console.WriteLine("{0:0.000000}",result1/result2 + result3);
    }
}

