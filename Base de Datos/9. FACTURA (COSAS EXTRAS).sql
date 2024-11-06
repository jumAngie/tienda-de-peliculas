-- PROCEDIMIENTOS PARA LA FACTURA

--- TRAER EL NUMERO DE FACTURA DE EL ULTIMO NUMERO REGISTRADO
CREATE OR ALTER PROCEDURE Peli.UDP_UltimoNumeroFactura
AS
	BEGIN
	SELECT TOP 1 (fact_NumFactura) AS 'fact_NumFactura'
	FROM Peli.tbFacturas
	ORDER BY fact_Id DESC
	END

	-- EDITAR EL TIPO DE DATO DE fact_NumFactura

GO

-- STOCK DISPONIBLE
CREATE OR ALTER PROCEDURE Peli.UDP_StockDisponible
@inve_ID INT
AS
	BEGIN
		SELECT inve_Cantidad FROM Peli.tbInventario WHERE inve_ID = @inve_ID
	END

	GO
CREATE OR ALTER PROCEDURE Peli.UDP_CalcularDescuento
@dato_ID INT
AS
	BEGIN
		DECLARE @FECHA DATETIME = (SELECT dato_FechaNacimiento FROM Gral.tbDatos_Generales WHERE dato_Id = @dato_ID)
		DECLARE @EDAD INT = (SELECT FLOOR(DATEDIFF(DAY, @FECHA, GETDATE()) / 365.25))
		SELECT @EDAD

		
	END


GO

CREATE TABLE Peli.tbDescuentos
(
	descu_ID			INT IDENTITY (1,1),
	descu_Descripcion	NVARCHAR(50),
	descu_RangoInicio	INT,
	descu_RangoFin		INT,
	descu_Porcentaje	DECIMAL(3,2)

	CONSTRAINT PK_Peli_tbDescuentos_descue_ID PRIMARY KEY (descu_ID)
);

INSERT INTO Peli.tbDescuentos(descu_Descripcion, descu_RangoInicio, descu_RangoFin, descu_Porcentaje)
VALUES						('Descuento Estudiantil', 12, 18, 0.10)
GO
INSERT INTO Peli.tbDescuentos(descu_Descripcion, descu_RangoInicio, descu_RangoFin, descu_Porcentaje)
VALUES						('Descuento Universitario', 19, 25, 0.15)
GO
INSERT INTO Peli.tbDescuentos(descu_Descripcion, descu_RangoInicio, descu_RangoFin, descu_Porcentaje)
VALUES						('Descuento Tercera Edad', 60, 79, 0.25)
GO
INSERT INTO Peli.tbDescuentos(descu_Descripcion, descu_RangoInicio, descu_Porcentaje)
VALUES						('Descuento Cuarta Edad', 80, 0.35)
GO