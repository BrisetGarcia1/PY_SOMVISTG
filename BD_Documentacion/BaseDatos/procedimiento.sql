--Activar la Base de Datos
USE bdAlmacen
GO

-- **********************************************************************************
-- TABLA CATEGORIA

--Creaciom de elementos almacenados
--Procedimientos almacenados
-- 1- Insertar categoria
CREATE PROCEDURE SP_Categoria_Ingresar
	@pnombrecategoria varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Categoria
	VALUES (@pnombrecategoria)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Categoria
CREATE PROCEDURE SP_Categoria_Actualizar
	@pidcategoria int,
	@pnombrecategoria varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Categoria  SET
		nombre = @pnombrecategoria
		WHERE id_categoria = @pidcategoria
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Categoria
CREATE PROCEDURE SP_Categoria_Eliminar
	@pidcategoria int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Categoria 
		WHERE id_categoria = @pidcategoria
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Categoria
CREATE PROCEDURE SP_Categoria_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Categoria
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Categoria
CREATE PROCEDURE SP_Categoria_Verificar
	@pvalor varchar(50),
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT nombre FROM dbo.Categoria
				WHERE nombre = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Categoria
CREATE PROCEDURE SP_Categoria_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Categoria
		WHERE id_categoria LIKE '%' + @pbusqueda + '%' OR nombre = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- **********************************************************************************
-- **********************************************************************************

-- TABLA PRODUCTO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Producto
CREATE PROCEDURE SP_Producto_Ingresar
	@pidcategoria int,
	@pmarca varchar(60), 
	@pdescripcion varchar(200), 
	@pprecio int,
	@pcantidad int,
	@pestado char(1)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Producto
	VALUES (@pidcategoria,@pmarca,@pdescripcion,@pprecio,@pcantidad,@pestado)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Producto
CREATE PROCEDURE SP_Producto_Actualizar
	@pidproducto int,
	@pidcategoria int,
	@pmarca varchar(60), 
	@pdescripcion varchar(200), 
	@pprecio int,
	@pcantidad int,
	@pestado char(1)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Producto  SET
		id_categoria = @pidcategoria,
		marca = @pmarca,
		descripcion = @pdescripcion,
		precio = @pprecio,
		cantidad = @pcantidad,
		estado = @pestado
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Producto
CREATE PROCEDURE SP_Producto_Eliminar
	@pidproducto int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Producto
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Producto
CREATE PROCEDURE SP_Producto_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Producto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Producto
CREATE PROCEDURE SP_Producto_Verificar
	@pvalor varchar(50),
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT descripcion FROM dbo.Producto
				WHERE descripcion = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Producto
CREATE PROCEDURE SP_Producto_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Producto
		WHERE descripcion LIKE '%' + @pbusqueda + '%' 
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

exec SP_Producto_Buscar @pbusqueda = 'Royal gelatina fresa bolsa x 160 gr.';

-- 7- Actualizar cantidad de Salida Producto
CREATE PROCEDURE SP_Producto_ACantidadS
	@pidproducto int,
	@pcantidad int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Producto  SET
		cantidad = cantidad  - @pcantidad
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 8- Actualizar cantidad de Entrada Producto
CREATE PROCEDURE SP_Producto_ACantidadE
	@pidproducto int,
	@pcantidad int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Producto  SET
		cantidad = cantidad  + @pcantidad
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 9- Activar Producto
CREATE PROCEDURE SP_Producto_Activar
	@pidproducto int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Producto  SET
		estado = 'A'
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO



-- 10- Desactivar Producto
CREATE PROCEDURE SP_Producto_Desactivar
	@pidproducto int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Producto  SET
		estado = 'I'
		WHERE codigo_producto = @pidproducto
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Activos Producto
CREATE PROCEDURE SP_Producto_ListarA
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Producto
		WHERE estado LIKE 'A'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- **********************************************************************************
-- **********************************************************************************

-- TABLA INVENTARIO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Inventario
CREATE PROCEDURE SP_Inventario_Ingresar
	@pidproducto int, 
	@pstock int, 
	@pstockfisico int, 
	@pdiferencia int, 
	@pstocksalida int,
	@pestado varchar(10)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Inventario
	VALUES (@pidproducto,@pstock,@pstockfisico,@pdiferencia,@pstocksalida,@pestado)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Inventario
CREATE PROCEDURE SP_Inventario_Actualizar
	@pidinventario int,
	@pidproducto int, 
	@pstock int, 
	@pstockfisico int, 
	@pdiferencia int, 
	@pstocksalida int,
	@pestado varchar(10)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Inventario  SET
		id_producto = @pidproducto,
		stock = @pstock,
		StockFisico = @pstockfisico,
		Diferencia = @pdiferencia,
		StockSalida = @pstocksalida,
		Estado = @pestado
		WHERE id_inventario = @pidinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Inventario
CREATE PROCEDURE SP_Inventario_Eliminar
	@pidinventario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Inventario
		WHERE id_inventario = @pidinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Inventario
