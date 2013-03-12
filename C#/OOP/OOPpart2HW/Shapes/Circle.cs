using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(int radius): base(radius*2,radius*2)
        {
        }
        public override double CalculateSurface()
        {
            return this.Width * Math.PI;
        }
    }
}
