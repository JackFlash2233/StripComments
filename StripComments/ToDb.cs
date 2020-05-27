using System;
using ClassLibrary;


namespace StripComments
{
    class ToDb 
    {
        public static void InsertToDb()
        {
            using (DataContext db = new DataContext())
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
                //db.Database.ExecuteSqlRaw("INSERT INTO InputTexts (Text) VALUES ({0})", text);
                Console.WriteLine("\n_____________________________________________________________");


                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Input comment symbol(Input by space)");
                string commentSymbols = Console.ReadLine();
                

                //db.Database.ExecuteSqlRaw("INSERT INTO CommentSymbol (Symbol) VALUES ({0})", commentSymbols);
                Console.WriteLine("\n_____________________________________________________________");

                Console.WriteLine("_____________________________________________________________\n");
                Console.WriteLine("Result:");
                string result = Algorithm.StripComments(text, commentSymbols);
                Console.WriteLine(result);
                //db.Database.ExecuteSqlRaw("INSERT INTO OutputText (OutputText) VALUES ({0})", result);
                Data data = new Data
                {
                    InputText = text,
                    CommentSymbol = commentSymbols,
                    OutputText = result
                };
                db.Datas.Add(data);
                db.SaveChanges();
                Console.WriteLine("\n_____________________________________________________________");
                Console.WriteLine("_____________________________________________________________\n");
            }
        }

    }
}
