--Activar la Base de Datos
USE bdAlmacen
GO
--*******************************************
--Insertar Registros en la Tabla Local
--(1)
INSERT INTO dbo.Local VALUES ('San Martin','Las Mercedes de la Bombola - H4','974744414')
GO
--(2)
INSERT INTO dbo.Local VALUES ('Bolognesi','	Av.Bolognesi P-5','945555612')
GO
--(3)
INSERT INTO dbo.Local VALUES ('TQP Plaza','Las Mercedes Lt. 10','945512368')
GO
--(4)
INSERT INTO dbo.Local VALUES ('G. Albarracin','San Roque S-5','977444125')
GO
--(5)
INSERT INTO dbo.Local VALUES ('Lima - Lince','Para Chico Toribio Ara 981','966214777')
GO
--Visualizar los datas de la Tabla Persona
SELECT * FROM dbo.Local
GO
delete from dbo.Local;
-- *******************************************
--Insertar Registros en la Tabla Empleado
--(1)
INSERT INTO dbo.Empleado VALUES ('Juan','Bohorquez Chaves','87452269','912456789','Administrador')
GO
--(2)
INSERT INTO dbo.Empleado VALUES ('Pedro','Bernabe Solis','47152222','947852136','Supervisor')
GO
--(3)
INSERT INTO dbo.Empleado VALUES ('Tatiana','Gomez Rios','78415788','914258367','Supervisor')
GO
--(4)
INSERT INTO dbo.Empleado VALUES ('Monica','Tintaya Arce','76521489','978456123','Supervisor')
GO
--(5)
INSERT INTO dbo.Empleado VALUES ('Renzo','Luque Poma','65748123','912365478','Personal')
GO
--(6)
INSERT INTO dbo.Empleado VALUES ('Miguel','Rodriguez Vega','14756322','948521763','Personal')
GO
--(7)
INSERT INTO dbo.Empleado VALUES ('Maricielo','Valencia Quispe','74152888','984125763','Personal')
GO
--(8)
INSERT INTO dbo.Empleado VALUES ('Enzo','Solis Roman ','84512367','963258741','Personal')
GO
--(9)
INSERT INTO dbo.Empleado VALUES ('Xiomara','Ramos Mareni','74523699','125478963','Personal')
GO
--(10)
INSERT INTO dbo.Empleado VALUES ('Ruth','Pilco Caceres','14257899','354789162','Personal')
GO
--Visualizar los datas de la Tabla Persona
SELECT * FROM dbo.Empleado
GO
delete from dbo.Empleado
--*********************************************************************************************************************************
--Insertar Registros en la Tabla UsuarioDetalleInventario
--(1)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (1,1)
GO
--(2)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (2,1)
GO
--(3)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (3,2)
GO
--(4)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (4,2)
GO
--(5)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (5,3)
GO
--(6)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (6,3)
GO
--(7)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (7,4)
GO
--(8)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (8,4)
GO
--(9)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (9,5)
GO
--(10)
INSERT INTO dbo.UsuarioDetalleInventario VALUES (10,5)
GO
--Visualizar los datas de la Tabla UsuarioDetalleInventario
SELECT * FROM dbo.UsuarioDetalleInventario
GO
delete from dbo.UsuarioDetalleInventario
--*******************************************
--Insertar Registros en la Tabla Usuario
--(1)
INSERT INTO dbo.Usuario VALUES (1022,'juboh','123456')
GO
--(2)
INSERT INTO dbo.Usuario VALUES (1024,'taber','654321')
GO
--(3)
INSERT INTO dbo.Usuario VALUES (1026,'reluq','143625')
GO
--(4)
INSERT INTO dbo.Usuario VALUES (1028,'maval','123789')
GO
--(5)
INSERT INTO dbo.Usuario VALUES (1030,'xiram','134679')
GO
--Visualizar los datas de la Tabla Persona
SELECT * FROM dbo.Usuario
GO
delete from dbo.Usuario
--Insertar Registros en la Tabla Categoria
--(1)
INSERT INTO dbo.Categoria VALUES ('Postres y Reposteria')
GO
--(2)
INSERT INTO dbo.Categoria VALUES ('Fideos y Menestras')
GO
--(3)
INSERT INTO dbo.Categoria VALUES ('Aceites, Salsas y Condimentos')
GO
--(4)
INSERT INTO dbo.Categoria VALUES ('Linea Integral')
GO
--(5)
INSERT INTO dbo.Categoria VALUES ('Arroz y Azúcar')
GO
--Visualizar los datas de la Tabla Categoria
SELECT * FROM dbo.Categoria
GO
delete from dbo.Categoria
--*********************************************************************************************************************************
--Insertar Registros en la Tabla Producto
--(1)
INSERT INTO dbo.Producto VALUES (16,'Royal','Royal gelatina fresa bolsa x 160 gr.',3.80,'700')
GO
--(2)
INSERT INTO dbo.Producto VALUES (16,'Negrita','Negrita flan vainilla bolsa x 95 gr.',1.89,'700')
GO
--(3)
INSERT INTO dbo.Producto VALUES (17,'Lucchetti','Lucchetti lasagÑa tradicional caja x 360 gr.',8.99,'450')
GO
--(4)
INSERT INTO dbo.Producto VALUES (17,'Don Vittorio','Don vittorio fideo fettuccine nº 1 bolsa x 500 gr.',3.00,'450')
GO
--(5)
INSERT INTO dbo.Producto VALUES (18,'Primor','Primor aceite vegetal botella x 1 lt.',9.00,'500')
GO
--(6)
INSERT INTO dbo.Producto VALUES (18,'Ideal','Ideal aceite vegetal botella x 1 lt.',7.70,'500')
GO
--(7)
INSERT INTO dbo.Producto VALUES (19,'Union','Union galleta mega naranja integral bolsa x 195 gr',4.90,'400')
GO
--(8)
INSERT INTO dbo.Producto VALUES (19,'Laive','Laive bebida c/almendra tetrapack x 1 lt.',9.90,'400')
GO
--(9)
INSERT INTO dbo.Producto VALUES (20,'Paisana','Paisana arroz superior x 1 kg.',3.70,'200')
GO
--(10)
INSERT INTO dbo.Producto VALUES (20,'Molino Rojo','Molino rojo arroz extra bolsa x 5 kg',25.00,'200')
GO
--Visualizar los datas de la Tabla Producto
SELECT * FROM dbo.Producto
GO
delete from dbo.Producto
--*********************************************************************************************************************************
--*********************************************************************************************************************************
--Insertar Registros en la Tabla Inventario
--(1)
INSERT INTO dbo.Inventario VALUES (1052,700,1,1,1,'A')
GO
--Visualizar los datas de la Tabla Inventario
SELECT * FROM dbo.Inventario
GO

ALTER TABLE dbo.Producto ALTER COLUMN precio float;

SELECT IDENT_CURRENT ('dbo.Inventario')AS id_inventario ;