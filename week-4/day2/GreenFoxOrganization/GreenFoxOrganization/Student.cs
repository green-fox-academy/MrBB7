using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public string PreviousOrganization
        {
            get
            {
                return previousOrganization;
            }
        }
    }
}
