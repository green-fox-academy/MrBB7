using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mathTeacher = new Teacher();
            Student poorStudent = new Student();

            Console.Write("The student is asking a question and the ");
            poorStudent.Question(mathTeacher);

            Console.WriteLine();

            Console.Write("The teacher is teaching and ");
            mathTeacher.Teach(poorStudent);
            Console.ReadLine();
        }
    }
}

