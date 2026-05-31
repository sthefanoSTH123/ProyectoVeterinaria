using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    public class Cliente
    {
        private string cedula;
        private string nombre;

        public Cliente()
        {
        }
        public Cliente(string cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
