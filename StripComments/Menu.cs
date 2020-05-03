using System;


namespace StripComments
{
    public class Menu : Algorithm
    {
        public static void MainMenu()
        {
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("1. Strip comments");
            Console.WriteLine("2. Show tests");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\n_____________________________________________________________");

        }

        public static void ShowTests()
        {
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("Test1:");
            Console.WriteLine("Text:");
            Console.WriteLine("apples, pears # and bananas\ngrapes\nbananas !apples");
            Console.WriteLine("Comment Symbols: \"#\", \"!\" \n");
            Console.WriteLine("Results:");
            Console.WriteLine(StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" }));
            Console.WriteLine("\n.............................................................");
            Console.WriteLine("Test2:");
            Console.WriteLine("Text:");
            Console.WriteLine("a #b\nc\nd $e f g");
            Console.WriteLine("Comment Symbols: \"#\", \"$\" \n");
            Console.WriteLine("Results:");
            Console.WriteLine(StripComments("a #b\nc\nd $e f g", new[] { "#", "$" }));
            Console.WriteLine("\n.............................................................");
            Console.WriteLine("Test3:");
            Console.WriteLine("Text:");
            Console.WriteLine("string1\nstring2%with symbols\nstring3 with some text ^  comments ");
            Console.WriteLine("Comment Symbols: \"%\", \"^\" \n");
            Console.WriteLine("Results:");
            Console.WriteLine(StripComments("string1\nstring2%with symbols\nstring3 with some text ^  comments ", new[] { "%", "^" }));
            Console.WriteLine("\n_____________________________________________________________");
        }

        public static void Task()
        {
            Console.WriteLine("_____________________________________________________________\n");
            bool fin = false;

            while (fin == false)
            {

                Console.WriteLine("Input your text(Press Ctrl + Z to exit)");
                Console.WriteLine();
                string line;
                string text = "";

                do
                {
                    line = Console.ReadLine();

                    if (line != null)
                    {
                        text += "\n" + line;
                    }

                } while (line != null);
                Console.WriteLine("\n_____________________________________________________________");

                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Input comment symbol");
                string[] commentSymbols = new string[2];
                string sym;
                int k = 0;
                do
                {
                    sym = Console.ReadLine();
                    if (sym != null)
                    {
                        commentSymbols[k] = sym;
                        k++;
                    }

                } while (sym != null);
                Console.WriteLine("\n_____________________________________________________________");

                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Result:");
                Console.WriteLine(StripComments(text, commentSymbols));
                Console.WriteLine("\n_____________________________________________________________");
                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Again? 1 - Yes; 2 - No");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp == 2)
                {
                    fin = true;
                }

            }

        }
    }
}
