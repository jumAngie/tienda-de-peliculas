---- ALTERACIONES

----- CREAR TABLA DE PANTALLAS
CREATE TABLE Acce.tbPantallas
(
	pant_ID					INT IDENTITY(1,1),
	pant_NombrePantalla		NVARCHAR(500),
	pant_RutaImagen			NVARCHAR(500),
	pant_NombreBoton		VARCHAR(50),
	PosicionY				INT,

	CONSTRAINT PK_Acce_tbPantallas_pant_ID  PRIMARY KEY(pant_ID)

);
----- CREAR TABLA DE PERMISOS
CREATE TABLE Acce.tbPermisos (
    perm_ID				INT IDENTITY(1,1),
    role_Id				INT,
	pant_ID				INT,
	perm_TienePermiso	BIT

	CONSTRAINT PK_Acce_tbPermisos_perm_ID		PRIMARY KEY(perm_ID),
	CONSTRAINT FK_Acce_tbPermisos_role_Id_Acce_tbRoles_role_Id FOREIGN KEY (role_Id) REFERENCES Acce.tbRoles (role_Id),
	CONSTRAINT FK_Acce_tbPermisos_pant_ID_Acce_tbPantallas_pant_ID FOREIGN KEY (pant_ID) REFERENCES Acce.tbPantallas (pant_ID)
);

--- IMPORTANTE PARA EL LOGIN
-- Paso 1: Crear una columna temporal para la contraseña en formato VARBINARY(MAX)
ALTER TABLE Acce.tbUsuarios
ADD usua_ContraseniaTemp VARBINARY(MAX);
GO

-- Paso 2: Copiar y convertir los datos de `usua_Contrasenia` a `usua_ContraseniaTemp`
UPDATE Acce.tbUsuarios
SET usua_ContraseniaTemp = CONVERT(VARBINARY(MAX), usua_Contrasenia);
GO

-- Paso 3: Eliminar la columna original `usua_Contrasenia`
ALTER TABLE Acce.tbUsuarios
DROP COLUMN usua_Contrasenia;
GO

-- Paso 4: Renombrar la columna temporal para que se llame `usua_Contrasenia`
EXEC sp_rename 'Acce.tbUsuarios.usua_ContraseniaTemp', 'usua_Contrasenia', 'COLUMN';
GO