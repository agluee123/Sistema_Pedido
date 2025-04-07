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
    public partial class Cargar_Pedido : Form
    {
        private List <Articulo> articulos;
        private List <ArticuloPedido> pedidos;  
        public int PedidoId { get; set; }
        

        public Cargar_Pedido(int pedidoId)
        {
            InitializeComponent();
            PedidoId = pedidoId;
        }

        private void Cargar_Pedido_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();
            List<Articulo> articulos=negocio.listar();
            cbxArticulo.DataSource=articulos;
            cbxArticulo.DisplayMember = "Nombre";
            cbxArticulo.ValueMember = "IdArticulo";
            CargarDatos();
            CambiarOrdenColumnas();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloPedido nuevo = new ArticuloPedido
                {
                    PedidoId = PedidoId,
                    ArticuloId = ((Articulo)cbxArticulo.SelectedItem).IdArticulo,
                    Cantidad = Convert.ToInt32(nmCantidad.Value),
                    Observacion = tbxObservacion.Text
                };

                ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
                negocio.agregar(nuevo);

                MessageBox.Show("Artículo agregado al pedido.");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el artículo: " + ex.Message);
            }
        }

        private void CargarDatos()
        {

            try
            {
                ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
                pedidos = negocio.listar();
                var pedidosFiltrados = pedidos.Where(p => p.PedidoId == PedidoId).ToList();

                dgvPedido.DataSource = pedidosFiltrados;
                dgvPedido.Columns["IdArticulosPedido"].Visible = false;
                dgvPedido.Columns["PedidoId"].Visible = false;
                dgvPedido.Columns["ArticuloId"].Visible = false;

                dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Si quieres que la última columna ocupe el espacio restante
                dgvPedido.Columns[dgvPedido.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void CambiarOrdenColumnas()
        {
            
            dgvPedido.Columns["Cantidad"].DisplayIndex = 0; // Primera columna
            dgvPedido.Columns["NombreArticulo"].DisplayIndex = 1; // Segunda columna
            dgvPedido.Columns["Observacion"].DisplayIndex = 2; // Tercera columna
                                                                  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloPedido seleccionado = (ArticuloPedido)dgvPedido.CurrentRow.DataBoundItem;
                    negocio.EliminarArticuloPedido(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            try
            {
                PedidoNegocio negocio = new PedidoNegocio();
                Pedido pedido = new Pedido();
                pedido.Estado = CbxEstado.SelectedItem?.ToString();
                pedido.IdPedido = PedidoId;
                negocio.Modificar(pedido);

                MessageBox.Show("El estado del pedido fue cambiado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Debes seleccionar el estado del pedido: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar selección en el DataGridView
                if (dgvPedido.CurrentRow == null ||dgvPedido.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Por favor seleccione un artículo del pedido para modificar",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que se haya seleccionado un artículo en el ComboBox
                if (cbxArticulo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un artículo",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Obtener el artículo seleccionado del DataGridView
                ArticuloPedido articuloSeleccionado = (ArticuloPedido)dgvPedido.CurrentRow.DataBoundItem;

                // 4. Obtener el artículo seleccionado del ComboBox
                Articulo articuloNuevo = (Articulo)cbxArticulo.SelectedItem;

                // 5. Crear el objeto con los datos modificados
                ArticuloPedido articuloModificado = new ArticuloPedido
                {
                    IdArticulosPedido = articuloSeleccionado.IdArticulosPedido,
                    ArticuloId = articuloNuevo.IdArticulo, // ID del nuevo artículo seleccionado
                    NombreArticulo = articuloNuevo.Nombre,  // Nombre del nuevo artículo
                    Cantidad = Convert.ToInt32(nmCantidad.Value),
                    Observacion = tbxObservacion.Text,
                    PedidoId = articuloSeleccionado.PedidoId // Mantener el mismo pedido
                };

                // 6. Llamar al método de negocio para modificar
                ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
                negocio.ModificarArticuloPedido(articuloModificado);

                // 7. Actualizar la lista
                CargarDatos();

                MessageBox.Show("Artículo modificado correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("La cantidad debe ser un valor numérico válido", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el artículo: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
