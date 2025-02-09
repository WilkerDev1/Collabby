using Microsoft.EntityFrameworkCore;
using Collabby.web.Models; 

namespace Collabby.web.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>(tb => {
                tb.HasKey(colu => colu.IdEmpleado);

                tb.Property(colu => colu.IdEmpleado)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(colu => colu.NombreCompleto).HasMaxLength(50);
                tb.Property(colu => colu.Correo).HasMaxLength(50);
            });

            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}
