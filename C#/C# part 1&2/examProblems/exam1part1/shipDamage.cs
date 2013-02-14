using System;

    class ShipDamage
    {
        static void Main()
        {
            int sX1, sY1,sX2,sY2, H, c1X, c1Y, c2X, c2Y, c3X, c3Y;
            int damage = 0;

            sX1 = int.Parse(Console.ReadLine());
            sY1 = int.Parse(Console.ReadLine());

            sX2 = int.Parse(Console.ReadLine());
            sY2 = int.Parse(Console.ReadLine());

            H = int.Parse(Console.ReadLine());

            c1X = int.Parse(Console.ReadLine());
            c1Y = int.Parse(Console.ReadLine());

            c2X = int.Parse(Console.ReadLine());
            c2Y = int.Parse(Console.ReadLine());

            c3X = int.Parse(Console.ReadLine());
            c3Y = int.Parse(Console.ReadLine());


            c1Y = 2 * H - c1Y;

            c2Y = 2 * H - c2Y;

            c3Y = 2 * H - c3Y;

            if (sX1 > sX2)
            {
                int t = sX1;
                sX1 = sX2;
                sX2 = t;
            }
            if (sY1 > sY2)
            {
                int t = sY1;
                sY1 = sY2;
                sY2 = t;
            }
            //sx1 min
            //sy2 max
            //c1
            if (c1X > sX1 && c1X < sX2 && c1Y > sY1 && c1Y < sY2)
            {
                damage += 100;
            }
            if ((c1X == sX1 || c1X == sX2) && (c1Y > sY1 && c1Y < sY2))
            {
                damage += 50;
            }
            if ((c1Y == sY1 || c1Y == sY2) && (c1X > sX1 && c1X < sX2))
            {
                damage += 50;
            }
            if ((c1X == sX1 || c1X == sX2) && (c1Y == sY1 || c1Y == sY2))
            {
                damage += 25;
            }

            //c2
            if (c2X > sX1 && c2X < sX2 && c2Y > sY1 && c2Y < sY2)
            {
                damage += 100;
            }
            if ((c2X == sX1 || c2X == sX2) && (c2Y > sY1 && c2Y < sY2))
            {
                damage += 50;
            }
            if ((c2Y == sY1 || c2Y == sY2) && (c2X > sX1 && c2X < sX2))
            {
                damage += 50;
            }
            if ((c2X == sX1 || c2X == sX2) && (c2Y == sY1 || c2Y == sY2))
            {
                damage += 25;
            }
            //c3
            if (c3X > sX1 && c3X < sX2 && c3Y > sY1 && c3Y < sY2)
            {
                damage += 100;
            }
            if ((c3X == sX1 || c3X == sX2) && (c3Y > sY1 && c3Y < sY2))
            {
                damage += 50;
            }
            if ((c3Y == sY1 || c3Y == sY2) && (c3X > sX1 && c3X < sX2))
            {
                damage += 50;
            }
            if ((c3X == sX1 || c3X == sX2) && (c3Y == sY1 || c3Y == sY2))
            {
                damage += 25;
            }
            
            Console.WriteLine("{0}%",damage);
        }
    }

