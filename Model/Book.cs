using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebSite
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string cover { get; set; }

        public Book() { }

        public Book(string t, string a, string c)
        {
            title = t;
            author = a;
            cover = c;
        }
    }
}
