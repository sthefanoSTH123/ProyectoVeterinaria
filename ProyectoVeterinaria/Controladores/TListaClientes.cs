using ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Controladores
{
    public class TListaClientes
    {
        public static List<Clientes> listaClientes = new List<Clientes>();


        public static void Agregar(Clientes cliente)
        {
            listaClientes.Add(cliente);
        }

        public static void Eliminar(int pos)
        {
            listaClientes.RemoveAt(pos);
        }

        public static void Modificar(int pos, Clientes cliente)
        {
            listaClientes[pos] = cliente;
        }
    }
}
