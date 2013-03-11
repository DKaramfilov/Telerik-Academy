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

            Console.WriteLine("test sounds------------------");
            tom.MakeSound();
            vladko.MakeSound();
            froggy.MakeSound();
            sharo.MakeSound();
            lora.MakeSound();
            Console.WriteLine("-----------------------------");

            Dog[] dogHouse = {   new Dog("Camellia", 23, GenderType.Female),
                                 new Dog("Merrill", 54, GenderType.Female),
                                 new Dog("Jack", 12, GenderType.Male),
                                 new Dog("Jared", 21, GenderType.Male),
                                 new Dog("Malorie", 3, GenderType.Female),
                                 new Dog("Oretha", 6, GenderType.Female),
                                 new Dog("Diamond", 9, GenderType.Male),
                             };
            Cat[] catHouse = {   new Cat("Camellia", 13, GenderType.Female),
                                 new Cat("Merrill", 45, GenderType.Female),
                                 new Tomcat("Jack", 65),
                                 new Cat("Jared", 21, GenderType.Male),
                                 new Cat("Malorie", 33, GenderType.Female),
                                 new Kitten("Oretha", 16),
                                 new Cat("Diamond", 19, GenderType.Male),
                             };

            Frog[] frogHouse = { new Frog("Camellia", 33, GenderType.Female),
                                 new Frog("Merrill", 14, GenderType.Female),
                                 new Frog("Jack", 22, GenderType.Male),
                                 new Frog("Jared", 61, GenderType.Male),
                                 new Frog("Malorie", 31, GenderType.Female),
                                 new Frog("Oretha", 2, GenderType.Female),
                                 new Frog("Diamond", 1, GenderType.Male),
                               };
            Console.WriteLine("Test average ------------------");
            Console.WriteLine("Awerage age in dogHouse: {0:00.00}", Animal.AverageAge(dogHouse));
            Console.WriteLine("Awerage age in frogHouse: {0:00.00}" , Animal.AverageAge(frogHouse));
            Console.WriteLine("Awerage age in catHouse: {0:00.00}" , Animal.AverageAge(catHouse));
            Console.WriteLine("-------------------------------");

           

        }
    }
}
