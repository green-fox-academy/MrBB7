using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Cohort
    {
        private string name;
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        public Cohort(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public int Size(List<Student> students)
        {
            return students.Count;
        }

        public int Size(List<Mentor> mentors)
        {
            return mentors.Count;
        }

        public string Info()
        {
            return "The" + name + " cohort has " + Size(students) + " students and " + Size(mentors) + " mentors.";
        }
    }
}
