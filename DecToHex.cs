using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter numer in decimal format:");
        int num = int.Parse(Console.ReadLine());
        string hex="";
        
        while (num > 0)
        {
            hex = Hex(num % 16) + hex;
            
            num /= 16;
        }
        Console.WriteLine(hex);
    }
    static string Hex(int i)
    {    
        switch (i)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 0:
                return i.ToString(); break;
            case 10: return "A"; break;
            case 11: return "B"; break;
            case 12: return "C"; break;
            case 13: return "D"; break;
            case 14: return "E"; break;
            case 15: return "F"; break;
            default: return ""; break;
        }
    }
}

