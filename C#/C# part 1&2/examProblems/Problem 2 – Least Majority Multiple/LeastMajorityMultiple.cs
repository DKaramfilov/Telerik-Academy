using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        

        for (int i= 1;  ; i++)
        {
            int atLeast = 0;

            if (i % e == 0) atLeast++;
            if (i % d == 0) atLeast++;
            if (i % c == 0) atLeast++;
            if (i % b == 0) atLeast++;
            if (i % a == 0) atLeast++;
            if (atLeast >=3)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

