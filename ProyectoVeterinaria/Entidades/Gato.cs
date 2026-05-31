using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    public class Gato : Mascota
    {
        public bool EsDomestico { get; set; }

        public override double CalcularCostoConsulta()
        {
            return 20;
        }
    }
}
