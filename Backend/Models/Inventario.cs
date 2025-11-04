namespace Backend.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }

        public Producto Producto { get; set; } = null!;
        public string Tipo { get; set; } = string.Empty; //Entrada-salida//
        public DateTime Fecha { get; set; }
    }
}