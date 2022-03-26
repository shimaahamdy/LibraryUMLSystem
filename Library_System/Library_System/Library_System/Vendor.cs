using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System
{
    public class Vendor
    {
        private int VendorID;
        private string VendorName;
        private string VendorEmail;
        private string VendorPhoneNumber;
        private Dictionary<string, Book> availableBooks;


        public Vendor(int _vendorId, string _vendorName, string _vendorEmail,string _vendorPhoneNumber)
        {
            VendorID = _vendorId;
            VendorName = _vendorName;
            VendorEmail = _vendorEmail;
            VendorPhoneNumber = _vendorPhoneNumber;
            AvailableBooks = new Dictionary<string, Book>();
        }
        public Dictionary<string, Book> AvailableBooks { get => availableBooks; set => availableBooks = value; }

        public List<Book> SupplyBooks(List<string> bookName)
        {
            
           List<Book> books = SearchBooks(bookName);
            return books;

        }

        public List<Book> SearchBooks(List<string> bookName)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < bookName.Count; i++)
            {
                if(AvailableBooks.ContainsKey(bookName[i]))
                {
                    Console.WriteLine($"{bookName[i]} book is found");
                    books.Add(AvailableBooks[bookName[i]]);
                } 
                else
                {
                 Console.WriteLine($"{bookName[i]} book is not found");

                }

            }
            return books;
        }

    }
}