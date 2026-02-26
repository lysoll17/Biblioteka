using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class FindBook
    {
        public static void Find()
        {
            Console.WriteLine("Podaj tytuł który chcesz wyszukać: ");
            string answer = Console.ReadLine();

            bool found = false;

            using (StreamReader reader = new StreamReader("dane.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.IndexOf(answer, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine (line);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Nie znaleziono danego tytułu");
                }
            }
           

            Menu.MainMenu();
        }
    }
}
