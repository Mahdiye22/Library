using System.Collections.Generic;

namespace Library.LibraryClass
{
    public class BookDefention
    {
        public int ID { get; set; }
        public int ISBN { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
        public int Quantity { get; set; }
        List<Category> Categories { get; set; }
    }
}
