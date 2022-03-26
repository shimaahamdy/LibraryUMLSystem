using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System
{
    public static class Library
    {
        static int libraryID;
        static string libraryName;
        static string libraryLocation;
        static Dictionary<string, Book> books;
        
       
        static Library()
        {
            libraryID = 3525;
            libraryName = "freedom country";
            libraryLocation = "25 cairo Egypt";
            books = new Dictionary<string, Book>();
        }

        public static Dictionary<string, Book> Books { get => books; }

        public static void addbooks(List<Book> _books)
        {
            for(int i=0;i<_books.Count;i++)
            {
                if(Books.ContainsKey(_books[i].BookName))
                {
                    Books[_books[i].BookName].updatebookCount();
                }
                else
                {
                    Book newBook = new Book(_books[i].BookID, _books[i].BookName, _books[i].AuthorName, _books[i].Category, _books[i].Status, _books[i].Price, _books[i].BookCount);
                    Books[_books[i].BookName] = newBook;

                }
            }


        }
        // for canceling the request
        public static void addbooks(string _books)
        {
      
                if (Books.ContainsKey(_books))
                {
                    Books[_books].updatebookCount();
                }

            else
            {
                Console.WriteLine($"{_books} is not found");

            }

        }

        public static void RemoveBooks(string book_Name)
        {
            if (Books.ContainsKey(book_Name))
            {
                Books[book_Name].takeBook();
            }

            else
            {
                Console.WriteLine("This book is not found");
            }
        }

        public static void updatebookStatus(string book_name, bool status)
        {
            if (Books.ContainsKey(book_name))
            {
                Books[book_name].updateStatus(status);
            }

            else
            {
                Console.WriteLine("This book is not found");
            }
        }
    }
}