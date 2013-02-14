using System;
using System.Collections.Generic;

class bus
{
    static void Main()
    {
        string nab = Console.ReadLine();
        string[] NAB = nab.Split(' ');

        int n = int.Parse(NAB[0]);
        int a = int.Parse(NAB[1]); 
        int b = int.Parse(NAB[2]);

        int[][] tickets = new int[n][];



        for (int row = 0; row < n; row++)
        {
            string temp = Console.ReadLine();
            string[] temp2 = temp.Split(' ');
            tickets[row] = new int[3];
            for (int col = 0; col < 3; col++)
            {
                tickets[row][ col] = int.Parse(temp2[col]);
            }
        }

        Sort<int>(tickets, 0);
        int startIndex = 0;
        int endIndex = 0;

        for (int row=0; row <n ; row++)
        {
            if (tickets[row][0] <= a && tickets[row][1] >= a) startIndex = row;
            if (tickets[row][0] <= b && tickets[row][1] >= b)
            {
                endIndex = row;
                break;
            }
        }
        int price = 0;

        for (int i = startIndex; i <= endIndex; i++)
        {
            price += tickets[i][2];
    
        }
        Console.WriteLine(price);
       
    }
    private static void Sort<T>(T[][] data, int col)
    {
        Comparer<T> comparer = Comparer<T>.Default;
        Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
    }
}

