---------------------------------------------
-- PROCEDIMIENTOS PARA LOS REPORTES --
---------------------------------------------

--- VENTAS
CREATE OR ALTER PROCEDURE Peli.REPORTE_VentasPorPeliculas
@inve_Id			INT,
@rangoInicio		DATETIME,
@rangoFin			DATETIME
AS
	BEGIN
				DECLARE @VENTA INT = 1

		SELECT 
				fac.fact_Id,
				fac.fact_NumFactura, 
				inv.inve_Titulo,
				fac.fact_Total
		FROM	Peli.tbFacturas fac	INNER JOIN	Peli.tbInventario inv
		ON		fac.inve_Id = inv.inve_Id
		WHERE	fac.tran_Id = @VENTA AND -- id de venta
				fac.fact_FechaFactura BETWEEN @rangoInicio AND @rangoFin AND -- condiciono el rango de tiempo
				inv.inve_Id = @inve_Id -- condiciono con el id de una peli en especifico
	END
GO

CREATE OR ALTER PROCEDURE Peli.REPORTE_VentasPorPeliculas_TOTAL
@inve_Id			INT,
@rangoInicio		DATETIME,
@rangoFin			DATETIME
AS
	BEGIN
				DECLARE @VENTA INT = 1

				SELECT SUM(fact_Total) FROM Peli.tbFacturas  fac INNER JOIN	Peli.tbInventario inv
				ON		fac.inve_Id = inv.inve_Id
				WHERE	fac.tran_Id = @VENTA AND fac.fact_FechaFactura BETWEEN @rangoInicio AND @rangoFin AND inv.inve_Id = @inve_Id
		
	END
GO