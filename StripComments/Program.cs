using System;

namespace StripComments
{
    class Program
    {

        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] words = text.Split("\n");

            for (int i = 0; i < commentSymbols.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {

                    int tmp = words[j].IndexOf(commentSymbols[i]);

                    if (tmp >= 0)
                    {
                        words[j] = words[j].Substring(0, tmp).Trim();
                    }

                }

            }

            return String.Join("\n", words);

        }

        static void Main(string[] args)
        {

            Console.WriteLine(StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
            Console.WriteLine(StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }

    }
}
