using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class MainClass
    {
        static void Main()
        {
            BitArray64 num = new BitArray64(15234);
            //test with foreach
            foreach (var item in num)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            //test indexer
            for (int i = 0; i < 64; i++)
            {
                Console.Write(num[63-i]);
            }
            Console.WriteLine();
            //compare to verify the rsult
            Console.WriteLine( Convert.ToString(15234, 2).PadLeft(64,'0'));
            //set any bit to zero or 1
            num[62] = 1;
            foreach (var item in num)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
