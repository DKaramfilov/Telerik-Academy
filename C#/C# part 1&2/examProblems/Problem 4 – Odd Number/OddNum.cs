using System;

class OddNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        int[] arr = new int[10];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            
            //Console.WriteLine(Convert.ToString(arr[i],2).PadLeft(32,'0'));
            result ^= arr[i];
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32,'0'));
        }
        //Console.WriteLine(result); 
        
    }
}

