using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_pedidos;

namespace Negocio
{
    public class EntregaStockNegocio
    {
        public void registrarEntrega(EntregaStock entrega) { 
            
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.setearConsulta(@"
                    BEGIN TRANSACTION

                    INSERT INTO EntregaStock (IdStock, EntregadoA, CantidadEntregada, FechaEntrega)
                    VALUES (@IdStock, @EntregadoA, @CantidadEntregada, @FechaEntrega);

                    UPDATE Stock
                    SET Cantidad = Cantidad - @CantidadEntregada
                    WHERE Id = @IdStock;

                    COMMIT TRANSACTION;
                    ");
                    datos.setearParametro("@IdStock", entrega.idStock);
                    datos.setearParametro("@EntregadoA", entrega.entregadoA);
                    datos.setearParametro("@CantidadEntregada", entrega.cantidadEntregada);
                    datos.setearParametro("@FechaEntrega", entrega.fechaEntrega);

                    datos.ejecutarAccion();

                    datos.cerrarConexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<EntregaStock> listar(){

            List <EntregaStock> lista=new List <EntregaStock>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = @"
                SELECT e.Id, s.Nombre AS NombreProducto, e.EntregadoA, e.CantidadEntregada, e.FechaEntrega
                FROM EntregaStock e
                INNER JOIN Stock s ON e.IdStock = s.Id";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EntregaStock aux = new EntregaStock();
                    aux.id = (int)lector["Id"];
                    aux.NombreProducto = lector["NombreProducto"].ToString();
                    aux.entregadoA = lector["EntregadoA"].ToString();
                    aux.cantidadEntregada = (int)lector["CantidadEntregada"];
                    aux.fechaEntrega = (DateTime)lector["FechaEntrega"];

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

        public int obtenerStockActual(int idStock)
        {
            int cantidad = 0;
            using (SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true"))
            {
                SqlCommand comando = new SqlCommand("SELECT Cantidad FROM Stock WHERE Id = @id", conexion);
                comando.Parameters.AddWithValue("@id", idStock);
                conexion.Open();
                object resultado = comando.ExecuteScalar();
                if (resultado != null)
                    cantidad = Convert.ToInt32(resultado);
            }
            return cantidad;
        }


    }
}
