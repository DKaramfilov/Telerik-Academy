using System;

class FishGlobe
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] input = str.Split(' ');

        int k = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int silver = k;
        int golden = 0;
        int prevgold = 0;

        for (int i = 2; i <= n; i++)
        {
            prevgold = golden;
            golden =golden + silver;
           
            silver =prevgold;


            
        }
       
        Console.WriteLine(golden);
    }
}

