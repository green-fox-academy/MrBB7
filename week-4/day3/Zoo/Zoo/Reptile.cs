using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
        }

        public override string WantChild()
        {
            return ", want a child from an egg!";
        }
    }
}
