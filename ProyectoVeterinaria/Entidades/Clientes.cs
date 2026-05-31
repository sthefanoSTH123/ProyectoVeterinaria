using System;

namespace ProyectoVeterinaria.Entidades
{
    public class Clientes
    {
        public Clientes()
        {
        }

        public Clientes(int idCliente, string cedula, string nombre,
                       string apellido, string telefono,
                       string correo, string direccion)
        {
            IdCliente = idCliente;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public int IdCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"{Cedula} - {Nombre} {Apellido}";
        }
    }
}