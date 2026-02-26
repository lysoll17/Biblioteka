using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class  AddBook
    {
        public static int NextId = 1;
        public static Book Add()
        {
            
            Console.WriteLine("Podaj tytuł książki:");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj autora książki:");
            string author = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania książki:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe stron");
            int pages = int.Parse(Console.ReadLine());


            if (year <= 0 || year == null)
            {
                Console.WriteLine("Nieprawidłowy rok wydania. Rok musi być większy od 0.");
            }
            else if (pages <= 0 || pages == null)
            {
                Console.WriteLine("Nieprawidłowa liczba stron");
            }

            
            Book newBook = new Book
            {
                Id = NextId++,
                Title = title,
                Author = author,
                Year = year,
                Pages = pages
                
            };
            Library.books.Add(newBook);
            


            Console.WriteLine("Książka została dodana");
            Menu.MainMenu();
            return newBook;

        }
    }
}
