using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    public class Perro : Mascota
    {
        public string Raza { get; set; }

        public override double CalcularCostoConsulta()
        {
            return 25;
        }
    }
}
