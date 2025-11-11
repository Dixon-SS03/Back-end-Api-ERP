using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Asistencia
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public int HorarioId { get; set; }
        public Horario Horario { get; set; } = null!;

        public DateTime Fecha { get; set; }

        public DateTime Hora_Entrada { get; set; }

        public DateTime Hora_Salida { get; set; }

        public string Estado { get; set; } = string.Empty;// Presente-ausente-tarde-permiso//
        public string Observaciones { get; set; } = string.Empty;
    }
}