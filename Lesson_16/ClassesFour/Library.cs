namespace Lesson_16.ClassesFour
{
    internal class Library
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Book> Books { get; set; }


        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            this.books.Remove(book);
        }

        public Book GetBook(string name)
        {
            Book mayBook =
                this.books.FirstOrDefault(book =>
                    book.BookName == name);

            if (mayBook == null)
            {
                Console.WriteLine($"There is not {name} book ");
            }


            return mayBook;
        }

        public void AllBooks()
        {
            foreach (Book b in this.books)
            {
                Console.WriteLine($" Book name {b.BookName} {b.Author}  {b.Year}");
            }
        }

        public List<Book> SearchingBook(string name)=>
             books.FindAll(a=>a.BookName == name);   
    }
}
