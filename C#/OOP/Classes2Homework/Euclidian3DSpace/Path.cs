using System;
using System.Collections.Generic;

namespace Euclidian3DSpace
{
    class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
        }

        public void AddPointToPath(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }
        public void PrintPath()
        {
            foreach (var item in points)
            {
                Console.WriteLine(item);
            }
        }
    }
}
