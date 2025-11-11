using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Puesto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public ICollection<DatosEmpleado> DatosEmpleados { get; set; } = new List<DatosEmpleado>();
    }
}