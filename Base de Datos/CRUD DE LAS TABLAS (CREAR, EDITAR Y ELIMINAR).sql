---------------------------------------------
--			CRUD DE LAS TABLAS			  --
---------------------------------------------

--- CIUDADES
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