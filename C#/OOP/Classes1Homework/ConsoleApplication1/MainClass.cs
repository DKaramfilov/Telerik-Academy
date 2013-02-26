using System;
using System.Linq;

namespace Classes1Homework
{
    class MainClass
    {
        static void Main()
        {
            GsmTest.TestingGsmClass();
            
            Console.WriteLine();

            GsmHistoryTest.TestingGsmCalcs();
        }
    }
    class GsmTest
    {
        public static GSM[] testCellPhones = {new GSM("Nokia","N95"),
                                    new GSM("HTC","5S",2033.98m,"nobody"),
                                    new GSM("Samsung","B2207",200.90m,"Petko",new Battery("MRE432",100,20,1100,BatteryType.Li_Poly),new Display(5.00f, "16M", "240x320", 100, true)),
                                    new GSM("Samsung","B3207",250.90m,"Mitko",new Battery(1000,500),new Display(5.00f)),
                                    new GSM("HTC", "One", 1000.34m, "")};
        public static void TestingGsmClass()
        {
            foreach (var item in testCellPhones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
    class GsmHistoryTest
    {
        public static GSM myPhone = new GSM("Samsung", "B2702");
        public static void TestingGsmCalcs()
        {
            myPhone.AddCall(new Call("999123456", 120, new DateTime(01/01/2013)));
            myPhone.AddCall(new Call("999233426", 100));
            myPhone.AddCall(new Call("992343456", 10,DateTime.Now));
            myPhone.AddCall(new Call("944444456", 20));
            myPhone.AddCall(new Call("995555556", 50));
            myPhone.AddCall(new Call("911111156", 10000));

            myPhone.PrintCallsHistory();

            decimal totalPrice = myPhone.CalculateCallsCosts(0.37m);
            Console.WriteLine("Total costs: {0:C} ",totalPrice);
            myPhone.CallHistroy.Sort();
            Call longestCall = myPhone.CallHistroy.Last();

            myPhone.RemoveCall(longestCall);

            totalPrice = myPhone.CalculateCallsCosts(0.37m);
            Console.WriteLine("Total costs: {0:C}", totalPrice);

            myPhone.ClearAllCalls();
            myPhone.PrintCallsHistory();
        }
    }

}
