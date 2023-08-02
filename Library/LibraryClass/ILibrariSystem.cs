using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LibraryClass
{
    interface ILibrariSystem
    {
        void AddNewBook(Book book);
        void RemoveNewBook(Book book);
        void SerchBook(BookSerchMdel bookSerch);
        void Brrow(Member member, Book book);
        void RegisterNewMember(Member member);
        void UnregisterNewMember(Member member);
    }
}
