--Crear Base de Datos
CREATE DATABASE bdAlmacen
GO

--Activar la Base de Datos
USE bdAlmacen
GO

--Crear Tablas
--Tabla Local
if (not exists(select 1 from sys.tables WHERE name = 'Local'))
CREATE TABLE dbo.Local(
id_local int identity(1,1) NOT NULL,
nombre varchar(45) NOT NULL UNIQUE,
direccion varchar(190) NOT NULL,
telefono char(9) NOT NULL,
PRIMARY KEY(id_local))
GO

--Tabla Empleado
if (not exists(select 1 from sys.tables WHERE name = 'Empleado'))
CREATE TABLE dbo.Empleado(
id_empleado int identity(1,1) NOT NULL,
nombre varchar(100) NOT NULL,
apellido varchar(250) NOT NULL,
dni varchar(8) NOT NULL UNIQUE,
celular varchar(15) NOT NULL,
tipo varchar(20) NOT NULL,
PRIMARY KEY(id_empleado))
GO

--Tabla Usuario
if(not exists(select 1 from sys.tables WHERE name = 'Usuario'))
CREATE TABLE dbo.Usuario(
id_usuario int identity(1,1) NOT NULL,
id_empleado int NOT NULL,
nombre varchar(30) NOT NULL,
contraseña varchar(100) NOT NULL,
PRIMARY KEY (id_usuario),
FOREIGN KEY (id_empleado) REFERENCES Empleado
)
GO


--Tabla LocalUsuario
if(not exists(select 1 from sys.tables WHERE name = 'LocalUsuario'))
CREATE TABLE dbo.LocalUsuario(
id_usuariolocal int identity(1,1) NOT NULL,
id_usuario int NOT NULL,
id_local int NOT NULL,
PRIMARY KEY (id_usuariolocal),
FOREIGN KEY (id_usuario) REFERENCES Usuario,
FOREIGN KEY (id_local) REFERENCES Local
)
GO

--Tabla Categoria
if(not exists(select 1 from sys.tables WHERE name = 'Categoria'))
CREATE TABLE dbo.Categoria(
id_categoria int identity(1,1) NOT NULL,
nombre varchar(60) NOT NULL,
PRIMARY KEY (id_categoria))
GO

--Tabla Producto
if(not exists(select 1 from sys.tables WHERE name = 'Producto'))
CREATE TABLE dbo.Producto(
codigo_producto int identity(1,1) NOT NULL,
id_categoria int NOT NULL,
marca varchar(50) NOT NULL,
descripcion varchar(100) NOT NULL,
precio float NOT NULL,
cantidad int NOT NULL,
estado char(1) NOT NULL,
PRIMARY KEY (codigo_producto),
FOREIGN KEY (id_categoria) REFERENCES Categoria
)
GO

ALTER TABLE dbo.Producto ADD estado char(1);

--Tabla Inventario
if(not exists(select 1 from sys.tables WHERE name = 'Inventario'))
CREATE TABLE dbo.Inventario(
id_inventario int identity(1,1) NOT NULL,
id_producto int NOT NULL,
stock int NOT NULL,
stockfisico int NOT NULL,
diferencia int NOT NULL,
stocksalida int NOT NULL,
fecha DATETIME NOT NULL,
estado varchar(80) NOT NULL,
PRIMARY KEY (id_inventario),
FOREIGN KEY (id_producto) REFERENCES Producto,
)
GO

--Tabla DetalleInventario
if(not exists(select 1 from sys.tables WHERE name = 'DetalleInventario'))
CREATE TABLE dbo.DetalleInventario(
id_detalle int identity(1,1) NOT NULL,
id_inventario int NOT NULL,
fecha VARCHAR(40) NOT NULL,
cantidad int NOT NULL,
PRIMARY KEY (id_detalle),
FOREIGN KEY (id_inventario) REFERENCES Inventario,
)
GO

ALTER TABLE DetalleInventario ADD nombre char(100);

--Tabla UsuarioDetalleInventario
if(not exists(select 1 from sys.tables WHERE name = 'UsuarioDetalleInventario'))
CREATE TABLE dbo.UsuarioDetalleInventario(
id_usuarioDetalleI int identity(1,1) NOT NULL,
id_detalle int NOT NULL,
id_usuario int NOT NULL,
PRIMARY KEY (id_usuarioDetalleI),
FOREIGN KEY (id_detalle) REFERENCES DetalleInventario,
FOREIGN KEY (id_usuario) REFERENCES Usuario,
)
GO



