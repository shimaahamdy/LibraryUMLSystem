namespace Library_System
{
    public class program
    {
        public static User currentuser;
        //public static Librarian currentLibrarian;
        public static Vendor vendor = new(1, "vendor1", "vendor1@com", "012345698");
        public static Librarian librarian = new(1, "admin", "admin@com", "admin123");

        public static int counter = 0;
        public static void Main()
        {


            Console.Clear();


            if (counter == 0)
            {
                librarian.RequiredBooks.Add("book4");
                librarian.RequiredBooks.Add("book5");
                librarian.RequiredBooks.Add("book6");
                librarian.RequiredBooks.Add("book7");

                Book book4 = new Book(1, "book4", "author1", "cat1", true, 100, 5);
                Book book5 = new Book(2, "book6", "author2", "cat2", true, 100, 5);
                Book book6 = new Book(3, "book5", "author3", "cat3", true, 100, 5);
                vendor.AvailableBooks.Add("book4", book4);
                vendor.AvailableBooks.Add("book5", book5);
                vendor.AvailableBooks.Add("book6", book6);
                loaddate();
                counter++;
            }
           Console.WriteLine("Enter your password");
            string adminPassword = Console.ReadLine();
            if (adminPassword == "admin123")
            {
                menuLibrarian();
            }
            else
            {
                Console.WriteLine("1-login");
                Console.WriteLine("2-register");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        login();
                        break;

                    case 2:
                        Console.Clear();
                        Register();
                        break;
                }
            }
        }
        public static void login()
        {
            Console.Clear();
            Console.WriteLine("enter id:");
            int userID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter password:");
            string password = Console.ReadLine();
            Registeration.login(userID, password);

            if (currentuser != null)
            {
                menue();
            }
            else
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    login();
            }


        }
        public static void menue()
        {
            Console.Clear();
            Console.WriteLine("1-request book");
            Console.WriteLine("2-search book");
            Console.WriteLine("3-Cancel request");
            Console.WriteLine("4-log out");


            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("enter book name");
                    string book = Console.ReadLine();
                    currentuser.requestBook(book);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menue();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter book name");
                    book = Console.ReadLine();
                    currentuser.searchBook(book);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menue();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("enter book name");
                    book = Console.ReadLine();
                    currentuser.cancelRequest(book);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menue();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("logged out");
                    currentuser = null;
                    Main();
                    break;
                case 0:
                    Console.Clear();
                    menue();
                    break;


            }


        }
        public static void menuLibrarian()
        {
            Console.Clear();
            Console.WriteLine("1-request book from vendor");
            Console.WriteLine("2-remove book");
            Console.WriteLine("3-update book status");
            Console.WriteLine("4-Display books");
            Console.WriteLine("5-log out");


            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("request book");
                    librarian.requestBookFromVendor(vendor);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menuLibrarian();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter book name");
                    string book = Console.ReadLine();
                    librarian.RemoveBook(book);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menuLibrarian();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("enter book name");
                    book = Console.ReadLine();
                    Console.WriteLine("enter book status");
                    bool status = Convert.ToBoolean(Console.ReadLine());
                    librarian.updateBookStatus(book, status);
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menuLibrarian();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("show books");
                    showBooks();
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0) menuLibrarian();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("logged out");
                    Main();
                    break;
                case 0:
                    Console.Clear();
                    menuLibrarian();
                    break;


            }


        }
        public static void Register()
        {
            Console.Clear();
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("email");
            string email = Console.ReadLine();
            Console.WriteLine("password");
            string password = Console.ReadLine();
            Registeration.registerUser(id, name, email, password);
            menue();
        }
        public static void loaddate()
        {
            Registeration.registerUser(1, "mohamed", "mohamed@gmail.com", "1234");
            Registeration.registerUser(2, "Ahmed", "ahmed@gmail.com", "1234");
            Registeration.registerUser(3, "riham", "riham@gmail.com", "1234");

            Book book1 = new Book(1, "book1", "author1", "cat1", true, 100, 5);
            Book book2 = new Book(2, "book2", "author2", "cat2", true, 100, 5);
            Book book3 = new Book(3, "book3", "author3", "cat3", true, 100, 5);




            List<Book> li = new List<Book>();
            li.Add(book3);
            li.Add(book2);
            li.Add(book1);
            Library.addbooks(li);

        }

        public static void showBooks()
        {
            foreach (var book in Library.Books)
            {
                book.Value.displayInfo();
            }
        }
    }
}