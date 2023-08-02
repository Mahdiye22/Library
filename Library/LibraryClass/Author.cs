using System.Collections.Generic;

namespace Library.LibraryClass
{
    public class Author : Person
    {
        public Author(string Name, string LName) : base(Name, LName)
        {
        }

        public List<BookDefention> Book { get; set; }
    }
}
