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
    public class ClsUsuarioDetalleInventarioNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsUsuarioDetalleInventarioDatos objUDI= new ClsUsuarioDetalleInventarioDatos();
            return objUDI.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsUsuarioDetalleInventarioDatos objUDI = new ClsUsuarioDetalleInventarioDatos();
            return objUDI.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int iddetalle,int idusuario)
        {
            ClsUsuarioDetalleInventarioDatos objUDI = new ClsUsuarioDetalleInventarioDatos();
            // intanciar 
            ClsUsuarioDetalleInventarioEntidad objUDIE = new ClsUsuarioDetalleInventarioEntidad();
            objUDIE.id_detalle = iddetalle;
            objUDIE.id_usuario= idusuario;
            return objUDI.Insertar(objUDIE);
        }

        //Actualizar
        public static string Actualizar(int id, int iddetalle, int idusuario)
        {
            ClsUsuarioDetalleInventarioDatos objUDI = new ClsUsuarioDetalleInventarioDatos();
            // intanciar 
            ClsUsuarioDetalleInventarioEntidad objUDIE = new ClsUsuarioDetalleInventarioEntidad();
            objUDIE.id_detalleUsuario = id;
            objUDIE.id_detalle = iddetalle;
            objUDIE.id_usuario = idusuario;
            return objUDI.Actualizar(objUDIE);
        }
            //Eliminar
        public static string Eliminar(int id)
        {
            ClsUsuarioDetalleInventarioDatos objUDI = new ClsUsuarioDetalleInventarioDatos();
            return objUDI.Eliminar(id);
        }

    }
}
