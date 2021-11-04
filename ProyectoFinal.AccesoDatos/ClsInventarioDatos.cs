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
    public class ClsInventarioDatos
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
                SqlCommand comando = new SqlCommand("SP_Inventario_Listar", sqlCnx);
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
                SqlCommand comando = new SqlCommand("SP_Inventario_Buscar", sqlCnx);
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
        public String Insertar(ClsInventarioEntidad objInventario)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Inventario_Ingresar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = objInventario.id_producto;
                comando.Parameters.Add("@pstock", SqlDbType.Int).Value = objInventario.Stock;
                comando.Parameters.Add("@pstockfisico", SqlDbType.Int).Value = objInventario.Stock_Fisico;
                comando.Parameters.Add("@pdiferencia", SqlDbType.Int).Value = objInventario.Diferencia;
                comando.Parameters.Add("@pstocksalida", SqlDbType.Int).Value = objInventario.Stock_Salida;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objInventario.Estado;
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

        public String Actualizar(ClsInventarioEntidad objInventario)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Inventario_Actualizar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidinventario", SqlDbType.Int).Value = objInventario.id_Inventario;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = objInventario.id_producto;
                comando.Parameters.Add("@pstock", SqlDbType.Int).Value = objInventario.Stock;
                comando.Parameters.Add("@pstockfisico", SqlDbType.Int).Value = objInventario.Stock_Fisico;
                comando.Parameters.Add("@pdiferencia", SqlDbType.Int).Value = objInventario.Diferencia;
                comando.Parameters.Add("@pstocksalida", SqlDbType.Int).Value = objInventario.Stock_Salida;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objInventario.Estado;
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
                SqlCommand comando = new SqlCommand("SP_Inventario_Eliminar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidempleado", SqlDbType.Int).Value = id;
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
                SqlCommand comando = new SqlCommand("SP_Producto_Verificar", sqlCnx);
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

        public DataTable Listar_Activar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Inventario_ListarActivar", sqlCnx);
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

        public DataTable identificador()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Inventario_id", sqlCnx);
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
    }
}
