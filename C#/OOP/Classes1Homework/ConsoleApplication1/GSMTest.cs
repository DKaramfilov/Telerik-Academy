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
        }
    }
}
