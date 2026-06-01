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

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmAdminClientes frm= new frmAdminClientes();
            frm.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            frmAdminMascotas frm = new frmAdminMascotas();
            frm.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmAdminConsultas frm = new frmAdminConsultas();
            frm.ShowDialog();
        }
    }
}
