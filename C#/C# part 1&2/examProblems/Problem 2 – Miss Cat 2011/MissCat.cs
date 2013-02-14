using System;

class MissCat
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int temp = 0;
        
        int[] arr = new int[10];
        
			
        for (int i = 0; i < n; i++)
        {
            temp = int.Parse(Console.ReadLine());

            switch (temp)
            {
                case 1: arr[0]++; break;
                case 2: arr[1]++; break;
                case 3: arr[2]++; break;
                case 4: arr[3]++; break;
                case 5: arr[4]++; break;
                case 6: arr[5]++; break;
                case 7: arr[6]++; break;
                case 8: arr[7]++; break;
                case 9: arr[8]++; break;
                case 10: arr[9]++; break;
            }
        }
        int max = arr[0];
        int maxi=0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxi = i;
            }
        }
        

        
        Console.WriteLine(maxi+1);
        
    }
}

