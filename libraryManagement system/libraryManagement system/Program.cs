using System;

namespace libraryManagement_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");
            Console.WriteLine("Are you librarian or regular user(L/R)");
            Library library = new Library();
            char userType = Console.ReadLine().ToUpper()[0];
           
                if (userType == 'L')
                {
                    Console.WriteLine("Welcome librarian Enter your name");
                    string librarianName = Console.ReadLine();

                    //create a librarian object
                    Librarian l1 = new Librarian();
                    l1.Name = librarianName;
                    Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please choose to add book (A), Remove book (B), Display book (D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter the book details: ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            library.Add(book);
                            break;

                        case 'B':
                            Console.WriteLine("Enter the book details to remove: ");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            library.Remove(book);
                            break;

                        case 'D':
                            Console.WriteLine("The Book List");
                            l1.DisplayBooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

                }
                else if (userType == 'R')
                {
                    Console.WriteLine("Welcome user your name");
                    string name = Console.ReadLine();

                    //create a librarian object
                    LibraryUser u1 = new LibraryUser(name);

                    Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {
                    Console.WriteLine("Please choose to Display book (D), Borrow book(B)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("The Book List");
                            u1.DisplayBooks(library);
                            break;

                        case 'B':
                            Console.WriteLine("Enter the book details to borrow: ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };

                            u1.BorrowBook(book, library);
                            break;


                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            }
                else
                {
                    Console.WriteLine("Please enter the right value: L or R ");
                }

            }
        }
    }

