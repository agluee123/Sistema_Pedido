using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public void Agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("insert into articulo(nombre,categoria,perforacion) values (@nombre, @categoria, @perforacion) ");
            datos.setearParametro("@nombre", nuevo.Nombre);
            datos.setearParametro("@categoria", nuevo.Categoria);
            datos.setearParametro("@perforacion", nuevo.Perforacion);

            datos.ejecutarAccion();
            datos.cerrarConexion();
        }


        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from articulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)lector["id_articulo"];

                    aux.Nombre = (string)lector["nombre"];
                    aux.Categoria = (string)lector["categoria"];
                    aux.Perforacion = (string)lector["perforacion"];

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

        public void EliminarArticulo(Articulo eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("DELETE FROM ARTICULO WHERE id_articulo = @Id");
                datos.setearParametro("@Id", eliminar.IdArticulo);
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

        public void Modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULO SET nombre = @Nombre, categoria = @Categoria, perforacion = @perforacion WHERE id_articulo = @Id");

                datos.setearParametro("@Id",modificar.IdArticulo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@categoria", modificar.Categoria);
                datos.setearParametro("@perforacion", modificar.Perforacion);

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
