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
    public class ClsLocalUsuarioNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsLocalUsuarioDatos objLocalUsuario = new ClsLocalUsuarioDatos();
            return objLocalUsuario.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsLocalUsuarioDatos objLocalUsuario = new ClsLocalUsuarioDatos();
            return objLocalUsuario.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int idusuario, int idLocal)
        {
            ClsLocalUsuarioDatos objLocalUsuario = new ClsLocalUsuarioDatos();
            // intanciar 
            ClsLocalUsuarioEntidad objLocalUsuarioE = new ClsLocalUsuarioEntidad();
            objLocalUsuarioE.id_usuario = idusuario;
            objLocalUsuarioE.id_local = idLocal;
            return objLocalUsuario.Insertar(objLocalUsuarioE);
        }

        //Actualizar
        public static string Actualizar(int id, int idusuario, int idLocal)
        {
            ClsLocalUsuarioDatos objLocalUsuario = new ClsLocalUsuarioDatos();
            // intanciar 
            ClsLocalUsuarioEntidad objLocalUsuarioE = new ClsLocalUsuarioEntidad();
            objLocalUsuarioE.id_usuarioloacal = id;
            objLocalUsuarioE.id_usuario = idusuario;
            objLocalUsuarioE.id_local = idLocal;
            return objLocalUsuario.Insertar(objLocalUsuarioE);
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsLocalUsuarioDatos objLocalUsuario = new ClsLocalUsuarioDatos();
            return objLocalUsuario.Eliminar(id);
        }


    }
}
