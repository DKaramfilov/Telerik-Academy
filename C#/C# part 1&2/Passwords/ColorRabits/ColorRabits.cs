using System;

class ColorRabits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ulong[] rabits = new ulong[n];
        for (int i = 0; i < rabits.Length; i++)
        {
            rabits[i] = ulong.Parse(Console.ReadLine());
        }
        Array.Sort(rabits);

        ulong totalRabits = 0;

        for (int i = 1; i < rabits.Length; i++)
        {
            if (rabits[i - 1] == rabits[i])
            {
                totalRabits += rabits[i] + 1;
                i++;
            }
            else
            {
                totalRabits += rabits[i] + 1;
            }
        }
        if (n == 1) totalRabits++;

        Console.WriteLine(totalRabits);
    }
}

