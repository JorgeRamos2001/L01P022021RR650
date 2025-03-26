using L01P022021RR650.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace L01P022021RR650.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Facultades> Facultades { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamentos>().ToTable("departamentos");
            modelBuilder.Entity<Facultades>().ToTable("facultades");
            modelBuilder.Entity<Materias>().ToTable("materias");
            modelBuilder.Entity<Alumnos>().ToTable("alumnos");

            base.OnModelCreating(modelBuilder);
        }
    }
}
