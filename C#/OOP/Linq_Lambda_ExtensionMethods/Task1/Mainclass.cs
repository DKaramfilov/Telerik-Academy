using System;
using System.Linq;
using System.Text;

namespace Task1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Extending StringBuilder");
            Console.WriteLine(sb.SubString(10,13));

        }
    }
}
