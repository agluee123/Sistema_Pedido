using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Sistema_de_pedidos;

namespace Negocio
{
    public class StockNegocio
    {
        
        
        public void agregarOActualizarStock(Stock stock)
        {
           
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Cantidad FROM Stock WHERE Nombre = @Nombre");
                datos.setearParametro("@Nombre", stock.nombre);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int id = (int)datos.Lector["Id"];
                    int cantidadActual = (int)datos.Lector["Cantidad"];
                    int nuevaCantidad = cantidadActual + stock.cantidad;

                    datos.cerrarConexion(); // cierro el actual

                    // nueva instancia para evitar problemas de parámetros
                    AccesoDatos datosUpdate = new AccesoDatos();
                    datosUpdate.setearConsulta("UPDATE Stock SET Cantidad = @Cantidad WHERE Id = @Id");
                    datosUpdate.setearParametro("@Cantidad", nuevaCantidad);
                    datosUpdate.setearParametro("@Id", id);
                    datosUpdate.ejecutarAccion();
                }
                else
                {
                    datos.cerrarConexion();

                    AccesoDatos datosInsert = new AccesoDatos();
                    datosInsert.setearConsulta("INSERT INTO Stock (Nombre, Cantidad) VALUES (@Nombre, @Cantidad)");
                    datosInsert.setearParametro("@Nombre", stock.nombre);
                    datosInsert.setearParametro("@Cantidad", stock.cantidad);
                    datosInsert.ejecutarAccion();
                }
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




        public List<Stock> listar()
        {
            List<Stock> lista = new List<Stock>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from stock";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Stock aux = new Stock();
                    aux.id = (int)lector["Id"];

                    aux.nombre = (string)lector["Nombre"];
                    aux.cantidad = (int)lector["Cantidad"];

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

        public void Modificar(Stock modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update stock set nombre = @Nombre, cantidad = @Cantidad WHERE id = @Id");

                datos.setearParametro("@Id", modificar.id);
                datos.setearParametro("@Nombre", modificar.nombre);
                datos.setearParametro("@Cantidad", modificar.cantidad);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarStock(Stock eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("delete from stock where id = @Id");
                datos.setearParametro("@Id", eliminar.id);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el stock: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}