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
VALUES							(1,				'Atlántida',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Choluteca',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Colón',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Comayagua',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Copan',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Cortés',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'El Paraíso',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Francisco Morazán',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Gracias a Dios',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Intibucá',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Islas de la Bahía',				1,			GETDATE());
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
VALUES							(1,				'Santa Bárbara',				1,			GETDATE());
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
--- insertar las 3 ciudades de los 15 deptos faltantes -- 	

-- Datos Generales
INSERT INTO Gral.tbDatos_Generales([dato_NombreCompleto],[dato_DNI],[dato_Telefono],[dato_email],
									[ciud_Id],[dato_Direccion],[dato_FechaNacimiento],[sexo_Id],[cate_Id],
									[usua_UsuarioCreacion],[dato_FechaCreacion])
VALUES								('Angie Yahaira Campos Arias', '0512200300736', '95887062', 'angie.campos@gmail.com',
									3, 'Avenida Flores, 8va Calle, Casa #34', '2003-01-03', 1,1,
									1, GETDATE())
GO
-- Datos Generales
INSERT INTO Gral.tbDatos_Generales([dato_NombreCompleto],[dato_DNI],[dato_Telefono],[dato_email],
									[ciud_Id],[dato_Direccion],[dato_FechaNacimiento],[sexo_Id],[cate_Id],
									[usua_UsuarioCreacion],[dato_FechaCreacion])
VALUES								('Karla Suazo', '0503199800733', '98702036', 'karla.s1998@gmail.com',
									2, 'Avenida Rosales, 7ma Calle, Casa #4', '1998-10-03', 1,2,
									1, GETDATE())
GO


-- Clasificaciones
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Todo Público',  1, GETDATE())
GO
INSERT INTO Peli.tbClasificaciones([clas_Descripcion], [usua_UsuarioCreacion], [clas_FechaCreacion])
VALUES							  ('Supervición de Padres',  1, GETDATE())
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
INSERT INTO Peli.tbFormatos([form_Descripcion],[usua_UsuarioCreacion], [form_FechaCreacion])
VALUES						('Streaming', 1, GETDATE())
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
VALUES						('Acción', 1, GETDATE())
GO
INSERT INTO Peli.tbGeneros([gene_Descripcion],[usua_UsuarioCreacion],[gene_FechaCreacion])
VALUES						('Animada', 1, GETDATE())
GO

-- Idiomas
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Español', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Inglés', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Italiano', 1, GETDATE())
GO
INSERT INTO Peli.tbIdiomas([idio_Descripcion],[usua_UsuarioCreacion], [idio_FechaCreacion])
VALUES					('Francés', 1, GETDATE())
GO

-- Metodos de Pago
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Efectivo', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Tarjeta de Crédito', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Transaccion Bancaria', 1, GETDATE())
GO
INSERT INTO Peli.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Tarjeta de Débito', 1, GETDATE())
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
VALUES						 (	'Coraline', '2009', 5, 200, 3, 1, 
								'Una niña descubre una puerta secreta en su nueva casa y entra a una realidad alterna que la refleja fielmente de muchas formas.',
								2, 120, 50.40, 1, 1, GETDATE())
GO

-- Factura
INSERT INTO Peli.tbFacturas([meto_Id], [dato_Id], [fact_NumFactura],[fact_FechaFactura],[tran_Id], [fact_Subtotal],[fact_Impuesto],[fact_Descuento], [inve_Id], [fact_fechaDev],[fact_Total], [usua_UsuarioCreacion], [fact_FechaCreacion])
VALUES						(1, 2,'00001', GETDATE(), 1, 200, 200*0.15, 200*0.05, 1, '2025-01-01', 155.59, 1, GETDATE())
GO