using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
        public int? Vote { get; set; }

        public Post()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
