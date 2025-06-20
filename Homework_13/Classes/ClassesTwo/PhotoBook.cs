namespace Homework_13.Classes.ClassesTwo
{
    internal class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
