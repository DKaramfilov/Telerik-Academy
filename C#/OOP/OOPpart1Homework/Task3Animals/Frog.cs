using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    class Frog :Animal, ISound
    {
        public Frog(string name, int age, GenderType gender) : base(name, age, gender) { }
        public void MakeSound()
        {
            Console.WriteLine("Frog croak");
        }
        public override void SetGender(GenderType gender)
        {
            base.gender = gender;
        }
    }
}
