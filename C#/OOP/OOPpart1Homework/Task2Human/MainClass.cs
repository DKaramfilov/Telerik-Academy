using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2Human
{
    class MainClass
    {
        static void Main()
        {
            List<Student> class2013 = new List<Student>();
            class2013.Add(new Student("Siobhan", "Finneran",6));
            class2013.Add(new Student("Colin", "Firth",4));
            class2013.Add(new Student("Marsha", "Fitzalan",5));
            class2013.Add(new Student("Jason", "Flemyng",63));
            class2013.Add(new Student("Barbara", "Flynn",23));
            class2013.Add(new Student("Bernard", " Fox",26));
            class2013.Add(new Student("Jessica", "French",35));
            class2013.Add(new Student("Edward", "Fox",14));
            class2013.Add(new Student("James", "Friel",100));
            class2013.Add(new Student("Laurence ", "Francis",87));
            class2013.Add(new Student("Martin", "Freeman",53));

            var sortedClass2013 = class2013.OrderBy(x =>  x.Grade);
            Console.WriteLine("Printig Students----------------------");
            foreach (Student student in sortedClass2013)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("--------------------------------------");

            List<Worker> microsoft = new List<Worker>();
            microsoft.Add(new Worker("Augus", "Good", 60,2));
            microsoft.Add(new Worker("Ming", " Briceno", 40,2));
            microsoft.Add(new Worker("Odaa", " Radcliff", 50,6));
            microsoft.Add(new Worker("Simone", "Schuelke", 630,8));
            microsoft.Add(new Worker("Tamiko", "Mixon", 230,8));
            microsoft.Add(new Worker("Edward", "Topping", 260, 8));
            microsoft.Add(new Worker("Lucius", "Bridwell", 350,8));
            microsoft.Add(new Worker("Keila", "Stebbins", 140,4));
            microsoft.Add(new Worker("Leah", "Empson", 1000,8));
            microsoft.Add(new Worker("Lorina", "Rix", 870,8));
            microsoft.Add(new Worker("Rashida", "Puleo", 530,6));

   
            var sortedBySalary = microsoft.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Printig Workers------------------------");
            foreach (Worker worker in sortedBySalary)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine("--------------------------------------");

            List<Human> aHumansList = new List<Human>();
            aHumansList.AddRange(microsoft);
            aHumansList.AddRange(class2013);

            var humansSortedByNames = aHumansList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);
            Console.WriteLine("Printig humans-------------------------");
            foreach (Human human in humansSortedByNames)
            {
                Console.WriteLine(human);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
