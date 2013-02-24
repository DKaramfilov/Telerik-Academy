using System;
using System.Collections.Generic;

namespace Generics
{
    class MainClass
    {
        static void Main(string[] args)
        {

            GenericList<string> testList = new GenericList<string>(5);
            testList.Add("mitko");
            testList.Add("pesho");
            testList.Add("gosho");
            testList.Add("sharo");
            testList.Add("balkan");
            testList.Add("pesho");
            testList.Add("gosho");
            testList.Add("sharo");
            testList.Add("balkan");
            
            Console.WriteLine(testList);

            //testList.Remove("gosho");
            //testList.Remove("mitko");

            //Console.WriteLine(testList);

            testList.Insert("joro", 2);
            Console.WriteLine(testList);
            GenericList<int> someInts = new GenericList<int>();
            someInts.Insert(5, 5);
            Console.WriteLine(someInts);
        }
    }
}
