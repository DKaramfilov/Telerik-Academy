using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint v = 15 ;
            uint c;

            //for (c = 0; v>0; v >>= 1)
            //{
            //    c += v & 1;
            //}

            //for (c = 0; v>0; c++)
            //{
            //    v &= v - 1; // clear the least significant bit set
            //}

            v = v - ((v >> 1) & 0x55555555);                    // reuse input as temporary
            v = (v & 0x33333333) + ((v >> 2) & 0x33333333);     // temp
            c = ((v + (v >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;

            Console.WriteLine(c);
        }
    }
}
