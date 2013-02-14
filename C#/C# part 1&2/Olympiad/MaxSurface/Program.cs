using System;


namespace MaxSurface
{
    class Program
    {
        static void Main()
        {
            decimal radius = decimal.Parse(Console.ReadLine());

            decimal y = radius + radius;
            decimal x = 0;
            decimal maxarea = 0;



            maxarea = (y * y) * (decimal)Math.Sin(90 * 0.0174532925);//0.0174532925

            x = maxarea / 4;
            x = Math.Round(x, 3);
          

            Console.WriteLine(x);
        }
    }
}
