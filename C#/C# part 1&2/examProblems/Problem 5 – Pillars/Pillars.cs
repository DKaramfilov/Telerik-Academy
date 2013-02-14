using System;

class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int temp = int.Parse(Console.ReadLine());

            string str = Convert.ToString(temp, 2).PadLeft(8, '0');

            for (int col = 7; col >=0 ; col--)
            {
                if (str[col] == '1')
                {
                    matrix[row, col] = 1;
                }
            }
        }
  
        int leftSum = 0;
        int rightSum = 0;
        int pillarIndex=0;
        int count = 0;
        int finalSum = 0;
        

        for (int pillar = 1; pillar < 7; pillar++)
        {
            leftSum = 0;
            rightSum = 0;
            //left from pillar
            for (int col = 0; col < pillar; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        leftSum++;
                    }
                }
            }
            
            //chek rigt from pilarr
            for (int col = pillar+1; col < 8; col++)
            {
                for (int row = 0; row< 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        rightSum++;
                    }
                } 
            }
            

            if (leftSum == rightSum)
            {
                pillarIndex =7- pillar;
                finalSum = leftSum;
                count++;
            }
            
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(pillarIndex);
            Console.WriteLine(finalSum);
        }
        
    }
}

