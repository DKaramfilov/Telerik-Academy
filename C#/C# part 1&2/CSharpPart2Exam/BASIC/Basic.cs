using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Basic
{
    static Variables vars = new Variables();
    static void Main()
    {
        StringBuilder temp = new StringBuilder();
        List<string> commands = new List<string>();

        string str;
        do
        {
            str = Console.ReadLine();
            if (str != "RUN")
            {
                commands.Add(str);
            } 

        } while (str != "RUN");
        executeLine(commands);
    }
    static void executeLine(List<string> Lines)
    {
        StringBuilder result = new StringBuilder();
        int[] lineNums = new int[Lines.Count];
        string[] commands = new string[Lines.Count];
        for (int i = 0; i < Lines.Count; i++)
        {
            string[] temp = Lines[i].Split(new char[] { ' ' }, 2);

            lineNums[i] = int.Parse(temp[0].Trim());
            commands[i] = temp[1];
        }
        for (int i = 0; i < commands.Length; i++)
        {

            string comand = commands[i];

            int print = comand.IndexOf("PRINT");
            int cls = comand.IndexOf("CLS");
            int stop = comand.IndexOf("STOP");
            int ifThen = comand.IndexOf("IF");
            int Goto = comand.IndexOf("GOTO");
            if (print != -1)
            {
                string s = comand.Substring(print + 5).Trim();
                result.AppendLine(ReturnVal(s).ToString());
                continue;
            }
            if (cls != -1)
            {
                result.Clear();
                continue;
            }
            if (stop != -1)
            {
                
                break;
            }
            if (ifThen != -1)
            {
                string condition = comand.Substring(ifThen + 2, comand.IndexOf("THEN") - ifThen - 2).Trim();
                if (Goto != -1)
                {
                    int goToLine = int.Parse(comand.Substring(Goto + 4).Trim());
                    if (Evaluate(condition) == true)
                    {
                        for (int j = 0; j < lineNums.Length; j++)
                        {
                            if (goToLine == lineNums[j])
                            {
                                i = j-1;
                            }
                        }
                    }
                }
                else
                {
                    if (Evaluate(condition) == true)
                    {
                        SumExpresion(comand.Substring(comand.IndexOf("THEN") + 4).Trim());
                    }
                }
                continue;
            }
            if (Goto != -1)
            {
                int goToLine = int.Parse(comand.Substring(Goto + 4).Trim());
                
                for (int j = 0; j < lineNums.Length; j++)
                {
                    if (goToLine == lineNums[j])
                    {
                        i = j - 1;
                        break;
                    }
                }
                continue;
                
            }
            SumExpresion(comand);


        }
        Console.WriteLine(result);
    }


    private static bool Evaluate(string condition)
    {
        int more = condition.IndexOf('>');
        int less = condition.IndexOf('<');
        int debug = ReturnVal("X");
        if (more != -1)
        {
            string[] operands = condition.Split('>');
            return ReturnVal(operands[0].Trim()) > ReturnVal(operands[1].Trim());
        }
        else if (less != -1)
        {
            string[] operands = condition.Split('<');
            return ReturnVal(operands[0].Trim()) < ReturnVal(operands[1].Trim());
        }
        else
        {
            string[] operands = condition.Split('=');
            return ReturnVal(operands[0].Trim()) == ReturnVal(operands[1].Trim());
        }
    }
    private static void SumExpresion(string str)
    {
        string[] temp = str.Split('=');
        string left = temp[0].Trim();
        string right = temp[1].Trim();
        switch (left)
        {
            case "X": vars.X = CalcRight(right); break;
            case "Y": vars.Y = CalcRight(right); break;
            case "Z": vars.Z = CalcRight(right); break;
            case "W": vars.W = CalcRight(right); break;
            case "V": vars.V = CalcRight(right); break;
        }
    }
    private static int ReturnVal(string s)
    {
        switch (s)
        {
            case "X": return vars.X;
            case "Y": return vars.Y;
            case "Z": return vars.Z;
            case "W": return vars.W;
            case "V": return vars.V;
            default: return int.Parse(s);
        }
    }

    private static int CalcRight(string right)
    {
        int plus = right.IndexOf('+');
        int minus = right.IndexOf('-');

        if (plus != -1)
        {
            string[] operands = right.Split('+');
            return ReturnVal(operands[0].Trim()) + ReturnVal(operands[1].Trim());
        }
        else if (minus > 0)
        {
            string[] operands = right.Split('-');
            return ReturnVal(operands[0].Trim()) - ReturnVal(operands[1].Trim());
        }
        else
        {
            return int.Parse(right);
        }
    }

}
class Variables
{
     public int X { get; set;} 
     public int Y { get; set;}
     public int Z { get; set;}
     public int W { get; set;}
     public int V { get; set;}
}
