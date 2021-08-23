using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidad;

namespace ProyectoFinal.AccesoDatos
{
    public class ClsUsuarioDetalleInventarioDatos
    {
        //CREAR METODO
        //METODO LISTAR

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Listar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }

        }

        // METODO BUSCAR
        public DataTable Buscar(string busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Buscar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = busqueda;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }

        }

        // METODO INSERTAR
        public String Insertar(ClsUsuarioDetalleInventarioEntidad objUDI)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Ingresar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@piddetalleinventario", SqlDbType.Int).Value = objUDI.id_detalle;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = objUDI.id_usuario;
                sqlCnx.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK se inserto en el registra" : "No se pudo insertar registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return respuesta;
        }

        public String Actualizar(ClsUsuarioDetalleInventarioEntidad objUDI)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Actualizar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidusuariodetalleinventario", SqlDbType.Int).Value = objUDI.id_detalleUsuario;
                comando.Parameters.Add("@piddetalleinventario", SqlDbType.Int).Value = objUDI.id_detalle;
                comando.Parameters.Add("@pidusuario", SqlDbType.Int).Value = objUDI.id_usuario;

                sqlCnx.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK RESGITRO SE ACTUALIZO" : "No se pudo actualizar registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return respuesta;
        }

        public String Eliminar(int id)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Eliminar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidusuariodetalleinventario", SqlDbType.Int).Value = id;
                sqlCnx.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK se Elimino" : "No se pudo Eliminar registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return respuesta;
        }

        public String Verificar(int valor)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_UsuarioDetalleInventario_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@pexiste";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCnx.Open();
                respuesta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
            return respuesta;
        }
    }
}
