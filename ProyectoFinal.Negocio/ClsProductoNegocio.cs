using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidad;
using ProyectoFinal.AccesoDatos;
using System.Data;

namespace ProyectoFinal.Negocio
{
    public class ClsProductoNegocio
    {
        //Listar
        public static DataTable Listar()
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int idcategoria, string marca, string descripcion, int precio, int cantidad,string estado)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            string verificar = objProducto.Verificar(descripcion);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsProductoEntidad objProductoE = new ClsProductoEntidad();
                objProductoE.id_categoria = idcategoria;
                objProductoE.Marca = marca;
                objProductoE.Descripcion = descripcion;
                objProductoE.precio = precio;
                objProductoE.catidad = cantidad;
                objProductoE.estado = estado;
                return objProducto.Insertar(objProductoE);
            }
        }

        //Actualizar
        public static string Actualizar(int id, int idcategoria, string marca, string descripcion, int precio, int cantidad,string estado)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            string verificar = objProducto.Verificar(descripcion);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsProductoEntidad objProductoE = new ClsProductoEntidad();
                objProductoE.id_Producto = id;
                objProductoE.id_categoria = idcategoria;
                objProductoE.Marca = marca;
                objProductoE.Descripcion = descripcion;
                objProductoE.precio = precio;
                objProductoE.catidad = cantidad;
                objProductoE.estado = estado;
                return objProducto.Actualizar(objProductoE);
            }
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Eliminar(id);
        }

        public static DataTable Actualizar_Entrada(int Busqueda,int cantidad)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Actualizar_Entrada(Busqueda,cantidad);
        }

        public static DataTable Actualizar_Salida(int Busqueda, int cantidad)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Actualizar_salida(Busqueda, cantidad);
        }

        public static string Activar(int id)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Activar(id);
        }

        public static string Desactivar(int id)
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Desactivar(id);
        }
        public static DataTable Listar_Activos()
        {
            ClsProductosDatos objProducto = new ClsProductosDatos();
            return objProducto.Listar_Activos();
        }
    }
}
