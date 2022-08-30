using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string BookName { get; set; }
        public int BookPages { get; set; }
        public string BookAuthor { get; set; }
        public bool IsCheckedOut { get; set; }
        public BookAuthor Author { get; set; }
        
        public Book(string bookName, int bookPages, string bookAuthor, BookAuthor author)
        {
            BookName = bookName;
            BookPages = bookPages;
            BookAuthor = bookAuthor;
            IsCheckedOut = false;
            Author = author;
        }

        public void IsBookAvaliable()
        {
            StringBuilder stringBuilder = new StringBuilder("Book");

            if (IsCheckedOut == false)
            {
                stringBuilder.Append(" available");
                Console.WriteLine(stringBuilder.ToString());
            }
            else
            {
                stringBuilder.Append(" unvailable");
                Console.WriteLine(stringBuilder.ToString());
            }
        }

        public void CheckOutBook()
        {
            if (IsCheckedOut == true)
                throw new InvalidOperationException("The book is already checked out");
            IsCheckedOut = true;
            Console.WriteLine("Checking the book out");
        }

        public void ReturnBook()
        {
            if (IsCheckedOut == false)
                throw new InvalidOperationException("The book was not checked out");
            IsCheckedOut = false;
            Console.WriteLine("Returning the book");
        }

        public void AuthorCountry()
        {
            switch (Author.Country)
            {
                case "Poland":
                    Console.WriteLine("Author is polish");
                    break;
                case "Sweden":
                    Console.WriteLine("Author is swedish");
                    break;
                case "Germany":
                    Console.WriteLine("Author is german");
                    break;
                case "Ukraine":
                    Console.WriteLine("Author is ukrainian");
                    break;
                default:
                    break;
            };
        }

    }
}
