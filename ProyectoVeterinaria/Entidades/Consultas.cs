using ProyectoVeterinaria.Entidades.ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVeterinaria.Entidades
{
    public class Consultas
    {
        public class Consulta
        {
            public Consulta()
            {
            }

            public Consulta(int idConsulta, DateTime fecha,
                            Clientes cliente, Mascotas mascota,
                            string motivo, string diagnostico,
                            double costo)
            {
                IdConsulta = idConsulta;
                Fecha = fecha;
                Cliente = cliente;
                Mascota = mascota;
                Motivo = motivo;
                Diagnostico = diagnostico;
                Costo = costo;
            }

            public int IdConsulta { get; set; }
            public DateTime Fecha { get; set; }

            public Clientes Cliente { get; set; }
            public Mascotas Mascota { get; set; }

            public string Motivo { get; set; }
            public string Diagnostico { get; set; }

            public double Costo { get; set; }

            public override string ToString()
            {
                return $"{IdConsulta} - {Mascota.Nombre}";
            }
        }
    }
}
