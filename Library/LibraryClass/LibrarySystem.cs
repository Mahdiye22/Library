using System;

namespace Library.LibraryClass
{
    public class LibrarySystem : ILibrariSystem
    {
        public void AddNewBook(Book book)
        {
            //.....
        }
        public void RemoveNewBook(Book book)
        {
            //.....
        }
        public void SerchBook(BookSerchMdel bookSerch)
        {
            //......
        }
        public void Brrow(Member member,Book book)
        {
            //......
        }
        public void RegisterNewMember(Member member)
        {

        }
        public void UnregisterNewMember(Member member)
        {

        }
        public DateTime MembershipPeriod(Member member) 
        { 
            return DateTime.MinValue;
        }

    }
}
