using System;

class FindingTheMode
{
    static Random rand = new Random();
    static void Main()
    {
        
        int[] array = new int[10];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] =  rand.Next(5);
            // Console.WriteLine(array[i]);
        }

        Array.Sort(array);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
        int hightFreq = 1;
        int mostFreq = 0;
        int currFreq = array[0];
        int index = 0;
        

        for (int i = 1; i < array.Length; i++)
        {
            
            if (currFreq != array[i])
            {
                mostFreq = 1;
            }
            else
            {
                mostFreq++;
            }
            if (hightFreq < mostFreq)
            {
                hightFreq = mostFreq;
                index=i;
            }
            currFreq = array[i];
        }

        Console.WriteLine(array[index]);
    }
}

