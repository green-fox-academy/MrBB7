using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string Greet()
        {
            return "Hi, I'm an animal";
        }

        public virtual string WantChild()
        {
            return ", want a child ";
        }

        public virtual string GetName()
        {
            return name;
        }
    }
}

