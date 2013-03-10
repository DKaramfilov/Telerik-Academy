using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    class Tomcat: Cat, ISound
    {
        public Tomcat(string name, int age) : base(name,age,GenderType.Male) { }
        
        public void MakeSound()
        {
            Console.WriteLine("Tomcat meow");
        }
        
    }
}
