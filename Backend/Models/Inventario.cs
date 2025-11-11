using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Inventario
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }

        public Producto Producto { get; set; } = null!;
        public string Tipo { get; set; } = string.Empty; //Entrada-salida//
        public DateTime Fecha { get; set; }
    }
}