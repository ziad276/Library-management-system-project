namespace Library_management_system_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Library System");

            Library library = new Library();

            Console.WriteLine("Are you librarian or a regular user (L/R)");

            char userType = Console.ReadLine().ToUpper()[0];
            
                if (userType == 'L')
                {
                    Console.WriteLine("Enter Your Name");
                    string librarianName = Console.ReadLine();

                    Librarian l1 = new Librarian(librarianName);

                    Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please Choose to add book (A)/ Remove book (R)/ Display Book(D)");

                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter Book Details");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            l1.AddBook(book, library);
                            break;


                        case 'R':
                            Console.WriteLine("Enter Book Details");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            l1.RemoveBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("Book list: ");
                            l1.DisplayBooks(library);
                            break;
                    }
                }
                }
                else if (userType == 'R')
                {
                    // Regular User Logic
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Value L Or R");
                }
            
        }
    }
}
