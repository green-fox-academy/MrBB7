using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : ICloneable
    {
        private string name;
        private int age;
        private string gender;
        private string previousOrganization;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
        }

        public object Clone()
        {
            Student clonedStudent = new Student(name, age, gender, previousOrganization);
            return clonedStudent;
        }

        public override string ToString()
        {
            return name + " " + age + " " + gender + " " + previousOrganization;
        }
    }
}

