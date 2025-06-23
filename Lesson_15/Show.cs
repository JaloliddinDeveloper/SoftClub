using Lesson_15.Models;
using Lesson_15.Services;

namespace Lesson_15
{
    internal class Show
    {
        public IStudentService studentService;

        public Show(IStudentService studentService)=>
            studentService = studentService;
        
        public void AddStudent(Student student)
        {
            Console.Write("Name");
            student.Name=Console.ReadLine();

            Console.Write("Age");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Email");
            student.Email =Console.ReadLine();

            studentService.InserStudent(student);
        }

        public void GetAllStudent()
        {
            var students=this.studentService.SelectAllStudents();
            foreach(Student s in students)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age} Email: {s.Email}");
            }
        }

        public void Update(Student student)
        {
            Console.Write("newName: ");
            student.Name=Console.ReadLine();
            Console.WriteLine();
        }
    }
}
