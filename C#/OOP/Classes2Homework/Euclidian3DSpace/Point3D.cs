using System;
using System.Linq;

namespace Euclidian3DSpace
{
    [Version(1,4)]
    struct Point3D
    {
        private int x;
        private int y;
        private int z;
        private static Point3D coordSystemStart = new Point3D();

        public static Point3D CoordSystemStart
        {
            get
            {
                return coordSystemStart;
            }
        }
        
        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public override string ToString()
        {
            return  string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }
    }
}
