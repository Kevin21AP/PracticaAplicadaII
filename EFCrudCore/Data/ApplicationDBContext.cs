using EFCrudCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCrudCore.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { 
        }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        protected override void OnModelCreating( ModelBuilder modelBuilder)//al momento que se ejecuta crea la tabla
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
