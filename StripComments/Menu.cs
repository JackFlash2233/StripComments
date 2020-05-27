using System;
using System.Linq;
using ClassLibrary;


namespace StripComments
{
    public class Menu 
    {
        public static void MainMenu()
        {
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("1. Strip comments(part 1)");
            Console.WriteLine("2. Show tests (part 1)");
            Console.WriteLine("3. Outputs from DB (last 5) (part 2)");
            Console.WriteLine("4. Input To Data Base new data (part 2)");
            Console.WriteLine("5. Exit");
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
            Console.WriteLine(Algorithm.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples",  "# !"));
            Console.WriteLine("\n.............................................................");
            Console.WriteLine("Test2:");
            Console.WriteLine("Text:");
            Console.WriteLine("a #b\nc\nd $e f g");
            Console.WriteLine("Comment Symbols: \"#\", \"$\" \n");
            Console.WriteLine("Results:");
            Console.WriteLine(Algorithm.StripComments("a #b\nc\nd $e f g",  "# $" ));
            Console.WriteLine("\n.............................................................");
            Console.WriteLine("Test3:");
            Console.WriteLine("Text:");
            Console.WriteLine("string1\nstring2%with symbols\nstring3 with some text ^  comments ");
            Console.WriteLine("Comment Symbols: \"%\", \"^\" \n");
            Console.WriteLine("Results:");
            Console.WriteLine(Algorithm.StripComments("string1\nstring2%with symbols\nstring3 with some text ^  comments ",  "% ^" ));
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
                Console.WriteLine("Input comment symbol(Input by space)");
                string commentSymbols = Console.ReadLine();

                Console.WriteLine("\n_____________________________________________________________");

                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Result:");
                Console.WriteLine(Algorithm.StripComments(text, commentSymbols));
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

        public static void FromDb()
        {

            

            using (DataContext db = new DataContext())
            {
                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Table Data:");

                var datas = db.Datas
                    .OrderByDescending(i => i.DataId)
                    .Take(5)
                    .ToList();
                foreach (var tmpData in datas)
                {
                    Console.WriteLine($"{tmpData.DataId}: InputText:\n" +
                                      $"{tmpData.InputText}\n" +
                                      "Comment Symbol\n" +
                                      $"{tmpData.CommentSymbol}\n" +
                                      "OutputText:\n" +
                                      $"{tmpData.OutputText}\n");
                }
                Console.WriteLine("_____________________________________________________________\n");
            }
        }
    }
}
