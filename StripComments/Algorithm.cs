using System;

namespace StripComments
{
    public class Algorithm
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] words = text.Split("\n");

            for (int i = 0; i < commentSymbols.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {

                    int tmp = words[j].IndexOf(commentSymbols[i], StringComparison.Ordinal);

                    if (tmp >= 0)
                    {
                        words[j] = words[j].Substring(0, tmp).Trim();
                    }

                }

            }

            return String.Join("\n", words);

        }

    }
}
