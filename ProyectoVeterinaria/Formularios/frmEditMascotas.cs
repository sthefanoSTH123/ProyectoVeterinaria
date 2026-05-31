using ProyectoVeterinaria.Controladores;
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
                TListaMascotas.listaMascotas;
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
    }
}
