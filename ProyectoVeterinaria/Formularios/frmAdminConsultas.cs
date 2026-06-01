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
    public partial class frmAdminConsultas : Form
    {
        public frmAdminConsultas()
        {
            InitializeComponent();
        }

        private void OrdenarColumnas()
        {
            dgvConsultas.Columns["Fecha"].DisplayIndex = 0;
            dgvConsultas.Columns["Cliente"].DisplayIndex = 1;
            dgvConsultas.Columns["Mascota"].DisplayIndex = 2;
            dgvConsultas.Columns["Motivo"].DisplayIndex = 3;
            dgvConsultas.Columns["Diagnostico"].DisplayIndex = 4;
            dgvConsultas.Columns["Costo"].DisplayIndex = 5;
        }

        private void CargarConsultas()
        {
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = TListaConsultas.listaConsultas;
            OrdenarColumnas();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmEditConsultas frm = new frmEditConsultas();
            frm.ShowDialog();
            CargarConsultas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            Consultas seleccionado =
                (Consultas)dgvConsultas.CurrentRow.DataBoundItem;

            int pos = TListaConsultas.listaConsultas.IndexOf(seleccionado);

            DialogResult res = MessageBox.Show(
                "¿Está seguro de eliminar esta consulta?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                TListaConsultas.Eliminar(pos);

                CargarConsultas();

                MessageBox.Show(
                    "Consulta eliminada correctamente.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fila.");
                return;
            }

            Consultas seleccionado =
                (Consultas)dgvConsultas
                .CurrentRow
                .DataBoundItem;

            int pos =
                TListaConsultas.listaConsultas
                .IndexOf(seleccionado);

            frmEditConsultas frm =
                new frmEditConsultas(pos);

            frm.ShowDialog();
            CargarConsultas();
        }
    }
}
