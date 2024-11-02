-- PROCEDIMIENTOS PARA EL LOGIN
CREATE OR ALTER PROCEDURE Acce.UDP_IniciarSesion
    @usua_Usuario NVARCHAR(100),
    @usua_Contrasenia NVARCHAR(100) 
AS
BEGIN
    BEGIN TRY
        DECLARE @contrasenaEncriptada VARBINARY(MAX) = HASHBYTES('SHA2_512', @usua_Contrasenia);
       
        SELECT 
            usua.usua_Id, 
            usua.usua_Usuario, 
            datos.dato_Id,
            datos.dato_NombreCompleto,
            datos.dato_email,
            roles.role_Descripcion,
            roles.role_Id
        FROM Acce.tbUsuarios usua
            LEFT JOIN Gral.tbDatos_Generales datos ON usua.dato_Id = datos.dato_Id
            LEFT JOIN Acce.tbRoles roles ON usua.role_Id = roles.role_Id
        WHERE usua.usua_Usuario = @usua_Usuario
        AND usua.usua_Contrasenia = @contrasenaEncriptada;
    END TRY
    BEGIN CATCH
        SELECT 'Error Message: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

---- ENCRIPTAR LA CONTRASEÑA
DECLARE @CONTRA NVARCHAR(100) = '123'
DECLARE @contrasenaEncriptada VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA);
SELECT @contrasenaEncriptada; 
UPDATE Acce.tbUsuarios
	   SET usua_Contrasenia = @contrasenaEncriptada
	   WHERE usua_Id = 1
GO

-- DIBUJANDO MENU SEGUN ROL
CREATE OR ALTER PROCEDURE Acce.UDP_DibujarMenuPorRol
@role_Id INT
AS
	BEGIN
		SELECT  rol.role_Id, 
				rol.role_Descripcion, 
				pant.pant_NombrePantalla, 
				pant.pant_ID, 
				pant.pant_NombreBoton, 
				pant.pant_RutaImagen,
				perm.perm_TienePermiso,
				pant.PosicionY
			FROM Acce.tbPermisos perm		INNER JOIN Acce.tbRoles rol
			ON   perm.role_Id = rol.role_Id	INNER JOIN Acce.tbPantallas pant
			ON   perm.pant_ID = pant.pant_ID
			WHERE perm.role_Id = @role_Id AND  perm.perm_TienePermiso = 1
	END