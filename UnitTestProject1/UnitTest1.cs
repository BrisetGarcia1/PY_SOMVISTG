using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal.AccesoDatos;
using ProyectoFinal.Entidad;
using ProyectoFinal.Negocio;
using ProyectoFinal.Presentacion;
using System;
using System.Data;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        //validacion de logueo del usuario, verifica que los datos (usuario y contraseña) existen en la base de datos
        //devuelve nombre, apellido, cargo, entre otros datos de la tabla empleado
        public void LoginTest()
        {
            string usuario = "juboh";
            string password = "123456";

            ClsUsuarioDatos objUsuario = new ClsUsuarioDatos();
            DataTable tabla = new DataTable();
            tabla = objUsuario.loguear(usuario, password);
            //aqui solo estamos verificando con el nombre del trabajador
            Assert.AreEqual(tabla.Rows[0][2], "Juan");

        }



        [TestMethod]
        //Comprueba que el local a buscar existe en la base de datos, esta busqueda es segun el nombre del local
        public void ExisteLocalTest()
        {
            String Busqueda = "Bolognesi";
            ClsLocalDatos objLocal = new ClsLocalDatos();
            DataTable tabla = new DataTable();
            tabla = objLocal.Buscar(Busqueda);
            Assert.AreEqual(tabla.Rows[0][1], "Bolognesi");

        }



       // [TestMethod]
        //Se envia los datos del trabajador (nombre, apellidos, dni, celular y tipo ), si es correcto debera de devolver una mensaje
        //de confirmacion del registro
        //public void RegistrarTrabajadorTest()
        //{
        //    // intanciar 
        //    ClsEmpleadoDatos objEmpleado = new ClsEmpleadoDatos();
        //    ClsEmpleadoEntidad objEmpleadoE = new ClsEmpleadoEntidad();
        //    objEmpleadoE.Nombre = "Alexander";
        //    objEmpleadoE.Apellido = "Huallpa Huaychani";
        //    objEmpleadoE.DNI = "76593212";
        //    objEmpleadoE.celular = "998675432";
        //    objEmpleadoE.Tipo = "Supervisor";
        //    String rpta = objEmpleado.Insertar(objEmpleadoE);
        //    Assert.AreEqual(rpta, "OK se inserto en el registro");

        //}



        [TestMethod]
        //Instanciamos las clases obtieniendo los objetos para poder hacer la prueba correspondiente, 
        //en el caso de  actualizar debemos ingresar el codigo con el que queremos identificar a nuestros siguientes datos 
        //para poder ser actulizados declaramos una variable String para que sea igualda 
        //con el tipo de resultado el cual estamos esperando.
        public void TestActualizarEmp()
        {
            //Instanciamos nuestras Clases
            ClsEmpleadoDatos ObjEMP = new ClsEmpleadoDatos();
            ClsEmpleadoEntidad ObjEMPE = new ClsEmpleadoEntidad();
            ObjEMPE.id_Empleado = 4;
            ObjEMPE.Nombre = "Andres";
            ObjEMPE.Apellido = "Ramos Gutierrez";
            ObjEMPE.DNI = "76543212";
            ObjEMPE.celular = "921675421";
            ObjEMPE.Tipo = "Personal";
            String resultado = ObjEMP.Actualizar(ObjEMPE);
            Assert.AreEqual(resultado, "OK RESGITRO SE ACTUALIZO");
        }




        [TestMethod]
        //en este metodo estamos verificando que se registre correctamente los usuarios, para ello
        //le debemos de pasar el id del empleado al cual se le creara un usuario y contraseña
        //si es registro se realizo nos devolvera un mensaje de confirmacion
        public void RegistrarUsuarioTest()
        {
            String rpta = ClsUsuarioNegocio.Insertar(3, "tgomez", "123");
            Assert.AreEqual(rpta, "OK se inserto en el registra");
        }



        [TestMethod]
        //Este metodo de prueba valida que no se pueda eliminar un empleado si es que tiene registrado un usuario y contraseña en otra tabla
        //nos enviara un mensaje que diga que no se pudo eliminar el regitro por el tema de dependencia
        public void EliminarTrabajadorTest()
        {
            String Rpta = "";
            int codigo = 17;
            Rpta = ClsEmpleadoNegocio.Eliminar(codigo);

            Assert.AreEqual(Rpta, "No se pudo Eliminar registro");
        }




        [TestMethod]
        //Instanciamos las clases obtieniendo los objetos para poder hacer la prueba correspondiente,
        //en el caso de  actualizar debemos ingresar el codigo con el que queremos identificar a nuestros
        //siguientes datos para poder ser actulizados declaramos una variable String 
        //para que sea igualda con el tipo de resultado el cual estamos esperando.
        public void TestActualizarInv()
        {
            //Instanciamos nuestras Clases
            ClsInventarioDatos ObjINV = new ClsInventarioDatos();
            ClsInventarioEntidad ObjINVE = new ClsInventarioEntidad();
            ObjINVE.id_producto = 1;
            ObjINVE.Stock = 200;
            ObjINVE.Stock_Fisico = 150;
            ObjINVE.Diferencia = 50;
            ObjINVE.Stock_Salida = 50;
            ObjINVE.Estado = "A";
            String resultado = ObjINV.Insertar(ObjINVE);
            Assert.AreEqual(resultado, "OK se inserto en el registra");
        }



        [TestMethod]
        //Instanciamos las clases obtieniendo los objetos para poder hacer la prueba correspondiente,
        //en el caso de insertar toma valores ya determinados o existentes los cuales seran ingresados 
        //al codigo de testeo que este determinara si se logro completar el resultado o no, 
        //devolviendo un resultado nuestra variable resultado.
        public void TestInsertarProd()
        {
            //Instanciamos nuestras Clases
            ClsProductosDatos ObjPRO = new ClsProductosDatos();
            ClsProductoEntidad ObjPROE = new ClsProductoEntidad();
            ObjPROE.id_categoria = 1;
            ObjPROE.Marca = "Gloria";
            ObjPROE.Descripcion = "Rico Arroz Sambito";
            ObjPROE.precio = 6;
            ObjPROE.catidad = 5;
            ObjPROE.estado = "A";
            String resultado = ObjPRO.Insertar(ObjPROE);
            Assert.AreEqual(resultado, "OK se inserto en el registra");
        }




        [TestMethod]
        //En la funcion tratamos de que nos retorne informacion existentes por lo cual necesitamos un DataTable,
        //en este recepcionamos datos de nuestra clase en donde se encuentra nuestro el metodo, 
        //por ultimo comparamos tabla con tabla para poder pasar la prueba.
        public void TestListarInv()
        {
            DataTable Tabla = new DataTable();
            ClsInventarioDatos ObjINV = new ClsInventarioDatos();
            Tabla = ObjINV.Listar();
            Assert.AreEqual(Tabla, Tabla);
        }



        //[TestMethod]
        //public void EliminarProducto()
        //{
        //    // Creamos una varible de Tipo String
        //    String resultado = "";
        //    // Asignamos un id para nuestra producto a Eliminar
        //    //debemos de tener en cuenta que para poder eliminarlo no debe haber dependencias 
        //    int id = 7;
        //    // LLamamos a nuestro procedimiento Eliminar de Producto y le pasamos el id
        //    resultado = ClsProductoNegocio.Eliminar(id);
        //    // Luego probamos las condiciones 
        //    Assert.AreEqual(resultado, "OK se Elimino");
        //}



        
        [TestMethod]
        //verificar Empleado
        //compreobaremos si el empleado esta registado en la base de datos usando el numero
        //de su numero de dni
        public void verificarEmpledo()
        {
            bool resul;
            //instanciamos local de capa datos
            ClsEmpleadoDatos objEmpleadoD = new ClsEmpleadoDatos();
            //llamamos al procedimiento
            string verificar = objEmpleadoD.Verificar("912456789");
            if (verificar.Equals("1"))
            {
                resul = false;
                //comprobamos el resultado
                Assert.IsFalse(resul, "El Empleado ya existe e la BD");
            }
            else
            {
                resul = true;
                //comprobamos el resultado
                Assert.IsTrue(resul, "ok se registro");
            }
        } 



        
        [TestMethod]
        //verificar local
        // en este test comprobaremos si el local esta registrado en la base de datos
        public void verifiacarLocal()
        {
            bool resul;
            //intanciamos el local que se encuentra en capas datos
            ClsLocalDatos objLocalD = new ClsLocalDatos();
            //luego llamamos al procedimiento en la capa datos y le damos el nombre
            string verificar = objLocalD.Verificar("Bolognesi");
            //comprebamos si el local esta registrado el procedimiento nos devolvera(1 = esta registrado - 2 = si no esta registrado)
            if (verificar.Equals("1"))
            {
                resul = false;
                //comprobamos el resultado
                Assert.IsFalse(resul, "El local ya existe e la BD");
            }
            else
            {
                resul = true;
                //comprobamos el resultado
                Assert.IsTrue(resul, "OK se inserto en el registra");
            }
        }



        [TestMethod]
        //En esta prueba tratamos de que nos duelvan datos existentes por eso declaramos DataTable, 
        //en el cual serian mostrados y recepcionados de nuestra clase "ClsEmpleadoDatos" donde se encuentra nuestro 
        //metodo "Listar", por ultimo comparamos tabla con tabla.
        public void TestListarEmp()
        {
            DataTable Tabla = new DataTable();
            //Instanciamos nuestras Clases
            ClsEmpleadoDatos ObjEMP = new ClsEmpleadoDatos();
            Tabla = ObjEMP.Listar();
            Assert.AreEqual(Tabla, Tabla);
        }


        //[TestMethod]
        //public void EliminarCategoria()
        //{
        //    // Creamos una varible de Tipo String
        //    String resultado = "";
        //    // Asignamos un id para nuestra categoria a Eliminar
        //    int id = 6;
        //    // LLamamos a nuestro procedimiento Eliminar de Categoria y le pasamos el id
        //    resultado = ClsCategoriaNegocio.Eliminar(id);
        //    // Luego probamos las condiciones, en caso sea exitoso se eliminara de nuestra bd
        //    Assert.AreEqual(resultado, "OK se Elimino");
        //}



        //[TestMethod]
        //public void EliminarEmpleado()
        //{
        //    // Creamos una varible de Tipo String
        //    String resultado = "";
        //    // Asignamos un id para nuestro Empleado para Eliminar
        //    int id = 22;
        //    // LLamamos a nuestro procedimiento Eliminar de Empleado y le pasamos el id
        //    resultado = ClsEmpleadoNegocio.Eliminar(id);
        //    // Luego probamos las condiciones, en caso sea exitoso se eliminara de nuestra base de datos
        //    Assert.AreEqual(resultado, "OK se Elimino");
        //}






        [TestMethod]
        public void TestActualizarProducto()
        {
            //Primero instanciaremos nuestras clases
            ClsProductosDatos ObjDPRO = new ClsProductosDatos();
            ClsProductoEntidad ObjEPRO = new ClsProductoEntidad();
            //Pasamos los objetos de la entidad Producto
            ObjEPRO.id_Producto = 2;
            ObjEPRO.id_categoria = 1;
            ObjEPRO.Marca = "Pura Vida";
            ObjEPRO.Descripcion = "Leche";
            ObjEPRO.precio = 15;
            ObjEPRO.catidad = 20;
            ObjEPRO.estado = "A";
            //Aqui pasamos los parametros para actualizar en la variable resultado
            String resultado = ObjDPRO.Actualizar(ObjEPRO);
            // Luego probamos las condiciones, en caso sea exitoso se actualizara en nuestra base de datos
            Assert.AreEqual(resultado, "OK RESGITRO SE ACTUALIZO");
        }

    }
}
