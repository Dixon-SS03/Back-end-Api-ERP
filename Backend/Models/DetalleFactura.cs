using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class DetalleFactura
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; } = null!;
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal Precio_Unitarios { get; set; }
        public decimal Subtotal { get; set; }
    }
}