using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using Sistema_de_pedidos;

namespace Ilgabinetto
{
    public partial class VistaStock : Form
    {
        private List<Stock> lista;
        private List<EntregaStock> lista2;
        public VistaStock()
        {
            InitializeComponent();
        }
        private void VistaStock_Load(object sender, EventArgs e)
        {
            CargarDatos();
            cargarProductos();
            
        }

        private void CargarDatos()
        {

            try
            {
                lista = new StockNegocio().listar();
                dgvStock.DataSource = lista;
                lista2 = new EntregaStockNegocio().listar();
                dgvEntrega.DataSource = lista2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarProductos() {
            StockNegocio negocio = new StockNegocio();
            List<Stock> listaStock = negocio.listar(); 
            cbxProducto.DataSource = listaStock;
            cbxProducto.DisplayMember = "nombre"; 
            cbxProducto.ValueMember = "id";       
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Stock stockNuevo = new Stock();
            StockNegocio negocio = new StockNegocio();
            try
            {
                Stock nuevo = new Stock();
                nuevo.id = Convert.ToInt32(dgvStock.CurrentRow.Cells["id"].Value);
                //MessageBox.Show(nuevo.id.ToString());
                nuevo.nombre = tbxNombre.Text;
                nuevo.cantidad = Convert.ToInt32(tbxCantidad.Text);

                negocio.agregarOActualizarStock(nuevo);
                CargarDatos(); // refresca
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            try
            {
                Stock seleccionado = (Stock)dgvStock.CurrentRow.DataBoundItem;

                seleccionado.nombre = tbxNombre.Text;
                seleccionado.cantidad = (int)Convert.ToInt64(tbxStock.Text);

                StockNegocio negocio = new StockNegocio();
                negocio.Modificar(seleccionado);

                // Mostrar mensaje de éxito
                MessageBox.Show("Stock modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                Stock seleccionado = (Stock)dgvStock.CurrentRow.DataBoundItem;
                tbxNombre.Text = seleccionado.nombre;
                tbxStock.Text = seleccionado.cantidad.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            StockNegocio negocio = new StockNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Stock seleccionado = (Stock)dgvStock.CurrentRow.DataBoundItem;
                    negocio.EliminarStock(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EntregaStock entrega = new EntregaStock();
                entrega.idStock = (int)cbxProducto.SelectedValue;
                entrega.entregadoA = tbxEntregado.Text;
                entrega.cantidadEntregada = int.Parse(tbxCantidad.Text);
                entrega.fechaEntrega = dtpFechaEntrega.Value;

                EntregaStockNegocio negocio = new EntregaStockNegocio();
                negocio.registrarEntrega(entrega);

                // Verificar el stock restante
                int idStock = entrega.idStock;
                int stockRestante = negocio.obtenerStockActual(idStock);
                if (stockRestante <= 10) // umbral de advertencia
                {
                    MessageBox.Show("⚠ Atención: Queda poco stock del producto seleccionado (" + stockRestante + " unidades).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //cargarGrilla();
                CargarDatos(); // refrescar grilla de stock
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la entrega: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
