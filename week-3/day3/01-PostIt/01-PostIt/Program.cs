using System;

namespace _01_PostIt
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }

        static void Main(string[] args)
        {
            PostIt post1;
            post1.BackgroundColor = "orange";
            post1.Text = "Idea 1";
            post1.TextColor = "blue";

            PostIt post2;
            post2.BackgroundColor = "pink";
            post2.Text = "Awesome";
            post2.TextColor = "black";

            PostIt post3;
            post3.BackgroundColor = "yellow";
            post3.Text = "Superb!";
            post3.TextColor = "green";

            Console.WriteLine(post1);
            Console.WriteLine(post2);
            Console.WriteLine(post3);

            Console.ReadLine();
        }
    }
}
