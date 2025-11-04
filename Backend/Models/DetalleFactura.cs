namespace Backend.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int Id_Factura { get; set; }
        public Factura Factura { get; set; } = null!;
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal Precio_Unitarios { get; set; }
        public decimal Subtotal { get; set; }
    }
}