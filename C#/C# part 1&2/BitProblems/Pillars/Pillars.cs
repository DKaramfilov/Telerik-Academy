using System;

class Pillars
{
    static void Main()
    {
        int[] matrix =new int[8];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = int.Parse(Console.ReadLine());

        }
        int countL = 0;
        int countR = 0;
        bool hasPillar = false;

        for (int pillar = 7; pillar >=0 ; pillar--)
        {
            //left from pillar
            countL = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int bitpos = 7; bitpos > pillar; bitpos--)
                {
                    int bitValue = (matrix[i] >> bitpos) & 1;
                    if (bitValue == 1)
                    {
                        countL++;

                    }
                }

            }
            //Console.WriteLine("pill={0} countL={1}",pillar,countL);
            
            //right from pilar
            countR = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int bitpos = pillar-1; bitpos >= 0; bitpos--)
                {
                    int bitValue = (matrix[i] >> bitpos) & 1;
                    if (bitValue == 1)
                    {
                        countR++;

                    }
                }

            }
            // Console.WriteLine("pill={0} countR={1}", pillar, countR);
            //Console.WriteLine();
            if (countL == countR)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(countR);
                hasPillar = true;
                break;
            }          
        }
        if (hasPillar == false) Console.WriteLine("No");

    }
}

