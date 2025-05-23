﻿using System;
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
            StockNegocio negocio = new StockNegocio();
            try
            {
                string nombre = tbxNombre.Text.Trim();
                string textoCantidad = tbxStock.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingresá un nombre válido.");
                    return;
                }

                if (!int.TryParse(textoCantidad, out int cantidad))
                {
                    MessageBox.Show("La cantidad ingresada no es un número válido.");
                    return;
                }

                Stock nuevo = new Stock
                {
                    nombre = nombre,
                    cantidad = cantidad
                };

                negocio.agregarOActualizarStock(nuevo);
                CargarDatos(); 
                cargarProductos();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            tbxNombre.Text = "";
            tbxStock.Text = "";
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

                if (!int.TryParse(tbxCantidad.Text, out int cantidadAEntregar) || cantidadAEntregar <= 0)
                {
                    MessageBox.Show("Ingresá una cantidad válida mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                entrega.cantidadEntregada = cantidadAEntregar;
                entrega.fechaEntrega = dtpFechaEntrega.Value;

                EntregaStockNegocio negocio = new EntregaStockNegocio();

                
                int stockActual = negocio.obtenerStockActual(entrega.idStock);

                if (cantidadAEntregar > stockActual)
                {
                    MessageBox.Show($"No hay suficiente stock. Solo quedan {stockActual} unidades.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                negocio.registrarEntrega(entrega);

                
                int stockRestante = stockActual - cantidadAEntregar;
                if (stockRestante <= 10)
                {
                    MessageBox.Show($"⚠ Atención: Queda poco stock del producto seleccionado ({stockRestante} unidades).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CargarDatos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la entrega: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
