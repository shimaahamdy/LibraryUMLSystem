using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System
{
    public class Book
    {
        private int bookID;
        private string bookName;
        private string authorName;
        private string category;
        private bool status;
        private int price;
        private int booksCount;

        public Book(int _bookID, string _bookname, string _author, string _cat, bool _stat, int _price, int _bookacout)
        {
            bookID = _bookID;
            bookName = _bookname;
            authorName = _author;
            category = _cat;
            status = _stat;
            price = _price;
            booksCount = _bookacout;

        }

        public int BookID
            {
            get { return bookID; }
            }
        public string BookName
        { get { return bookName; } }

        public string AuthorName
        {
                get { return authorName; }
        }
        public bool Status
        {
           get { return status; }
        }
        public string Category
        {
            get { return category; }
        }

        public int Price
        {
            get { return price;}
        }
        public int BookCount
        {
            get { return booksCount; }
        }
        public void updateStatus(bool isvaild)
        {
            status = isvaild;
        }

        public void displayInfo()
        {
            Console.WriteLine($"{bookName} by {authorName} category:{category} price:{price} count: {BookCount} status:{status}");
        }
        public bool takeBook()
        {
            if (status && booksCount >= 0)
            {
                booksCount--;
                return true;
            }
            else return false;
        }

        public void updatebookCount()
        {
            booksCount++;
        }
    }
}