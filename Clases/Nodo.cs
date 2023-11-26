using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoSeries_DLL_JSVE.Forms.FormListas;

namespace ProyectoSeries_DLL_JSVE.Clases
{
    public class Nodo
    {
        public Serie datos { get; set; }
        public Nodo siguiente { get; set; }

        public Nodo(Serie serie)
        {
            datos = serie;
            siguiente = null;
        }
    }
}
