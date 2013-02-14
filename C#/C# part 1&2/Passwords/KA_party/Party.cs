using System;

class Party
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split(' ');
        string[] temp2 = Console.ReadLine().Split(' ');

        int startH = int.Parse(temp[0].ToString());
        int startM = int.Parse(temp[1].ToString());

        int endH = int.Parse(temp2[0].ToString());
        int endM = int.Parse(temp2[1].ToString());

        int totalSongs = ((endH - startH) * 60 + (endM - startM)) / 5;
        Console.WriteLine(totalSongs);

    }
}

