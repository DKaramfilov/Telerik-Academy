using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Student mitko = new Student("mitko","petrov", "ivanov",12343);
            mitko.FirstName = "mitko";
            mitko.Faculty = Faculty.FMI;

            Student vladko =(Student) mitko.Clone();
            mitko.Faculty = Faculty.CST;
            mitko.FirstName = "mdsadasdasd";

            Console.WriteLine(vladko.FirstName);
            Console.WriteLine(vladko.Faculty);
        }
    }
}
