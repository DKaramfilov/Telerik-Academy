using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleaveBits
{
    class Interleave
    {
         

        static void Main(string[] args)
        {
            uint[] B = { 0x55555555, 0x33333333, 0x0F0F0F0F, 0x00FF00FF };
            int[] S = { 1, 2, 4, 8 };

            uint x =15; // Interleave lower 16 bits of x and y, so the bits of x
            uint y =16; // are in the even positions and bits from y in the odd;
            uint z ; // z gets the resulting 32-bit Morton Number.  
                   // x and y must initially be less than 65536.

            x = (x | (x << 8)) & B[3];
            //Console.WriteLine(Convert.ToString(x,2).PadLeft(32,'0'));
            x = (x | (x << 4)) & B[2];
            x = (x | (x << 2)) & B[1];
            x = (x | (x << 1)) & B[0];
            Console.WriteLine(Convert.ToString(x, 2).PadLeft(32, '0'));

            y = (y | (y << 8)) & B[3];
            y = (y | (y << S[2])) & B[2];
            y = (y | (y << S[1])) & B[1];
            y = (y | (y << S[0])) & B[0];
            Console.WriteLine(Convert.ToString(y, 2).PadLeft(32, '0'));

            z = x | (y << 1);
            Console.WriteLine(Convert.ToString(z, 2).PadLeft(32, '0'));
        }
    }
}
