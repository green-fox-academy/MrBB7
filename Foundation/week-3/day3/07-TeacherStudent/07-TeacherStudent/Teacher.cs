using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        public string answer;

        public void Answer()
        {
            this.answer = "the teacher is answering";
        }

        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
