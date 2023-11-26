using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeries_DLL_JSVE.Clases
{
    public class Serie
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int nroCapitulos { get; set; }
        public Serie(string _nombre, string _descripcion, int _nroCapitulos)
        {
            nombre = _nombre;
            descripcion = _descripcion;
            nroCapitulos = _nroCapitulos;
        }
    }
}
