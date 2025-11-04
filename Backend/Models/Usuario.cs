namespace Backend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public byte Estado { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public int Id_Rol { get; set; }

        public Role Rol { get; set; } = null!;

        public ICollection<DatosEmpleado> DatosEmpleados { get; set; } = new List<DatosEmpleado>();
        public ICollection<Nomina> Nominas { get; set; } = new List<Nomina>();
        public ICollection<Factura> Facturas { get; set; } = new List<Factura>();

        public ICollection<Horario> horarios { get; set; } = new List<Horario>();
        public ICollection<Asistencia> asistencias { get; set; } = new List<Asistencia>();
    }
}