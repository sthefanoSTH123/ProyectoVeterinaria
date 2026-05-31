using ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Controladores
{
    public static class TLista
    {
        public static List<Mascota> lista =
            new List<Mascota>();

        public static void Agregar(Mascota m)
        {
            lista.Add(m);
        }

        public static void Eliminar(int pos)
        {
            lista.RemoveAt(pos);
        }
    }
}
