using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class Save
    {
        public static void SaveFile()
        {
            using (StreamWriter writer = new StreamWriter("dane.txt", append: true))
            {
                foreach (Book book in Library.books)
                {
                    writer.WriteLine($"{book.Id} {book.Title} {book.Author} {book.Year} {book.Pages}");                    
                }
            }
            Console.WriteLine("Dane zostały zapisane do pliku");

            Menu.MainMenu();
        }
    }
}
