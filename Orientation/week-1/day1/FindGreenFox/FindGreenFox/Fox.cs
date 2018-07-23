using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreenFox
{
    class Fox
    {
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
    }
}
