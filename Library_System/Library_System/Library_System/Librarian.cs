using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Librarian
    {
        private int LibrarianID;
        private string LibrarianName;
        private string LibrarianPassword;
        private string LibrarianEmail;
        private List<string> Requiredbooks;

        public  List<string> RequiredBooks { get => Requiredbooks; set => Requiredbooks = value; }

        public Librarian(int id, string _name, string _email, string _password)
        {
            LibrarianID = id;
            LibrarianName = _name;
            LibrarianPassword = _password;
            LibrarianEmail = _email;
            Requiredbooks = new List<string>();
        }
   
        public  void requestBookFromVendor(Vendor vendor)
        {
            List<Book> books = vendor.SupplyBooks(RequiredBooks);
            
                Library.addbooks(books);
            
        }

        public  void RemoveBook(string bookName)
        {
            Library.RemoveBooks(bookName);
        }

        public  void updateBookStatus(string bookName, bool status)
        {
            Library.updatebookStatus(bookName, status);
        }

   
    }
}
