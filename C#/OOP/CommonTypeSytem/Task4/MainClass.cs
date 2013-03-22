using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MainClass
    {
        static void Main()
        {
            Person mitko = new Person("Genadi", 23);
            Person pesho = new Person("Haralampi");

            Console.WriteLine(mitko);
            Console.WriteLine(pesho);
        }
    }
}
