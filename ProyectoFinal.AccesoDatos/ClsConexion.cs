using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoFinal.AccesoDatos
{
    class ClsConexion
    {
        //nombres
        private string BD;//Nombre de base de datos
        private string Server;//Nombre de Servidor
        private string User;//Nombre de Usuario
        private string Clave;//Nombre de clave
        private bool Autenticacion;//Autenticación de acceso de servidor
        private static ClsConexion cnx = null;

        //constructor para coneción a base de datos
        private ClsConexion()
        {
            this.BD = "bdAlmacen";//base de datos creada
            this.Server = "DESKTOP-SVQGTEQ";//ip,nombreservido,localhost,nombredominio,nombre de pc
            this.User = "sa";//Usuario de base de datos
            this.Clave = "2000celia08";//Colocar clave de base datos
            this.Autenticacion = true;//Autentificación Windows
        }

        //Metodo para establecer conexión
        public SqlConnection EstablecerConexion()
        {
            SqlConnection url = new SqlConnection();

            //Para controlar la excepciones
            try
            {
                //concexión SQL


                //connectinstrin propia de sql
                //pasando nombre servidor y nombre de base datos
                url.ConnectionString = "Server=" + this.Server + ";" + "DataBase=" + this.BD + ";";

                //concexión Windows

                //Se junta url.ConnectionString mas Integrated security
                if (this.Autenticacion) //seguridad integrada windows true
                {
                    url.ConnectionString = url.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    //autentificación sQL
                    url.ConnectionString = url.ConnectionString + "User Id=" + this.User + ";" + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                url = null;
                throw ex;
            }
            return url;
        }

        //Metodo de captura de instancia
        public static ClsConexion getInstancia()
        {
            if (cnx == null)
            {
                cnx = new ClsConexion();
            }
            return cnx;
        }
    }
}
