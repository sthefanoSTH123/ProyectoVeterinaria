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
    public partial class frmMascotas : Form
    {
        private string tipoMascota;
        private int posicion;

        public frmMascotas()
        {
            InitializeComponent();
        }

        public frmMascotas(string tipo)
        {
            InitializeComponent();
            tipoMascota = tipo;
            this.posicion = -1;
            ConfigurarFormulario();
        }

        public frmEditMascotas(string tipo, int pos)
        {
            InitializeComponent();
            this.tipoMascota = tipo;
            this.posicion = pos;
            ConfigurarFormulario();
            CargarDatos();
        }

        private void ConfigurarFormulario()
        {
            lblRaza.Enabled = false;
            txtRaza.Enabled = false;

            lblDomestico.Enabled = false;
            chkDomestico.Enabled = false;

            if (tipoMascota == "Perro")
            {
                lblRaza.Enabled = true;
                txtRaza.Enabled = true;
            }
            else if (tipoMascota == "Gato")
            {
                lblDomestico.Enabled = true;
                chkDomestico.Enabled = true;
            }
        }
    }
}
