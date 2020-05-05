using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace StripComments
{
    class ToDb : Algorithm
    {
        public static void InsertToDb()
        {
            using (ApplicationContext db = new ApplicationContext())
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
                db.Database.ExecuteSqlRaw("INSERT INTO InputTexts (Text) VALUES ({0})", text);
                Console.WriteLine("\n_____________________________________________________________");


                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Input comment symbol(Press Ctrl + Z to exit)");
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

                var jsymbols = JsonConvert.SerializeObject(commentSymbols);
                db.Database.ExecuteSqlRaw("INSERT INTO InputSymbols (Symbol) VALUES ({0})", jsymbols);
                Console.WriteLine("\n_____________________________________________________________");

                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Result:");
                string result = StripComments(text, commentSymbols);
                Console.WriteLine(result);
                db.Database.ExecuteSqlRaw("INSERT INTO Outputs (OutputText) VALUES ({0})", result);
                Console.WriteLine("\n_____________________________________________________________");
                Console.WriteLine("_____________________________________________________________\n");
            }
        }

    }
}
