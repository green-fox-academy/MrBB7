using MacrotisExam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExam.Entities
{
    public class AttractionsDbContext : DbContext
    {
        public DbSet<Attractions> Attractions { get; set; }

        public AttractionsDbContext(DbContextOptions<AttractionsDbContext> options) : base(options)
        {

        }
    }
}
