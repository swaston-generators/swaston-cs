using System;
using System.Collections.Generic;

namespace SwastonGenerator
{
    public static class SwastonGenerator
    { 
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string FromString(string input)
        {
            List<string> lines = new List<string>();
            string space = new string(' ', 2 * input.Length - 3);
            string word = string.Join(" ", input.ToCharArray());
            lines.Add($"{input[input.Length - 1]}{space}{word}");
            for (int j = 1; j < input.Length - 1; j++)
            {
                lines.Add($"{input[input.Length - j - 1]}{space}{input[j]}");
            }
            lines.Add(word + Reverse(word).Substring(1));
            space += ' ';
            for (int j = input.Length - 2; j > 0; j--)
            {
                lines.Add(space + Reverse(lines[j]));
            }
            lines.Add(Reverse(lines[0]));
            return string.Join(Environment.NewLine, lines);
        }
    }
}
