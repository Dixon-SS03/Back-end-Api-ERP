using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class DatosEmpleado
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public int PuestoId { get; set; }

        public Usuario Usuario { get; set; } = null!;
        public Puesto Puesto { get; set; } = null!;   

        public DateTime Fecha_contratacion { get; set; }
        
        public string Telefono { get; set; } = string.Empty;  
    }
}