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
            Console.WriteLine("4 - Zapisz do pliku");
            Console.WriteLine("5 - Wczytaj z pliku");
            Console.WriteLine("6. Zakończ program");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Book book = AddBook.Add();
                Library.books.Add(book);
            }
            else if (choice == 2)
            {
                ShowBooks.Show();
            }
            else if (choice == 3)
            {
                FindBook.Find();
            }
            else if(choice == 4)
            {
                Save.SaveFile();
            }
            else if(choice == 5)
            {

            }
            else if (choice == 6)
            {
                Environment.Exit(0);
            }
        }
    }
}
