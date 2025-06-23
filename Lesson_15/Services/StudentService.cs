using Lesson_15.Models;

namespace Lesson_15.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> students;
        public StudentService(List<Student> students) =>
        this.students = students;

        public void InserStudent(Student student)
        {
            if(students.Any(student=>student.Name==student.Name))
            {
                Console.WriteLine($"{student.Name} bunday ismli Student bazada bor");
            }
            students.Add(student);
            Console.WriteLine($"{student.Name} ismli Student bazaga qo'shildi");
        }

        public List<Student> SelectAllStudents() =>
            this.students.ToList();

        public void UpdateStudent(Student student)
        {
            Student maybeStudent =
                 this.students.FirstOrDefault(student =>
                     student.Name == student.Name);

            maybeStudent.Name = student.Name;
            maybeStudent.Age = student.Age;
            maybeStudent.Email = student.Email;
        }

        public void DeleteStudent(Student student)
        {
            Student maybeStudent =
                 this.students.FirstOrDefault(student =>
                     student.Name == student.Name);

            students.Remove(maybeStudent);
        }

        public Student GetStudent(string studentName)
        {
            return this.students.FirstOrDefault(student =>
                        student.Name == student.Name);
        }
    }
}
