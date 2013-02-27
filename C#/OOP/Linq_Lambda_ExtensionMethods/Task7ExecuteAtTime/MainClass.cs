using System;

namespace Task7ExecuteAtTime
{
    class MainClass
    {
        static void Main()
        {
            MethodTimer execute = new MethodTimer();
            execute.currentMethods += TestMetnod;
            execute.Start(2000);

            Console.WriteLine("Press the Enter key to exit the program.");
            Console.ReadLine();
        }
        public static void TestMetnod()
        {
            Console.WriteLine("Message that appears every couple of seconds" );
        }
    }
}
