using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


class PHPVariables
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        string str;
        do
        {
            str = Console.ReadLine();
            text.AppendLine(str);
        } while (str != "?>");
        str = text.ToString();

        int start = str.IndexOf("/*");
        int end = str.IndexOf("*/");
        while (end != -1)
        {
            str = str.Remove(start, end - start);
            start = str.IndexOf("/*", start + 1);
            end = str.IndexOf("*/", end + 1);
        }
        start = str.IndexOf('#');
        while (start != -1)
        {
            str = str.Remove(start, str.IndexOf('\n', start) - start);
            start = str.IndexOf("#", start + 1);
        }
        start = str.IndexOf(@"//");
        while (start != -1)
        {
            str = str.Remove(start, str.IndexOf('\n', start) - start);
            start = str.IndexOf(@"//", start + 1);
        }
        
        str = Regex.Replace(str, @"[^\\][\\]\$\w*", "###", RegexOptions.Multiline);

        List<String> variables = new List<string>();
        foreach (var match in Regex.Matches(str, @"\$\w*"))
        {          
            variables.Add(match.ToString());
        }
        variables.Sort();
        for (int i = 1; i < variables.Count; i++)
        {
            if (variables[i - 1] == variables[i])
            {
                variables.RemoveAt(i - 1);
                i--;
            }
        }
        Console.WriteLine(variables.Count);
        foreach (var item in variables)
        {
            Console.WriteLine(item.Substring(1));
        }
    }
}

