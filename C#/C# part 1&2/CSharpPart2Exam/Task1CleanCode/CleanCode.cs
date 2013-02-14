using System;
using System.Globalization;
using System.Text;
using System.Threading;

class CleanCode
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int nLines = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < nLines; i++)
		{
            sb.AppendLine(Console.ReadLine());
		}

        bool inString = false;
        bool inComment = false;
        bool inMultiComment = false;
        bool inMultiString = false;
        int index = 0;

        string str = sb.ToString();
        StringBuilder result =new StringBuilder();

        for(int c= 0; c< str.Length-1; c++)
        {
            if (str[c] == '\"' && inString == false && inComment==false)
            {
                inString = true;
            }
            else if(inString == true && str[c] == '\"' && str[c-1] !='\\')
            {
                inString = false;
                inComment = false;
            }
            //single line comment
            if (str[c] == '/' && str[c + 1] == '/')
            {
                inComment = true;
            }
            if (inComment == true && str[c] == '\n')
            {
                inComment = false;
            }
            // multiline comment
            if (str[c] == '/' && str[c + 1] == '*' && inString == false)
            {
                c = str.IndexOf("*/", c)+2;
            }
            //apend
            if ((inString == false) && (inComment == true))
            {
                continue;
            }
            else
            {
                result.Append(str[c]);
            }

            
            

        }
        
        string[] StrResult = result.ToString().Split(new char[] { '\n','\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in StrResult)
        {
            if (item.Trim() != "")
            {
                Console.WriteLine(item.TrimEnd());
            }
        }
        
    }

}

