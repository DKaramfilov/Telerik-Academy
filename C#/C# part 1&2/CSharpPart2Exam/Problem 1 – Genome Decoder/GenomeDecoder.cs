using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split(' ');
        int n = int.Parse(temp[0]);
        int m = int.Parse(temp[1]);

        string genome = Console.ReadLine();
        StringBuilder decoded = new StringBuilder();
        StringBuilder num = new StringBuilder();

        for (int i = 0; i < genome.Length; i++)
        {
            num.Clear();
            while (i< genome.Length-1 &&(genome[i] != 'A' && genome[i] != 'G' && genome[i] != 'T' && genome[i] != 'C'))
            {
                num.Append(genome[i]);
                i++;
            }
            int t = 0;
            if (int.TryParse(num.ToString(), out t)) decoded.Append(new string(genome[i], t));
            else decoded.Append(genome[i]);
        }
        int maxRows = (int)Math.Ceiling((decimal)decoded.Length / (decimal)n);
        int padSize = maxRows.ToString().Length;

        StringBuilder result = new StringBuilder();

        for (int i = 1; i <=maxRows; i++)
        {
            result.Append(new string(' ', padSize - i.ToString().Length));
            result.Append(i);
            for (int j = (i - 1) * n; j <= i * n - 1; j++)
            {
                if ((j - (i - 1) * n) % m == 0) result.Append(' ');
                if (j >= decoded.Length) break;
                result.Append(decoded[j]);
            }
            result.AppendLine();
        }
        Console.WriteLine(result);
    }

}

