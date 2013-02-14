using System;

class BitShit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            string str = Convert.ToString(temp, 2);

            
            int[] bits = new int[32];
            

            for (int col = 0; col <str.Length ; col++)
            {
                if (str[col] == '1')
                {
                    bits[col] = 1;
                }
                
            }
            int result = 0;

            for (int col = 31; col >=0; col--)
            {
                result += bits[col] * (int)Math.Pow(2, col); 
            }
            Console.WriteLine(result);


        }
    } 
}

