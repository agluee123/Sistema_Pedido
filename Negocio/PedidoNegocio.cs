using Dominio;
using Sistema_de_pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PedidoNegocio
    {
        public List<Articulo> listarNombre()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id_articulo,nombre from articulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)lector["id_articulo"];

                    aux.Nombre = (string)lector["nombre"];

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


        public int InsertarPedido(Pedido nuevo)
        {
            int pedidoId = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Pedidos (fecha, cliente_id,tipo,Estado) output inserted.id_pedido values (@Fecha, @ClienteId,@Tipo,@Estado)");
                datos.setearParametro("@Fecha", nuevo.Fecha);
                datos.setearParametro("@ClienteId", nuevo.ClienteId);
                datos.setearParametro("@Tipo", nuevo.Tipo);
                datos.setearParametro("@Estado", nuevo.Estado);

                datos.abrirConexion();  

                pedidoId = (int)datos.ejecutarAccionEscalar();

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return pedidoId;
        }


        public List<Pedido> ListarPedidos()
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "SELECT Pedidos.id_pedido, Pedidos.Tipo, Pedidos.Estado, Clientes.nombre AS Nombre, Clientes.localidad AS Localidad, Pedidos.fecha AS fecha_Del_Pedido FROM Pedidos JOIN Clientes ON Clientes.id_cliente = Pedidos.cliente_id ORDER BY Pedidos.fecha DESC;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pedido aux = new Pedido
                    {
                        IdPedido = (int)lector["id_pedido"],
                        NombreCliente = (string)lector["Nombre"],
                        Fecha = (DateTime)lector["Fecha_Del_Pedido"],
                        Tipo = (string)lector["Tipo"],
                        Estado = (string)lector["Estado"],
                        Localidad = (string)lector["Localidad"]
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

        public void EliminarPedido(Pedido eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("DELETE FROM PEDIDOS WHERE id_pedido = @Id");
                datos.setearParametro("@Id", eliminar.IdPedido);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el pedido: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void EliminarPedidos(List<int> idsPedidos)
        {
            if (idsPedidos.Count == 0) return;

            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Eliminar artículos asociados primero
                datos.setearConsulta($"DELETE FROM ArticulosPedidos WHERE pedido_id IN ({string.Join(",", idsPedidos)})");
                datos.ejecutarAccion();

                // Luego eliminar los pedidos
                datos.setearConsulta($"DELETE FROM Pedidos WHERE id_pedido IN ({string.Join(",", idsPedidos)})");
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion(); // Asegurar que la conexión se cierre
            }
        }




        public void Modificar(Pedido modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE PEDIDOS SET estado=@Estado WHERE id_pedido = @Id");

                datos.setearParametro("@Id", modificar.IdPedido);
                datos.setearParametro("@Estado", modificar.Estado);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ModificarTipo(Pedido modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE PEDIDOS SET Tipo=@Tipo WHERE id_pedido = @Id");

                datos.setearParametro("@Id", modificar.IdPedido);
                datos.setearParametro("@Tipo", modificar.Tipo);

                datos.ejecutarAccion();

                datos.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Pedido ObtenerPorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Pedido pedido = new Pedido();

            try
            {
                datos.setearConsulta("SELECT id_pedido, Tipo, Estado FROM PEDIDOS WHERE id_pedido = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    pedido.IdPedido = (int)datos.Lector["id_pedido"];
                    pedido.Tipo = datos.Lector["Tipo"].ToString();
                    pedido.Estado = datos.Lector["Estado"].ToString();
                }

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el pedido: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }







    }
}
