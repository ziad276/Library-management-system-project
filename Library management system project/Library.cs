using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Library
    {
        private Book[] books = new Book[100]; // max capacity
        private int currentBookCount = 0;

        private Book[] Borrowedbooks = new Book[50];
        private int currentBorrowedBookCount = 0;


        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book Added Succesfully");
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }
        public void Display()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book Removed");
        }
    }
}
