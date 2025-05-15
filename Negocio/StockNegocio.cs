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
        //public void Agregar(Stock nuevo)
        //{

        //    AccesoDatos datos = new AccesoDatos();
        //    datos.setearConsulta("insert into stock(nombre,cantidad) values (@nombre, @cantidad) ");
        //    datos.setearParametro("@nombre", nuevo.nombre);
        //    datos.setearParametro("@cantidad", nuevo.cantidad);

        //    datos.ejecutarAccion();
        //    datos.cerrarConexion();
        //}

        public void agregarOActualizarStock(Stock stock)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Cantidad FROM Stock WHERE Id = @Id");
                datos.setearParametro("@Id", stock.id);
                datos.ejecutarLectura();

                int cantidadActual = 0;

                if (datos.Lector.Read())
                {
                    cantidadActual = (int)datos.Lector["Cantidad"];
                    datos.cerrarConexion();

                    int nuevaCantidad = cantidadActual + stock.cantidad;

                    datos.setearConsulta("UPDATE Stock SET Cantidad = @Cantidad WHERE Id = @Id");
                    datos.setearParametro("@Cantidad", nuevaCantidad);
                    datos.setearParametro("@Id", stock.id);
                    datos.ejecutarAccion();
                }
                else
                {
                    datos.cerrarConexion();
                    datos.setearConsulta("INSERT INTO Stock (Nombre, Cantidad) VALUES (@Nombre, @Cantidad)");
                    datos.setearParametro("@Nombre", stock.nombre);
                    datos.setearParametro("@Cantidad", stock.cantidad);
                    datos.ejecutarAccion();
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