---------------------------------------------
-- PROCEDIMIENTOS PARA LLENAR LOS COMBOBOX --
---------------------------------------------

--- PAISES
CREATE OR ALTER PROCEDURE Gral.Paises_CMB
AS
	BEGIN
			SELECT '0' AS 'pais_Id', ' - Seleccione una opción -' AS 'pais_Descripcion'
			UNION ALL
			SELECT pais_Id, pais_Descripcion FROM Gral.tbPaises
	END
GO

--- DEPARTAMENTOS FILTRADOS POR PAIS
CREATE OR ALTER PROCEDURE Gral.Departamentos_CMB
@pais_Id INT
AS
	BEGIN
			SELECT '0' AS 'dept_Id', ' - Seleccione una opción -' AS 'dept_Descripcion'
			UNION ALL
			SELECT dept_Id, dept_Descripcion FROM Gral.tbDepartamentos
			WHERE  pais_Id = @pais_Id
	END
GO

--- CIUDADES FILTRADAS POR DEPARTAMENTOS
CREATE OR ALTER PROCEDURE Gral.Ciudades_CMB
@dept_Id INT
AS
	BEGIN
			SELECT '0' AS 'dept_Id', ' - Seleccione una opción -' AS 'dept_Descripcion'
			UNION ALL
			SELECT ciud_Id, ciud_Descripcion FROM Gral.tbCiudades
			WHERE  dept_Id = @dept_Id
	END
GO

--- CLIENTES

--- PELICULAS (INVENTARIO)

--- SEXO

--- CLASIFICACIONES

--- GENEROS

--- FORMATOS