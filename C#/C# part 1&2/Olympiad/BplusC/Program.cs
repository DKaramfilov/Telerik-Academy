using System;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        string str  = Console.ReadLine();

        int[] array = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            array[i] = int.Parse(str[i].ToString());
        }
        //insertion sort; 
        int j;

        for (int i = 1; i < array.Length; i++)
        {
            int value = array[i];
            j = i - 1;
            while ((j >= 0) && (array[j].CompareTo(value) > 0))
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = value;
        }

        string temp = "";
        for (int i = array.Length - 1; i >= 0; i--)
        {
            temp += array[i].ToString();
        }
        BigInteger c = BigInteger.Parse(temp);
        //Console.WriteLine(c);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                int t = array[i];
                array[i] = array[0];
                array[0] = t;
                break;
            }
        }

        temp ="";
        for (int i = 0; i < array.Length; i++)
        {
           
            temp += array[i].ToString();
        }
        BigInteger b = BigInteger.Parse(temp);
        Console.WriteLine(b+c);       
    }
}

