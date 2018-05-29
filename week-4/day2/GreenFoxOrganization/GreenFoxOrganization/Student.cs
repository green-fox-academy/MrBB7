using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        private string previousOrganization;
        private static int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            this.previousOrganization = "The School Of Life";
            skippedDays = 0;
        }

        public override string GetGoal()
        {
            return string.Format("Be a junior software developer.");
        }

        public override string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {0} year old {2} from {3} who skipped {4} days from the course already.", Name , Age , Gender, previousOrganization, skippedDays );
        }

        public int SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
            return skippedDays;
        }
    }
}
