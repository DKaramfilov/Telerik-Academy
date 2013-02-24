using System;
using System.Collections.Generic;

namespace Generics
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Console.WriteLine(new string('-',30));
                Console.WriteLine("Testing Add");
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

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Testing Remove");

                //testList.Remove("gosho");
                //testList.Remove("mitko");
                
                testList.Remove(5);

                Console.WriteLine(testList);

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Testing Insert");

                testList.Insert("Joro", 2);
                testList.Insert("Pencho", 7);

                Console.WriteLine(testList);


                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Testing Indexer");
                
                testList[4] = "asigned using indexer";
                Console.WriteLine(testList[4]);
                Console.WriteLine(testList);

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Testing with invalid data");

                //testList.Insert("some text", 1000);
                //testList[100] = "does not matter";
                //Console.WriteLine(testList[500]);
                //testList.Remove("Not in list text");

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Testing Min And Max");
                Console.WriteLine(testList.Min());
                Console.WriteLine(testList.Max());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
