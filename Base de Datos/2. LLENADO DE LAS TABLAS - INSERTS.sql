-- /* INSERTS */ -- 

--USUARIOS
INSERT INTO Acce.tbUsuarios(usua_Usuario,usua_Contrasenia,dato_Id,role_Id,usua_UsuarioCreacion,usua_FechaCreacion)
VALUES						('Admin', '123', 1, 1, 1, GETDATE());
GO
-- ROLES
INSERT INTO Acce.tbRoles(role_Descripcion,usua_UsuarioCreacion, role_FechaCreacion)
VALUES					('Administrador',		1,					GETDATE());
GO

-- SEXOS
INSERT INTO Gral.tbSexos([sexo_Descripcion], [usua_UsuarioCreacion],[sexo_FechaCreacion] )
VALUES					('Femenino', 1, GETDATE())
GO
INSERT INTO Gral.tbSexos([sexo_Descripcion], [usua_UsuarioCreacion],[sexo_FechaCreacion] )
VALUES					('Masculino', 1, GETDATE())
GO

-- CATEGORIAS
INSERT INTO Gral.tbCategorias([cate_Descripcion], [usua_UsuarioCreacion], [cate_FechaCreacion])
VALUES						('Empleado',               1,						GETDATE())
GO
INSERT INTO Gral.tbCategorias([cate_Descripcion], [usua_UsuarioCreacion], [cate_FechaCreacion])
VALUES						('Cliente',               1,						GETDATE())
GO

-- PAISES
INSERT INTO Gral.tbPaises(pais_Descripcion,usua_UsuarioCreacion, pais_FechaCreacion)
VALUES					('Honduras',			1,					GETDATE());
GO

-- DEPARTAMENTOS
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Atl�ntida',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Choluteca',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Col�n',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Comayagua',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Copan',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Cort�s',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'El Para�so',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Francisco Moraz�n',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Gracias a Dios',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Intibuc�',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Islas de la Bah�a',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'La Paz',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Lempira',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Ocotepque',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Olancho',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Santa B�rbara',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Valle',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Yoro',				1,			GETDATE());
GO

--- Ciudades
-------------------------------- 3 ciudades de Atlantida -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(1,			'La Ceiba',				1,						GETDATE()),
							(1,			'Esparta',				1,						GETDATE()),
							(1,			'Jutiapa',				1,						GETDATE());
-------------------------------- 3 ciudades de Choluteca -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(2,			'San Isidro',				1,						GETDATE()),
							(2,			'Pespire',				1,						GETDATE()),
							(2,			'Choluteca',				1,						GETDATE());
-------------------------------- 3 ciudades de Col�n -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(3,			'Trujillo',				1,						GETDATE()),
							(3,			'Tocoa',				1,						GETDATE()),
							(3,			'Bonito Oriental',		1,						GETDATE());

-------------------------------- 3 ciudades de Comayagua -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(4,			'Comayagua',			1,						GETDATE()),
							(4,			'Siguatepeque',			1,						GETDATE()),
							(4,			'La Libertad',			1,						GETDATE());

-------------------------------- 3 ciudades de Cop�n -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(5,			'Santa Rosa de Cop�n',	1,						GETDATE()),
							(5,			'La Entrada',			1,						GETDATE()),
							(5,			'Dulce Nombre',			1,						GETDATE());

-------------------------------- 3 ciudades de Cort�s -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(6,			'San Pedro Sula',		1,						GETDATE()),
							(6,			'Puerto Cort�s',		1,						GETDATE()),
							(6,			'Choloma',				1,						GETDATE());

-------------------------------- 3 ciudades de El Para�so -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(7,			'Danl�',				1,						GETDATE()),
							(7,			'Yuscar�n',				1,						GETDATE()),
							(7,			'Alauca',				1,						GETDATE());

-------------------------------- 3 ciudades de Francisco Moraz�n -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(8,			'Tegucigalpa',			1,						GETDATE()),
							(8,			'Valle de �ngeles',		1,						GETDATE()),
							(8,			'Santa Luc�a',			1,						GETDATE());

-------------------------------- 3 ciudades de Gracias a Dios -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(9,			'Puerto Lempira',		1,						GETDATE()),
							(9,			'Brus Laguna',			1,						GETDATE()),
							(9,			'Ahuas',				1,						GETDATE());

