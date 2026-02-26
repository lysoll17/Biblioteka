using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("1 - Dodaj książkę");
            Console.WriteLine("2 - Wyświetl wszystkie książki");
            Console.WriteLine("3 - Wyszukaj książkę");
            Console.WriteLine("4. Zakończ program");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Book book = AddBook.Add();
                Save.SaveToFile(book);

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {
                Environment.Exit(0);
            }
        }
    }
}
