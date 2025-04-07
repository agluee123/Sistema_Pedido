using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloPedidoNegocio
    {
        public void agregar(ArticuloPedido nuevo)
        {
			AccesoDatos datos= new AccesoDatos();	
			try
			{
				datos.setearConsulta("insert into ArticulosPedidos (pedido_id ,articulo_id ,cantidad, observacion) values (@pedido_id,@articulo_id,@cantidad,@observacion)");
				datos.setearParametro("@pedido_id", nuevo.PedidoId);
                datos.setearParametro("@articulo_id", nuevo.ArticuloId);
                datos.setearParametro("@cantidad", nuevo.Cantidad);
                datos.setearParametro("@observacion", nuevo.Observacion);

                datos.ejecutarAccion();

            }
			catch (Exception ex)
			{
                datos.cerrarConexion();
				throw ex;
			}

        }

        public List<ArticuloPedido> listar()
        {
            List<ArticuloPedido> lista = new List<ArticuloPedido>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = @"
            SELECT 
                ArticulosPedidos.id_articulosPedido,
                ArticulosPedidos.pedido_id,
                ArticulosPedidos.articulo_id,
                ArticulosPedidos.cantidad,
                ArticulosPedidos.observacion,
                Articulo.nombre as articulo
            FROM 
                ArticulosPedidos
            JOIN 
                Articulo ON ArticulosPedidos.articulo_id = Articulo.id_articulo";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ArticuloPedido aux = new ArticuloPedido
                    {
                        IdArticulosPedido = (int)lector["id_articulosPedido"],
                        PedidoId = (int)lector["pedido_id"],
                        ArticuloId = (int)lector["articulo_id"],
                        Cantidad = (int)lector["cantidad"],
                        Observacion = lector["observacion"] != DBNull.Value ? (string)lector["observacion"] : string.Empty,
                        NombreArticulo = (string)lector["articulo"]
                    };

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

        public void EliminarArticuloPedido(ArticuloPedido eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("DELETE FROM ARTICULOSPEDIDOS WHERE id_articulosPedido = @Id");
                datos.setearParametro("@Id", eliminar.IdArticulosPedido);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el artículo: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void ModificarArticuloPedido(ArticuloPedido modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"
            UPDATE 
                ArticulosPedidos 
            SET 
                articulo_id = @articulo_id,
                cantidad = @cantidad,
                observacion = @observacion
            WHERE id_articulosPedido = @id");

                datos.setearParametro("@id", modificar.IdArticulosPedido);
                datos.setearParametro("@articulo_id", modificar.ArticuloId);
                datos.setearParametro("@cantidad", modificar.Cantidad);
                datos.setearParametro("@observacion", modificar.Observacion ?? (object)DBNull.Value);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el artículo del pedido: " + ex.Message);
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }






    }
}
