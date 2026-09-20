using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; } // Library User owns a library card (Agregation)
        public void DisplayBooks()
        {
            // Add Logic
        }
        public void BorrowBook(Book book)
        {
            // Add Logic
        }
    }
}
