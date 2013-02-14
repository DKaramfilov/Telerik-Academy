using System;

class marks
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] nk = str.Split(' ');
        int n = int.Parse(nk[0]);
        int m = int.Parse(nk[1]);

        int[,] grades = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            string temp = Console.ReadLine();
            for (int col = 0; col < m; col++)
            {
                grades[row, col] = int.Parse(temp[col].ToString());
            }
        }

        int maxGade = 0;
        int bestStud = 0;
        int secGrade = 0;
        int index = 0;
        int[] students= new int[n];
        bool isGood = true;


        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n; row++)
            {
                maxGade = grades[row,col];
                isGood = false;
                for (int i = 0; i < n; i++)
                {
                    
                    if(maxGade >grades[i,col])
                    {
                        isGood = true;
                       
                    }
                }
                if (isGood==true)
                {
                    students[row]++;
                }
            }
                
        }

        for (int i = 0; i < n; i++)
        {
            if (students[i] != 0) bestStud++;
        }
        if (n == 1) bestStud++;
        Console.WriteLine(bestStud);
        

    }
}

