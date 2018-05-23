using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mathTeacher = new Teacher();
            Student firstStudent = new Student();

            Console.Write("The student is asking a question and the ");
            firstStudent.Question(mathTeacher);

            Console.WriteLine();

            Console.Write("The teacher is teaching and ");
            mathTeacher.Teach(firstStudent);
            Console.ReadLine();
            /*            Student
             learn()
             question(teacher)->calls the teachers answer method
             Teacher
             teach(student)->calls the students learn method
             answer()*/
        }
    }
}
