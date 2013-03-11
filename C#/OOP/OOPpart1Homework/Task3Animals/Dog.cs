using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, GenderType gender) : base(name, age, gender) { }
        public void MakeSound()
        {
            Console.WriteLine("Dog bark");
        }
        public sealed override void SetGender(GenderType gender)
        {
            base.gender = gender;
        }
    }
}
