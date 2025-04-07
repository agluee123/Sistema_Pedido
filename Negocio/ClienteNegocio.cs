using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from clientes";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.IdCliente = (int)lector["id_cliente"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Direccion = (string)lector["direccion"];
                    aux.Cuit = (string)lector["cuit"];
                    aux.Localidad = (string)lector["localidad"];
                    aux.Telefono = (string)lector["telefono"];

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

        public void Agregar(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into clientes(nombre,direccion,cuit,localidad,telefono) values (@nombre, @direccion, @cuit, @localidad, @telefono) ");
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@direccion", nuevo.Direccion);
                datos.setearParametro("@cuit", nuevo.Cuit);
                datos.setearParametro("@localidad", nuevo.Localidad);
                datos.setearParametro("@telefono", nuevo.Telefono);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
                
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void EliminarCliente(Cliente eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from clientes where id_cliente = @Id");
                datos.setearParametro("@Id", eliminar.IdCliente);
                datos.ejecutarAccion();
                Console.WriteLine("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                throw; 
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarCliente(Cliente modificar)
        {
            AccesoDatos datos=new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE clientes SET nombre = @Nombre, direccion = @Direccion, cuit = @CUIT, localidad = @Localidad, telefono = @Telefono WHERE id_cliente = @IdCliente;");

                datos.setearParametro("@IdCliente", modificar.IdCliente);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Direccion", modificar.Direccion);
                datos.setearParametro("@CUIT", modificar.Cuit);
                datos.setearParametro("@Localidad", modificar.Localidad);
                datos.setearParametro("@Telefono", modificar.Telefono);

                datos.ejecutarAccion();
        


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }




    }
}
