using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}