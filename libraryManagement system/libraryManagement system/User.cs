using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagement_system
{
    internal abstract class User
    {
        public string Name { get; set; }
        // it returns an array of object book
        public void DisplayBooks(Library library)
        {
            library.Display();
        }
    }
}
