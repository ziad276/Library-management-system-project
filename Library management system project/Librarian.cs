using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; }
        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook, Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook(Book newBook, Library library)
        {
            library.Remove(newBook);
        }
    }
}
