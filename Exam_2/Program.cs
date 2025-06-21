using Exam_2.ClassesOne;

Student student1 =new Student("Jaloliddin","Shahrisabz","C#",4,100000);
Student student2 =new Student("Oybek","Kitob","C++",1,100000);
Student student3 =new Student("Mustafo","Olot","C",2,100000);

Console.WriteLine(student2.GetName());
Console.WriteLine(student3.GetName());
Console.WriteLine(student1.GetName());

Console.WriteLine(student2.GetProgram());
Console.WriteLine(student3.GetProgram());
Console.WriteLine(student1.GetProgram());


