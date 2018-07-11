using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Entities
{
    public class RedditBackendDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public RedditBackendDbContext(DbContextOptions<RedditBackendDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User);
        }
    }
}
