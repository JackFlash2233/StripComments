using System;
using System.Linq;

namespace StripComments
{
    public class Program : Menu
    {
        
        static void Main()
        {
            /*
            Console.WriteLine("Strip Comments");
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("This is the solution which which strips all text \nthat allows any of a set of comments markers passed in.\nAny whitespace at the end of the line will be stripped out.");

            MainMenu();

            bool f = false;

            while (f == false)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());

                switch (tmp)
                {
                    case 1:
                        Task();
                        MainMenu();
                        break;
                    case 2:
                        ShowTests();
                        MainMenu();
                        break;
                    case 3:
                        f = true;
                        break;
                }
            }
            */

            using (ApplicationContext db = new ApplicationContext())
            {
                InputText inputText1 = new InputText { Text = "apples, pears # and bananas\ngrapes\nbananas !apples" };
                InputSymbol inputSymbol1 = new InputSymbol { Symbol = "#" };
                InputSymbol inputSymbol2 = new InputSymbol { Symbol = "!" };
                db.InputTexts.Add(inputText1);
                db.InputSymbols.Add(inputSymbol1);
                db.InputSymbols.Add(inputSymbol2);

                db.SaveChanges();

                Console.WriteLine("Saved");

                var inputTexts = db.InputTexts.ToList();
                Console.WriteLine("List of inputTexts:");
                foreach (InputText tmpInputText in inputTexts)
                {
                    Console.WriteLine($"{tmpInputText.InputTextId}. {tmpInputText.Text} ");
                }
                Console.WriteLine("_____________________________________________________________\n");

                var inputSymbols = db.InputSymbols.ToList();
                Console.WriteLine("List of inputSymbols:");
                foreach (InputSymbol tmpInputSymbol in inputSymbols)
                {
                    Console.WriteLine($"{tmpInputSymbol.InputSymbolId}. {tmpInputSymbol.Symbol}");
                }
                Console.WriteLine("_____________________________________________________________\n");

                var toStrips = db.ToStrips.ToList();
                Console.WriteLine("List of toStrips:");
                foreach (ToStrip tmpToStrip in toStrips)
                {
                    Console.WriteLine($"{tmpToStrip.ToStripId}. 1st sym:{tmpToStrip.InputTextId}; 2nd sym:{tmpToStrip.InputSymbolId}");
                }
                Console.WriteLine("_____________________________________________________________\n");

            }


        }

    }
}
