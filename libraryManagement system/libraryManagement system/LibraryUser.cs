using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagement_system
{

   internal class LibraryUser:User
    {
        public LibraryUser(string name)
        {
            Name=name;
        }
        public LibraryCard card { get; set; } 
        public void BorrowBook(Book book,Library library)
        {
            library.BorrowBook(book);
        }

        //public Book[] DisplayBooks()
        //{
        //        //Add logic later
        //}
    }
}
