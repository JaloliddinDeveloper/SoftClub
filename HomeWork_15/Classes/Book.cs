using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15.Classes
{
    internal class Book: AbstractBook, Borrowable
    {
        public void Borrow()
        {
            Console.WriteLine($"The book '{Title}' has been borrowed.");
        }

        public void ReturnBook()
        {
            Console.WriteLine($"The book '{Title}' has been returned.");
        }
    }
}