CREATE PROCEDURE SP_Inventario_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Inventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Inventario
CREATE PROCEDURE SP_Inventario_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_inventario FROM dbo.Inventario
				WHERE id_inventario = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Inventario
CREATE PROCEDURE SP_Inventario_Buscar
	@pbusqueda int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Inventario
		WHERE id_inventario = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 7- Estado Inventario
CREATE PROCEDURE SP_Inventario_Activar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Inventario
		WHERE estado = 'A'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 7- Estado Inventario
CREATE PROCEDURE SP_Inventario_ListarActivar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Inventario
		WHERE estado = 'A'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 7- Estado Inventario
CREATE PROCEDURE SP_Inventario_id
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT IDENT_CURRENT ('dbo.Inventario')AS id_inventario 
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO



-- **********************************************************************************
-- **********************************************************************************

-- TABLA DETALLE INVENTARIO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Ingresar
	@pidinventario int, 
	@pfechainventario varchar(40),
	@pcantidad int,
	@pnombre char(100)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.DetalleInventario
	VALUES (@pidinventario,@pfechainventario,@pcantidad,@pnombre)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Actualizar
	@piddetalleinventario int,
	@pidinventario int,  
	@pfechainventario varchar(40),
	@pcantidad int,
	@pnombre char(100)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.DetalleInventario  SET
		id_inventario = @pidinventario,
		fecha = @pfechainventario,
		Cantidad = @pcantidad,
		nombre = @pnombre
		WHERE id_detalle = @piddetalleinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Eliminar
	@piddetalleinventario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.DetalleInventario
		WHERE id_detalle = @piddetalleinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.DetalleInventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_detalle FROM dbo.DetalleInventario
				WHERE id_detalle = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Buscar
	@pbusqueda int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.DetalleInventario
		WHERE id_detalle  = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 7- Unir Detalle Inventario
CREATE PROCEDURE SP_DetalleInventario_Unir
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT  d.id_detalle,d.nombre,d.fecha,i.stock,i.stockfisico,i.diferencia,i.stocksalida
		FROM dbo.DetalleInventario AS d
		INNER JOIN dbo.Inventario AS i
		ON d.id_inventario = i.id_inventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


-- **********************************************************************************
-- **********************************************************************************

-- TABLA USUARIO DETALLE INVENTARIO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Ingresar
	@piddetalleinventario int, 
	@pidusuario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.UsuarioDetalleInventario
	VALUES (@piddetalleinventario,@pidusuario)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Actualizar
	@pidusuariodetalleinventario int,
	@piddetalleinventario int,
	@pidusuario int 
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.UsuarioDetalleInventario  SET
		id_detalle = @piddetalleinventario,
		id_usuario = @pidusuario
		WHERE id_usuarioDetalleI = @pidusuariodetalleinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Eliminar
	@pidusuariodetalleinventario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.UsuarioDetalleInventario
		WHERE id_usuarioDetalleI = @pidusuariodetalleinventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.UsuarioDetalleInventario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_usuarioDetalleI FROM dbo.UsuarioDetalleInventario
				WHERE id_usuarioDetalleI = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Usuario Detalle Inventario
CREATE PROCEDURE SP_UsuarioDetalleInventario_Buscar
	@pbusqueda int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.UsuarioDetalleInventario
		WHERE  id_usuarioDetalleI = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- **********************************************************************************
-- **********************************************************************************

-- TABLA USUARIO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Usuario
CREATE PROCEDURE SP_Usuario_Ingresar
	@pidempreado int, 
	@pnombre varchar(50), 
	@pcontraseña varchar(20)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Usuario
	VALUES (@pidempreado,@pnombre,@pcontraseña)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Usuario
CREATE PROCEDURE SP_Usuario_Actualizar
	@pidusuario int,
	@pidempreado int, 
	@pnombre varchar(50), 
	@pcontrasena varchar(20)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Usuario  SET
		id_empleado = @pidempreado,
		nombre = @pnombre,
		contraseña = @pcontrasena
		WHERE id_usuario = @pidusuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Usuario Detalle Inventario
CREATE PROCEDURE SP_Usuario_Eliminar
	@pidusuario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Usuario
		WHERE id_usuario = @pidusuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Usuario 
CREATE PROCEDURE SP_Usuario_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Usuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Usuario 
CREATE PROCEDURE SP_Usuario_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_usuario FROM dbo.Usuario
				WHERE id_usuario = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Usuario 
CREATE PROCEDURE SP_Usuario_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Usuario
		WHERE nombre LIKE '%' + @pbusqueda + '%' OR id_usuario = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 7. Metodo Login

CREATE PROCEDURE SP_Usuario_Login
	@pusuario varchar(50),
	@ppassword varchar(50)
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			SELECT u.id_usuario, p.apellido, p.nombre, u.nombre, p.tipo
			FROM dbo.Usuario AS u
			INNER JOIN dbo.Empleado AS p
			ON u.id_empleado = p.id_empleado
			WHERE u.nombre = @pusuario AND u.contraseña = @ppassword
		COMMIT
		END TRY
		BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
