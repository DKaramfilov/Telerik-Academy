using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MainClass
    {
        static void Main()
        {
            Shape[] someShapes = { new Triangle(5,3),
                                   new Triangle(23,54),
                                   new Circle(5),
                                   new Circle(38),
                                   new Rectangle(5,4),
                                   new Rectangle(23 ,45)
                               };
            foreach (Shape figure in someShapes)
            {
                Console.WriteLine("This is {0} with surface of:{1:00.00}",figure.GetType(),figure.CalculateSurface() );
            }
        }
    }
}
