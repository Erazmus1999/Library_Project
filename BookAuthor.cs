using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookAuthor
    {
        public string Name { get; }
        public int Age { get; set; }
        public bool IsAuthorAlive { get; }
        public string Country { get; }

        public BookAuthor(string name, int age, bool isAuthorAlive, string country)
        {
            Name = name;
            Age = age;
            IsAuthorAlive = isAuthorAlive;
            Country = country;
        }

        public static implicit operator BookAuthor((int, string, bool, string) v)
        {
            throw new NotImplementedException();
        }
    }
}
