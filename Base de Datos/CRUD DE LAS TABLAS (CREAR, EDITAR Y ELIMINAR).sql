---------------------------------------------
--			CRUD DE LAS TABLAS			  --
---------------------------------------------

----------------------- CIUDADES -------------------------
-- Insertar Ciudades
CREATE OR ALTER PROCEDURE Gral.UDP_tbCiudades_Insertar
	@ciud_Descripcion			NVARCHAR(500), 
	@dept_Id					INT, 
	@usua_UsuarioCreacion		INT,
	@ciud_FechaCreacion		    DATETIME
AS
BEGIN
	BEGIN TRY
			INSERT INTO Gral.tbCiudades (ciud_Descripcion, 
										 dept_Id, 
										 usua_UsuarioCreacion, 
										 ciud_FechaCreacion)
			VALUES (@ciud_Descripcion, 
					@dept_Id, 
					@usua_UsuarioCreacion, 
					@ciud_FechaCreacion)

			SELECT 'Datos registrados correctamente.'
	END TRY

	BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
	END CATCH

END
GO

-- Cargar Informacion para Editar Ciudades
CREATE OR ALTER PROCEDURE Gral.UPD_tbCiudades_CargarInformacion
@ciud_Id	INT
AS
	BEGIN
		SELECT p.pais_Id, d.dept_Id, ciud_Descripcion 
		FROM Gral.tbCiudades c		INNER JOIN Gral.tbDepartamentos d
		ON	 c.dept_Id = d.dept_Id	INNER JOIN Gral.tbPaises p
		ON	 d.pais_Id = p.pais_Id
		WHERE ciud_Id = @ciud_Id
	END
GO

-- Editar Ciudades
CREATE OR ALTER PROCEDURE Gral.UPD_tbCiudades_Editar
@ciud_Id	INT,
@ciud_Descripcion			NVARCHAR(500), 
@dept_Id					INT, 
@usua_UsuarioModificacion	INT,
@ciud_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Gral.tbCiudades	
			SET		dept_Id = @dept_Id, 
					ciud_Descripcion = @ciud_Descripcion,
					usua_UsuarioModificacion = @usua_UsuarioModificacion, 
					ciud_FechaModificacion = @ciud_FechaModificacion
			WHERE	ciud_Id = @ciud_Id

			SELECT 'Datos editados correctamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
					
	END
GO

-- Eliminar Ciudades
CREATE OR ALTER PROCEDURE Gral.UPD_tbCiudades_Eliminar
@ciud_Id	INT,
@usua_UsuarioModificacion	INT,
@ciud_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Gral.tbCiudades	
			SET		ciud_Estado = 0, 
					usua_UsuarioModificacion = @usua_UsuarioModificacion,
					ciud_FechaModificacion = @ciud_FechaModificacion
			WHERE	ciud_Id = @ciud_Id

			SELECT 'Registro eliminado existosamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH				
	END
GO

----------------------- INVENTARIO -------------------------
-- INSERTAR
CREATE OR ALTER PROCEDURE Peli.UPD_tbInventario_Insertar
@inve_Titulo	NVARCHAR(100),
@inve_Anio		VARCHAR(5), 
@gene_Id		INT,		
@inve_Duracion	INT, 
@form_Id		INT, 
@esta_Id		INT, 
@inve_Descripcion	NVARCHAR(MAX), 
@idio_Id		INT, 
@inve_Cantidad	INT, 
@inve_Precio	DECIMAL(18,2), 
@clas_Id		INT, 
@usua_UsuarioCreacion	INT, 
@inve_FechaCreacion	DATETIME
AS
	BEGIN
		BEGIN TRY
		INSERT INTO Peli.tbInventario (inve_Titulo, inve_Anio, gene_Id, inve_Duracion, form_Id, esta_Id, inve_Descripcion, 
									   idio_Id, inve_Cantidad, inve_Precio, clas_Id, usua_UsuarioCreacion, inve_FechaCreacion)
		VALUES							
									   (@inve_Titulo, @inve_Anio, @gene_Id, @inve_Duracion, @form_Id, @esta_Id, @inve_Descripcion,
										@idio_Id, @inve_Cantidad, @inve_Precio, @clas_Id, @usua_UsuarioCreacion, @inve_FechaCreacion)

			SELECT 'Datos registrados correctamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH

	END