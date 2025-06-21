namespace HomeWork_14.Classes
{
    internal class Teacher : Person
    {
        private List<string> courses;

        public Teacher(string name, string address) : base(name, address)
        {
            courses = new List<string>();
        }

        public bool AddCourse(string course)
        {
            if (courses.Count >= 5)
                return false;

            if (!courses.Contains(course))
            {
                courses.Add(course);
                return true;
            }
            return false;
        }

        public bool RemoveCourse(string course)
        {
            return courses.Remove(course);
        }

        public void PrintCourses()
        {
            Console.WriteLine($"Courses taught by {Name}: {string.Join(", ", courses)}");
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Courses Teaching: {courses.Count}";
        }
    }
}
