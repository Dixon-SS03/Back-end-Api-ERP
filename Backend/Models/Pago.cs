namespace Backend.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int Id_Factura { get; set; }
        public Factura Factura { get; set; } = null!;
        public int Id_Nomina { get; set; }
        public Nomina Nomina { get; set; } = null!;
        public string Tipo { get; set; } = string.Empty; //Ingreso-Egreso//
        public decimal Monto { get; set; }
        public string Metodo_Pago { get; set; } = string.Empty;
        public DateTime Fecha_registro { get; set; }
    }
}