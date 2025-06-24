namespace Lesson_16.ClassesFour
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book()
        { }

        public Book(string bookName,string author, int year)
        {
            this.BookName = bookName;
            this.Author = author;
            this.Year = year;
        }
    }
}