-------------------------------- 3 ciudades de Intibuc� -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(10,		'La Esperanza',			1,						GETDATE()),
							(10,		'Yamaranguila',			1,						GETDATE()),
							(10,		'San Francisco de Opalaca', 1,					GETDATE());

-------------------------------- 3 ciudades de Islas de la Bah�a -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(11,		'Coxen Hole',			1,						GETDATE()),
							(11,		'Utila',				1,						GETDATE()),
							(11,		'French Harbour',		1,						GETDATE());

-------------------------------- 3 ciudades de La Paz -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(12,		'La Paz',				1,						GETDATE()),
							(12,		'Marcala',				1,						GETDATE()),
							(12,		'Caba�as',				1,						GETDATE());

-------------------------------- 3 ciudades de Lempira -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(13,		'Gracias',				1,						GETDATE()),
							(13,		'Erandique',			1,						GETDATE()),
							(13,		'La Campa',				1,						GETDATE());

-------------------------------- 3 ciudades de Ocotepeque -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(14,		'Nueva Ocotepeque',		1,						GETDATE()),
							(14,		'La Encarnaci�n',		1,						GETDATE()),
							(14,		'Sensenti',				1,						GETDATE());

-------------------------------- 3 ciudades de Olancho -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(15,		'Juticalpa',			1,						GETDATE()),
							(15,		'Catacamas',			1,						GETDATE()),
							(15,		'San Francisco de la Paz',	1,				GETDATE());

-------------------------------- 3 ciudades de Santa B�rbara -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(16,		'Santa B�rbara',		1,						GETDATE()),
							(16,		'Quimist�n',			1,						GETDATE()),
							(16,		'Ilama',				1,						GETDATE());

-------------------------------- 3 ciudades de Valle -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(17,		'Nacaome',				1,						GETDATE()),
							(17,		'San Lorenzo',			1,						GETDATE()),
							(17,		'Amapala',				1,						GETDATE());

-------------------------------- 3 ciudades de Yoro -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(18,		'Yoro',					1,						GETDATE()),
							(18,		'El Progreso',			1,						GETDATE()),
							(18,		'Olanchito',			1,						GETDATE());



-- Datos Generales Empleados
INSERT INTO Gral.tbDatos_Generales([dato_NombreCompleto],[dato_DNI],[dato_Telefono],[dato_email],
									[ciud_Id],[dato_Direccion],[dato_FechaNacimiento],[sexo_Id],[cate_Id],
									[usua_UsuarioCreacion],[dato_FechaCreacion])
VALUES								('Angie Yahaira Campos Arias', '0512200300736', '95887062', 'angie.campos@gmail.com',
									3, 'Avenida Flores, 8va Calle, Casa #34', '2003-01-03', 1,1,
									1, GETDATE())
GO
INSERT INTO Gral.tbDatos_Generales([dato_NombreCompleto],[dato_DNI],[dato_Telefono],[dato_email],
									[ciud_Id],[dato_Direccion],[dato_FechaNacimiento],[sexo_Id],[cate_Id],
									[usua_UsuarioCreacion],[dato_FechaCreacion])
VALUES								('Cindy Nicole Reyes', '0512200200736', '33663366', 'cindy@gmail.com',
									3, 'Avenida Flores, 8va Calle, Casa #34', '2002-01-13', 1,1,
									1, GETDATE())
GO
INSERT INTO Gral.tbDatos_Generales([dato_NombreCompleto],[dato_DNI],[dato_Telefono],[dato_email],
									[ciud_Id],[dato_Direccion],[dato_FechaNacimiento],[sexo_Id],[cate_Id],
									[usua_UsuarioCreacion],[dato_FechaCreacion])
VALUES								('Carlos Francisco Arita', '0512200500736', '33663366', 'carlos005@gmail.com',
									3, 'Avenida Flores, 8va Calle, Casa #34', '2005-11-16', 2,1,
									1, GETDATE())
GO

-- Clasificaciones
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Todo P�blico',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Supervici�n de Padres',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Para Adolescentes',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Mayores de 17',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Para Adultos',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Myores de 21',  1, GETDATE())
GO

