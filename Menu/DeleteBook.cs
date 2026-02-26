using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class DeleteBook
    {
        public static void Delete()
        {
            Console.WriteLine("Podaj id ksiązki którą chcesz usunąc:");
            int answer = int.Parse(Console.ReadLine());

           foreach(Book book in Library.books)
           {
                if(book.Id == answer)
                {
                    Library.books.Remove(book);
                    Console.WriteLine("Usunięto daną książke");
                    break;
                }
            }

            Menu.MainMenu();
        }
    }
}
