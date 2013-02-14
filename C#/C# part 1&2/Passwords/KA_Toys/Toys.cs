using System;

class Toys
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ') ;

        int s = int.Parse(str[0].ToString());
        int s1 = int.Parse(str[1].ToString());
        int s2 = int.Parse(str[2].ToString());
        int s3 = int.Parse(str[3].ToString());

        s1 = s / s1;
        s2 = s / s2;
        s3 = s / s3;
        

        if (s1 > s2 && s1 > s3) Console.WriteLine(s1);
        else if (s2 > s1 && s2 > s3) Console.WriteLine(s2);
        else if (s3 > s2 && s3 > s1) Console.WriteLine(s3);


    }
}

