namespace Lesson_6.Classes
{
    internal class Student
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }
        public int[] Scores { get; set; }

        public double GetAverage()
        {
            if (Scores == null || Scores.Length == 0)
                return 0;
            return Scores.Average();
        }
    }
}
