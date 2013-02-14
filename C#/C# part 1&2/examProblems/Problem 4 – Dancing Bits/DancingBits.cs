using System;

class DancingBits
{
    static void Main()
    {
        int k =  int.Parse(Console.ReadLine());
        int n =  int.Parse(Console.ReadLine());

    
        int temp;
        string s="";
       

        for (int i = 0; i < n; i++)
        {
            temp =  int.Parse(Console.ReadLine());
            s += Convert.ToString(temp, 2);
        }
        s = "#"+s+"#"; 
        int oneCount = 0;
        int zeroCount =0;
        string ones = new string('1', k);
        string zeroes = new string('0', k);
        int index = -1;
    
        while (true)
        {
                index = s.IndexOf(ones, index + 1);
                if (index == -1)
                {
                    break;
                }
                if (s[index-1] != s[index] && s[index +k-1] != s[index +k])
                {
                    oneCount++;
                }
                
        }
        index = -1;
        while (true)
        {
            index = s.IndexOf(zeroes, index + 1);
            if (index == -1)
            {
                break;
            }
            if (s[index - 1] != s[index] && s[index + k - 1] != s[index + k])
            {
                zeroCount++;
            }

        }
        
        Console.WriteLine(oneCount +zeroCount);
    }
}

