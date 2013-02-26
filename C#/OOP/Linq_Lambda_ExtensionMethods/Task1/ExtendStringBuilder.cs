using System;
using System.Linq;
using System.Text;


namespace Task1
{
    public static class ExtendStringBuilder
    {
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            return new StringBuilder(input.ToString().Substring(index,length));
        }
    }
}
