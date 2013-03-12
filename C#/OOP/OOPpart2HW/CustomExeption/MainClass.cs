using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CustomExeption
{
    class MainClass
    {
        static void Main()
        {
            
            try
            {
                TestWithInt();
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Time of error: "+e.ErrorTimeStamp);
                // Get stack trace for the exception with source file information
                var st = new StackTrace(e, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                Console.WriteLine("Exeption occur at line: "+line);
            }
            Console.WriteLine("--------------------------------------------------");
            try
            {
                TestWithDate();
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Time of error: " + e.ErrorTimeStamp);
                // Get stack trace for the exception with source file information
                var st = new StackTrace(e, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                Console.WriteLine("Exeption occur at line: " + line);
            }
            
        }
        public static void TestWithInt()
        {           
            int start = 0;
            int end = 100;

            for (int i = 0; i <= 101; i++)
            {
                if (i<start || i >end)
                {
                    throw  new InvalidRangeException<int>("int out of range", start, end);
                }
            }
        }
        public static void TestWithDate()
        {
            List<DateTime> someDates = new List<DateTime>();

            someDates.Add(new DateTime(2012,1,12));
            someDates.Add(new DateTime(2012, 10, 15));
            someDates.Add(new DateTime(2013, 3, 2));
            someDates.Add(new DateTime(2012, 12, 30));
            someDates.Add(new DateTime(2117, 1, 12)); // the out of range date
        
            DateTime startDate = new DateTime(2012,1,1);
            DateTime endDate = DateTime.Now;
            foreach (DateTime date in someDates)
            {
                if (date < startDate || date >endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date is Outside the target period", startDate, endDate);
                }
            }
        }
    }
}
