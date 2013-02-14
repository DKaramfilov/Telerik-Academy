using System;

class Chocolate2
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] nk = str.Split(' ');
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        string[] temp = Console.ReadLine().Split(' ');

        int[] chocos = new int[n];

        for (int i = 0; i < chocos.Length; i++)
        {
            chocos[i] = int.Parse(temp[i]);
        }

    }
}

