using Lesson_15.Models;

namespace Lesson_15.Services
{
    public interface IStudentService
    {
        void InserStudent(Student student);
        List<Student> SelectAllStudents();
        Student GetStudent(string studentName);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
