using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        public string fragment;

        public Student()
        {
            fragment = "the student is learning";
        }

        public void Question(Teacher teacher)
        {
                teacher.Answer();
        }
    }
}
