using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    class Kitten: Cat, ISound
    {
        
        public Kitten(string name, int age) : base(name, age, GenderType.Female) { }

        public void MakeSound()
        {
            Console.WriteLine("Kitten meow");
        }
        public sealed override void SetGender(GenderType gender)
        {
            Console.WriteLine("Kitten is Female");
            throw new NotImplementedException();
        }

        
    }
}
