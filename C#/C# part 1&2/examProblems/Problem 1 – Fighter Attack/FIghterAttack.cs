using System;

class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());

        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());

        int d = int.Parse(Console.ReadLine());

        int damage =0;
        fx += d;

        if (px1 > px2)
        {
            int t = px1;
            px1 = px2;
            px2 = t;
        }
        if (py1 > py2)
        {
            int t = py1;
            py1 = py2;
            py2 = t;
        }
        // check fx
        if ((fx >= px1 && fx <= px2) && (fy >= py1 && fy <= py2))
        {
            damage += 100;
        }
        // check fx up
        if ((fx >= px1 && fx <= px2) && ((fy+1) >= py1 && (fy+1) <= py2))
        {
            damage += 50;
        }
        //check down 
        if ((fx >= px1 && fx <= px2) && ((fy - 1) >= py1 && (fy - 1) <= py2))
        {
            damage += 50;
        }
        //check ahead
        if (((fx+1) >= px1 && (fx+1) <= px2) && (fy >= py1 && fy <= py2))
        {
            damage += 75;
        }
        Console.WriteLine("{0}%",damage);

    }
}

