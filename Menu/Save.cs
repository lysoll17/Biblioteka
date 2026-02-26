using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Biblioteka
{
    internal class Save
    {
        public static void SaveToFile(Book book)
        {
            StreamWriter writer = new StreamWriter("dane.txt", append: true);
            writer.WriteLine($"{book.Title} {book.Author} {book.Year} {book.Pages}");
            writer.Close();
            Console.WriteLine("Zapisano");

            Start.Main();
        }
    }
}
