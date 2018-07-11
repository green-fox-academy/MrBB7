using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            level = "intermediate";
        }

        public override string GetGoal()
        {
            return string.Format("Educate brilliant junior software developers.");
        }

        public override string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {1} year old {2}, {3} level mentor", Name, Age, Gender, level);
        }
    }
}