-- Estados
INSERT INTO Peli.tbEstados([esta_Descripcion], [usua_UsuarioCreacion], [esta_FechaCreacion])
VALUES						('Nuevo',  1, GETDATE())
GO
INSERT INTO Peli.tbEstados([esta_Descripcion], [usua_UsuarioCreacion], [esta_FechaCreacion])
VALUES						('Usado',  1, GETDATE())
GO

-- Formatos
INSERT INTO Peli.tbFormatos([form_Descripcion],[usua_UsuarioCreacion], [form_FechaCreacion])
VALUES						('Blue Ray', 1, GETDATE())
GO
INSERT INTO Peli.tbFormatos([form_Descripcion],[usua_UsuarioCreacion], [form_FechaCreacion])
VALUES						('DVD', 1, GETDATE())
GO

-- Generos
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Comedia', 1, GETDATE())
GO
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Romance', 1, GETDATE())
GO
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Terror', 1, GETDATE())
GO
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Acci�n', 1, GETDATE())
GO
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Animada', 1, GETDATE())
GO

-- Idiomas
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Espa�ol', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Ingl�s', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Italiano', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Franc�s', 1, GETDATE())
GO

-- Metodos de Pago
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Efectivo', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Tarjeta de Cr�dito', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Transaccion Bancaria', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Tarjeta de D�bito', 1, GETDATE())
GO

-- Tipo de Transaccion
INSERT INTO Peli.tbTipoTransaccion([tran_Descripcion],[usua_UsuarioCreacion], [tran_FechaCreacion])
VALUES							  ('Venta', 1, GETDATE())
GO
INSERT INTO Peli.tbTipoTransaccion([tran_Descripcion],[usua_UsuarioCreacion], [tran_FechaCreacion])
VALUES							  ('Alquiler', 1, GETDATE())
GO

-- Inventario
INSERT INTO Peli.tbInventario([inve_Titulo],[inve_Anio], [gene_Id], [inve_Duracion], [form_Id],[esta_Id] , [inve_Descripcion],
							  [idio_Id],[inve_Cantidad],[inve_Precio] , [clas_Id], [usua_UsuarioCreacion],[inve_FechaCreacion] )
VALUES						 (	'Coraline', '2009', 5, 200, 2, 1, 
								'Una ni�a descubre una puerta secreta en su nueva casa y entra a una realidad alterna que la refleja fielmente de muchas formas.',
								2, 120, 50.40, 1, 1, GETDATE())
GO


 --- ARREGLAR UNOS INSERTS ACA

-- LLENANDO ROLES
INSERT INTO Acce.tbRoles (role_Descripcion, usua_UsuarioCreacion, role_FechaCreacion)
VALUES					('Supervisor', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (role_Descripcion, usua_UsuarioCreacion, role_FechaCreacion)
VALUES					('Vendedor', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (role_Descripcion, usua_UsuarioCreacion, role_FechaCreacion)
VALUES					('Almac�n', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (role_Descripcion, usua_UsuarioCreacion, role_FechaCreacion)
VALUES					('RRHH', 1, GETDATE())
GO

--- INSERTANDO PANTALLAS
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Clientes', 'Icono_Registrar_Clientes', 'btnRegistroClientes', 72)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Empleados', 'Icono_Registrar_Empleados', 'btnRegistroEmpleados', 144)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Venta/Alquiler', 'Icono_Registrar_Venta_Alquiler', 'btnVentaAlquiler', 231)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Inventario', 'Icono_Inventario', 'btnInventario', 310)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Reportes', 'Icono_Reportes', 'btnReportes', 390)
GO

--- ASIGNANDO PERMISOS
------- ADMIN
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(1, 1, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(1, 2, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(1, 3, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(1, 4, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(1, 5, 1)
GO

------- SUPERVISOR
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(3, 1, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(3, 2, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(3, 3, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(3, 4, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(3, 5, 1)
GO
------- VENTAS
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(4, 1, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(4, 2, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(4, 3, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(4, 4, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(4, 5, 0)
GO
------- ALMACEN
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(5, 1, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(5, 2, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(5, 3, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(5, 4, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(5, 5, 0)
GO
------- RRHH
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(6, 1, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(6, 2, 1)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(6, 3, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(6, 4, 0)
GO
INSERT INTO Acce.tbPermisos ([role_Id], [pant_ID], [perm_TienePermiso])
VALUES						(6, 5, 0)
GO
