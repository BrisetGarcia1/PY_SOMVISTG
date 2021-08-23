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
    public class ClsLocalNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            return objLocal.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            return objLocal.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(string nombre, string direccion, string telefono)
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            string verificar = objLocal.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsLocalEntidad objLocalE = new ClsLocalEntidad();
                objLocalE.Nombre = nombre;
                objLocalE.Direccion = direccion;
                objLocalE.Telefono = telefono;
                return objLocal.Insertar(objLocalE);
            }
        }

        //Actualizar
        public static string Actualizar(int id, string nombre, string direccion, string telefono)
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            string verificar = objLocal.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsLocalEntidad objLocalE = new ClsLocalEntidad();
                objLocalE.id_Local = id;
                objLocalE.Nombre = nombre;
                objLocalE.Direccion = direccion;
                objLocalE.Telefono = telefono;
                return objLocal.Actualizar(objLocalE);
            }
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            return objLocal.Eliminar(id);
        }

        //combo
        public static DataTable Combo()
        {
            ClsLocalDatos objLocal = new ClsLocalDatos();
            return objLocal.Combo();
        }

    }
}
