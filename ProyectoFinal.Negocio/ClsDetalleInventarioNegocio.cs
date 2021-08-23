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
    public class ClsDetalleInventarioNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();
            return objDetalleInventario.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();
            return objDetalleInventario.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int idinventario, string fecha, int cantidad, string nombre)
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();

            ClsDetalleInventarioEntidad objDetalleInventarioE = new ClsDetalleInventarioEntidad();
            objDetalleInventarioE.id_Inventario= idinventario;
            objDetalleInventarioE.Fecha = fecha;
            objDetalleInventarioE.Cantidad = cantidad;
            objDetalleInventarioE.nombre = nombre;
            return objDetalleInventario.Insertar(objDetalleInventarioE);
        }

        //Actualizar
        public static string Actualizar(int Id,int idinventario, string fecha, int cantidad ,string nombre)
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();

            ClsDetalleInventarioEntidad objDetalleInventarioE = new ClsDetalleInventarioEntidad();
            objDetalleInventarioE.id_detalle = Id;
            objDetalleInventarioE.id_Inventario = idinventario;
            objDetalleInventarioE.Fecha = fecha;
            objDetalleInventarioE.Cantidad = cantidad;
            objDetalleInventarioE.nombre = nombre;
            return objDetalleInventario.Actualizar(objDetalleInventarioE);
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();
            return objDetalleInventario.Eliminar(id);
        }

        public static DataTable Unir()
        {
            ClsDetalleInventarioDatos objDetalleInventario = new ClsDetalleInventarioDatos();
            return objDetalleInventario.Unir();
        }
    }
}
