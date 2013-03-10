using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    class MainClass
    {
        static void Main()
        {
            Tomcat tom = new Tomcat("mitko",45);
            Dog vladko = new Dog("vladko", 23, GenderType.Male);
            Frog froggy = new Frog("groggy", 12, GenderType.Female);
            Cat sharo = new Cat("sharo", 42, GenderType.Female);
            Kitten lora = new Kitten("lora", 90);

            tom.MakeSound();
            vladko.MakeSound();
            froggy.MakeSound();
            sharo.MakeSound();
            lora.MakeSound();
            Console.WriteLine();
            sharo.SetGender(GenderType.Unknown);
            lora.SetGender(GenderType.Unknown);
            Console.WriteLine(sharo.Gender);
            Console.WriteLine(lora.Gender);
        }
    }
}
