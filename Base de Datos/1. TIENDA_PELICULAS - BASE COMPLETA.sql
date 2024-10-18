
/*
		DROP DATABASE TIENDA_PELICULAS
		GO
		DROP SCHEMA Gral
		GO
		DROP SCHEMA Acce
		GO
		DROP SCHEMA Peli
		GO
		*/
	/*
	
	Primero crear y luego correr script
	
	CREATE DATABASE TIENDA_PELICULAS
	GO
	USE TIENDA_PELICULAS
	GO
	*/

	--CREATE SCHEMA Gral
	--GO  
	--CREATE SCHEMA Acce
	--GO
	--CREATE SCHEMA Peli
	--GO

--**********************************************************--
--*************** SCHEMA Acceso ***************************--
--**********************************************************--

-- --- -- TABLA USUARIOS -- -- -- --  
CREATE TABLE Acce.tbUsuarios(
		usua_Id 					INT IDENTITY(1,1),
		usua_Usuario				NVARCHAR(100) 	NOT NULL, 
		usua_Contrasenia			NVARCHAR(MAX) 	NOT NULL,
		dato_Id						INT 			NOT NULL,
		role_Id						INT				NOT NULL,
		
		usua_UsuarioCreacion 		INT				NOT NULL,
		usua_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		usua_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_Estado					BIT				DEFAULT 1,
	
	
	CONSTRAINT PK_Acce_tbUsuarios_usua_Id 					PRIMARY KEY (usua_Id),
	CONSTRAINT UQ_acce_tbUsuarios_usua_Usuario				UNIQUE(usua_Usuario)
);
GO
-- --- -- TABLA ROLES -- -- -- -- 
GO
CREATE TABLE Acce.tbRoles
(
		role_Id						INT 			IDENTITY(1,1),
		role_Descripcion			NVARCHAR(500),		

		usua_UsuarioCreacion 		INT							NOT NULL,
		role_FechaCreacion 			DATETIME 					NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT		NULL,
		role_FechaModificacion		DATETIME 		DEFAULT		NULL,
		role_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Acce_tbRoles_role_Id 				PRIMARY KEY (role_Id),
	CONSTRAINT UQ_acce_tbRoles_role_Descripcion 	UNIQUE(role_Descripcion),
	
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioCreacion_Acce_tbRoles_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioModificacion_Acce_tbRoles_usua_Id FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

--**********************************************************--
--**************** SCHEMA GENERAL **************************--
--**********************************************************--

-- --- -- TABLA PAISES -- -- -- -- 
CREATE TABLE Gral.tbPaises
(
		pais_Id						INT 			IDENTITY(1,1),
		pais_Descripcion			NVARCHAR(500),		

		usua_UsuarioCreacion 		INT							NOT NULL,
		pais_FechaCreacion 			DATETIME 					NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT		NULL,
		pais_FechaModificacion		DATETIME 		DEFAULT		NULL,
		pais_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbPais_pais_Id				PRIMARY KEY (pais_Id),
	CONSTRAINT UQ_Gral_tbPais_pais_Descripcion 		UNIQUE		(pais_Descripcion),
	
	CONSTRAINT FK_Acce_tbPais_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbPais_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

-- --- -- TABLA DEPARTAMENTOS -- -- -- -- 
CREATE TABLE Gral.tbDepartamentos
(
	dept_Id				INT			IDENTITY(1,1),
	pais_Id				INT,
	dept_Descripcion	NVARCHAR(500),

	usua_UsuarioCreacion 		INT							NOT NULL,
	dept_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	dept_FechaModificacion		DATETIME 		DEFAULT		NULL,
	dept_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbDepartamentos_dept_Id											PRIMARY KEY(dept_Id),
	CONSTRAINT FK_Gral_tbDepartamentos_pais_Id_Gral_tbPaises_pais_Id					FOREIGN KEY (pais_Id)		REFERENCES Gral.tbPaises(pais_Id),
	
	CONSTRAINT FK_Gral_tbDepartamentos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbDepartamentos_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

-- --- -- TABLA CIUDADES -- -- -- -- 
CREATE TABLE Gral.tbCiudades
(
	ciud_Id		INT		IDENTITY(1,1),
	dept_Id		INT,
	ciud_Descripcion	NVARCHAR(500),

	usua_UsuarioCreacion 		INT							NOT NULL,
	ciud_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	ciud_FechaModificacion		DATETIME 		DEFAULT		NULL,
	ciud_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbCiudades_ciud_Id	PRIMARY KEY (ciud_Id),
	CONSTRAINT FK_Gral_tbCiudades_dept_Id_Gral_tbDepartamentos_dept_Id				FOREIGN KEY (dept_Id)	REFERENCES	Gral.tbDepartamentos (dept_Id),
	
	CONSTRAINT FK_Gral_tbCiudades_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbCiudades_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA CIUDADES -- -- -- -- 
CREATE TABLE Gral.tbSexos
(
	sexo_Id				INT		IDENTITY(1,1),
	sexo_Descripcion	NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	sexo_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	sexo_FechaModificacion		DATETIME 		DEFAULT		NULL,
	sexo_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbSexos_sexo_Id	PRIMARY KEY (sexo_Id),
	
	CONSTRAINT FK_Gral_tbSexos_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbSexos_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

-- --- -- TABLA CATEGORIA -- -- -- -- 
CREATE TABLE Gral.tbCategorias
(
	cate_Id						INT IDENTITY(1,1),
	cate_Descripcion			NVARCHAR(200),

	usua_UsuarioCreacion 		INT							NOT NULL,
	cate_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	cate_FechaModificacion		DATETIME 		DEFAULT		NULL,
	cate_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbCategorias_cate_Id	PRIMARY KEY (cate_Id),
	
	CONSTRAINT FK_Gral_tbCategorias_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbCategorias_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

-- --- -- TABLA DATOS GENERALES -- -- -- -- 
CREATE TABLE Gral.tbDatos_Generales
(
	dato_Id					INT IDENTITY (1,1),
	dato_NombreCompleto		NVARCHAR(500)		NOT NULL,
	dato_DNI				NVARCHAR(20)		NOT NULL,
	dato_Telefono			NVARCHAR(20)		NOT NULL,
	dato_email				NVARCHAR(150)		NOT NULL,
	ciud_Id					INT,
	dato_Direccion			NVARCHAR(500)		NOT NULL,
	dato_FechaNacimiento	DATE				NOT NULL,
	sexo_Id					INT,
	cate_Id					INT,

	usua_UsuarioCreacion 		INT							NOT NULL,
	dato_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	dato_FechaModificacion		DATETIME 		DEFAULT		NULL,
	dato_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Gral_tbDatos_Generales_dato_Id	PRIMARY KEY (dato_Id),
	CONSTRAINT FK_Gral_tbDatos_Generales_ciud_Id_Gral_tbCiudades_ciud_Id					FOREIGN KEY (ciud_Id)					REFERENCES Gral.tbCiudades (ciud_Id),
	CONSTRAINT FK_Gral_tbDatos_Generales_sexo_Id_Gral_tbSexos_sexo_Id						FOREIGN KEY (sexo_Id)					REFERENCES Gral.tbSexos (sexo_Id),
	CONSTRAINT FK_Gral_tbDatos_Generales_cate_Id_Gral_tbCategorias_cate_Id					FOREIGN KEY (cate_Id)					REFERENCES Gral.tbCategorias (cate_Id),
	
	CONSTRAINT FK_Gral_tbDatos_Generales_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbDatos_Generales_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

--**********************************************************--
--**************** SCHEMA PELI **************************--
--**********************************************************--
-- --- -- TABLA GENEROS -- -- -- -- 
CREATE TABLE Peli.tbGeneros
(
	gene_Id						INT IDENTITY (1,1),
	gene_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	gene_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	gene_FechaModificacion		DATETIME 		DEFAULT		NULL,
	gene_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbGeneros_gene_Id		PRIMARY KEY (gene_Id),

	CONSTRAINT FK_Peli_tbGeneros_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbGeneros_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA FORMATOS -- -- -- -- 
CREATE TABLE Peli.tbFormatos
(
	form_Id						INT IDENTITY (1,1),
	form_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	form_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	form_FechaModificacion		DATETIME 		DEFAULT		NULL,
	form_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbFormatos_form_Id	PRIMARY KEY (form_Id),

	CONSTRAINT FK_Peli_tbFormatos_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbFormatos_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA TIPO DE TRANSACCION -- -- -- -- 
CREATE TABLE Peli.tbTipoTransaccion
(
	tran_Id						INT IDENTITY (1,1),
	tran_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	tran_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	tran_FechaModificacion		DATETIME 		DEFAULT		NULL,
	tran_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbTipoTransaccion_tran_Id	PRIMARY KEY (tran_Id),

	CONSTRAINT FK_Peli_tbTipoTransaccion_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbTipoTransaccion_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA ESTADOS -- -- -- -- 
CREATE TABLE Peli.tbEstados
(
	esta_Id						INT IDENTITY (1,1),
	esta_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	esta_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	esta_FechaModificacion		DATETIME 		DEFAULT		NULL,
	esta_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbEstados_esta_Id	PRIMARY KEY (esta_Id),

	CONSTRAINT FK_Peli_tbEstados_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbEstados_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA CLASIFICACIÓN -- -- -- -- 
CREATE TABLE Peli.tbClasificaciones
(
	clas_Id						INT IDENTITY (1,1),
	clas_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	clas_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	clas_FechaModificacion		DATETIME 		DEFAULT		NULL,
	clas_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbClasificaciones_clas_Id	PRIMARY KEY (clas_Id),

	CONSTRAINT FK_Peli_tbClasificaciones_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbClasificaciones_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA IDIOMAS -- -- -- -- 
CREATE TABLE Peli.tbIdiomas
(
	idio_Id						INT IDENTITY (1,1),
	idio_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	idio_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	idio_FechaModificacion		DATETIME 		DEFAULT		NULL,
	idio_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbIdiomas_idio_Id	PRIMARY KEY (idio_Id),

	CONSTRAINT FK_Peli_tbIdiomas_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbIdiomas_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA IDIOMAS -- -- -- -- 
CREATE TABLE Peli.tbMetodosPago
(
	meto_Id						INT IDENTITY (1,1),
	meto_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	meto_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	meto_FechaModificacion		DATETIME 		DEFAULT		NULL,
	meto_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbMetodosPago_meto_Id	PRIMARY KEY (meto_Id),

	CONSTRAINT FK_Peli_tbMetodosPago_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbMetodosPago_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO
-- --- -- TABLA IVENTARO -- -- -- -- 
CREATE TABLE Peli.tbInventario
(
	inve_Id						INT IDENTITY (1,1),
	inve_Titulo					NVARCHAR(100),
	inve_Anio					VARCHAR(5),
	gene_Id						INT,
	inve_Duracion				INT,
	form_Id						INT,
	esta_Id						INT,
	inve_Descripcion			NVARCHAR(MAX),
	idio_Id						INT,
	inve_Cantidad				INT,
	inve_Precio					DECIMAL(18,2),
	clas_Id						INT,

	usua_UsuarioCreacion 		INT							NOT NULL,
	inve_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	inve_FechaModificacion		DATETIME 		DEFAULT		NULL,
	inve_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbInventario_inve_Id	PRIMARY KEY (inve_Id),
	
	CONSTRAINT FK_Peli_tbInventario_gene_Id_Peli_tbGeneros_gene_Id				FOREIGN KEY (gene_Id)			REFERENCES Peli.tbGeneros (gene_Id),
	CONSTRAINT FK_Peli_tbInventario_form_Id_Peli_tbFormatos_form_Id				FOREIGN KEY (form_Id)			REFERENCES Peli.tbFormatos (form_Id),
	CONSTRAINT FK_Peli_tbInventario_esta_Id_Peli_tbEstados_esta_Id				FOREIGN KEY (esta_Id)			REFERENCES Peli.tbEstados (esta_Id),
	CONSTRAINT FK_Peli_tbInventario_idio_Id_Peli_tbIdiomas_idio_Id				FOREIGN KEY (idio_Id)			REFERENCES Peli.tbIdiomas (idio_Id),
	CONSTRAINT FK_Peli_tbInventario_clas_Id_Peli_tbClasificaciones_clas_Id		FOREIGN KEY (clas_Id)			REFERENCES Peli.tbClasificaciones (clas_Id),

	CONSTRAINT FK_Peli_tbInventario_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbInventario_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);

-- --- -- TABLA FACTURA -- -- -- -- 
CREATE TABLE Peli.tbFacturas
(
	fact_Id				INT IDENTITY(1,1),
	meto_Id				INT,
	dato_Id				INT,
	fact_NumFactura		NVARCHAR(100),
	fact_FechaFactura	DATETIME,
	tran_Id				INT,
	fact_Impuesto		DECIMAL(18,2),
	fact_Descuento		DECIMAL(18,2),
	fact_Subtotal		DECIMAL(18,2),
	inve_Id				INT,
	fact_fechaDev		DATETIME,
	fact_Total			DECIMAL(18,2),

	usua_UsuarioCreacion 		INT							NOT NULL,
	fact_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	fact_FechaModificacion		DATETIME 		DEFAULT		NULL,
	fact_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Peli_tbFacturas_fact_Id	PRIMARY KEY (fact_Id),
	
	CONSTRAINT FK_Peli_tbFacturas_meto_Id_Peli_tbMetodosPago_meto_Id			FOREIGN KEY (meto_Id)			REFERENCES Peli.tbMetodosPago (meto_Id),
	CONSTRAINT FK_Peli_tbFacturas_form_Id_Peli_tbDatos_Generales_dato_Id		FOREIGN KEY (dato_Id)			REFERENCES Gral.tbDatos_Generales (dato_Id),
	CONSTRAINT FK_Peli_tbFacturas_tran_Id_Peli_tbTipoTransaccion_tran_Id		FOREIGN KEY (tran_Id)			REFERENCES Peli.tbTipoTransaccion (tran_Id),
	CONSTRAINT FK_Peli_tbFacturas_inve_Id_Peli_tbInventario_inve_Id				FOREIGN KEY (inve_Id)			REFERENCES Peli.tbInventario (inve_Id),

	CONSTRAINT FK_Peli_tbFacturas_usua_UsuarioCreacion_Acce_tbUsuarioss_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Peli_tbFacturas_usua_UsuarioModificacion_Acce_tbUsuarioss_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);