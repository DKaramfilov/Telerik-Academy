using System;

class MaxWalk
{
    static int[, ,] cube;
    static void Main()
    {
        string cubeSize = Console.ReadLine();
        string[] sizes = cubeSize.Split();
        int w = int.Parse(sizes[0]);
        int h = int.Parse(sizes[1]);
        int d = int.Parse(sizes[2]);

        cube = new int[w, h, d];

        for (int i = 0; i < h; i++)
        {
            string line = Console.ReadLine();
            string[] sequences = line.Split('|');
            for (int k = 0; k < d; k++)
            {
                string[] numbers = sequences[k].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int l = 0; l < w; l++)
                {
                    short cubeValue = short.Parse(numbers[l]);
                    cube[l, i, k] = cubeValue;
                }
            }
        }

        int x = w / 2;
        int y = h / 2;
        int z = d / 2;
        long sum = cube[x,y,z];
        
        bool[, ,] visited = new bool[w, h, d];

        while (true)
        {
            visited[x, y, z] = true;
            int newX, newY, newZ, maxCount;

            maxCount = GetNextPos(x, y, z, out newX, out newY, out newZ);
            if (visited[newX, newY, newZ] || maxCount > 1)
            {
                // We fall into a loop (went into already visited position)
                break;
            }
            else
            {
                sum += cube[newX, newY, newZ];
                x = newX;
                y = newY;
                z = newZ;
            }

        }
        Console.WriteLine(sum);
    }

    private static int GetNextPos(int w, int h, int d, out int newW, out int newH, out int newD)
    {
        int oldPos = cube[w, h, d];
        cube[w, h, d] = int.MinValue;

        int maxValue = int.MinValue;
        int maxCount = 0;

        newW = 0;
        newH = 0;
        newD = 0;

        for (int nextW = 0; nextW < cube.GetLength(0); nextW++)
        {
            int value = cube[nextW, h, d];
            if (value == maxValue) maxCount++;
            if (value > maxValue)
            {
                maxValue = value;
                newW = nextW;
                newH = h;
                newD = d;
                maxCount = 1;
            }
        }
        for (int nextH = 0; nextH < cube.GetLength(1); nextH++)
        {
            int value = cube[w, nextH, d];
            if (value == maxValue)
            {
                maxCount++;
            }
            if (value > maxValue)
            {
                maxValue = value;
                newW = w;
                newH = nextH;
                newD = d;
                maxCount = 1;
            }
        }
        for (int nextD = 0; nextD < cube.GetLength(2); nextD++)
        {
            int value = cube[w, h, nextD];
            if (value == maxValue)
            {
                maxCount++;
            }
            if (value > maxValue)
            {
                maxValue = value;
                newW = w;
                newH = h;
                newD = nextD;
                maxCount = 1;
            }
        }
        cube[w, h, d] = oldPos;
        return maxCount;

    }
}

