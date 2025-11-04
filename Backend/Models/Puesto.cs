namespace Backend.Models
{
    public class Puesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public ICollection<DatosEmpleado> DatosEmpleados { get; set; } = new List<DatosEmpleado>();
    }
}