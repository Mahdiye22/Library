using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LibraryClass
{
    public class Book
    {
        public int Code { get; set; }
        public DateTime BrrowTime { get; set; }
        public bool IsAvailable { get; set; }

    }
}
