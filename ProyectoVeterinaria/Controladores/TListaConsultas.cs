using ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Controladores
{
    public class TListaConsultas
    {   
        public static List<Consultas> listaConsultas = new List<Consultas>();

        public static void Agregar(Consultas consulta)
        {
            listaConsultas.Add(consulta);
        }

        public static void Eliminar(int index)
        {
            if (index >= 0 && index < listaConsultas.Count)
            {
                listaConsultas.RemoveAt(index);
            }
        }

        public static void Modificar(int pos, Consultas consulta)
        {
            listaConsultas[pos] = consulta;
        }
    }
}



