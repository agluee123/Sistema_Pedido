using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private SqlTransaction transaccion;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public void IniciarTransaccion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true");
                conexion.Open();
            }
            transaccion = conexion.BeginTransaction();
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
          if (lector != null)
              lector.Close();
            conexion.Close();
        }

        public object ejecutarAccionEscalar()
        {
            return comando.ExecuteScalar();
        }

        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            comando.Connection = conexion;
        }

        public void ConfirmarTransaccion()
        {
            if (transaccion != null)
            {
                transaccion.Commit();
                transaccion = null;
            }
        }

        public void RevertirTransaccion()
        {
            if (transaccion != null)
            {
                transaccion.Rollback();
                transaccion = null;
            }
        }

    }
}
