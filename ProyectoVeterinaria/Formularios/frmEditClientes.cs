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
    public partial class frmEditClientes : Form
    {
        private int pos;
        private bool editar;
        public frmEditClientes()
        {
            InitializeComponent();
            editar = false;
        }

        public frmEditClientes(int pos)
        {
            InitializeComponent();

            this.pos = pos;
            editar = true;

            Clientes cliente =
                TListaClientes.listaClientes[pos];

            txtCedula.Text = cliente.Cedula;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
        }


        


        private void CargarDatos()
        {
            txtCedula.Text = clienteEditar.Cedula;
            txtNombre.Text = clienteEditar.Nombre;
            txtApellido.Text = clienteEditar.Apellido;
            txtTelefono.Text = clienteEditar.Telefono;
            txtCorreo.Text = clienteEditar.Correo;
            txtDireccion.Text = clienteEditar.Direccion;

            txtCedula.Enabled = false;
        }

        private bool ValidarCampos()
        {
            if (txtCedula.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la cédula");
                txtCedula.Focus();
                return false;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Clientes cliente = new Clientes
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text
            };

            if (editar)
            {
                TListaClientes.Modificar(pos, cliente);

                MessageBox.Show(
                    "Cliente modificado correctamente.");
            }
            else
            {
                TListaClientes.Agregar(cliente);

                MessageBox.Show(
                    "Cliente registrado correctamente.");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
