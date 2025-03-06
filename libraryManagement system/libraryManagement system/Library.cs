using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagement_system
{
   internal class Library
    {
        //books are defined as private because the user shouldn't know how many books are stored
        //"Encapsulation"   
        private Book[] books =new Book[100];
        private Book[] borrowedBooks = new Book[50];
        private int currentBookCount=0;
        private int currentBorrowedBookCount = 0;


        public void Display()
        {
            for (int i = 0; i < currentBorrowedBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void Remove(Book book)
        {
            //هنا هو بيرجع العنصر بتاع الكتاب اللى انا عايزه امسحه
            int index=Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;

            Console.WriteLine("Book removed");


        }
        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added succcessfully! ");
            }
            else
                Console.WriteLine("Library is full, I can't add new book");

        }

        public void BorrowBook(Book book)
        {
            if (currentBookCount < borrowedBooks.Length)
            {
                books[currentBorrowedBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book borrowed succcessfully! ");
            }
            else
                Console.WriteLine("Sorry can't borrow more books");
        }

    }
}
