using System;

namespace StripComments
{
    class Program : Menu
    {
        
        static void Main(string[] args)
        {
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
            

        }

    }
}
