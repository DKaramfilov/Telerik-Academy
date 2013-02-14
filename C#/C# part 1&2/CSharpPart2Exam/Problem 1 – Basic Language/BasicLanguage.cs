using System;
using System.Text;

class BasicLanguage
{
    static StringBuilder result = new StringBuilder();
    static void Main()
    {
        StringBuilder buffer = new StringBuilder();
        bool inBrackets = false;
        while (true)
        {
            int nextConsoleToken = Console.Read();
            if (nextConsoleToken == -1) break;
            char nextChar = (char)nextConsoleToken;
            if (nextChar =='(')
            {
                inBrackets = true;
            }
            if (nextChar ==')')
            {
                inBrackets = false;
            }
            if (nextChar == ';' && !inBrackets)
            {
                string statement = buffer.ToString();
                if (ProcessConstruct(statement)) break;             
                buffer.Clear();
            }
            else
            {
                if (inBrackets) buffer.Append(nextChar);
                else if(!char.IsWhiteSpace(nextChar)) buffer.Append(nextChar);
            }

        }
        Console.WriteLine(result);
    }

    static bool ProcessConstruct(string statement)
    {
        int count = 1;
        string[] comands = statement.Split(')');
        for (int i = 0; i < comands.Length; i++)
        {
            string cmd = comands[i];
            cmd = cmd.TrimStart();
            if (cmd.StartsWith("EXIT"))
            {
                return true;
            }
            else if (cmd.StartsWith("PRINT"))
            {
                int start = cmd.IndexOf('(') + 1;
                string content = cmd.Substring(start);
                if (content.Length > 0 && count>0)
                {
                    for (int c = 0; c < count; c++)
                    {
                        result.Append(content);
                    }
                }
            }
            else if (cmd.StartsWith("FOR"))
            {
                int start = cmd.IndexOf('(') + 1;
                int commaIndex = cmd.IndexOf(',');
                if (commaIndex == -1)
                {
                    string forCount = cmd.Substring(start);
                    count *= int.Parse(forCount);
                }
                else
                {
                    string forStartCount = cmd.Substring(start, commaIndex - start);
                    int startCount = int.Parse(forStartCount);
                    int endCount = int.Parse(cmd.Substring(commaIndex + 1));
                    count *= (endCount - startCount + 1);
                }
                 
            }
        }
        return false;
    }
}

