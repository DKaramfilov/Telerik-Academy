using System;

class WeLoveBits
{
    static void Main()
    
    {
        int n = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < n; i++)
        {
            uint temp = uint.Parse(Console.ReadLine());
            uint result = 0;

            //Console.WriteLine(Convert.ToString(temp, 2));
            while (temp >0)
            {
                
                if ((temp & 1) == 1)
                {
                    result = (result | 1);
                    result <<= 1;
                }
                else
                {
                    //result = (result & 1);
                    result <<= 1;
                }
                temp >>= 1;
                //result <<= 1;
                
            }
            //Console.WriteLine(Convert.ToString(result, 2));
            Console.WriteLine(result >>=1);
        }
    }
}

