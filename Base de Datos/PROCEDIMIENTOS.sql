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
CREATE OR ALTER PROCEDURE Gral.Datos_Generales_CantidadDeClientes
AS
	BEGIN
		SELECT COUNT(*) AS 'Cantidad de Clientes Registrados' FROM Gral.tbDatos_Generales
		WHERE cate_Id = 2
	END
	GO
--- PELICULAS (INVENTARIO)

--- SEXO

--- CLASIFICACIONES
CREATE OR ALTER PROCEDURE Peli.Clasificaciones_CMB
AS
	BEGIN
		SELECT '0' AS 'clas_Id', ' - Seleccione una opción -' AS 'clas_Descripcion'
		UNION ALL
		SELECT clas_Id, clas_Descripcion FROM Peli.tbClasificaciones
		WHERE clas_Estado = 1;
	END
GO

--- GENEROS
GO
CREATE OR ALTER PROCEDURE Peli.Generos_CMB
AS
	BEGIN
		SELECT '0' AS 'gene_Id', ' - Seleccione una opción -' AS 'gene_Descripcion'
		UNION ALL
		SELECT gene_Id, gene_Descripcion FROM Peli.tbGeneros
		WHERE gene_Estado = 1;
	END
	GO

--- FORMATOS
CREATE OR ALTER PROCEDURE Peli.Formatos_CMB
AS
	BEGIN
		SELECT '0' AS 'form_Id', ' - Seleccione una opción -' AS 'form_Descripcion'
		UNION ALL
		SELECT form_Id, form_Descripcion FROM Peli.tbFormatos
		WHERE form_Estado = 1;
	END
GO

--- FACTURA

--- IDIOMAS
GO
CREATE OR ALTER PROCEDURE Peli.Idiomas_CMB
AS
	BEGIN
		SELECT '0' AS 'idio_Id', ' - Seleccione una opción -' AS 'idio_Descripcion'
		UNION ALL
		SELECT idio_Id, idio_Descripcion FROM Peli.tbIdiomas
		WHERE idio_Estado = 1;
	END
GO

--- ESTADOS
CREATE OR ALTER PROCEDURE Peli.Estados_CMB
AS
	BEGIN
		SELECT '0' AS 'esta_Id', ' - Seleccione una opción -' AS 'esta_Descripcion'
		UNION ALL
		SELECT esta_Id, esta_Descripcion FROM Peli.tbEstados
		WHERE esta_Estado = 1;
	END
GO

--- DASHBOARD
GO
CREATE OR ALTER PROCEDURE Peli.Datos_Generales_VentasSemanales
@fechaLunes DATETIME,
@fechaDomingo DATETIME
AS
	BEGIN
		SELECT COUNT(*)  AS 'Ventas de la Semana Actual'
		FROM Peli.tbFacturas 
		WHERE  fact_FechaFactura BETWEEN @fechaLunes AND @fechaDomingo
		AND tran_Id = 1
	END

GO
	CREATE OR ALTER PROCEDURE Peli.Datos_Generales_AlquileresSemanales
@fechaLunes DATETIME,
@fechaDomingo DATETIME
AS
	BEGIN
		SELECT COUNT(*)  AS 'Alquileres de la Semana Actual'
		FROM Peli.tbFacturas 
		WHERE  fact_FechaFactura BETWEEN @fechaLunes AND @fechaDomingo
		AND tran_Id = 2
	END