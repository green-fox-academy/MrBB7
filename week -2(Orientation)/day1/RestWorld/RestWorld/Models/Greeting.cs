using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWorld.Models
{
    public class Greeting
    {
        public static long Counter { get; set; }
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
            Counter++;
            Id+= Counter;
        }
    }
}
