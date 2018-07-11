using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class RedditDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public RedditDbContext(DbContextOptions<RedditDbContext> options) : base(options)
        {

        }
    }
}
