using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class LibraryManagement
    {
        List<Book> Books = new List<Book>();
        List<User> Users = new List<User>();
        //Methods

        public void AddBook(Book book)
        {
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Author: ");
            string Author = Console.ReadLine();
            Console.Write("ISBN: ");
            string ISBN = Console.ReadLine();
            Console.Write("PublishedYear: ");
            int PublishedYear = Parser();
            Books.Add(new Book(Name, Author, ISBN, PublishedYear, true));
        }

        public void RegisterUser(User user)
        {
            Console.Write("UserName: ");
            string UserName = Console.ReadLine();
            Console.Write("UserId: ");
            int UserId = Parser();
            Users.Add(new User(UserName, UserId));
        }

        public void BorrowBook(string bookName, string userName)
        {
            if (GetUser(userName) != null)
            {
                User user = (User)GetUser(userName);
                foreach (Book book in Books)
                {
                    if (book.available == true)
                    {
                        if (book.name == bookName)
                        {
                            user.BorrowBook(book);
                            book.UnavailableBook();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not find such a username");
            }
        }

        public void ReturnBook(string bookName, string userName)
        {
            if (GetUser(userName) != null)
            {
                User user = (User)GetUser(userName);
                user.ReturnBook(bookName);
            }
            else
            {
                Console.WriteLine("Could not find such a username");
            }

        }

        public void ListAvailableBooks()
        {
            foreach (Book book in Books)
            {
                if (book.available == true)
                {
                    Console.WriteLine(book.name);
                }
            }
        }
        public void ListBorrowedBooks(string UserName)
        {
            if (GetUser(UserName) != null)
            {
                ((User)GetUser(UserName)).ListBorrowedBooks();

            }
            else
            {
                Console.WriteLine("there is not such a username");
            }
        }

        //my methods
        public static int Parser()
        {
            string x;
            int y = 0;
            int t = 0;
            while (true)
            {
                x = Console.ReadLine();

                try
                {
                    y = int.Parse(x);
                    t = 1;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
                if (t == 1)
                {
                    break;
                }

            }
            return y;
        }
        public User? GetUser(string UserName)
        {
            foreach (User user in Users)
            {
                if (user.userName == UserName)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
