using BookStruct;
using System;

namespace _8Paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Super Knyga", "124");

            var book1 = new Book("Super Knyga", "124");

            book.TestProperty = 5;
            var value = book.TestProperty;
        }
    }
}
