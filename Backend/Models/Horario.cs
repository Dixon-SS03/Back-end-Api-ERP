using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Horario
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public string Dia { get; set; } = string.Empty; // Lunes-Martes-Miercoles-Jueves-etc//
        public TimeOnly Hora_Entrada { get; set; }
        public TimeOnly Hora_Salida { get; set; }
        public string Observaciones { get; set; } = string.Empty;
        public ICollection<Asistencia> Asistencias { get; set; } = new List<Asistencia>();
    }
}