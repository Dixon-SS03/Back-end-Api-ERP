namespace Backend.Models
{
    public class DatosEmpleado
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public int Id_Puesto { get; set; }

        public Usuario Usuario { get; set; } = null!;
        public Puesto Puesto { get; set; } = null!;   

        public DateTime Fecha_contratacion { get; set; }

        public string Telefono { get; set; } = string.Empty;  
    }
}