using System;

namespace Euclidian3DSpace              // look for task info in SolutionItems TaskInfo.txt
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("point zero: ");
            Console.WriteLine(Point3D.CoordSystemStart);
            Console.WriteLine();
            //Testing distnace class
            Console.WriteLine("Print some distances:");

            double dist1 = Calc3Ddistance.CalcDistance(new Point3D(1, 6, 5), new Point3D(4, 3, 5));
            Console.WriteLine("distance = {0:00.000} ",dist1);
            dist1 = Calc3Ddistance.CalcDistance(new Point3D(-1, 6, -5), new Point3D(4, -3, 5));
            Console.WriteLine("distance = {0:00.000} ", dist1);
            dist1 = Calc3Ddistance.CalcDistance(new Point3D(-10, 61, 52), new Point3D(124, 398, -545));
            Console.WriteLine("distance = {0:00.000} ", dist1);

            //Testing Path class
            Path path1 = new Path();
            path1.AddPointToPath(new Point3D(1, 2, 3));
            path1.AddPointToPath(new Point3D(1, 3, 4));
            path1.AddPointToPath(new Point3D(6, 3, 1));
            path1.AddPointToPath(new Point3D(7, 9, 13));
            path1.AddPointToPath(new Point3D(15, 24, 31));

            Console.WriteLine("Printing path1");
            path1.PrintPath();
            Console.WriteLine();

            //saveing path1 to file
            PathStorage.SavePathToFile("Saved Path.txt", path1, false);

            //load path1 from file
            Path loadedPath = PathStorage.LoadPathFromFile("Saved Path.txt");
            Console.WriteLine("printing loadedPath");
            loadedPath.PrintPath();

            // testing attributes
            Console.WriteLine("Testing attributes");
            Type t = typeof(Point3D);
            Type tVersion = typeof(Version);
            Version version = (Version)Attribute.GetCustomAttribute(t, tVersion);

            Console.WriteLine(version.CurrentVersion);
        }
    }
}
