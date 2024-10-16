-- VISTA DE DATOS GENERALES -- 
CREATE OR ALTER VIEW Gral.DatosGenerales_Cliente
AS
	SELECT 
			dg.dato_NombreCompleto	AS 'Nombre Completo', 
			dg.dato_DNI				AS 'Identificación', 
			dg.dato_Telefono		AS 'Telefono', 
			dg.dato_email			AS 'Correo Electronico', 
			p.pais_Descripcion		AS 'País', 
			d.dept_Descripcion		AS 'Departamento',
			c.ciud_Descripcion		AS 'Ciudad', 
			dg.dato_Direccion		AS 'Dirección', 
			dg.dato_FechaNacimiento AS 'Fecha Nacimiento', 
			s.sexo_Descripcion		AS 'Sexo', 
			cat.cate_Descripcion	AS 'Categoria', 
			u.usua_Usuario			AS 'Usuario Creador', 
			dg.dato_FechaCreacion	AS 'Fecha Creación'

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
			dg.dato_DNI				AS 'Identificación', 
			dg.dato_Telefono		AS 'Telefono', 
			dg.dato_email			AS 'Correo Electronico', 
			p.pais_Descripcion		AS 'País', 
			d.dept_Descripcion		AS 'Departamento',
			c.ciud_Descripcion		AS 'Ciudad', 
			dg.dato_Direccion		AS 'Dirección', 
			dg.dato_FechaNacimiento AS 'Fecha Nacimiento', 
			s.sexo_Descripcion		AS 'Sexo', 
			cat.cate_Descripcion	AS 'Categoria', 
			u.usua_Usuario			AS 'Usuario Creador', 
			dg.dato_FechaCreacion	AS 'Fecha Creación'

  FROM		Gral.tbDatos_Generales dg	INNER JOIN Gral.tbCiudades c
			ON dg.ciud_Id = c.ciud_Id	INNER JOIN Gral.tbSexos s
			ON dg.sexo_Id = s.sexo_Id	INNER JOIN Gral.tbCategorias cat
			ON dg.cate_Id = cat.cate_Id INNER JOIN Acce.tbUsuarios u
			ON dg.usua_UsuarioCreacion = u.usua_Id	INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id = d.dept_Id INNER JOIN Gral.tbPaises p
			ON d.pais_Id = p.pais_Id
 WHERE		dg.cate_Id = 1
GO

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

