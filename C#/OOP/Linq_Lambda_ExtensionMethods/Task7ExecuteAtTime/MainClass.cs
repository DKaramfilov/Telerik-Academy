using System;

namespace Task7ExecuteAtTime
{
    class MainClass
    {
        public static void Main()
        {
            Timer aTimer = new Timer(2000, 10);
            aTimer.CurrentMethods = TestMetnod;
            aTimer.Execute();
        }
        public static void TestMetnod()
        {
            Console.WriteLine("Message that appears every couple of seconds");
        }
    }
}
