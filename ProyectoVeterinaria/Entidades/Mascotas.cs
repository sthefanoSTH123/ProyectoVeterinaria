using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    using System;

    namespace ProyectoVeterinaria.Entidades
    {
        public class Mascotas
        {
            public Mascotas()
            {
            }

            public Mascotas(int idCodigo, string nombre, int edad,
                           string especie, string raza,
                           string sexo, double peso,
                           DateTime fechaNacimiento,
                           Clientes dueño)
            {
                IdCodigo = idCodigo;
                Nombre = nombre;
                Edad = edad;
                Especie = especie;
                Raza = raza;
                Sexo = sexo;
                Peso = peso;
                FechaNacimiento = fechaNacimiento;
                Dueño = dueño;
            }

            public int IdCodigo { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }

            // Datos de la mascota
            public string Especie { get; set; }
            public string Raza { get; set; }
            public string Sexo { get; set; }
            public double Peso { get; set; }
            public DateTime FechaNacimiento { get; set; }

            // Dueño de la mascota
            public Clientes Dueño { get; set; }

            public override string ToString()
            {
                return $"{Nombre} - {Especie}";
            }
        }
    }
}
