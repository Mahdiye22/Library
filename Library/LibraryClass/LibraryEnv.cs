using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LibraryClass
{
    partial class program
    {
        public class LibraryEnv
        {
            public void Run()
            {
                Book HarryPater = new Book();
                DateTime time = new DateTime(2022,11,5);
                HarryPater.IsAvailable = true;
                HarryPater.BrrowTime = time;
                LibrarySystem librarySystem = new LibrarySystem();
                librarySystem.AddNewBook(HarryPater);
            }

        }



    }
}
