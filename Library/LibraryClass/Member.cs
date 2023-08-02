using System.Collections.Generic;

namespace Library.LibraryClass
{
    public class Member : Person
    {
        public Member(string Name, string LName) : base(Name, LName)
        {
        }

        public List<Book> Books { get; set; }
    }
}
