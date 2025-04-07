using Dominio;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
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

namespace Ilgabinetto
{
    public partial class Empleados : Form
    {
        private List<Empleado> lista;
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado NuevoEmpleado = new Empleado();
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            try
            {
                NuevoEmpleado.Nombre = tbxNombre.Text;
                NuevoEmpleado.Apellido = tbxApellido.Text;
                NuevoEmpleado.DNI = tbxDni.Text;
                NuevoEmpleado.Edad = int.Parse(tbxEdad.Text);
                NuevoEmpleado.Nacionalidad = tbxNacionalidad.Text;
                NuevoEmpleado.Domicilio = tbxDomicilio.Text;
                NuevoEmpleado.Contacto = tbxContacto.Text;
                NuevoEmpleado.Tarea = tbxTarea.Text;
                NuevoEmpleado.FechaIngreso = DateTime.Parse(dtpFecha.Text);

                DialogResult resultado = MessageBox.Show("¿Está seguro que desea agregar este Empleado?",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    negocio.Agregar(NuevoEmpleado);

                    MessageBox.Show("Empleado agregado exitosamente");
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
                lista = new EmpleadoNegocio().listar();
                dgvEmpleados.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                Empleado seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                tbxNombre.Text = seleccionado.Nombre;
                tbxApellido.Text = seleccionado.Apellido;
                tbxDni.Text = seleccionado.DNI;
                tbxEdad.Text = seleccionado.Edad.ToString(); 
                tbxNacionalidad.Text = seleccionado.Nacionalidad;
                tbxDomicilio.Text = seleccionado.Domicilio;
                tbxContacto.Text = seleccionado.Contacto;
                tbxTarea.Text = seleccionado.Tarea;
                dtpFecha.Text = seleccionado.FechaIngreso.ToString("yyyy-MM-dd"); 
            }
        }

        private void eliminar()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Empleado seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                    negocio.EliminarEmpleado(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar(); 
        }

        private void ModificarEmpleado()
        {
            try
            {
                Empleado seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Apellido = tbxApellido.Text;
                seleccionado.DNI = tbxDni.Text;
                seleccionado.Edad = int.Parse(tbxEdad.Text); 
                seleccionado.Nacionalidad = tbxNacionalidad.Text;
                seleccionado.Domicilio = tbxDomicilio.Text;
                seleccionado.Contacto = tbxContacto.Text;
                seleccionado.Tarea = tbxTarea.Text;
                seleccionado.FechaIngreso = DateTime.Parse(dtpFecha.Text); // Validar formato de fecha

                EmpleadoNegocio negocio = new EmpleadoNegocio();
                negocio.ModificarEmpleado(seleccionado);

                MessageBox.Show("Empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
            tbxApellido.Clear(); 
            tbxDni.Clear(); 
            tbxEdad.Clear();    
            tbxNacionalidad.Clear();
            tbxDomicilio.Clear();
            tbxContacto.Clear();    
            tbxTarea.Clear();
        }
    }
}
