using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacRetake.Entities
{
    public class TechReportDbContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }

        public TechReportDbContext(DbContextOptions<TechReportDbContext> options) : base(options)
        {

        }
    }
}
