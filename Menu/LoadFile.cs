using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    internal class LoadFile
    {
        public static void Load()
        {
            if(!File.Exists("dane.txt"))
            {
                Console.WriteLine("Plik z danymi nie istnieje");
                return;
            }

            using(StreamReader reader = new StreamReader("dane.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');

                    Book book = new Book
                    {
                        Id = int.Parse(parts[0]),
                        Title = parts[1],
                        Author = parts[2],
                        Year = int.Parse(parts[3]),
                        Pages = int.Parse(parts[4]),
                    };

                    Library.books.Add(book);
                }
                Console.WriteLine("Dane zostały wczytane");
            }
            Menu.MainMenu();
        }
    }
}
