using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class LibraryMain
    {
        static void Main(string[] args)
        {
            //BookAuthor Author_1 = new BookAuthor("Mirosław",67, true, "Poland");
            //BookAuthor Author_2 = new BookAuthor("James", 95, false, "Sweden");

            //Book book = new Book("Andrzej", 500, "Piotr Kowalski", Author_1);
            //Book book_2 = new Book("Andrzej", 500, "Piotr Kowalski", Author_2);

           
            ////book.IsBookAvaliable();
            ////book.CheckOutBook();
            ////Console.WriteLine("----------------------");
            ////book.ReturnBook();

            //book.AuthorCountry();
            //book_2.AuthorCountry();
            /////////////////////////////////////////////////////////////////
            string AuthorJsonData = File.ReadAllText("Authors.json");        
            var Authors = JsonSerializer.Deserialize<List<BookAuthor>>(AuthorJsonData);

            if(Authors != null)
            {
                foreach (BookAuthor Author in Authors)
                {
                    string alive;
                    if (Author.IsAuthorAlive == true)
                        alive = "Author is still alive !!!";
                    else
                        alive = "Unfortunately this author passed away.";
                    Console.WriteLine($"Authors name: {Author.Name}, age: {Author.Age}, Country: {Author.Country}, Is this author still alive?: {alive}");
                }
                    
            }
        }
    }
}