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
    public class ClsProductosDatos
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
                SqlCommand comando = new SqlCommand("SP_Producto_Listar", sqlCnx);
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
                SqlCommand comando = new SqlCommand("SP_Producto_Buscar", sqlCnx);
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
        public String Insertar(ClsProductoEntidad objProducto)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_Ingresar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidcategoria", SqlDbType.Int).Value = objProducto.id_categoria;
                comando.Parameters.Add("@pmarca", SqlDbType.VarChar).Value = objProducto.Marca;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objProducto.Descripcion;
                comando.Parameters.Add("@pprecio", SqlDbType.Int).Value = objProducto.precio;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = objProducto.catidad;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objProducto.estado;
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

        public String Actualizar(ClsProductoEntidad objProducto)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_Actualizar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = objProducto.id_Producto;
                comando.Parameters.Add("@pidcategoria", SqlDbType.Int).Value = objProducto.id_categoria;
                comando.Parameters.Add("@pmarca", SqlDbType.VarChar).Value = objProducto.Marca;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objProducto.Descripcion;
                comando.Parameters.Add("@pprecio", SqlDbType.Int).Value = objProducto.precio;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = objProducto.catidad;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objProducto.estado;
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
                SqlCommand comando = new SqlCommand("SP_Producto_Eliminar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = id;
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

        public DataTable Actualizar_salida(int busqueda,int cantidad)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_ACantidadS", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = busqueda;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = cantidad;
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

        public DataTable Actualizar_Entrada(int busqueda, int cantidad)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_ACantidadE", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = busqueda;
                comando.Parameters.Add("@pcantidad", SqlDbType.Int).Value = cantidad;
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

        public String Activar(int id)
        {
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_Activar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = id;
                sqlCnx.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK se desactivo el inventario del producto" : "No se pudo activar registro";
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

        public String Desactivar(int id)
        {
            
            string respuesta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_Desactivar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pidproducto", SqlDbType.Int).Value = id;
                sqlCnx.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK Se desactivo el inventario del producto" : "No se pudo desactivar registro";
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
        public DataTable Listar_Activos()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = ClsConexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("SP_Producto_ListarA", sqlCnx);
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
