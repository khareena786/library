using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static library.books;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryInventory<Book> library = new LibraryInventory<Book>();

            Book book1 = new Book("Book1", "Author1", 123456);
            Book book2 = new Book("Book2", "Author2", 789012);

            library.addbook(book1);
            library.addbook(book2);

            Console.WriteLine("All Books:");
            library.displaybooks();

            int isbnToFind = 123456;
            Book foundBook = library.bookby_ISBN(isbnToFind);
            if (foundBook != null)
            {
                Console.WriteLine("\nFound Book:");
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine($"\nBook with ISBN {isbnToFind} not found.");
            }
        }
    }
}
    

