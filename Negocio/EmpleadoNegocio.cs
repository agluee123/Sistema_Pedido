using Dominio;
using Sistema_de_pedidos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        public void Agregar(Empleado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("INSERT INTO Empleados (nombre, apellido, DNI, edad, nacionalidad, domicilio, contacto, tarea, FechaIngreso) VALUES (@nombre, @apellido, @DNI, @edad, @nacionalidad, @domicilio, @contacto, @tarea, @FechaIngreso)");

            datos.setearParametro("@nombre", nuevo.Nombre);
            datos.setearParametro("@apellido", nuevo.Apellido);
            datos.setearParametro("@DNI", nuevo.DNI);
            datos.setearParametro("@edad", nuevo.Edad);
            datos.setearParametro("@nacionalidad", nuevo.Nacionalidad);
            datos.setearParametro("@domicilio", nuevo.Domicilio);
            datos.setearParametro("@contacto", nuevo.Contacto);
            datos.setearParametro("@tarea", nuevo.Tarea);
            datos.setearParametro("@FechaIngreso", nuevo.FechaIngreso);

            datos.ejecutarAccion();
            datos.cerrarConexion();

        }


        public List<Empleado> listar()
        {
            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Empleados";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Empleado aux = new Empleado();

                    aux.Id = (int)lector["id"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Apellido = (string)lector["apellido"];
                    aux.DNI = (string)lector["DNI"];
                    aux.Edad = (int)lector["edad"];
                    aux.Nacionalidad = (string)lector["nacionalidad"];
                    aux.Domicilio = (string)lector["domicilio"];
                    aux.Contacto = (string)lector["contacto"];
                    aux.Tarea = (string)lector["tarea"];
                    aux.FechaIngreso = (DateTime)lector["FechaIngreso"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarEmpleado(Empleado eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Empleados WHERE id = @Id");
                datos.setearParametro("@Id", eliminar.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarEmpleado(Empleado modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Empleados SET nombre = @Nombre, apellido = @Apellido, DNI = @DNI, edad = @Edad, nacionalidad = @Nacionalidad, domicilio = @Domicilio, contacto = @Contacto, tarea = @Tarea, FechaIngreso = @FechaIngreso WHERE id = @Id");

                datos.setearParametro("@Id", modificar.Id);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Apellido", modificar.Apellido);
                datos.setearParametro("@DNI", modificar.DNI);
                datos.setearParametro("@Edad", modificar.Edad);
                datos.setearParametro("@Nacionalidad", modificar.Nacionalidad);
                datos.setearParametro("@Domicilio", modificar.Domicilio);
                datos.setearParametro("@Contacto", modificar.Contacto);
                datos.setearParametro("@Tarea", modificar.Tarea);
                datos.setearParametro("@FechaIngreso", modificar.FechaIngreso);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
