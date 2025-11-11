using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Monto_Total { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}