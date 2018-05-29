using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            var student = new Student();
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            var mentor = new Mentor();
            people.Add(mentor);
            var sponsor = new Sponsor();
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort ocelot = new Cohort("OCELOT");
            ocelot.AddStudent(student);
            ocelot.AddStudent(john);
            ocelot.AddMentor(mentor);
            ocelot.AddMentor(gandhi);
            ocelot.Info();
            Console.WriteLine(mark.Introduce());
            Console.WriteLine(ocelot.Info());
            Console.ReadLine();
        }
    }
}
