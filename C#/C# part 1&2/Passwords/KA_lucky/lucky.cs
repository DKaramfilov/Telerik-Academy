using System;

class lucky
{
    static void Main()
    {
        string str = Console.ReadLine();
        string str2 = Console.ReadLine();

       
        int strFours = 0;
        
        int str2Fours = 0;
       

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != str2[i])
            {
                if (str[i] == '4')
                {
                    strFours++;
                }
                else
                {
                    str2Fours++;
                }
            }
            
        }
        int res = (str2Fours > strFours) ? str2Fours : strFours;

        Console.WriteLine(res); 
    }
}

