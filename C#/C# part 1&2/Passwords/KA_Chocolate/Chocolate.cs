using System;

class Chocolate
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] nk = str.Split(' ');
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        string[] temp = Console.ReadLine().Split(' ');

        int[] chocos = new int[n];

        for (int i = 0; i < chocos.Length; i++)
        {
            chocos[i] = int.Parse(temp[i]);
        }
        
        int count=1;
        int len =0;
        int minLen=100000;

        for (int i = 1; i < chocos.Length; i++)
        { 
            len = 0;

            while (i<chocos.Length)
            {
                if (chocos[i - 1] != chocos[i])
                {
                    count++;
                }
                i++;
                len++;
                if (count == k)
                {
                    if (minLen > len && len>=k) minLen = len;
                    break;
                }
            }
            
            i -= len;
            
        }
        Console.WriteLine(minLen);
    }
}

