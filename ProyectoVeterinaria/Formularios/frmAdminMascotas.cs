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
    public partial class frmAdminMascotas : Form
    {
        public frmAdminMascotas()
        {
            InitializeComponent();
        }

        private void OrdenarColumnas()
        {
            dgvMascotas.Columns["Nombre"].DisplayIndex = 0;
            dgvMascotas.Columns["Edad"].DisplayIndex = 1;
            dgvMascotas.Columns["Especie"].DisplayIndex = 2;
            dgvMascotas.Columns["Raza"].DisplayIndex = 3;
            dgvMascotas.Columns["Sexo"].DisplayIndex = 4;
            dgvMascotas.Columns["Peso"].DisplayIndex = 5;
            dgvMascotas.Columns["FechaNacimiento"].DisplayIndex = 6;
            dgvMascotas.Columns["Dueño"].DisplayIndex = 7;

        }

        private void CargarMascotas()
        {
            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = TListaMascotas.listaMascotas;
            OrdenarColumnas();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEditMascotas frm = new frmEditMascotas();
            frm.ShowDialog();
            CargarMascotas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            Mascotas seleccionado =
                (Mascotas)dgvMascotas.CurrentRow.DataBoundItem;

            int pos = TListaMascotas.listaMascotas.IndexOf(seleccionado);

            DialogResult res = MessageBox.Show(
                "¿Está seguro de eliminar esta mascota?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                TListaMascotas.Eliminar(pos);

                CargarMascotas();

                MessageBox.Show(
                    "Mascota eliminada correctamente.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fila.");
                return;
            }

            Mascotas seleccionado =
                (Mascotas)dgvMascotas
                .CurrentRow
                .DataBoundItem;

            int pos =
                TListaMascotas.listaMascotas
                .IndexOf(seleccionado);

            frmEditMascotas frm =
                new frmEditMascotas(pos);

            frm.ShowDialog();

            CargarMascotas();
        }

        private void frmAdminMascotas_Load(object sender, EventArgs e)
        {

        }
    }
}
