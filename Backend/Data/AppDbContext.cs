using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Tablas del modelo
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Backend.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<Backend.Models.Role> Role { get; set; } = default!;
        public DbSet<Backend.Models.Horario> Horario { get; set; } = default!;
        public DbSet<Backend.Models.Pago> Pago { get; set; } = default!;
        public DbSet<Backend.Models.Asistencia> Asistencia { get; set; } = default!;
        public DbSet<Backend.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<Backend.Models.DatosEmpleado> DatosEmpleado { get; set; } = default!;
        public DbSet<Backend.Models.DetalleFactura> DetalleFactura { get; set; } = default!;
        public DbSet<Backend.Models.Presupuesto> Presupuesto { get; set; } = default!;
        public DbSet<Backend.Models.Nomina> Nomina { get; set; } = default!;
        public DbSet<Backend.Models.Puesto> Puesto { get; set; } = default!;
        public DbSet<Backend.Models.Factura> Factura { get; set; } = default!;
        public DbSet<Backend.Models.Inventario> Inventario { get; set; } = default!;
    }
}