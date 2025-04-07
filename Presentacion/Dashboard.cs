using Ilgabinetto;
using Sistema_de_pedidos;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos agregar = new Articulos();
            agregar.ShowDialog();   
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes agregar = new Clientes();
            agregar.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos agregar= new Pedidos();
            agregar.ShowDialog();

        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registros agregar= new Registros();
            agregar.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados agregar= new Empleados(); 
            agregar.ShowDialog();     
        }
    }
}
