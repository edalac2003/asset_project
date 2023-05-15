using asset_project.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Propiedad> Propiedades { get; set; }

        public DbSet<TipoActivoFijo> TiposActivoFijo { get; set; }

        public DbSet<TipoIdentificacion> TiposIdentificacion { get; set; }

        public DbSet<ActivoFijo> ActivosFijos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>().HasIndex(c => c.nombre);
            modelBuilder.Entity<Persona>().HasIndex(p => new { p.Nombres, p.Apellidos });
            modelBuilder.Entity<Propiedad>().HasIndex(p => p.Nombre);
            modelBuilder.Entity<TipoActivoFijo>().HasIndex(t => t.Nombre);
            modelBuilder.Entity<TipoIdentificacion>().HasIndex(t => t.Nombre);
            modelBuilder.Entity<ActivoFijo>().HasIndex(a => a.Codigo);

        }
    }
}
