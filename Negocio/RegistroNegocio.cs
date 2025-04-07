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
    public class RegistroNegocio
    {



        public List<Registro> Registros()
        {
            List<Registro> lista = new List<Registro>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"
            SELECT 
                Pedidos.id_pedido, 
                Clientes.nombre AS cliente_nombre,
                Clientes.localidad AS localidad,
                Pedidos.fecha AS fecha_Del_Pedido, 
                ArticulosPedidos.cantidad AS cantidad,
                Articulo.nombre AS nombreArticulo, 
                Articulo.perforacion AS perforacion,
                Articulo.categoria AS Categoria,
                Pedidos.Tipo AS Tipo_De_Pedido,
                ArticulosPedidos.observacion AS observacion
            FROM Pedidos
            JOIN Clientes ON Clientes.id_cliente = Pedidos.cliente_id
            JOIN ArticulosPedidos ON Pedidos.id_pedido = ArticulosPedidos.pedido_id
            JOIN Articulo ON ArticulosPedidos.articulo_id = Articulo.id_articulo";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Registro aux = new Registro
                    {
                        IdPedido = (int)lector["id_pedido"],
                        NombreCliente = (string)lector["cliente_nombre"],
                        localidad = (string)lector["localidad"],
                        Fecha = (DateTime)lector["fecha_Del_Pedido"],
                        Cantidad = (int)lector["cantidad"],
                        NombreArticulo = (string)lector["nombreArticulo"],
                        Categoria = (string)lector["Categoria"],
                        Perforacion = (string)lector["perforacion"],
                        Tipo = (string)lector["Tipo_De_Pedido"],
                        Observacion = lector["observacion"] != DBNull.Value ? (string)lector["observacion"] : null
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


    }
}
