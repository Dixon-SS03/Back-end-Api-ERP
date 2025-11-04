namespace Backend.Models
{
    public class Nomina
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateTime Periodo_Inicio { get; set; }
        public DateTime Periodo_Fin { get; set; }
        public decimal Salario_Bruto { get; set; }

        public decimal Salario_Neto { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}