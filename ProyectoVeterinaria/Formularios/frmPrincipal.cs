using ProyectoVeterinaria.Controladores;
using ProyectoVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinaria.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Datos()
        {
            Dueño d1 = new Dueño()
            {
                Cedula = "0911111111",
                Nombre = "Juan Perez"
            };

            Dueño d2 = new Dueño()
            {
                Cedula = "0922222222",
                Nombre = "Maria Lopez"
            };

            TLista.Agregar(new Perro()
            {
                IdCodigo = 1,
                Nombre = "Firulais",
                Edad = 5,
                Raza = "Pastor Alemán",
                Dueño = d1
            });

            TLista.Agregar(new Gato()
            {
                IdCodigo = 2,
                Nombre = "Michi",
                Edad = 2,
                EsDomestico = true,
                Dueño = d2
            });
        }
        public void ListarPerros()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource =
                TLista.lista.OfType<Perro>().ToList();
        }

        public void ListarGatos()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource =
                TLista.lista.OfType<Gato>().ToList();
        }

        public void ListarMascotas()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource =
                TLista.lista.ToList();
        }

        public void ActualizarTabla()
        {
            if (cmbTipo.SelectedItem.Equals("Perro"))
            {
                ListarPerros();
            }
            else if (cmbTipo.SelectedItem.Equals("Gato"))
            {
                ListarGatos();
            }
            else
            {
                ListarMascotas();
            }
        }

        // Consultas
        public void CalcularConsultas()
        {
            txtTotalMascotas.Text =
    TLista.lista.Count.ToString();

            txtPromedioEdad.Text =
    TLista.lista.Average(x => x.Edad)
    .ToString("F2");

            Mascota vieja =
    TLista.lista.OrderByDescending
    (x => x.Edad).FirstOrDefault();

            if (vieja != null)
            {
                txtMayorEdad.Text =
                    $"{vieja.Nombre} - {vieja.Edad}";
            }

            double total =
    TLista.lista.Sum(x =>
    x.CalcularCostoConsulta());

            txtTotalConsultas.Text =
                total.ToString("F2");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Datos();
            cmbTipo.Items.Add("Perro");
            cmbTipo.Items.Add("Gato");
            cmbTipo.Items.Add("Todos");
            cmbTipo.SelectedIndex = 2;
            ActualizarTabla();
            CalcularConsultas();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem.ToString();

            if (tipo == "Todos")
            {
                MessageBox.Show("Seleccione un tipo específico para agregar.");
                return;
            }
            frmEditMascotas frm = new frmEditMascotas(tipo);
            frm.ShowDialog();

            ActualizarTabla();
            CalcularConsultas();

        }
    }
}
