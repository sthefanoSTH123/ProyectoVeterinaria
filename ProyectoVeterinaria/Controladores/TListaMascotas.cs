using ProyectoVeterinaria.Entidades;
using ProyectoVeterinaria.Entidades.ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Controladores
{
    public class TListaMascotas
    {
        public static List<Mascotas> listaMascotas = new List<Mascotas>();

        public static void Agregar(Mascotas mascota)
        {
            listaMascotas.Add(mascota);
        }

        public static void Eliminar(int pos)
        {
            listaMascotas.RemoveAt(pos);
        }

        public static void Modificar(int pos, Mascotas mascota)
        {
            listaMascotas[pos] = mascota;
        }
    }
}
