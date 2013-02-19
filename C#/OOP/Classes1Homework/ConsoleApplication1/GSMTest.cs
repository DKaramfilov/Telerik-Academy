using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1Homework
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] testCellPhones = {new GSM("Nokia","N95"),
                                    new GSM("iPhone","5S",2033.98m,"nobody"),
                                    new GSM("Samsung","B2207",200.90m,"Petko",new Battery(100,20,"MRE432",1100,BatteryType.Li_Poly),new Display(5.00f, "16M", "240x320", 100, true)),
                                    new GSM("HTC", "One", 1000.34m, "")};
            foreach (var item in testCellPhones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GSM.IPhone4S1);
            Console.WriteLine();
            GsmHistoryTest.TestingGsmCals();
        }
    }
    class GsmHistoryTest
    {
        public static GSM myPhone = new GSM("Samsung", "B2702");
        public static void TestingGsmCals()
        {
            myPhone.AddCall(new Call("999123456", 120, new DateTime(01/01/2013)));
            myPhone.AddCall(new Call("999233426", 100));
            myPhone.AddCall(new Call("992343456", 10,DateTime.Now));
            myPhone.AddCall(new Call("944444456", 20));
            myPhone.AddCall(new Call("995555556", 50));
            myPhone.AddCall(new Call("911111156", 10000));

            myPhone.PrintCallsHistory();

            decimal totalPrice = myPhone.CalculateCallsCosts(0.37m);
            Console.WriteLine("Total costs: "+totalPrice);
            myPhone.CallHistroy.Sort();
            Call longestCall = myPhone.CallHistroy.Last();

            myPhone.RemoveCall(longestCall);

            totalPrice = myPhone.CalculateCallsCosts(0.37m);
            Console.WriteLine("Total costs: " + totalPrice);

            myPhone.ClearAllCalls();
            myPhone.PrintCallsHistory();
        }
    }

}
