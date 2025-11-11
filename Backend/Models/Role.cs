using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}