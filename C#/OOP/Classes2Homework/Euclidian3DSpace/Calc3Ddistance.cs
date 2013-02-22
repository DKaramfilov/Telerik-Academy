using System;

namespace Euclidian3DSpace
{
    static class Calc3Ddistance
    {
        public static double CalcDistance(Point3D first, Point3D second)
        {
            double distance = 0;
            double deltaX = second.X - first.X;
            double deltaY = second.Y - first.Y;
            double deltaZ = second.Z - first.Z;

            distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));

            return distance;
        }
    }
}
