using Dominio;
using Negocio;
using Sistema_de_pedidos;
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
    public partial class Pedidos : Form
    {
        private Dictionary<int, bool> checkboxStates = new Dictionary<int, bool>();
        public Pedidos()
        {
            InitializeComponent();  
        }


        private void Pedidos_Load(object sender, EventArgs e)
        {


            try
            {
               

                PedidoNegocio negocio = new PedidoNegocio();
                //cbxArticulo.DataSource = negocio.listarNombre(); // Comentado porque no está relacionado con cbxCliente
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                List<Cliente> clientes = clienteNegocio.listar(); // Obtener la lista de clientes desde el negocio

                // Si la lista de clientes está vacía, muestra un mensaje o realiza alguna acción adecuada
                if (clientes == null || clientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener el texto del filtro (no es necesario convertir a minúsculas aquí)
                string filtro = cbxCliente.Text;

                // Filtrar los clientes que coinciden con el filtro (insensible a mayúsculas y minúsculas)
                List<Cliente> clientesFiltrados = clientes
                                                    .Where(c => c.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                                                    .ToList();

                // Establecer el DataSource de la ComboBox con la lista filtrada
                cbxCliente.DataSource = null; // Limpiar el DataSource para evitar conflictos
                cbxCliente.DataSource = clientesFiltrados; // Establecer el DataSource con la lista filtrada
                cbxCliente.DisplayMember = "Nombre"; // Especificar la propiedad que quieres mostrar en la ComboBox
                ListarPedido();
                AgregarBoton();
                ModificarColumnas();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            PedidoNegocio negocio = new PedidoNegocio();

            try
            {
                if (cbxCliente.SelectedItem != null)
                {
                    Cliente seleccionado = (Cliente)cbxCliente.SelectedItem;
                    Pedido pedido = new Pedido
                    {
                        Fecha = dtpFechaPedido.Value,
                        ClienteId = seleccionado.IdCliente,
                        Tipo = cbxTipo.SelectedItem?.ToString(),
                        Estado = "Pendiente"
                    };
                    
                    int pedidoId = negocio.InsertarPedido(pedido);

                    Cargar_Pedido agregar = new Cargar_Pedido(pedidoId);
                    agregar.ShowDialog();
                    ListarPedido();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes seleccionar el tipo de pedido");
            }

        }

        private void ListarPedido()
        {
            PedidoNegocio nuevo= new PedidoNegocio();
            List<Pedido> pedidos = nuevo.ListarPedidos();
            dgvListaPedidos.DataSource = pedidos;


        }

        private void AgregarBoton()
        {
            DataGridViewButtonColumn VerPedido= new DataGridViewButtonColumn();
            VerPedido.Name = "Ver Pedido";
            VerPedido.Text = "Ver Pedido";
            VerPedido.UseColumnTextForButtonValue = true;
            VerPedido.HeaderText = "Acciones";     dgvListaPedidos.Columns.Add(VerPedido); 
        }

        private void dgvListaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvListaPedidos.Columns["Ver Pedido"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int pedidoId = (int)dgvListaPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value;

                    Cargar_Pedido form = new Cargar_Pedido(pedidoId);
                    form.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los detalles del pedido: " + ex.Message);
                }
            }



        }

        private void ModificarColumnas()
        {
            dgvListaPedidos.Columns["idPedido"].Visible = false;
            dgvListaPedidos.Columns["ClienteId"].Visible = false;

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidosAEliminar = new List<Pedido>();

            // Recorremos todas las filas del DataGridView para obtener los pedidos seleccionados
            foreach (DataGridViewRow row in dgvListaPedidos.Rows)
            {
                // Verificamos si el checkbox está marcado
                bool isSelected = Convert.ToBoolean(row.Cells["chkSelect"].Value);
                if (isSelected)
                {
                    // Obtenemos el pedido de la fila
                    Pedido pedido = row.DataBoundItem as Pedido;
                    if (pedido != null)
                    {
                        pedidosAEliminar.Add(pedido);
                    }
                }
            }

            if (pedidosAEliminar.Count == 0)
            {
                MessageBox.Show("No hay pedidos seleccionados para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar los pedidos seleccionados?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    PedidoNegocio negocio = new PedidoNegocio();
                    foreach (var pedido in pedidosAEliminar)
                    {
                        negocio.EliminarPedido(pedido);
                    }
                    MessageBox.Show("Pedidos eliminados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPedido();  // Refresca la lista de pedidos después de eliminar
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
        private void dgvListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListaPedidos.Columns["chkSelect"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = dgvListaPedidos.Rows[e.RowIndex].Cells["chkSelect"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    bool isChecked = Convert.ToBoolean(checkBoxCell.Value);
                    checkBoxCell.Value = !isChecked;
                    dgvListaPedidos.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Obtén el IdPedido de la fila actual
                    int pedidoId = (int)dgvListaPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value;

                    // Actualiza el estado del checkbox en el diccionario
                    if (checkboxStates.ContainsKey(pedidoId))
                    {
                        checkboxStates[pedidoId] = !isChecked;
                    }
                    else
                    {
                        checkboxStates.Add(pedidoId, !isChecked);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PedidoNegocio pedidoNegocio = new PedidoNegocio();
            List<Pedido> lista = pedidoNegocio.ListarPedidos();
            List<Pedido> listaFiltrada;
            string filtro = textBox1.Text.ToUpper(); // Convertir el filtro a mayúsculas una vez

            if (filtro.Length >= 1)
            {
                listaFiltrada = lista.FindAll(x =>
                    x.NombreCliente.ToUpper().Contains(filtro) || x.Fecha.ToString().Contains(filtro) 
                    || x.Tipo.ToUpper().Contains(filtro) || x.Estado.ToUpper().Contains(filtro) || x.Localidad.ToUpper().Contains(filtro) // Filtrar por nombre que contiene el filtro
                );
            }
            else
            {
                listaFiltrada = lista;
            }

            dgvListaPedidos.DataSource = listaFiltrada;

            foreach (DataGridViewRow row in dgvListaPedidos.Rows)
            {
                int pedidoId = (int)row.Cells["IdPedido"].Value;
                if (checkboxStates.ContainsKey(pedidoId))
                {
                    row.Cells["chkSelect"].Value = checkboxStates[pedidoId];
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dTPReg1.Value.Date;
            DateTime fechaFin = dTPreg2.Value.Date;
           

           

            PedidoNegocio nuevo = new PedidoNegocio();
            List<Pedido> registros = nuevo.ListarPedidos();
            

            var listaFiltrada = registros.Where(r => r.Fecha >= fechaInicio && r.Fecha <= fechaFin).ToList();

            dgvListaPedidos.DataSource = listaFiltrada;
        }


        private void dgvListaPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {    
            if (dgvListaPedidos.Columns[e.ColumnIndex].Name == "Estado")
            {
                string estado = e.Value?.ToString();

                if (estado == "Pendiente")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (estado == "Entregado")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnBuscarEst_Click(object sender, EventArgs e)
        {
            
            string Tipo = cbxSelTipo.SelectedItem?.ToString();
            string Estado = cbxSelEstado.SelectedItem?.ToString();  


            PedidoNegocio nuevo = new PedidoNegocio();
            List<Pedido> registros = nuevo.ListarPedidos();


            var listaFiltrada = registros.Where(r => r.Tipo == Tipo && r.Estado == Estado).ToList();

            dgvListaPedidos.DataSource = listaFiltrada;



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ListarPedido();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarPedido();
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            List<int> idsSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dgvListaPedidos.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chkSelect"].Value);
                if (isSelected)
                {
                    int idPedido = (int)row.Cells["idPedido"].Value;
                    idsSeleccionados.Add(idPedido);
                }
            }

            Registros registros = new Registros(idsSeleccionados);
            registros.Show();
        }


    }
}