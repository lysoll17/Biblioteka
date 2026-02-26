using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Biblioteka
{
    internal class ShowBooks
    {
        public static void Show()
        {
            if(Library.books == null)
            {
                Console.WriteLine("Lista nic nie zawiera");
                return;
            }
            Library.Sort();

            foreach (var book in Library.books)
            {
                Console.WriteLine($"Id: {book.Id} Tytuł: {book.Title}, Autor: {book.Author}, Year: {book.Year}, Pages: {book.Pages}");
            }

            Menu.MainMenu();
        }
    }
}
