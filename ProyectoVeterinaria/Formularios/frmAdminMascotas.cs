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
    public partial class frmAdminMascotas : Form
    {
        public frmAdminMascotas()
        {
            InitializeComponent();
        }

        private void CargarMascotas()
        {
            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = TListaMascotas.listaMascotas;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEditMascotas frm = new frmEditMascotas();
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            Clientes seleccionado =
                (Clientes)dgvMascotas.CurrentRow.DataBoundItem;

            int pos = TListaClientes.listaClientes.IndexOf(seleccionado);

            DialogResult res = MessageBox.Show(
                "¿Está seguro de eliminar este cliente?",
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

        }
    }
}
