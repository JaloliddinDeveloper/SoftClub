namespace HomeWork_15.Classes
{
    internal class AbstractBook : Readable
    {
        protected string Title;
        protected string Author;

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void Read()
        {
            Console.WriteLine($"Reading the book: {Title} by {Author}");
        }
    }
}
