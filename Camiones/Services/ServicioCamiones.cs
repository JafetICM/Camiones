
using System.Linq;
using Refaccionaria.Models;

namespace Refaccionaria.Services
{
    public class ServicioCamiones
    {
        private Camion[] camiones;

        public ServicioCamiones(Camion[] camiones)
        {
            this.camiones = camiones;
        }

        public Camion[] BuscarPorNombre(string nombre)
        {
            return camiones.Where(c => c.Nombre.Contains(nombre, System.StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        public Camion[] BuscarPorMarca(string marca)
        {
            return camiones.Where(c => c.Marca.Contains(marca, System.StringComparison.OrdinalIgnoreCase)).ToArray();
        }
    }
}
