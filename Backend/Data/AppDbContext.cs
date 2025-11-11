using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; } = default!;
        public DbSet<Role> Role { get; set; } = default!;
        public DbSet<Horario> Horario { get; set; } = default!;
        public DbSet<Asistencia> Asistencia { get; set; } = default!;
        public DbSet<DatosEmpleado> DatosEmpleado { get; set; } = default!;
        public DbSet<Factura> Factura { get; set; } = default!;
        public DbSet<Nomina> Nomina { get; set; } = default!;
        public DbSet<Puesto> Puesto { get; set; } = default!;
        public DbSet<Presupuesto> Presupuesto { get; set; } = default!;
        public DbSet<Producto> Producto { get; set; } = default!;
        public DbSet<Inventario> Inventario { get; set; } = default!;
        public DbSet<Categoria> Categoria { get; set; } = default!;
        public DbSet<Pago> Pago { get; set; } = default!;
        public DbSet<DetalleFactura> DetalleFactura { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Horario>()
                .HasOne(h => h.Usuario)
                .WithMany(u => u.Horarios)
                .HasForeignKey(h => h.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Asistencia>()
                .HasOne(a => a.Usuario)
                .WithMany(u => u.Asistencias)
                .HasForeignKey(a => a.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Asistencia>()
                .HasOne(a => a.Horario)
                .WithMany(h => h.Asistencias)
                .HasForeignKey(a => a.HorarioId)
                .OnDelete(DeleteBehavior.Restrict);

                 modelBuilder.Entity<Pago>()
        .HasOne(p => p.Factura)
        .WithMany(f => f.Pagos)
        .HasForeignKey(p => p.FacturaId)
        .OnDelete(DeleteBehavior.Restrict);

    // 🔹 Relación Pago -> Nomina
    modelBuilder.Entity<Pago>()
        .HasOne(p => p.Nomina)
        .WithMany(n => n.Pagos)
        .HasForeignKey(p => p.NominaId)
        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
