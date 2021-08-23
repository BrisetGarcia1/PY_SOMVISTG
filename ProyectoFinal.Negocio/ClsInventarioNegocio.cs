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
    public class ClsInventarioNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();
            return objInventario.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();
            return objInventario.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int idproducto, int stock, int stockFisico, int diferencia, int stocksalida, string estado)
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();

            // intanciar 
            ClsInventarioEntidad objInventarioE = new ClsInventarioEntidad();
            objInventarioE.id_producto = idproducto;
            objInventarioE.Stock = stock;
            objInventarioE.Stock_Fisico = stockFisico;
            objInventarioE.Diferencia = diferencia;
            objInventarioE.Stock_Salida = stocksalida;
            objInventarioE.Estado = estado;
            return objInventario.Insertar(objInventarioE);
        }

        //Actualizar
        public static string Actualizar(int id, int idproducto, int stock, int stockFisico, int diferencia, int stocksalida, string estado)
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();

            // intanciar 
            ClsInventarioEntidad objInventarioE = new ClsInventarioEntidad();
            objInventarioE.id_Inventario = id;
            objInventarioE.id_producto = idproducto;
            objInventarioE.Stock = stock;
            objInventarioE.Stock_Fisico = stockFisico;
            objInventarioE.Diferencia = diferencia;
            objInventarioE.Stock_Salida = stocksalida;
            objInventarioE.Estado = estado;
            return objInventario.Actualizar(objInventarioE);
            
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();
            return objInventario.Eliminar(id);
        }

        //Activar
        public static DataTable Listar_Activar()
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();
            return objInventario.Listar_Activar();
        }

        public static DataTable Indentificador()
        {
            ClsInventarioDatos objInventario = new ClsInventarioDatos();
            return objInventario.identificador();
        }
    }
}
