using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Biblioteka
{
    internal static class Library
    {
       public static List<Book> books = new List<Book>();

        public static void Sort()
        {
            books.Sort((x,y) => x.Year.CompareTo(y.Year));
        }
    }
    
}
