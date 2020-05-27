using System;

namespace StripComments
{
    
    public class Program 
    {
        
        static void Main()
        {
            
            Console.WriteLine("Strip Comments");
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("This is the solution which which strips all text \nthat allows any of a set of comments markers passed in.\nAny whitespace at the end of the line will be stripped out.");

            Menu.MainMenu();

            bool f = false;

            while (f == false)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());

                switch (tmp)
                {
                    case 1:
                        Menu.Task();
                        Menu.MainMenu();
                        break;
                    case 2:
                        Menu.ShowTests();
                        Menu.MainMenu();
                        break;
                    case 3:
                        Menu.FromDb();
                        Menu.MainMenu();
                        break;
                    case 4:
                        ToDb.InsertToDb();
                        Menu.MainMenu();
                        break;
                    case 5:
                        f = true;
                        break;
                }
            }
        }
    }
}
