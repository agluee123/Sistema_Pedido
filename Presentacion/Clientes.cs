using Dominio;
using Negocio;
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

namespace Presentacion
{
    public partial class Clientes : Form
    {
        private List<Cliente> listaCliente;
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente NuevoCliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                NuevoCliente.Nombre = tbxNombre.Text;
                NuevoCliente.Direccion = tbxDireccion.Text;
                NuevoCliente.Cuit = tbxCuit.Text;
                NuevoCliente.Localidad = tbxLocalidad.Text;
                NuevoCliente.Telefono = tbxTelefono.Text;

                DialogResult resultado = MessageBox.Show("¿Está seguro que desea agregar este cliente?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    negocio.Agregar(NuevoCliente);

                    MessageBox.Show("Cliente agregado exitosamente");
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void CargarDatos()
        {
            
            try
            {
                listaCliente = new ClienteNegocio().listar();
                dgvClientes.DataSource = listaCliente;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ModificarColumnas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();

        }

        private void eliminar()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    negocio.EliminarCliente(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                tbxNombre.Text = seleccionado.Nombre;
                tbxDireccion.Text = seleccionado.Direccion;
                tbxCuit.Text = seleccionado.Cuit;
                tbxLocalidad.Text = seleccionado.Localidad;
                tbxTelefono.Text = seleccionado.Telefono;


            }

        }

        private void modificar()
        {
            try
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Direccion = tbxDireccion.Text;
                seleccionado.Cuit = tbxCuit.Text;
                seleccionado.Localidad=tbxLocalidad.Text;
                seleccionado.Telefono = tbxTelefono.Text;

                ClienteNegocio negocio = new ClienteNegocio();
                negocio.ModificarCliente(seleccionado);

                // Mostrar mensaje de éxito
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Text = "";
            tbxDireccion.Text = "";
            tbxCuit.Text = "";
            tbxLocalidad.Text = "";
            tbxTelefono.Text = "";

        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> listaFiltrada;
            string filtro = tbxFiltro.Text.ToUpper();

            if (filtro.Length >= 1)
            {
                listaFiltrada = listaCliente.FindAll(x =>
                    x.Nombre.ToUpper().Contains(filtro) || // Filtrar por nombre que contiene el filtro
                    x.Localidad.ToUpper().Contains(filtro)||
                    x.Telefono.ToUpper().Contains(filtro)
                // Filtrar por categoría que contiene el filtro
                );
            }
            else
            {
                listaFiltrada = listaCliente; 
            }

            // Actualizar el DataSource del DataGridView con la lista filtrada
            dgvClientes.DataSource = null; 
            dgvClientes.DataSource = listaFiltrada;
            ModificarColumnas();
        }

        private void ModificarColumnas()
        {
            dgvClientes.Columns["idCliente"].Visible = false;


        }
    }
}
