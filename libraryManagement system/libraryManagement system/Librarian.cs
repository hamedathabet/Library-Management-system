using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagement_system
{
    class Librarian:User
    {
        public int EmployeeNumber { get; set; }
        public void AddBook(Book newBook,Library library)
        {
            library.Add(newBook);
        }
        public Librarian(string name)
        {
            Name = name; 
        }
        public Librarian() { }
        
        public void RemoveBook(Book newBook, Library library)
        {
            library.Remove(newBook);
            


        }
    }
}
