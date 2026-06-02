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
        private int idConsulta;
        private DateTime fecha;
        private Clientes cliente;
        private Mascotas mascota;
        private string motivo;
        private string diagnostico;
        private double costo;
        public Consultas()
        {
        }

        public Consultas(int idConsulta, DateTime fecha,
                        Clientes cliente, Mascotas mascota,
                        string motivo, string diagnostico,
                        double costo)
        {
            Costo = costo;
        public Consultas()
        {
        }

        public Consultas(int idConsulta, DateTime fecha,
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
