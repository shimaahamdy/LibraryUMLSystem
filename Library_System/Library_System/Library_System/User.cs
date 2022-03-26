using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string email;
        private Dictionary<string, Book> books;

        public User(int id,string _name,string _email, string _password)
        {
            userID = id;
            userName = _name;
            password = _password;
            email = _email;
            books = new Dictionary<string, Book>();
        }
        

        public bool verfiy(string _password)
        {
            return password == _password;
        }
        public void searchBook(string bookName)
        {
            if(Library.Books.ContainsKey(bookName))
            {
                Console.WriteLine("This book exists");
            }
            else
            {
                Console.WriteLine("This book is not found");
            }
        }

        public int requestBook(string bookName)
        {
            if (Library.Books.ContainsKey(bookName))
            {
                if (Library.Books[bookName].takeBook())
                {
                    Console.WriteLine("Your request is successful");
                    books[bookName]=Library.Books[bookName];
                    Library.RemoveBooks(bookName);
                    return books[bookName].BookID;
                }
            }

                Console.WriteLine("Your request is failed");
                return -1;
            
        }

        public void cancelRequest(string bookName)
        {
            if (Library.Books.ContainsKey(bookName))
            {
                if (books.ContainsKey(bookName))
                {
                    Console.WriteLine("Your request is canceled");
                    Library.addbooks(bookName);
                    books.Remove(bookName);
                }
                else Console.WriteLine("Your request is failed");
            }
            else
                 Console.WriteLine("Your request is failed");
        }
    }
}