-- **********************************************************************************
-- **********************************************************************************

-- TABLA EMPLEADO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Empleado
CREATE PROCEDURE SP_Empleado_Ingresar
	@pnombre varchar(50), 
	@papellido varchar(50), 
	@pdni char(8),
	@ptelefono varchar(12),
	@ptipo varchar(20)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Empleado
	VALUES (@pnombre,@papellido,@pdni,@ptelefono,@ptipo)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Empleado
CREATE PROCEDURE SP_Empleado_Actualizar
	@pidempleado int,
	@pnombre varchar(50), 
	@papellido varchar(50), 
	@pdni char(8),
	@ptelefono varchar(12),
	@ptipo varchar(20)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Empleado  SET
		Nombre = @pnombre,
		apellido = @papellido,
		DNI = @pdni,
		celular = @ptelefono
		WHERE id_empleado = @pidempleado
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Empleado
CREATE PROCEDURE SP_Empleado_Eliminar
	@pidempleado int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Empleado
		WHERE id_empleado = @pidempleado
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Empleado
CREATE PROCEDURE SP_Empleado_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Empleado
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Empleado
CREATE PROCEDURE SP_Empleado_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_empleado FROM dbo.Empleado
				WHERE id_empleado = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Empleado
CREATE PROCEDURE SP_Empleado_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Empleado
		WHERE apellido LIKE '%' + @pbusqueda + '%' 
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Empleado
CREATE PROCEDURE SP_Empleado_Buscarid
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT id_empleado FROM dbo.Empleado
		WHERE apellido LIKE '%' + @pbusqueda + '%' 
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO




-- **********************************************************************************
-- **********************************************************************************

-- TABLA LOCAL USUARIO

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Local Usuario
CREATE PROCEDURE SP_LocalUsuario_Ingresar
	@pidusuario int, 
	@pidlocal int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.LocalUsuario
	VALUES (@pidusuario,@pidlocal)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Local Usuario
CREATE PROCEDURE SP_LocalUsuario_Actualizar
	@pidlocalusuario int,
	@pidusuario int, 
	@pidlocal int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.LocalUsuario  SET
		id_usuario = @pidusuario,
		id_local = @pidlocal
		WHERE id_usuariolocal = @pidlocalusuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Local Usuario
CREATE PROCEDURE SP_LocalUsuario_Eliminar
	@pidlocalusuario int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.LocalUsuario
		WHERE id_usuariolocal = @pidlocalusuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar LocalUsuario
CREATE PROCEDURE SP_LocalUsuario_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.LocalUsuario
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Local Usuario
CREATE PROCEDURE SP_LocalUsuario_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_usuariolocal FROM dbo.LocalUsuario
				WHERE id_usuariolocal = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Local Usuario
CREATE PROCEDURE SP_LocalUsuario_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.LocalUsuario
		WHERE id_usuariolocal LIKE '%' + @pbusqueda + '%'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- **********************************************************************************
-- **********************************************************************************

-- TABLA LOCAL 

--Creaciom de elementos almacenados
--Procedimientos almacenados

-- 1- Insertar Local
CREATE PROCEDURE SP_Local_Ingresar
	@pnombre varchar(45), 
	@pdireccion varchar(190), 
	@ptelefono char(9)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
	INSERT INTO dbo.Local
	VALUES (@pnombre,@pdireccion,@ptelefono)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 2- Actualizar Local
CREATE PROCEDURE SP_Local_Actualizar
	@pidlocal int,
	@pnombre varchar(45),  
	@pdureccion varchar(190), 
	@ptelefono char(9) 
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		UPDATE dbo.Local  SET
		nombre = @pnombre,
		direccion = @pdureccion,
		telefono = @ptelefono
		WHERE id_local = @pidlocal
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 3- Eliminar Local 
CREATE PROCEDURE SP_Local_Eliminar
	@pidlocal int
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		DELETE FROM dbo.Local
		WHERE id_local = @pidlocal
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 4- Listar Local
CREATE PROCEDURE SP_Local_Listar
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Local
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 5- Verificar Local 
CREATE PROCEDURE SP_Local_Verificar
	@pvalor int,
	@pexiste bit output
AS 
BEGIN
	BEGIN TRAN
		BEGIN TRY
			IF EXISTS(
				SELECT id_local FROM dbo.Local
				WHERE id_local = LTRIM(RTRIM(@pvalor))
			)
		BEGIN
			SET @pexiste = 0
		END
		ELSE
		BEGIN
			SET @pexiste = 1
		END
		COMMIT
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- Buscar Local 
CREATE PROCEDURE SP_Local_Buscar
	@pbusqueda varchar(50)
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT * FROM dbo.Local
		WHERE id_local LIKE '%' + @pbusqueda + '%' OR nombre = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

-- 6- combo Local 
CREATE PROCEDURE SP_Local_Combo
AS 
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SELECT nombre FROM dbo.Local
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
