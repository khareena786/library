using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class books
    {
        private string title;
        private string author;
        private int ISBN;

        public books(string title, string author, int ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN=ISBN;
        }

        public string booktitle
        {
            get { return title; }
        }
        public string bookauthor
        {
            get { return author; }

        }
        public int bookisbn
        {
            get { return ISBN; }
        }
         public string Tostring()
        {
            return ($"{title} ,{author},{ISBN}");
            
        }
 
        public class LibraryInventory<T> where T : Book
        {
            private List<T> books;

            public LibraryInventory()
            {
                books = new List<T>();
            }

            public void addbook(T book)
            {
                books.Add(book);
            }

            public void removebook(T book)
            {
                books.Remove(book);
            }

            public T bookby_ISBN(string isbn)
            {
                foreach (T b in books)
                {
                    if (b.ISBN == isbn)
                    {
                        return b;
                    }
                }
                return null; // Book not found
            }

            public void displaybooks()
            {
                foreach (T book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }

    }
}

