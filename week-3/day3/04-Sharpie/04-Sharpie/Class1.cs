using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string Color;
        public float Width;
        public float inkAmount;

        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
            inkAmount = 100;
        }
        public float Use()
        {
           
            inkAmount-=Width;

            return inkAmount;
        }
    }
}
