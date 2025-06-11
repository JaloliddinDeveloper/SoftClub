namespace Lesson_6.Classes
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string GetFullName()
        {
            return $"{Firstname} {Lastname}";
        }

        public int GetBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Age;
        }
    }
}
