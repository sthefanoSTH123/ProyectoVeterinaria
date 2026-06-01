using ProyectoVeterinaria.Controladores;
using ProyectoVeterinaria.Entidades;
using ProyectoVeterinaria.Entidades.ProyectoVeterinaria.Entidades;
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
    public partial class frmEditConsultas : Form
    {
        private int pos;
        private bool editar;

        public frmEditConsultas()
        {
            InitializeComponent();
            editar = false;
        }

        public frmEditConsultas(int pos)
        {
            InitializeComponent();

            this.pos = pos;
            editar = true;

            CargarCombos();

            Consultas consulta =
                TListaConsultas.listaConsultas[pos];

            txtIdConsulta.Text =
                consulta.IdConsulta.ToString();

            txtMotivo.Text =
                consulta.Motivo;

            txtDiagnostico.Text =
                consulta.Diagnostico;

            txtCosto.Text =
                consulta.Costo.ToString();

            cmbCliente.SelectedItem =
                consulta.Cliente;

            cmbMascota.SelectedItem =
                consulta.Mascota;

            dtpFechaNacimiento.Value =
                consulta.Fecha;
        }

        private void CargarCombos()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource =
                TListaClientes.listaClientes;

            cmbMascota.DataSource = null;
            cmbMascota.DataSource =
                TListaMascotas.listaMascotas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();

            consultas.IdConsulta =
                Convert.ToInt32(txtIdConsulta.Text);

            consultas.Motivo =
                txtMotivo.Text;

            consultas.Diagnostico =
                txtDiagnostico.Text;

            consultas.Costo =
                Convert.ToDouble(txtCosto.Text);

            consultas.Cliente =
                (Clientes)cmbCliente.SelectedItem;

            consultas.Mascota =
                (Mascotas)cmbMascota.SelectedItem;

            consultas.Fecha =
                dtpFechaNacimiento.Value;


            if (editar)
            {
                TListaConsultas.Modificar(
                    pos,
                    consultas);

                MessageBox.Show(
                    "Consulta modificada correctamente.");
            }
            else
            {
                TListaConsultas.Agregar(
                    consultas);

                MessageBox.Show(
                    "Consulta registrada correctamente.");
            }

            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditConsultas_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
    }
}
