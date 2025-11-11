using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;
        public ICollection<Inventario> Inventario { get; set; } = new List<Inventario>();
        public ICollection<DetalleFactura> DetallesFactura { get; set; } = new List<DetalleFactura>();  
    }
}