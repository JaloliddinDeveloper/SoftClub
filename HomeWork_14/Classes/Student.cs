namespace HomeWork_14.Classes
{
    internal class Student : Person
    {
        private List<string> courses;
        private List<int> grades;

        public Student(string name, string address) : base(name, address)
        {
            courses = new List<string>();
            grades = new List<int>();
        }

        public bool AddCourseGrade(string course, int grade)
        {
            if (courses.Count >= 30)
                return false;

            courses.Add(course);
            grades.Add(grade);
            return true;
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{courses[i]}: {grades[i]}");
            }
        }

        public double GetAverageGrade()
        {
            if (grades.Count == 0) return 0;
            return grades.Average();
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Courses Taken: {courses.Count}";
        }
    }
}
