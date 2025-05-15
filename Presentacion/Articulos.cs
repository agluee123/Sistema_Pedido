using Dominio;
using Negocio;
using System;
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
    public partial class Articulos : Form
    {
        private List<Articulo> lista;
        public Articulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo NuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                NuevoArticulo.Nombre=tbxNombre.Text; 
                NuevoArticulo.Categoria=cbxCategoria.SelectedItem?.ToString(); 
                NuevoArticulo.Perforacion=cbxPerforacion.SelectedItem?.ToString();   

                DialogResult resultado = MessageBox.Show("¿Está seguro que desea agregar este articulo?",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    negocio.Agregar(NuevoArticulo);

                    MessageBox.Show("Articulo agregado exitosamente");
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
                lista = new ArticuloNegocio().listar();
                dgvArticulos.DataSource = lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ModificarColumnas();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                tbxNombre.Text = seleccionado.Nombre;
                cbxCategoria.SelectedItem = seleccionado.Categoria;
                cbxPerforacion.SelectedItem = seleccionado.Perforacion;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();

        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.EliminarArticulo(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxFiltro.Text.ToUpper(); // Convertir el filtro a mayúsculas una vez

            if (filtro.Length >= 1)
            {
                listaFiltrada = lista.FindAll(x =>
                    x.Nombre.ToUpper().Contains(filtro) || // Filtrar por nombre que contiene el filtro
                    x.Categoria.ToUpper().Contains(filtro) // Filtrar por categoría que contiene el filtro
                );
            }
            else
            {
                listaFiltrada = lista; // Mostrar la lista completa si el filtro es corto
            }

            // Actualizar el DataSource del DataGridView con la lista filtrada
            dgvArticulos.DataSource = null; // Limpiar el DataSource previo si lo hubiera
            dgvArticulos.DataSource = listaFiltrada; // Asignar la lista filtrada como DataSource del DataGridView
            ModificarColumnas();


        }

        private void modificar()
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Categoria = cbxCategoria.SelectedItem?.ToString();
                seleccionado.Perforacion = cbxPerforacion.SelectedItem?.ToString();

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Modificar(seleccionado);

                // Mostrar mensaje de éxito
                MessageBox.Show("Artículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModiicar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
            cbxCategoria.SelectedItem = null;
            cbxPerforacion.SelectedItem=null; 
        }

       private void ModificarColumnas()
        {
            dgvArticulos.Columns["idArticulo"].Visible = false;
            dgvArticulos.Columns["Medida"].Visible = false;


            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Si quieres que la última columna ocupe el espacio restante
            dgvArticulos.Columns[dgvArticulos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvArticulos.ReadOnly = true;

        }

    }
}
