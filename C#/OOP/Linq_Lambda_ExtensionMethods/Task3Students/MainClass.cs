using System;
using System.Linq;

namespace Task3Students //task 3,  4, and 5 at single project
{
    class MainClass
    {
        static void Main()
        {
            Student[] students = { new Student("Johnny","English",50), new Student("Bruce","Willis",20), 
                                     new Student("Brad","Pit",25), new Student("Quentin"," Tarantino",24),
                                 new Student("Sylvester","Stallone",19), new Student("Jason" ,"Statham",12),
                                 new Student("Sylvester","Andreev",19)};

            Console.WriteLine("Testing Task 3 ...................");
            var names = from s in students
                        where s.FName.CompareTo(s.LName) < 0
                        select s;

            foreach (Student name in names)
            {
                Console.WriteLine(name);   
            }
            Console.WriteLine();
            Console.WriteLine("Testing Task 4 ...................");
            var age = from s in students 
                      where s.Age >= 18 && s.Age <= 24 
                      select new{s1= s.FName, s2=s.LName} ;//made like this for exaple purpose

            foreach (var name in age)
            {
                Console.WriteLine(name.s1 +" " +name.s2);
            }
            Console.WriteLine();
            Console.WriteLine("Testing Task 5 ...................");
            Console.WriteLine("\nPrintig with lambda\n");
            var lambdaSorted = students.OrderByDescending(x => x.FName).ThenByDescending(x => x.LName);
            foreach (var name in lambdaSorted)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nPrinting wit LINQ\n");
            var sortedStudents = from s in students  orderby s.FName descending, s.LName descending select s;
            foreach (Student name in sortedStudents)
            {
                Console.WriteLine(name);
            }
        }
    }
}
