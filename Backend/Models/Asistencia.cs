namespace Backend.Models
{
    public class Asistencia
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int Id_Horario { get; set; }
        public Horario Horario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        
        public DateOnly Hora_Entrada { get; set; }
        public DateOnly Hora_Salida { get; set; }
        public string Estado { get; set; } = string.Empty;// Presente-ausente-tarde-permiso//

        public string Observaciones { get; set; } = string.Empty;
    }
}