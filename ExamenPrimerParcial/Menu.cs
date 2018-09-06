using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Menu
    {
        string Nombre { get; set; }
        string Identificador { get; set; }
        int HoraInicio { get; set; }
        int HoraFin { get; set; }
        List<Platillo> Platillos { get; set; }

        public Menu(string nombre, string identificador, int horainicio, int horafin)
        {
            if(nombre!=null)
            {
                Nombre = nombre;
            }
            else
            {
                Nombre = "Nuevo Menú";
            }
            Identificador = identificador;
            HoraInicio = horainicio;
            HoraFin = horafin;

            Platillos = new List<Platillo>();
        }

    }
}
