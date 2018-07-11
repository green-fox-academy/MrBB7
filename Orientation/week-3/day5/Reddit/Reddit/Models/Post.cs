using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeTag { get; set; }
        public int PlusCount { get; set; }
        public int MinusCount { get; set; }

        public virtual User User { get; set; }
    }
}
