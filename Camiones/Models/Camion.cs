namespace Refaccionaria.Models
{
    public class Camion
    {
        public int IdCamion { get; set; } // Id único del camión
        public string Nombre { get; set; } // Nombre del camión
        public decimal TotalAlmacenaje { get; set; } // Totalmacenaje (coincide con la base de datos)
        public string Placas { get; set; } // Placas del camión
        public string Marca { get; set; } // Marca del camión
    }
}
