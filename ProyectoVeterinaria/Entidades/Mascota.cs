using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    public abstract class Mascota
    {
        private int idCodigo;
        private string nombre;
        private int edad;
        private Dueño dueño;

        public Mascota()
        {
        }

        public Mascota(int idCodigo, string nombre, int edad, Dueño dueño)
        {
            this.idCodigo = idCodigo;
            this.nombre = nombre;
            this.edad = edad;
            this.dueño = dueño;
        }

        public int IdCodigo { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Dueño Dueño { get; set; }

        public abstract double CalcularCostoConsulta();
    }
}
