using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Backend.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = string.Empty;

        public ICollection<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();
        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}