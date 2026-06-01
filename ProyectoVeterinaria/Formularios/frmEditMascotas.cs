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
    public partial class frmEditMascotas : Form
    {
        private int pos;
        private bool editar;
        public frmEditMascotas()
        {
            InitializeComponent();
            editar = false;
        }

        public frmEditMascotas(int pos)
        {
            InitializeComponent();

            this.pos = pos;
            editar = true;

            CargarCombos();

            Mascotas mascota =
                TListaMascotas.listaMascotas[pos];

            txtCodigo.Text = mascota.IdCodigo.ToString();
            txtNombre.Text = mascota.Nombre;
            txtEdad.Text = mascota.Edad.ToString();
            txtRaza.Text = mascota.Raza;
            txtPeso.Text = mascota.Peso.ToString();

            cmbEspecie.Text = mascota.Especie;
            cmbSexo.Text = mascota.Sexo;

            cmbDueño.SelectedItem = mascota.Dueño;

            dtpFechaNacimiento.Value =
                mascota.FechaNacimiento;
        }

        private void CargarCombos()
        {
            cmbEspecie.Items.Add("Perro");
            cmbEspecie.Items.Add("Gato");
            cmbEspecie.Items.Add("Ave");
            cmbEspecie.Items.Add("Conejo");
            cmbEspecie.Items.Add("Hamster");
            cmbEspecie.Items.Add("Tortuga");

            cmbSexo.Items.Add("Macho");
            cmbSexo.Items.Add("Hembra");

            cmbDueño.DataSource = null;
            cmbDueño.DataSource =
                TListaClientes.listaClientes;
        }

 

        private void frmEditMascotas_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascotas mascota = new Mascotas();

            mascota.IdCodigo =
                Convert.ToInt32(txtCodigo.Text);

            mascota.Nombre =
                txtNombre.Text;

            mascota.Edad =
                Convert.ToInt32(txtEdad.Text);

            mascota.Raza =
                txtRaza.Text;

            mascota.Peso =
                Convert.ToDouble(txtPeso.Text);

            mascota.Especie =
                cmbEspecie.Text;

            mascota.Sexo =
                cmbSexo.Text;

            mascota.FechaNacimiento =
                dtpFechaNacimiento.Value;

            mascota.Dueño =
                (Clientes)cmbDueño.SelectedItem;

            if (editar)
            {
                TListaMascotas.Modificar(
                    pos,
                    mascota);

                MessageBox.Show(
                    "Mascota modificada correctamente.");
            }
            else
            {
                TListaMascotas.Agregar(
                    mascota);

                MessageBox.Show(
                    "Mascota registrada correctamente.");
            }

            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
