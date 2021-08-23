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
    public class ClsLocalDatos
    {
        //crear metodos
        //METODO LISTAR

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Local_Listar", sqlCnx);
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
                SqlCommand comando = new SqlCommand("SP_Local_Buscar", sqlCnx);
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
        public String Insertar(ClsLocalEntidad objLocal)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Local_Ingresar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objLocal.Nombre;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objLocal.Direccion;
                comando.Parameters.Add("@ptelefono", SqlDbType.VarChar).Value = objLocal.Telefono;
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

        public String Actualizar(ClsLocalEntidad objLocal)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Local_Actualizar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidlocal", SqlDbType.Int).Value = objLocal.id_Local;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objLocal.Nombre;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objLocal.Direccion;
                comando.Parameters.Add("@ptelefono", SqlDbType.VarChar).Value = objLocal.Telefono;
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
                SqlCommand comando = new SqlCommand("SP_Local_Eliminar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidlocal", SqlDbType.Int).Value = id;
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

        public String Verificar(string valor)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Local_Verificar", sqlCnx);
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

        public DataTable Combo()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Local_Combo", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
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
    }
}
