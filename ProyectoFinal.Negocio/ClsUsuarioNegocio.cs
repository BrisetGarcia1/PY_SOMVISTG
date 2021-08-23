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
    public class ClsUsuarioNegocio
    {
        //Listar
        public static DataTable Listar()
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            return objUsuario.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            return objUsuario.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(int idemplesa, string nombre, string contrasena)
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            string verificar = objUsuario.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsUsuarioEntidad objUsuarioE = new ClsUsuarioEntidad();
                objUsuarioE.id_Empleado = idemplesa;
                objUsuarioE.Nombre = nombre;
                objUsuarioE.Contrasena = contrasena;
                return objUsuario.Insertar(objUsuarioE);
            }
        }

        //Actualizar
        public static string Actualizar(int id, int idemplesa, string nombre, string contrasena)
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            string verificar = objUsuario.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsUsuarioEntidad objUsuarioE = new ClsUsuarioEntidad();
                objUsuarioE.id_Usuario = id;
                objUsuarioE.id_Empleado = idemplesa;
                objUsuarioE.Nombre = nombre;
                objUsuarioE.Contrasena = contrasena;
                return objUsuario.Actualizar(objUsuarioE);
            }
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            return objUsuario.Eliminar(id);
        }

        //Login
        public static DataTable Loguear(string usuario, string password)
        {
            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            return objUsuario.loguear(usuario, password);
        }
    }
}
