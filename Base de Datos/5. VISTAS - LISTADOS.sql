-- VISTA DE DATOS GENERALES -- 
CREATE OR ALTER VIEW Gral.DatosGenerales_Cliente
AS
	SELECT 
			dg.dato_NombreCompleto	AS 'Nombre Completo', 
			dg.dato_DNI				AS 'Identificaci�n', 
			dg.dato_Telefono		AS 'Telefono', 
			dg.dato_email			AS 'Correo Electronico', 
			p.pais_Descripcion		AS 'Pa�s', 
			d.dept_Descripcion		AS 'Departamento',
			c.ciud_Descripcion		AS 'Ciudad', 
			dg.dato_Direccion		AS 'Direcci�n', 
			dg.dato_FechaNacimiento AS 'Fecha Nacimiento', 
			s.sexo_Descripcion		AS 'Sexo', 
			cat.cate_Descripcion	AS 'Categoria', 
			u.usua_Usuario			AS 'Usuario Creador', 
			dg.dato_FechaCreacion	AS 'Fecha Creaci�n'

  FROM		Gral.tbDatos_Generales dg	INNER JOIN Gral.tbCiudades c
			ON dg.ciud_Id = c.ciud_Id	INNER JOIN Gral.tbSexos s
			ON dg.sexo_Id = s.sexo_Id	INNER JOIN Gral.tbCategorias cat
			ON dg.cate_Id = cat.cate_Id INNER JOIN Acce.tbUsuarios u
			ON dg.usua_UsuarioCreacion = u.usua_Id	INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id = d.dept_Id INNER JOIN Gral.tbPaises p
			ON d.pais_Id = p.pais_Id
 WHERE		dg.cate_Id = 2
GO

CREATE OR ALTER VIEW Gral.DatosGenerales_Empleado
AS
	SELECT 
			dg.dato_NombreCompleto	AS 'Nombre Completo', 
			dg.dato_DNI				AS 'Identificaci�n', 
			dg.dato_Telefono		AS 'Telefono', 
			dg.dato_email			AS 'Correo Electronico', 
			p.pais_Descripcion		AS 'Pa�s', 
			d.dept_Descripcion		AS 'Departamento',
			c.ciud_Descripcion		AS 'Ciudad', 
			dg.dato_Direccion		AS 'Direcci�n', 
			dg.dato_FechaNacimiento AS 'Fecha Nacimiento', 
			s.sexo_Descripcion		AS 'Sexo', 
			cat.cate_Descripcion	AS 'Categoria', 
			u.usua_Usuario			AS 'Usuario Creador', 
			dg.dato_FechaCreacion	AS 'Fecha Creaci�n'

  FROM		Gral.tbDatos_Generales dg	INNER JOIN Gral.tbCiudades c
			ON dg.ciud_Id = c.ciud_Id	INNER JOIN Gral.tbSexos s
			ON dg.sexo_Id = s.sexo_Id	INNER JOIN Gral.tbCategorias cat
			ON dg.cate_Id = cat.cate_Id INNER JOIN Acce.tbUsuarios u
			ON dg.usua_UsuarioCreacion = u.usua_Id	INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id = d.dept_Id INNER JOIN Gral.tbPaises p
			ON d.pais_Id = p.pais_Id
 WHERE		dg.cate_Id = 1
GO

-- VISTA DE CIUDADES -- 
CREATE OR ALTER VIEW Gral.Listado_Ciudades
AS
	SELECT	
			c.ciud_Id				AS 'CiudadID',
			p.pais_Descripcion		AS 'Pais',
			d.dept_Descripcion		AS 'Departamento',
			ciud_Descripcion		AS 'Ciudad',
			u.usua_Usuario			AS 'Usuario Creador'

	FROM    Gral.tbCiudades c			INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id = d.dept_Id	INNER JOIN Gral.tbPaises p
			ON d.pais_Id = p.pais_Id	INNER JOIN Acce.tbUsuarios u
			ON c.usua_UsuarioCreacion = u.usua_Id
	WHERE   c.ciud_Estado = 1
GO

-- VISTA DE INVENTARIO -- 
CREATE OR ALTER VIEW Peli.Listado_Inventario
AS
	SELECT 
			inve_Id,
			inve_Titulo,
			inve_Anio,
			g.gene_Descripcion,
			inve_Duracion,
			f.form_Descripcion,
			e.esta_Descripcion,
			inve_Descripcion,
			idi.idio_Descripcion,
			inve_Cantidad,
			inve_Precio,
			c.clas_Descripcion,
			uC.usua_Usuario AS 'Usuario Creacion',
			CASE WHEN uM.usua_Usuario IS NULL THEN 'N/A' 
				ELSE uM.usua_Usuario  
			END AS 'Usuario Modificador'
	FROM Peli.tbInventario i					INNER JOIN Peli.tbGeneros g
	ON	 i.gene_Id = g.gene_Id					INNER JOIN Peli.tbFormatos f
	ON   i.form_Id = f.form_Id					INNER JOIN Peli.tbEstados e
	ON   i.esta_Id = e.esta_Id					INNER JOIN Peli.tbIdiomas idi
	ON   i.idio_Id = idi.idio_Id				INNER JOIN Peli.tbClasificaciones c
	ON   i.clas_Id = c.clas_Id					INNER JOIN Acce.tbUsuarios uC
	ON   i.usua_UsuarioCreacion = uC.usua_Id	LEFT JOIN Acce.tbUsuarios uM
	ON   i.usua_UsuarioModificacion = uM.usua_Id

GO

-- VISTA DE FACTURAS -- 
CREATE OR ALTER VIEW Peli.Listado_Facturas
	AS
		SELECT  fact_Id, 
				met.meto_Descripcion, 
				dato.dato_NombreCompleto, 
				fact_NumFactura, 
				fact_FechaFactura, 
				trn.tran_Descripcion, 
				fact_Impuesto, 
				fact_Descuento, 
				fact_Subtotal, 
				inve.inve_Titulo, 
				fact_fechaDev, 
				fact_Total, 
				usuC.usua_Usuario AS 'Usuario Creaci�n',
				fact_FechaCreacion, 

				CASE WHEN usuM.usua_Usuario IS NULL THEN 'N/A' 
				ELSE usuM.usua_Usuario  
				END AS 'Usuario Modificador',

				fact_FechaModificacion
		FROM	Peli.tbFacturas fact							INNER JOIN Peli.tbMetodosPago met
		ON		fact.meto_Id = met.meto_Id						INNER JOIN Peli.tbTipoTransaccion trn
		ON		fact.tran_Id = trn.tran_Id						INNER JOIN Peli.tbInventario inve
		ON		fact.inve_Id = inve.inve_Id						INNER JOIN Acce.tbUsuarios usuC
		ON		fact.usua_UsuarioCreacion = usuC.usua_Id		LEFT JOIN Acce.tbUsuarios usuM
		ON		fact.usua_UsuarioModificacion = usuM.usua_Id	INNER JOIN Gral.tbDatos_Generales dato
		ON		fact.dato_Id = dato.dato_Id
		WHERE	fact_Estado = 1
	GO
