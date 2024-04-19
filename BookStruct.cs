using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    struct Book
    {
        string Name;
        string Author;
        string ISBN;
        int PublishedYear;
        bool Available;
        public string name { get => Name; }
        public bool available { get => Available; }
        public Book(string name, string author, string iSBN, int publisheYear, bool available)
        {
            Name = name;
            Author = author;
            ISBN = iSBN;
            PublishedYear = publisheYear;
            Available = available;
        }
        public void AvailableBook()
        {
            Available = true;
        }
        public void UnavailableBook()
        {
            Available = false;
        }
    }
    struct User
    {
        string UserName;
        int UserId;
        List<Book> BorrowedBooks;
        public string userName { get => UserName; }
        public User(string userName, int Id)
        {
            UserName = userName;
            UserId = Id;
            BorrowedBooks = new List<Book>();
        }
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }
        public void ReturnBook(string BookName)
        {
            int t = 0;
            foreach (Book book in BorrowedBooks)
            {
                if (book.name == BookName)
                {
                    t = 1;
                    book.AvailableBook();
                    BorrowedBooks.Remove(book);
                }
            }
            if (t == 0)
            {
                Console.WriteLine("There is no book with that name");
            }
        }
        public void ListBorrowedBooks()
        {
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine(book.name);
            }

        }
    }
    class BookStruct
    {


    }
}
