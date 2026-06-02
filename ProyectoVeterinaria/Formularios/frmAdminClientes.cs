using ProyectoVeterinaria.Controladores;
using ProyectoVeterinaria.Entidades;
using ProyectoVeterinaria.Entidades.ProyectoVeterinaria.Entidades;
using System;
using System.Collections;
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
    public partial class frmAdminClientes : Form
    {
        public frmAdminClientes()
        {
            InitializeComponent();
        }

        private void OrdenarColumnas()
        {
            dgvClientes.Columns["Cedula"].DisplayIndex = 0;
            dgvClientes.Columns["Nombre"].DisplayIndex = 1;
            dgvClientes.Columns["Apellido"].DisplayIndex = 2;
            dgvClientes.Columns["Telefono"].DisplayIndex = 3;
            dgvClientes.Columns["Correo"].DisplayIndex = 4;
            dgvClientes.Columns["Direccion"].DisplayIndex = 5;
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = TListaClientes.listaClientes;
            OrdenarColumnas();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEditClientes frm = new frmEditClientes();
            frm.ShowDialog();
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            Clientes seleccionado =
                (Clientes)dgvClientes.CurrentRow.DataBoundItem;

            int pos = TListaClientes.listaClientes.IndexOf(seleccionado);

            DialogResult res = MessageBox.Show(
                "¿Está seguro de eliminar este cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                TListaClientes.Eliminar(pos);

                CargarClientes();

                MessageBox.Show(
                    "Cliente eliminado correctamente.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fila.");
                return;
            }

            Clientes seleccionado = (Clientes)dgvClientes.CurrentRow.DataBoundItem;

            int pos = TListaClientes.listaClientes.IndexOf(seleccionado);

            frmEditClientes frm = new frmEditClientes(pos);
            frm.ShowDialog();

            CargarClientes();
        }
    }
}
