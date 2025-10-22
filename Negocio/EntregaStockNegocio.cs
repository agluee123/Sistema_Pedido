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
                SELECT e.Id, e.IdStock, s.Nombre AS NombreProducto, e.EntregadoA, e.CantidadEntregada, e.FechaEntrega
                FROM EntregaStock e
                INNER JOIN Stock s ON e.IdStock = s.Id";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EntregaStock aux = new EntregaStock();
                    aux.id = (int)lector["Id"];
                    aux.idStock = (int)lector["IdStock"];
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

        //public void modificarEntrega(EntregaStock entrega, int cantidadAnterior)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        // Validar que la nueva cantidad no exceda el stock disponible
        //        int stockActual = obtenerStockActual(entrega.idStock);
        //        int diferencia = entrega.cantidadEntregada - cantidadAnterior;

        //        if (diferencia > stockActual)
        //        {
        //            throw new Exception($"No hay suficiente stock disponible. Solo quedan {stockActual} unidades.");
        //        }

        //        datos.setearConsulta(@"
        //    BEGIN TRANSACTION;

        //    -- Actualizar la entrega
        //    UPDATE EntregaStock
        //    SET EntregadoA = @EntregadoA,
        //        CantidadEntregada = @CantidadEntregada
        //    WHERE Id = @Id;

        //    -- Ajustar el stock
        //    UPDATE Stock
        //    SET Cantidad = Cantidad - @Diferencia
        //    WHERE Id = @IdStock;

        //    COMMIT TRANSACTION;
        //");

        //        datos.setearParametro("@EntregadoA", entrega.entregadoA);
        //        datos.setearParametro("@CantidadEntregada", entrega.cantidadEntregada);
        //        datos.setearParametro("@Id", entrega.id);
        //        datos.setearParametro("@IdStock", entrega.idStock);
        //        datos.setearParametro("@Diferencia", diferencia);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al modificar la entrega: " + ex.Message);
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        public void modificarEntrega(EntregaStock entrega, int cantidadAnterior, int idStockAnterior)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Obtener stock actual de ambos artículos
                int stockOriginal = obtenerStockActual(idStockAnterior);
                int stockNuevo = obtenerStockActual(entrega.idStock);

                // Calcular la diferencia de cantidad si es el mismo artículo
                if (entrega.idStock == idStockAnterior)
                {
                    int diferencia = entrega.cantidadEntregada - cantidadAnterior;
                    if (diferencia > stockNuevo)
                        throw new Exception($"No hay suficiente stock. Solo quedan {stockNuevo} unidades.");

                    datos.setearConsulta(@"
                BEGIN TRANSACTION;

                -- Actualizar la entrega
                UPDATE EntregaStock
                SET EntregadoA = @EntregadoA,
                    CantidadEntregada = @CantidadEntregada
                WHERE Id = @Id;

                -- Ajustar el stock del mismo artículo
                UPDATE Stock
                SET Cantidad = Cantidad - @Diferencia
                WHERE Id = @IdStock;

                COMMIT TRANSACTION;
            ");

                    datos.setearParametro("@Diferencia", diferencia);
                }
                else
                {
                    // Si el artículo cambia, devolver cantidad anterior al stock del artículo viejo
                    if (entrega.cantidadEntregada > stockNuevo)
                        throw new Exception($"No hay suficiente stock del nuevo artículo. Solo quedan {stockNuevo} unidades.");

                    datos.setearConsulta(@"
                BEGIN TRANSACTION;

                -- Ajustar stock antiguo (devolver cantidad anterior)
                UPDATE Stock
                SET Cantidad = Cantidad + @CantidadAnterior
                WHERE Id = @IdStockAnterior;

                -- Ajustar stock nuevo (restar nueva cantidad)
                UPDATE Stock
                SET Cantidad = Cantidad - @CantidadNueva
                WHERE Id = @IdStockNuevo;

                -- Actualizar entrega con nuevo artículo
                UPDATE EntregaStock
                SET EntregadoA = @EntregadoA,
                    CantidadEntregada = @CantidadNueva,
                    IdStock = @IdStockNuevo
                WHERE Id = @Id;

                COMMIT TRANSACTION;
            ");

                    datos.setearParametro("@CantidadAnterior", cantidadAnterior);
                    datos.setearParametro("@CantidadNueva", entrega.cantidadEntregada);
                    datos.setearParametro("@IdStockAnterior", idStockAnterior);
                    datos.setearParametro("@IdStockNuevo", entrega.idStock);
                }

                // Parámetros comunes
                datos.setearParametro("@EntregadoA", entrega.entregadoA);
                datos.setearParametro("@CantidadEntregada", entrega.cantidadEntregada);
                datos.setearParametro("@Id", entrega.id);
                if (entrega.idStock == idStockAnterior)
                    datos.setearParametro("@IdStock", entrega.idStock);

                // Ejecutar la acción
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la entrega: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }





    }
}
