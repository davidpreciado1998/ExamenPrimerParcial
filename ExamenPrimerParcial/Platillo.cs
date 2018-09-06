using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Platillo
    {
        string Nombre { get; set; }
        string Identificador { get; set; }
        string Descripcion { get; set; }
        int Precio { get; set; }
        List<Ingrediente> Ingredientes { get; set; }

        public Platillo(string nombre, string identificador, string descripcion, int precio)
        {
            Nombre = nombre;
            Identificador = identificador;
            Descripcion = descripcion;
            Precio = precio;

            Ingredientes = new List<Ingrediente>();
        }

    }
}
