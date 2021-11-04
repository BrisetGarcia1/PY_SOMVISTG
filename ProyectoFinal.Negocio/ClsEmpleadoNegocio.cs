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
    public class ClsEmpleadoNegocio
    {
        //Lustar
        public static DataTable Listar()
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            return objEmpleado.Listar();
        }

        //Buscar
        public static DataTable Buscar(string Busqueda)
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            return objEmpleado.Buscar(Busqueda);
        }

        //Insertar
        public static string Insertar(string nombre,string apellido,string dni,string telefono, string tipo)
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            string verificar = objEmpleado.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Trabajador ya existe en la BD";
            }
            else
            {
                // intanciar 
                ClsEmpleadoEntidad objEmpleadoE = new ClsEmpleadoEntidad();
                objEmpleadoE.Nombre = nombre;
                objEmpleadoE.Apellido = apellido;
                objEmpleadoE.DNI = dni;
                objEmpleadoE.celular = telefono;
                objEmpleadoE.Tipo = tipo;
                return objEmpleado.Insertar(objEmpleadoE);
            }
        }

        //Actualizar
        public static string Actualizar(int id, string nombre, string apellido, string dni, string telefono, string tipo)
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            string verificar = objEmpleado.Verificar(nombre);
            if (verificar.Equals("1"))
            {
                return "El Local ya existe e la BD";
            }
            else
            {
                // intanciar 
                ClsEmpleadoEntidad objEmpleadoE = new ClsEmpleadoEntidad();
                objEmpleadoE.id_Empleado = id;
                objEmpleadoE.Nombre = nombre;
                objEmpleadoE.Apellido = apellido;
                objEmpleadoE.DNI = dni;
                objEmpleadoE.celular = telefono;
                objEmpleadoE.Tipo = tipo;
                return objEmpleado.Actualizar(objEmpleadoE);
            }
        }

        //Eliminar
        public static string Eliminar(int id)
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            return objEmpleado.Eliminar(id);
        }
        public static DataTable Buscar_id(string Busqueda)
        {
            ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
            return objEmpleado.Buscar_id(Busqueda);
        }

    }
}
