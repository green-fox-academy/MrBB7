using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }

        public virtual string Introduce()
        {
            return string.Format("Hi, I'm {0}, a {1} year old {2}", name, age, gender);
        }

        public virtual string GetGoal()
        {
            return string.Format("My goal is: Live for the moment");
        }
    }
}
