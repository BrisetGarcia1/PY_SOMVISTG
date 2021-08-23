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
    public class ClsCategoriaNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsCategoriaDatos objCategoria = new ClsCategoriaDatos();
            return objCategoria.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsCategoriaDatos objCategoria = new ClsCategoriaDatos();
            return objCategoria.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(string nombre)
        {
            ClsCategoriaDatos objCategoria = new ClsCategoriaDatos();
            string verificar = objCategoria.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsCategoriaEntidad objCategoriaE = new ClsCategoriaEntidad();
                objCategoriaE.Nombre = nombre;
                return objCategoria.Insertar(objCategoriaE);
            }
        }

        //Actualizar
        public static string Actualizar(int id, string nombre)
        {
            ClsCategoriaDatos objCategoria = new ClsCategoriaDatos();
            string verificar = objCategoria.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsCategoriaEntidad objCategoriaE = new ClsCategoriaEntidad();
                objCategoriaE.id_categoria = id;
                objCategoriaE.Nombre = nombre;
                return objCategoria.Actualizar(objCategoriaE);
            }

        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsCategoriaDatos objCategoria = new ClsCategoriaDatos();
            return objCategoria.Eliminar(id);
        }
    }
}
