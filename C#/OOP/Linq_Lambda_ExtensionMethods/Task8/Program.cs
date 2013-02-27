using System;
using System.Windows.Forms;
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute(10);
        }
        private static Timer interval;
        public static void Execute(int miliSeconds)
        {
            interval = new Timer();
            interval.Enabled = true;
            interval.Tick += new EventHandler(Method);
            interval.Interval = miliSeconds ;
            interval.Start();
        }
        private static void Method(object sender,EventArgs e)
        {
            TestMehod();
        }
        public static void TestMehod()
        {
            Console.WriteLine("Some Message");
        }
    }
}
