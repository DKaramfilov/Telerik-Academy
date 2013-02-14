using System;

class Lines3D
{
    static char[, ,] cube;
    static int w = 0, h = 0, d = 0;
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        w = int.Parse(input[0]); h = int.Parse(input[1]); d = int.Parse(input[2]);
        cube = new char[w, h, d];

        for (int y = 0; y < h; y++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int z = 0; z < d; z++)
            {
                for (int x = 0; x < w; x++)
                {
                    cube[x, y, z] = temp[z][x];
                }
            }
        }

        int MaxLen = 0;
        int bestLen = 0;
        int lenCount = 0;
        
        #region straithLines
        
        for (int z = 0; z < d; z++)
        {
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    MaxLen = 1;
                    while (y < h - 1 && cube[x, y, z] == cube[x, y + 1, z])
                    {
                        MaxLen++;
                        y++;
                    }
                    if (bestLen == MaxLen)
                    {
                        lenCount++;
                    }
                    if (bestLen < MaxLen)
                    {
                        bestLen = MaxLen;
                        lenCount = 1;
                    }
                }
            }

        }
        for (int z = 0; z < d; z++)
        {
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    MaxLen = 1;
                    while (x < w - 1 && cube[x, y, z] == cube[x + 1, y, z])
                    {
                        MaxLen++;
                        x++;
                    }
                    if (bestLen == MaxLen)
                    {
                        lenCount++;
                    }
                    if (bestLen < MaxLen)
                    {
                        bestLen = MaxLen;
                        lenCount = 1;
                    }
                }
            }

        }
        for (int x = 0; x < w; x++)
        {
            for (int y = 0; y < h; y++)
            {
                for (int z = 0; z < d; z++)
                {
                    MaxLen = 1;
                    while (z < d - 1 && cube[x, y, z] == cube[x, y, z + 1])
                    {
                        MaxLen++;
                        z++;
                    }
                    if (bestLen == MaxLen)
                    {
                        lenCount++;
                    }
                    if (bestLen < MaxLen)
                    {
                        bestLen = MaxLen;
                        lenCount = 1;
                    }
                }
            }

        }
        
        #endregion
        for (int z = 0; z < d; z++)
        {
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    MaxLen = 1;
                    while (x < w && y < (h-y))
                    {
                        x++;
                        y++;
                        while ((x < w && y < (h-y)) && (cube[x - 1, y - 1, z] == cube[x, y, z]))
                        {
                            MaxLen++;
                            if (bestLen == MaxLen)
                            {
                                lenCount++;
                            }
                            if (bestLen < MaxLen)
                            {
                                bestLen = MaxLen;
                                lenCount = 1;
                            }
                            x++;
                            y++;
                        }
                    }
                }
            }

        }
        if (bestLen <= 1) Console.WriteLine(-1);
        else Console.WriteLine(bestLen + " " + lenCount);
    }
}

