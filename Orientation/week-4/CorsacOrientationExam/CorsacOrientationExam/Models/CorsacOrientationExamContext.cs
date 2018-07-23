using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CorsacOrientationExam.Models
{
    public partial class CorsacOrientationExamContext : DbContext
    {
        public CorsacOrientationExamContext()
        {
        }

        public CorsacOrientationExamContext(DbContextOptions<CorsacOrientationExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Planet> Planet { get; set; }
        public virtual DbSet<Spaceship> Spaceship { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CorsacOrientationExam;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>(entity =>
            {
                entity.ToTable("planet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Population).HasColumnName("population");
            });

            modelBuilder.Entity<Spaceship>(entity =>
            {
                entity.ToTable("spaceship");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxCapacity).HasColumnName("max_capacity");

                entity.Property(e => e.Planet)
                    .HasColumnName("planet")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Utilization).HasColumnName("utilization");
            });
        }
    }
}
