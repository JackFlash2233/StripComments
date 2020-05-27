using System;

namespace ClassLibrary
{
    public class Algorithm
    {
        public static string StripComments(string inputText, string commentSymbols)
        {
            string[] lines = inputText.Split("\n");
            string[] symbols = commentSymbols.Split(" ");

            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    int tmp = lines[j].IndexOf(symbols[i], StringComparison.Ordinal);

                    if (tmp >= 0)
                    {
                        lines[j] = lines[j].Substring(0, tmp).Trim();
                    }
                }
            }

            return String.Join("\n", lines);
        }
    }
}
