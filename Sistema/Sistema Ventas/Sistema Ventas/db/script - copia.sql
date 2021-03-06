USE [master]
GO
/****** Object:  Database [DBSAV]    Script Date: 06/30/2012 00:42:43 ******/
CREATE DATABASE [DBSAV]  
go
USE DBSAV
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 06/30/2012 00:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[Razon_social] [nvarchar](70) NOT NULL,
	[Direccion] [nvarchar](70) NOT NULL,
	[Telefono] [nvarchar](13) NULL,
 CONSTRAINT [empresa_pk] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[NombreDepartamento] [nvarchar](30) NOT NULL,
	[NombreCapitalDep] [nvarchar](30) NOT NULL,
 CONSTRAINT [dep_pk] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [nomdep_uk] UNIQUE NONCLUSTERED 
(
	[NombreDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[NombreMarca] [nvarchar](90) NOT NULL,
	[RazonSocial] [nvarchar](90) NOT NULL,
	[Direccion] [nvarchar](90) NOT NULL,
	[RUC] [nvarchar](90) NULL,
	[Telefono1] [nvarchar](13) NULL,
	[Telefono2] [nvarchar](13) NULL,
	[Email] [nvarchar](90) NULL,
 CONSTRAINT [provEEDOR_pk] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [nommar_uk] UNIQUE NONCLUSTERED 
(
	[NombreMarca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [ruc_uk] UNIQUE NONCLUSTERED 
(
	[RUC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vivienda]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vivienda](
	[idVivienda] [int] IDENTITY(1,1) NOT NULL,
	[Superficie] [nvarchar](20) NOT NULL,
	[Telefono] [nvarchar](15) NULL,
	[Situacion] [nvarchar](30) NOT NULL,
	[Valuacion] [decimal](14, 2) NOT NULL,
	[NroTitulo] [nvarchar](30) NOT NULL,
 CONSTRAINT [vivienda_pk] PRIMARY KEY CLUSTERED 
(
	[idVivienda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [vivienda_uk] UNIQUE NONCLUSTERED 
(
	[NroTitulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[idVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](20) NOT NULL,
	[Modelo] [nvarchar](15) NULL,
	[NroTarjeta] [nvarchar](30) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Valuacion] [decimal](14, 2) NOT NULL,
 CONSTRAINT [vehiculo_pk] PRIMARY KEY CLUSTERED 
(
	[idVehiculo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [vehiculo_uk] UNIQUE NONCLUSTERED 
(
	[NroTarjeta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NomCategoria] [nvarchar](45) NOT NULL,
	[Descripcion] [nvarchar](200) NULL,
 constraint nomcat_uk unique(NomCategoria),
 CONSTRAINT [categoria_pk] PRIMARY KEY CLUSTERED 
 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aval]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aval](
	[IdAval] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [nvarchar](8) NOT NULL,
	[Nombres] [nvarchar](45) NOT NULL,
	[Apellidos] [nvarchar](45) NOT NULL,
	[Fec_nacimiento] [datetime] NULL,
	[Estado_civil] [nvarchar](15) NULL,
	[Direccion] [nvarchar](90) NULL,
	[Distrito] [nvarchar](90) NULL,
	[NroTitulo] [nvarchar](50) NULL,
 CONSTRAINT [aval_pk] PRIMARY KEY CLUSTERED 
(
	[IdAval] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] NOT NULL,
	[NombreProvincia] [nvarchar](30) NOT NULL,
	[NombreCapitalProv] [nvarchar](30) NOT NULL,
	[IdDepartamento] [int] NOT NULL,
 CONSTRAINT [prov_pk] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [nomprov_uk] UNIQUE NONCLUSTERED 
(
	[NombreProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Marca] [nvarchar](40) NOT NULL,
	[Modelo] [nvarchar](20) NOT NULL,
	[Precio] [real] NOT NULL,
	[Stock] [int] NOT NULL,
	[Estado] [nvarchar](90) NULL,
	constraint modelo_uk unique(Modelo),
 CONSTRAINT [producto_pk] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 06/30/2012 00:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[IdDistrito] [int] NOT NULL,
	[NombreDistrito] [nvarchar](80) NOT NULL,
	[IdProvincia] [int] NOT NULL,
 CONSTRAINT [dist_pk] PRIMARY KEY CLUSTERED 
(
	[IdDistrito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spS_BuscarDistrito]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_BuscarDistrito]
@nomdistri nvarchar(30)
as begin
SELECT     dbo.Distrito.NombreDistrito, dbo.Provincia.NombreProvincia, dbo.Departamento.NombreDepartamento
FROM         dbo.Provincia INNER JOIN
                      dbo.Distrito ON dbo.Provincia.IdProvincia = dbo.Distrito.IdProvincia INNER JOIN
                      dbo.Departamento ON dbo.Provincia.IdDepartamento = dbo.Departamento.IdDepartamento
WHERE NombreDistrito=@nomdistri
end
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [nvarchar](8) NOT NULL,
	[Tipo_persona] [nvarchar](15) NOT NULL,
	[Nombres] [nvarchar](45) NOT NULL,
	[Apellidos] [nvarchar](45) NOT NULL,
	[Razon_social] [nvarchar](70) NULL,
	[RUC] [nvarchar](11) NULL,
	[Fec_nacimiento] [datetime] NULL,
	[Estado_civil] [nvarchar](15) NULL,
	[Direccion] [nvarchar](90) NULL,
	[IdDistrito] [int] NOT NULL,
 CONSTRAINT [cliente_pk] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [nvarchar](8) NOT NULL,
	[Nombres] [nvarchar](45) NOT NULL,
	[Apellidos] [nvarchar](45) NOT NULL,
	[Fec_nacimiento] [datetime] NULL,
	[Estado_civil] [nchar](20) NULL,
	[Celular] [nchar](13) NULL,
	[Correo_electronico] [nvarchar](60) NULL,
	[Direccion] [nvarchar](90) NOT NULL,
	[IdDistrito] [int] NOT NULL,
 CONSTRAINT [empleado_pk] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Egresos]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egresos](
	[IdEgreso] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [real] NOT NULL,
	[Motivo] [nvarchar](45) NOT NULL,
 CONSTRAINT [egresos_pk] PRIMARY KEY CLUSTERED 
(
	[IdEgreso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contrato]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contrato](
	[IdContrato] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Fec_ini] [datetime] NULL,
	[Fec_fin] [datetime] NULL,
	[Nick] [nchar](8) NOT NULL,
	[Clave] [nchar](8) NOT NULL,
	[Cargo] [nvarchar](50) NOT NULL,
	[Turno] [nchar](20) NULL,
	[Estado] [nchar](15) NULL,
 CONSTRAINT [contrato_pk] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Tipo] [nvarchar](45) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [Movimiento_pk] PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LineaCredito]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineaCredito](
	[IdLinea_credito] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nrohijos] [int] NOT NULL,
	[TiempoResidencia] [nvarchar](20) NOT NULL,
	[Edad] [int] NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[TipoVivienda] [nvarchar](50) NOT NULL,
	[FormaVida] [nchar](20) NULL,
	[CentroTrabajo] [nvarchar](50) NOT NULL,
	[Profesion] [nvarchar](50) NOT NULL,
	[TiempoTrabajo] [int] NULL,
	[TipoTrabajo] [nvarchar](50) NULL,
	[DireccionTrabajo] [nvarchar](90) NOT NULL,
	[Urbanizacion] [nvarchar](50) NULL,
	[Ingresos] [real] NOT NULL,
	[TelefonoTrabajo] [nvarchar](13) NULL,
	[CME] [real] NOT NULL,
	[CMEdisponible] [real] NULL,
	[DistritoTrabajo] [nvarchar](80) NULL,
	[Estado] [nvarchar](50) NOT NULL,
	[IdVivienda] [int] NULL,
	[IdVehiculo] [int] NULL,
	[IdAval] [int] NULL,
 CONSTRAINT [linea_credito_pk] PRIMARY KEY CLUSTERED 
(
	[IdLinea_credito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Tipo_venta] [nvarchar](20) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nro_venta] [int] NOT NULL,
	[Estado] [nchar](20) NULL,
	[Pago_a_cuenta] [real] NULL,
	[Total] [decimal](6, 2) NULL,
 CONSTRAINT [venta_pk] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spS_TipoIngreso]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--create proc [dbo].[spS_TipoLogin]
--@nick nvarchar(12),
--@cla nvarchar(8)
--as begin
--select Cargo from Contrato where Nick=@nick and Clave=@cla
--end
--GO
--/****** Object:  StoredProcedure [dbo].[spS_TipoIngreso]    Script Date: 06/21/2012 08:06:59 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
create proc [dbo].[spS_TipoIngreso]
@nick varchar(15),
@cla varchar(8)
as begin
select cargo from Contrato where Nick=@nick and Clave=@cla
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarVenta_parte1]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListarVenta_parte1]
@nro_preven int
as begin
SELECT     clientes.IdCliente, dbo.Clientes.DNI, dbo.Clientes.Nombres+' '+dbo.Clientes.Apellidos as Cliente, dbo.Clientes.Direccion, dbo.Empleados.DNI AS 'Cod. Vendedor', dbo.Empleados.Nombres +' '+ 
                      dbo.Empleados.Apellidos AS Vendedor, dbo.Ventas.Tipo_venta,Ventas.pago_a_cuenta ,dbo.Ventas.Total
FROM         dbo.Ventas INNER JOIN
                      dbo.Empleados ON dbo.Ventas.IdEmpleado = dbo.Empleados.IdEmpleado INNER JOIN
                      dbo.Clientes ON dbo.Ventas.IdCliente = dbo.Clientes.IdCliente
where Nro_venta=@nro_preven
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarVendedores]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ListarVendedores]
as begin
SELECT     dbo.Empleados.IdEmpleado, dbo.Empleados.Nombres + ' ' + dbo.Empleados.Apellidos AS Vendedor
FROM         dbo.Contrato INNER JOIN
                      dbo.Empleados ON dbo.Contrato.IdEmpleado = dbo.Empleados.IdEmpleado
where Contrato.Cargo like 'Vendedor'
end
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[IdCaja] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[IdEmpleado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [real] NOT NULL,
	[Motivo] [nvarchar](45) NULL,
 CONSTRAINT [caja_pk] PRIMARY KEY CLUSTERED 
(
	[IdCaja] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarEstadoCuenta1]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListarEstadoCuenta1]
@dni nvarchar(8)
as begin
SELECT     dbo.Clientes.Nombres+' '+ dbo.Clientes.Apellidos as Cliente, dbo.Clientes.DNI, dbo.Clientes.Direccion, dbo.LineaCredito.CME, dbo.LineaCredito.CMEdisponible, 
                      dbo.Empleados.Nombres +' '+ dbo.Empleados.Apellidos AS Vendedor, dbo.Empleados.DNI as DNI_Vendedor 
                      
FROM         dbo.Clientes INNER JOIN
                      dbo.LineaCredito ON dbo.Clientes.IdCliente = dbo.LineaCredito.IdCliente INNER JOIN
                      dbo.Empleados ON dbo.LineaCredito.IdEmpleado = dbo.Empleados.IdEmpleado
where Clientes.dni = @dni                      
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarAlmaceneros]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListarAlmaceneros]
as begin
SELECT     dbo.Empleados.IdEmpleado, dbo.Empleados.Nombres + ' ' + dbo.Empleados.Apellidos AS Vendedor
FROM         dbo.Contrato INNER JOIN
                      dbo.Empleados ON dbo.Contrato.IdEmpleado = dbo.Empleados.IdEmpleado
where Contrato.Cargo like 'Almacen'+'%' or Contrato.Cargo like 'Administrador'+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListaEmpleadosContratados]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListaEmpleadosContratados]
@car nvarchar(40),
@est nvarchar(15),
@dni nvarchar(8)
as begin
SELECT     dbo.Contrato.IdContrato, dbo.Contrato.IdEmpleado, dbo.Empleados.DNI, dbo.Empleados.Nombres+' '+ dbo.Empleados.Apellidos as Empleado, dbo.Contrato.Fec_ini, 
                      dbo.Contrato.Fec_fin, dbo.Contrato.Nick, dbo.Contrato.Clave, dbo.Contrato.Cargo, dbo.Contrato.Turno, dbo.Contrato.Estado
FROM         dbo.Empleados INNER JOIN
                      dbo.Contrato ON dbo.Empleados.IdEmpleado = dbo.Contrato.IdEmpleado
where DNI like @dni+'%' and Cargo like @car + '%' and Estado like @est +'%'                    
end
GO
/****** Object:  StoredProcedure [dbo].[spS_Ingresar]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_Ingresar]
@nick varchar(15),
@cla varchar(8)
as begin
	declare @nro int
	set @nro=( select COUNT(*) from Contrato where Nick=@nick and Clave=@cla)
if(@nro>0)
select @nro as Nro 		
end
GO
/****** Object:  StoredProcedure [dbo].[spS_IdEmpleadoIngreso]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_IdEmpleadoIngreso]
@nick varchar(15),
@cla varchar(8)
as begin
select IdEmpleado from Contrato where Nick=@nick and Clave=@cla
end
GO
/****** Object:  StoredProcedure [dbo].[spS_BuscarPreventa]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_BuscarPreventa]
@nro_venta int
as begin
if( @nro_venta not in(select nro_venta from ventas))
select 0
end
GO
/****** Object:  StoredProcedure [dbo].[spS_CierreCaja2]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_CierreCaja2]
AS BEGIN
Select ISNULL( sum(Monto),0) as 'Total',Motivo from Egresos where CONVERT(date, Fecha,120) = CONVERT(date, GETDATE(),120) group by Motivo
END
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[NroSerie] [nchar](20) NOT NULL,
	[Venta_bruta] [decimal](8, 2) NOT NULL,
	[Descuento] [decimal](8, 2) NULL,
	[Valor_venta] [decimal](8, 2) NOT NULL,
	[IGV] [decimal](8, 2) NOT NULL,
	[Comision] [decimal](8, 2) NULL,
 CONSTRAINT [PK_DetalleVentas] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC,
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleMovimiento]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleMovimiento](
	[IdMovimiento] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[NroSerie] [nchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[IdPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[IdLinea_credito] [int] NOT NULL,
	[IdVenta] [int] NOT NULL,
	[Capital_prestado] [real] NOT NULL,
	[Fec_desembolso] [datetime] NOT NULL,
	[Plazo_nrocuotas] [int] NOT NULL,
	[TEA] [real] NOT NULL,
	[TEM] [real] NOT NULL,
	[Estado] [nchar](20) NULL,
 CONSTRAINT [prestamo_pk] PRIMARY KEY CLUSTERED 
(
	[IdPrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdPago] [int] IDENTITY(1,1) NOT NULL,
	[IdPrestamo] [int] NOT NULL,
	[Nro] [int] NOT NULL,
	[Fec_vencimiento] [datetime] NOT NULL,
	[Capital] [real] NOT NULL,
	[Interes] [real] NOT NULL,
	[Cuota] [real] NOT NULL,
	[Desgravamen] [real] NOT NULL,
	[ITF] [real] NOT NULL,
	[Total] [real] NOT NULL,
	[Debe] [real] NULL,
	[Fec_pago] [nvarchar](50) NULL,
 CONSTRAINT [pago_pk] PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spS_CierreCaja]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_CierreCaja]
AS BEGIN
Select sum(Monto) as 'TotalVenta',Motivo from Caja where CONVERT(date, Fecha,120) = CONVERT(date, GETDATE(),120) group by Motivo
END
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarPrestamos]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListarPrestamos]
@dni nvarchar(8)
as begin
SELECT     dbo.Prestamos.IdPrestamo, dbo.Prestamos.Capital_prestado, dbo.Prestamos.Fec_desembolso, dbo.Prestamos.Plazo_nrocuotas, dbo.Prestamos.Estado
FROM         dbo.Clientes INNER JOIN
                      dbo.Ventas ON dbo.Clientes.IdCliente = dbo.Ventas.IdCliente AND dbo.Clientes.IdCliente = dbo.Ventas.IdCliente INNER JOIN
                      dbo.Prestamos ON dbo.Ventas.IdVenta = dbo.Prestamos.IdVenta
where clientes.dni=@dni and Prestamos.Estado='Deuda'
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarVenta_parte2]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ListarVenta_parte2]
@id int
as begin
SELECT     dbo.Productos.Marca, dbo.Productos.Modelo, dbo.Productos.Precio, dbo.DetalleVentas.Cantidad, dbo.DetalleVentas.Descuento, dbo.DetalleVentas.IGV, 
                      dbo.DetalleVentas.Valor_venta
FROM         dbo.DetalleVentas INNER JOIN
                      dbo.Productos ON dbo.DetalleVentas.IdProducto = dbo.Productos.IdProducto INNER JOIN
                      dbo.Ventas ON dbo.DetalleVentas.IdVenta = dbo.Ventas.IdVenta
where DetalleVentas.IdVenta=@id            
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ObtenerIDPrestamo]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ObtenerIDPrestamo]
@nro_preven int
as begin
SELECT     dbo.Prestamos.IdPrestamo
FROM         dbo.Ventas INNER JOIN
                      dbo.Prestamos ON dbo.Ventas.IdVenta = dbo.Prestamos.IdVenta
where Ventas.Nro_venta=@nro_preven
end
GO
/****** Object:  StoredProcedure [dbo].[spS_Ventas_x_dia]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Ventas por tipo de venta por dia
create procedure [dbo].[spS_Ventas_x_dia]
@fec datetime,
@tipven nvarchar(20)
as begin
SELECT   dbo.Empleados.DNI, dbo.Empleados.Nombres+' '+ dbo.Empleados.Apellidos as Vendedor,sum(Ventas.IdVenta) as Cantidad,sum(dbo.DetalleVentas.Valor_venta)as 'Valor de ventas'
FROM         dbo.DetalleVentas INNER JOIN
                      dbo.Ventas ON dbo.DetalleVentas.IdVenta = dbo.Ventas.IdVenta INNER JOIN
                      dbo.Empleados ON dbo.Ventas.IdEmpleado = dbo.Empleados.IdEmpleado
where Fecha=@fec and Tipo_venta=@tipven
group by dbo.Empleados.DNI,dbo.Empleados.Nombres,dbo.Empleados.Apellidos
end
GO
/****** Object:  StoredProcedure [dbo].[spS_TotalVentaDiaria_x_vendedor]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Total venta diaria por tipo
create procedure [dbo].[spS_TotalVentaDiaria_x_vendedor]
@fec datetime,
@tipven nvarchar(20)

as begin
SELECT     sum(dbo.DetalleVentas.Valor_venta) as Total
FROM         dbo.Empleados INNER JOIN
                      dbo.Ventas ON dbo.Empleados.IdEmpleado = dbo.Ventas.IdEmpleado INNER JOIN
                      dbo.DetalleVentas ON dbo.Ventas.IdVenta = dbo.DetalleVentas.IdVenta
where Fecha=@fec and Tipo_venta=@tipven and Estado='Efectuado'
end
GO
/****** Object:  StoredProcedure [dbo].[spS_TotalVenta_x_vendedor]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Total venta en un rango de fechas
create procedure [dbo].[spS_TotalVenta_x_vendedor]
@fecini datetime,
@fecfin datetime
as begin
SELECT     sum(dbo.DetalleVentas.Valor_venta) as Total
FROM         dbo.Empleados INNER JOIN
                      dbo.Ventas ON dbo.Empleados.IdEmpleado = dbo.Ventas.IdEmpleado INNER JOIN
                      dbo.DetalleVentas ON dbo.Ventas.IdVenta = dbo.DetalleVentas.IdVenta
where Fecha>=@fecini and Fecha<=@fecfin and Estado='Efectuado'
end
GO
/****** Object:  StoredProcedure [dbo].[spS_SimuladorComision2]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spS_SimuladorComision2]
@dni nvarchar(8)
as begin
select ISNULL( sum(DetalleVentas.Comision),0) as TotalComision,ISNULL( SUM(DetalleVentas.Comision)/convert(decimal(8,2), DATEPART(DD,GETDATE()),101)*(DATEDIFF(DD,GETDATE(),DATEADD(MM,1,GETDATE()))),0) as Proyeccion 
FROM         dbo.DetalleVentas INNER JOIN
                      dbo.Ventas ON dbo.DetalleVentas.IdVenta = dbo.Ventas.IdVenta INNER JOIN
                      dbo.Empleados ON dbo.Ventas.IdEmpleado = dbo.Empleados.IdEmpleado
where Empleados. DNI=@dni and Estado='1'
end
GO
/****** Object:  StoredProcedure [dbo].[spS_SimuladorComision1]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spS_SimuladorComision1]
@dni nvarchar(8)
as begin
SELECT    top 1 dbo.Empleados.DNI, dbo.Empleados.Nombres+' '+dbo.Empleados.Apellidos as Vendedor,
			(select SUM( dbo.DetalleVentas.Comision) as comision where Ventas.IdVenta=(select MAX(Ventas.IdVenta))) as 'Ultima venta', Ventas.Tipo_venta,
			SUM(DetalleVentas.Descuento/100) as 'Descuento acumulado',Ventas.Fecha
FROM         dbo.DetalleVentas INNER JOIN
                      dbo.Ventas ON dbo.DetalleVentas.IdVenta = dbo.Ventas.IdVenta INNER JOIN
                      dbo.Empleados ON dbo.Ventas.IdEmpleado = dbo.Empleados.IdEmpleado

WHERE      DNI=@dni and Estado='1'

GROUP BY Empleados.DNI,Empleados.Nombres,Empleados.Apellidos,Ventas.Tipo_venta,DetalleVentas.Comision,Ventas.IdVenta,Ventas.Fecha                  
order by Fecha desc
end
GO
/****** Object:  StoredProcedure [dbo].[spS_SimuladorComision]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spS_SimuladorComision]
@dni nvarchar(8)
as begin
SELECT    top 1 dbo.Empleados.DNI, dbo.Empleados.Nombres+' '+dbo.Empleados.Apellidos as Vendedor, 
			(select SUM( dbo.DetalleVentas.Comision) as comision where Ventas.IdVenta=(select MAX(Ventas.IdVenta))) as 'Ultima venta',
			SUM(DetalleVentas.Descuento/100) as 'Descuento acumulado',Ventas.Fecha
FROM         dbo.DetalleVentas INNER JOIN
                      dbo.Ventas ON dbo.DetalleVentas.IdVenta = dbo.Ventas.IdVenta INNER JOIN
                      dbo.Empleados ON dbo.Ventas.IdEmpleado = dbo.Empleados.IdEmpleado

WHERE      DNI=@dni and Estado='1'

GROUP BY Empleados.DNI,Empleados.Nombres,Empleados.Apellidos,Ventas.Tipo_venta,DetalleVentas.Comision,Ventas.IdVenta,Ventas.Fecha                  
order by Fecha desc
end
GO
/****** Object:  StoredProcedure [dbo].[spS_RankingVendedores]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spS_RankingVendedores]
@fecini datetime,
@fecfin datetime
as
begin
SELECT   dbo.Empleados.DNI, dbo.Empleados.Nombres+' '+ dbo.Empleados.Apellidos as Vendedor,sum(dbo.DetalleVentas.Valor_venta)as 'Valor de ventas',count(dbo.Ventas.IdVenta) as Cantidad
FROM         dbo.Empleados INNER JOIN
                      dbo.Ventas ON dbo.Empleados.IdEmpleado = dbo.Ventas.IdEmpleado INNER JOIN
                      dbo.DetalleVentas ON dbo.Ventas.IdVenta = dbo.DetalleVentas.IdVenta
where Fecha>=@fecini and Fecha<=@fecfin and Estado='1'
group by dbo.Empleados.DNI,dbo.Empleados.Nombres,dbo.Empleados.Apellidos
order by 'Valor de ventas' desc
end
GO
/****** Object:  StoredProcedure [dbo].[spS_Obtenertem]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_Obtenertem]
@idpres int
as begin
SELECT     Prestamos.TEM
FROM         dbo.Prestamos INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
WHERE Prestamos.IdPrestamo=''                     
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ObtenerPlazo]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ObtenerPlazo]
@idpres int
as begin
SELECT     Prestamos.Plazo_nrocuotas
FROM         dbo.Prestamos INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
WHERE Prestamos.IdPrestamo=@idpres                      
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ObtenerCapital]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ObtenerCapital]
@idpres int
as begin
SELECT     dbo.Prestamos.Capital_prestado
FROM         dbo.Prestamos INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
WHERE Prestamos.IdPrestamo=@idpres                      
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarEstadoCuenta3]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_ListarEstadoCuenta3]
@id int
as begin
SELECT     dbo.Pagos.IdPago, dbo.Pagos.IdPrestamo, dbo.Pagos.Nro, dbo.Pagos.Fec_vencimiento, dbo.Pagos.Total, dbo.Pagos.Debe, dbo.Pagos.Fec_pago
FROM         dbo.Prestamos INNER JOIN
                      dbo.LineaCredito ON dbo.Prestamos.IdLinea_credito = dbo.LineaCredito.IdLinea_credito INNER JOIN
                      dbo.Clientes ON dbo.LineaCredito.IdCliente = dbo.Clientes.IdCliente INNER JOIN
                      dbo.Ventas ON dbo.Prestamos.IdVenta = dbo.Ventas.IdVenta AND dbo.Clientes.IdCliente = dbo.Ventas.IdCliente AND 
                      dbo.Clientes.IdCliente = dbo.Ventas.IdCliente INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
where Prestamos.IdPrestamo = @id 
end
GO
/****** Object:  StoredProcedure [dbo].[spS_ListarEstadoCuenta2]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spS_ListarEstadoCuenta2]
@id int
as begin
SELECT     dbo.Pagos.IdPago, dbo.Pagos.IdPrestamo, dbo.Pagos.Nro, dbo.Pagos.Fec_vencimiento, dbo.Pagos.Total, dbo.Pagos.Debe, dbo.Pagos.Fec_pago
FROM         dbo.Prestamos INNER JOIN
                      dbo.LineaCredito ON dbo.Prestamos.IdLinea_credito = dbo.LineaCredito.IdLinea_credito INNER JOIN
                      dbo.Clientes ON dbo.LineaCredito.IdCliente = dbo.Clientes.IdCliente INNER JOIN
                      dbo.Ventas ON dbo.Prestamos.IdVenta = dbo.Ventas.IdVenta AND dbo.Clientes.IdCliente = dbo.Ventas.IdCliente AND 
                      dbo.Clientes.IdCliente = dbo.Ventas.IdCliente INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
where Prestamos.IdPrestamo = @id and pagos.total=pagos.debe
end
GO
/****** Object:  StoredProcedure [dbo].[spS_EstadoCuenta]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Estado de cuenta
create procedure [dbo].[spS_EstadoCuenta]
@dni nvarchar(8)
as begin
SELECT     dbo.Pagos.Nro, dbo.Pagos.Cuota, dbo.Pagos.Fec_vencimiento, dbo.Pagos.Debe, dbo.Pagos.Fec_pago, dbo.Pagos.Total
FROM         dbo.Clientes INNER JOIN
           dbo.LineaCredito ON dbo.Clientes.IdCliente = dbo.LineaCredito.IdCliente INNER JOIN
           dbo.Prestamos ON dbo.LineaCredito.IDLinea_credito = dbo.Prestamos.IDLinea_credito INNER JOIN
           dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
WHERE     DNI=@dni
end
GO
/****** Object:  StoredProcedure [dbo].[spS_BuscarIdPrestamo]    Script Date: 06/30/2012 00:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spS_BuscarIdPrestamo]
@dni nvarchar(15)
as begin


SELECT    top 1 dbo.Prestamos.IdPrestamo
FROM         dbo.Prestamos INNER JOIN
                      dbo.Ventas ON dbo.Prestamos.IdVenta = dbo.Ventas.IdVenta INNER JOIN
                      dbo.Clientes ON dbo.Ventas.IdCliente = dbo.Clientes.IdCliente INNER JOIN
                      dbo.Pagos ON dbo.Prestamos.IdPrestamo = dbo.Pagos.IdPrestamo
                      where Clientes.DNI=@dni
end
GO
---------------------------------------------------------------------
create proc spS_FiltrarIdDepartamento
@id int
as begin
SELECT     dbo.Departamento.IdDepartamento
FROM         dbo.Distrito INNER JOIN
                      dbo.Provincia ON dbo.Distrito.IdProvincia = dbo.Provincia.IdProvincia INNER JOIN
                      dbo.Departamento ON dbo.Provincia.IdDepartamento = dbo.Departamento.IdDepartamento
                      where IdDistrito=@id
end
go
--------------------------------------------------------------
create proc spS_FiltrarIdProvincia
@id int
as begin
SELECT     dbo.Provincia.IdProvincia
FROM         dbo.Distrito INNER JOIN
                      dbo.Provincia ON dbo.Distrito.IdProvincia = dbo.Provincia.IdProvincia
                      where IdDistrito=@id
end
go
/****** Object:  ForeignKey [prov_fk]    Script Date: 06/30/2012 00:42:45 ******/
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [prov_fk] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamento] ([IdDepartamento])
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [prov_fk]
GO
/****** Object:  ForeignKey [categoria_fk]    Script Date: 06/30/2012 00:42:45 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [categoria_fk] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [categoria_fk]
GO
/****** Object:  ForeignKey [dist_fk]    Script Date: 06/30/2012 00:42:45 ******/
ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [dist_fk] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
GO
ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [dist_fk]
GO
/****** Object:  ForeignKey [distrito_cliente_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [distrito_cliente_fk] FOREIGN KEY([IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDistrito])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [distrito_cliente_fk]
GO
/****** Object:  ForeignKey [distrito_empleado_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [distrito_empleado_fk] FOREIGN KEY([IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDistrito])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [distrito_empleado_fk]
GO
/****** Object:  ForeignKey [empleado_egresos_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Egresos]  WITH CHECK ADD  CONSTRAINT [empleado_egresos_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Egresos] CHECK CONSTRAINT [empleado_egresos_fk]
GO
/****** Object:  ForeignKey [empleado_contrato_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [empleado_contrato_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [empleado_contrato_fk]
GO
/****** Object:  ForeignKey [empleado_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [empleado_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [empleado_fk]
GO
/****** Object:  ForeignKey [cliente_linea_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[LineaCredito]  WITH CHECK ADD  CONSTRAINT [cliente_linea_fk] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[LineaCredito] CHECK CONSTRAINT [cliente_linea_fk]
GO
/****** Object:  ForeignKey [empleado_lineacredito_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[LineaCredito]  WITH CHECK ADD  CONSTRAINT [empleado_lineacredito_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[LineaCredito] CHECK CONSTRAINT [empleado_lineacredito_fk]
GO
/****** Object:  ForeignKey [FK_LineaCredito_Aval]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[LineaCredito]  WITH CHECK ADD  CONSTRAINT [FK_LineaCredito_Aval] FOREIGN KEY([IdAval])
REFERENCES [dbo].[Aval] ([IdAval])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LineaCredito] CHECK CONSTRAINT [FK_LineaCredito_Aval]
GO
/****** Object:  ForeignKey [FK_LineaCredito_Vehiculo]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[LineaCredito]  WITH CHECK ADD  CONSTRAINT [FK_LineaCredito_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([idVehiculo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LineaCredito] CHECK CONSTRAINT [FK_LineaCredito_Vehiculo]
GO
/****** Object:  ForeignKey [FK_LineaCredito_Vivienda]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[LineaCredito]  WITH CHECK ADD  CONSTRAINT [FK_LineaCredito_Vivienda] FOREIGN KEY([IdVivienda])
REFERENCES [dbo].[Vivienda] ([idVivienda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LineaCredito] CHECK CONSTRAINT [FK_LineaCredito_Vivienda]
GO
/****** Object:  ForeignKey [cliente_venta_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [cliente_venta_fk] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [cliente_venta_fk]
GO
/****** Object:  ForeignKey [empleado_venta_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [empleado_venta_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [empleado_venta_fk]
GO
/****** Object:  ForeignKey [empresa_venta_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [empresa_venta_fk] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [empresa_venta_fk]
GO
/****** Object:  ForeignKey [empleado_caja_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [empleado_caja_fk] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [empleado_caja_fk]
GO
/****** Object:  ForeignKey [venta_caja_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [venta_caja_fk] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [venta_caja_fk]
GO
/****** Object:  ForeignKey [producto_detalleventa_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [producto_detalleventa_fk] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [producto_detalleventa_fk]
GO
/****** Object:  ForeignKey [venta_detalle_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [venta_detalle_fk] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [venta_detalle_fk]
GO
/****** Object:  ForeignKey [movimiento_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[DetalleMovimiento]  WITH CHECK ADD  CONSTRAINT [movimiento_fk] FOREIGN KEY([IdMovimiento])
REFERENCES [dbo].[Movimiento] ([IdMovimiento])
GO
ALTER TABLE [dbo].[DetalleMovimiento] CHECK CONSTRAINT [movimiento_fk]
GO
/****** Object:  ForeignKey [producto_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[DetalleMovimiento]  WITH CHECK ADD  CONSTRAINT [producto_fk] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleMovimiento] CHECK CONSTRAINT [producto_fk]
GO
/****** Object:  ForeignKey [linea_credito_prestamo_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [linea_credito_prestamo_fk] FOREIGN KEY([IdLinea_credito])
REFERENCES [dbo].[LineaCredito] ([IdLinea_credito])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [linea_credito_prestamo_fk]
GO
/****** Object:  ForeignKey [venta_prestamo_fk]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [venta_prestamo_fk] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Ventas] ([IdVenta])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [venta_prestamo_fk]
GO
/****** Object:  ForeignKey [FK_Pagos_Prestamos]    Script Date: 06/30/2012 00:42:46 ******/
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Prestamos] FOREIGN KEY([IdPrestamo])
REFERENCES [dbo].[Prestamos] ([IdPrestamo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Prestamos]
GO
--Insertar registros

--Departamentos
insert into DEPARTAMENTO values('AMAZONAS','CHACHAPOYAS')
insert into DEPARTAMENTO values('ANCASH','HUARAZ')
insert into DEPARTAMENTO values('APURIMAC','ABANCAY')
insert into DEPARTAMENTO values('AREQUIPA','AREQUIPA')
insert into DEPARTAMENTO values('AYACUCHO','AYACUCHO')
insert into DEPARTAMENTO values('CAJAMARCA','CAJAMARCA')
insert into DEPARTAMENTO values('CUZCO','CUZCO')
insert into DEPARTAMENTO values('HUANCAVELICA','HUANCAVELICA')
insert into DEPARTAMENTO values('HUANUCO','HUANUCO')
insert into DEPARTAMENTO values('ICA','ICA')
insert into DEPARTAMENTO values('JUNIN','HUANCAYO')
insert into DEPARTAMENTO values('LAMBAYEQUE','LAMBAYEQUE')
insert into DEPARTAMENTO values('LA LIBERTAD','TRUJILLO')
insert into DEPARTAMENTO values('LIMA','LIMA')
insert into DEPARTAMENTO values('LORETO','IQUITOS')
insert into DEPARTAMENTO values('MADRE DE DIOS','PUERTO MALDONADO')
insert into DEPARTAMENTO values('MOQUEGUA','MOQUEGUA')
insert into DEPARTAMENTO values('PASCO','CERRO DE PASCO')
insert into DEPARTAMENTO values('PIURA','PIURA')
insert into DEPARTAMENTO values('PUNO','PUNO')
insert into DEPARTAMENTO values('SAN MARTIN','MOYOBAMBA')
insert into DEPARTAMENTO values('TACNA','TACNA')
insert into DEPARTAMENTO values('TUMBES','TUMBES')
insert into DEPARTAMENTO values('UCAYALI','PUCALLPA')

--Provincias de AMAZONAS
insert into PROVINCIA values (101,'BAGUA','BAGUA',1)
insert into PROVINCIA values (102,'BONGARA','JUMBILLA',1)
insert into PROVINCIA values (103,'CHACHAPOYAS','CHACHAPOYAS',1)
insert into PROVINCIA values (104,'CONDORCANQUI','SANTA MARIA DE NIEVA',1)
insert into PROVINCIA values (105,'LUYA','LAMUD',1)
insert into PROVINCIA values (106,'RODRIGUEZ DE MENDOZA','MENDOZA',1)
insert into PROVINCIA values (107,'UTCUBAMBA','BAGUA GRANDE',1)

--Provincias de ANCASH
insert into PROVINCIA values(201,'AIJA','AIJA',2)
insert into PROVINCIA values(202,'ANTONIO RAYMONDI','LLAMELLIN',2)
insert into PROVINCIA values(203,'ASUNCION','CHACAS',2)
insert into PROVINCIA values(204,'BOLOGNESI','CHIQUIAN',2)
insert into PROVINCIA values(205,'CARHUAZ','CARHUAZ',2)
insert into PROVINCIA values(206,'CARLOS FERMIN FITZCARRALD','SAN LUIS',2)
insert into PROVINCIA values(207,'CASMA','CASMA',2)
insert into PROVINCIA values(208,'CORONGO','CORONGO',2)
insert into PROVINCIA values(209,'HUARAZ','HUARAZ',2)
insert into PROVINCIA values(210,'HUARI','HUARI',2)
insert into PROVINCIA values(211,'HUARMEY','HUARMEY',2)
insert into PROVINCIA values(212,'HUAYLAS','CARAZ',2)
insert into PROVINCIA values(213,'MARISCAL LUZURIAGA','PISCOBAMBA',2)
insert into PROVINCIA values(214,'OCROS','OCROS',2)
insert into PROVINCIA values(215,'PALLASCA','CABANA',2)
insert into PROVINCIA values(216,'POMABAMBA','POMABAMBA',2)
insert into PROVINCIA values(217,'RECUAY','RECUAY',2)
insert into PROVINCIA values(218,'SANTA','CHIMBOTE',2)
insert into PROVINCIA values(219,'SIHUAS','SIHUAS',2)
insert into PROVINCIA values(220,'YUNGAY','YUNGAY',2)

--Provincias de APURIMAC
insert into PROVINCIA values (301,'ABANCAY','ABANCAY',3)
insert into PROVINCIA values (302,'ANDAHUAYLAS','ANDAHUAYLAS',3)
insert into PROVINCIA values (303,'ANTABAMBA','ANTABAMBA',3)
insert into PROVINCIA values (304,'AYMARAES','CHALHUANCA',3)
insert into PROVINCIA values (305,'CHINCHEROS','CHINCHEROS',3)
insert into PROVINCIA values (306,'COTABAMBAS','TAMBOBAMBA',3)
insert into PROVINCIA values (307,'GRAU','CHUQUIBAMBILLA',3)

--Provincias de AREQUIPA
insert into PROVINCIA values(401,'AREQUIPA','AREQUIPA',4)
insert into PROVINCIA values(402,'CAMANA','CAMANA',4)
insert into PROVINCIA values(403,'CARAVELI','CARAVELI',4)
insert into PROVINCIA values(404,'CASTILLA','APLAO',4)
insert into PROVINCIA values(405,'CAYLLOMA','CHIVAY',4)
insert into PROVINCIA values(406,'CONDESUYOS','CHUQUIBAMBA',4)
insert into PROVINCIA values(407,'ISLAY','MOLLENDO',4)
insert into PROVINCIA values(408,'LA UNION','COTAHUASI',4)

--Provincias de AYACUCHO
insert into PROVINCIA values(501,'CANGALLO','CANGALLO',5)
insert into PROVINCIA values(502,'HUAMANGA','AYACUCHO',5)
insert into PROVINCIA values(503,'HUANCASANCOS','HUANCA SANCOS',5)
insert into PROVINCIA values(504,'HUANTA','HUANTA',5)
insert into PROVINCIA values(505,'LA MAR','SAN MIGUEL',5)
insert into PROVINCIA values(506,'LUCANAS','PUQUIO',5)
insert into PROVINCIA values(507,'PARINACOCHAS','CORACORA',5)
insert into PROVINCIA values(508,'PAUCAR DEL SARA-SARA','PAUSA',5)
insert into PROVINCIA values(509,'SUCRE','QUEROBAMBA',5)
insert into PROVINCIA values(510,'VICTOR FAJARDO','HUANCAPI',5)
insert into PROVINCIA values(511,'VILCASHUAMAN','VILCAS HUAMAN',5)

--Provincias de CAJAMARCA
insert into PROVINCIA values(601,'CAJABAMBA','CAJABAMBA',6)
insert into PROVINCIA values(602,'CAJAMARCA','CAJAMARCA',6)
insert into PROVINCIA values(603,'CELENDIN','CELENDIN',6)
insert into PROVINCIA values(604,'CHOTA','CHOTA',6)
insert into PROVINCIA values(605,'CONTUMAZA','CONTUMAZA',6)
insert into PROVINCIA values(606,'CUTERVO','CUTERVO',6)
insert into PROVINCIA values(607,'HUALGAYOC','BAMBAMARCA',6)
insert into PROVINCIA values(608,'JAEN','JAEN',6)
insert into PROVINCIA values(609,'SAN IGNACIO','SAN IGNACIO',6)
insert into PROVINCIA values(610,'SAN MARCOS','SAN MARCOS',6)
insert into PROVINCIA values(611,'SAN MIGUEL','SAN MIGUEL DE PALLAQUES',6)
insert into PROVINCIA values(612,'SAN PABLO','SAN PABLO',6)
insert into PROVINCIA values(613,'SANTA CRUZ','SANTA CRUZ DE SUCHUBAMBA',6)

--Provincias de CUZCO
insert into PROVINCIA values(701,'ACOMAYO','ACOMAYO',7)
insert into PROVINCIA values(702,'ANTA','ANTA',7)
insert into PROVINCIA values(703,'CALCA','CALCA',7)
insert into PROVINCIA values(704,'CANAS','YANAOCA',7)
insert into PROVINCIA values(705,'CANCHIS','SICUANI',7)
insert into PROVINCIA values(706,'CHUMBIVILCAS','SANTO TOMAS',7)
insert into PROVINCIA values(707,'CUZCO','CUZCO',7)
insert into PROVINCIA values(708,'ESPINAR','YAURI',7)
insert into PROVINCIA values(709,'LA CONVENCION','QUILLABAMBA',7)
insert into PROVINCIA values(710,'PARURO','PARURO',7)
insert into PROVINCIA values(711,'PAUCARTAMBO','PAUCARTAMBO',7)
insert into PROVINCIA values(712,'QUISPICANCHI','URCOS',7)
insert into PROVINCIA values(713,'URUBAMBA','URUBAMBA',7)

--Provincias de HUANCAVELICA
insert into PROVINCIA values(801,'ACOBAMBA','ACOBAMBA',8)
insert into PROVINCIA values(802,'ANGARAES','LIRCAY',8)
insert into PROVINCIA values(803,'CASTROVIRREYNA','CASTROVIRREYNA',8)
insert into PROVINCIA values(804,'CHURCAMPA','CHURCAMPA',8)
insert into PROVINCIA values(805,'HUANCAVELICA','HUANCAVELICA',8)
insert into PROVINCIA values(806,'HUAYTARA','HUAYTARA',8)
insert into PROVINCIA values(807,'TAYACAJA','PAMPAS',8)

--Provincias de HUANUCO
insert into PROVINCIA values(901,'AMBO','AMBO',9)
insert into PROVINCIA values(902,'DOS DE MAYO','LA UNION',9)
insert into PROVINCIA values(903,'HUACAYBAMBA','HUACAYBAMBA',9)
insert into PROVINCIA values(904,'HUAMALIES','LLATA',9)
insert into PROVINCIA values(905,'HUANUCO','HUANUCO',9)
insert into PROVINCIA values(906,'LAURICOCHA','JESUS',9)
insert into PROVINCIA values(907,'LEONCIO PRADO','TINGO MARIA',9)
insert into PROVINCIA values(908,'MARAÑON','HUACRACHUCO',9)
insert into PROVINCIA values(909,'PACHITEA','PANAO',9)
insert into PROVINCIA values(910,'PUERTO INCA','PUERTO INCA',9)
insert into PROVINCIA values(911,'YAROWILCA','CHAVINILLO',9)


--Provincias de ICA--
insert into PROVINCIA values(1001,'CHINCHA','CHINCHA ALTA',10)
insert into PROVINCIA values(1002,'ICA','ICA',10)
insert into PROVINCIA values(1003,'NAZCA','NAZCA',10)
insert into PROVINCIA values(1004,'PALPA','PALPA',10)
insert into PROVINCIA values(1005,'PISCO','PISCO',10)

--Provincias de JUNIN
insert into PROVINCIA values(1101,'CHANCHAMAYO','LA MERCED',11)
insert into PROVINCIA values(1102,'CHUPACA','CHUPACA',11)
insert into PROVINCIA values(1103,'CONCEPCION','CONCEPCION',11)
insert into PROVINCIA values(1104,'HUANCAYO','HUANCAYO',11)
insert into PROVINCIA values(1105,'JAUJA','JAUJA',11)
insert into PROVINCIA values(1106,'JUNIN','JUNIN',11)
insert into PROVINCIA values(1107,'SATIPO','SATIPO',11)
insert into PROVINCIA values(1108,'TARMA','TARMA',11)
insert into PROVINCIA values(1109,'YAULI','LA OROYA',11)

--Provincias de LAMBAYEQUE
insert into PROVINCIA values(1201,'CHICLAYO','CHICLAYO',12)
insert into PROVINCIA values(1202,'FERREÑAFE','FERREÑAFE',12)
insert into PROVINCIA values(1203,'LAMBAYEQUE','LAMBAYEQUE',12)

--Provincias de LA LIBERTAD
insert into PROVINCIA values(1301,'ASCOPE','ASCOPE',13)
insert into PROVINCIA values(1302,'BOLIVAR','BOLIVAR',13)
insert into PROVINCIA values(1303,'CHEPEN','CHEPEN',13)
insert into PROVINCIA values(1304,'GRAN CHIMU','CASCAS',13)
insert into PROVINCIA values(1305,'JULCAN','JULCAN',13)
insert into PROVINCIA values(1306,'OTUZCO','OTUZCO',13)
insert into PROVINCIA values(1307,'PACASMAYO','SAN PEDRO DE LLOC',13)
insert into PROVINCIA values(1308,'PATAZ','TAYABAMBA',13)
insert into PROVINCIA values(1309,'SANCHEZ CARRION','HUAMACHUCO',13)
insert into PROVINCIA values(1310,'SANTIAGO DE CHUCO','SANTIAGO DE CHUCO',13)
insert into PROVINCIA values(1311,'TRUJILLO','TRUJILLO',13)
insert into PROVINCIA values(1312,'VIRU','VIRU',13)

--Provincias de LIMA
insert into PROVINCIA values (1401,'BARRANCA','BARRANCA',14)
insert into PROVINCIA values (1402,'CAJATAMBO','CAJATAMBO',14)
insert into PROVINCIA values (1403,'CANTA','CANTA',14)
insert into PROVINCIA values (1404,'CAÑETE','SAN VICENTE DE CAÑETE',14)
insert into PROVINCIA values (1405,'HUARAL','HUARAL',14)
insert into PROVINCIA values (1406,'HUAROCHIRI','MATUCANA',14)
insert into PROVINCIA values (1407,'HUAURA','HUACHO',14)
insert into PROVINCIA values (1408,'LIMA','LIMA',14)
insert into PROVINCIA values (1409,'OYON','OYON',14)
insert into PROVINCIA values (1410,'YAUYOS','YAUYOS',14)

--Provincias de LORETO
insert into PROVINCIA values(1501,'ALTO AMAZONAS','YURIMAGUAS',15)
insert into PROVINCIA values(1502,'LORETO','NAUTA',15)
insert into PROVINCIA values(1503,'MARISCAL RAMON CASTILLA','CABALLOCOCHA',15)
insert into PROVINCIA values(1504,'MAYNAS','IQUITOS',15)
insert into PROVINCIA values(1505,'REQUENA','REQUENA',15)
insert into PROVINCIA values(1506,'UCAYALI','CONTAMANA',15)

--Provincias de MADRE DE DIOS
insert into PROVINCIA values(1601,'MANU','SALVACION',16)
insert into PROVINCIA values(1602,'TAHUAMANU','IÑAPARI',16)
insert into PROVINCIA values(1603,'TAMBOPATA','PUERTO MALDONADO',16)

--Provincias de MOQUEGUA
insert into PROVINCIA values(1701,'GENERAL SANCHEZ CERRO','OMATE',17)
insert into PROVINCIA values(1702,'ILO','ILO',17)
insert into PROVINCIA values(1703,'MARISCAL NIETO','MOQUEGUA',17)

--Provincias de PASCO
insert into PROVINCIA values(1801,'DANIEL ALCIDES CARRION','YANAHUACA',18)
insert into PROVINCIA values(1802,'OXAPAMPA','OXAPAMPA',18)
insert into PROVINCIA values(1803,'PASCO','CERRO DE PASCO',18)

--Provincias de PIURA
insert into PROVINCIA values(1901,'AYABACA','AYABACA',19)
insert into PROVINCIA values(1902,'HUANCABAMBA','HUANCABAMBA',19)
insert into PROVINCIA values(1903,'MORROPON','CHULUCANAS',19)
insert into PROVINCIA values(1904,'PAITA','PAITA',19)
insert into PROVINCIA values(1905,'PIURA','PIURA',19)
insert into PROVINCIA values(1906,'SECHURA','SECHURA',19)
insert into PROVINCIA values(1907,'SULLANA','SULLANA',19)
insert into PROVINCIA values(1908,'TALARA','TALARA',19)

--Provincias de PUNO
insert into PROVINCIA values(2001,'AZANGARO','AZANGARO',20)
insert into PROVINCIA values(2002,'CARABAYA','MACUSANI',20)
insert into PROVINCIA values(2003,'CHUCUITO','JULI',20)
insert into PROVINCIA values(2004,'EL COLLAO','ILAVE',20)
insert into PROVINCIA values(2005,'HUANCANE','HUANCANE',20)
insert into PROVINCIA values(2006,'LAMPA','LAMPA',20)
insert into PROVINCIA values(2007,'MELGAR','AYAVIRI',20)
insert into PROVINCIA values(2008,'MOHO','MOHO',20)
insert into PROVINCIA values(2009,'PUNO','PUNO',20)
insert into PROVINCIA values(2010,'SANDIA','SANDIA',20)
insert into PROVINCIA values(2011,'SAN ANTONIO DE PUTINA','PUTINA',20)
insert into PROVINCIA values(2012,'SAN ROMAN','JULIACA',20)
insert into PROVINCIA values(2013,'YUNGUYO','YUNGUYO',20)

--Provincias de SAN MARTIN
insert into PROVINCIA values(2101,'BELLAVISTA','BELLAVISTA',21)
insert into PROVINCIA values(2102,'EL DORADO','SAN JOSE DE SISA',21)
insert into PROVINCIA values(2103,'HUALLAGA','SAPOSOA',21)
insert into PROVINCIA values(2104,'LAMAS','LAMAS',21)
insert into PROVINCIA values(2105,'MARISCAL CACERES','JUANJI',21)
insert into PROVINCIA values(2106,'MOYOBAMBA','MOYOBAMBA',21)
insert into PROVINCIA values(2107,'PICOTA','PICOTA',21)
insert into PROVINCIA values(2108,'RIOJA','RIOJA',21)
insert into PROVINCIA values(2109,'SAN MARTIN','TARAPOTO',21)
insert into PROVINCIA values(2110,'TOCACHE','TOCACHE',21)

--Provincias de TACNA
insert into PROVINCIA values(2201,'CANDARAVE','CANDARAVE',22)
insert into PROVINCIA values(2202,'JORGE BASADRE','LOCUMBA',22)
insert into PROVINCIA values(2203,'TACNA','TACNA',22)
insert into PROVINCIA values(2204,'TARATA','TARATA',22)

--Provincias de TUMBES
insert into PROVINCIA values(2301,'CONTRALMIRANTE VILLAR','ZORRITOS',23)
insert into PROVINCIA values(2302,'TUMBES','TUMBES',23)
insert into PROVINCIA values(2303,'ZARUMILLA','ZARUMILLA',23)

--Provincias de UCAYALI
insert into PROVINCIA values(2401,'ATALAYA','ATALAYA',24)
insert into PROVINCIA values(2402,'CORONEL PORTILLO','PUCALLPA',24)
insert into PROVINCIA values(2403,'PADRE ABAD','AGUAYTIA',24)
insert into PROVINCIA values(2404,'PURUS','ESPERANZA',24)

---DEPARTAMENTO AMAZONAS:*/
--Distritos de BAGUA
insert into DISTRITO values (10101,'ARAMANGO',101)
insert into DISTRITO values (10102,'COPALLIN',101)
insert into DISTRITO values (10103,'EL PARCO',101)
insert into DISTRITO values (10104,'IMAZA',101)
insert into DISTRITO values (10105,'LA PECA',101)

--Distritos de BONGARA
insert into DISTRITO values (10201,'CHISQUILLA',102)
insert into DISTRITO values (10202,'CHURUJA',102)
insert into DISTRITO values (10203,'COROSHA',102)
insert into DISTRITO values (10204,'CUISPES',102)
insert into DISTRITO values (10205,'FLORIDA',102)
insert into DISTRITO values (10206,'JAZAN',102)
insert into DISTRITO values (10207,'JUMBILLA',102)
insert into DISTRITO values (10208,'RECTA',102)
insert into DISTRITO values (10209,'SAN CARLOS',102)
insert into DISTRITO values (10210,'SHIPASBAMBA',102)
insert into DISTRITO values (10211,'VALERA',102)
insert into DISTRITO values (10212,'YAMBRASBAMBA',102)

--Distritos de CHACHAPOYAS
insert into DISTRITO values (10301,'ASUNCION',103)
insert into DISTRITO values (10302,'BALSAS',103)
insert into DISTRITO values (10303,'CHACHAPOYAS',103)
insert into DISTRITO values (10304,'CHETO',103)
insert into DISTRITO values (10305,'CHILIQUIN',103)
insert into DISTRITO values (10306,'CHUQUIBAMBA',103)
insert into DISTRITO values (10307,'GRANADA',103)
insert into DISTRITO values (10308,'HUANCAS',103)
insert into DISTRITO values (10309,'LA JALCA',103)
insert into DISTRITO values (10310,'LEIMEBAMBA',103)
insert into DISTRITO values (10311,'LEVANTO',103)
insert into DISTRITO values (10312,'MAGDALENA',103)
insert into DISTRITO values (10313,'MARISCAL CASTILLA',103)
insert into DISTRITO values (10314,'MOLINOPAMPA',103)
insert into DISTRITO values (10315,'MONTEVIDEO',103)
insert into DISTRITO values (10316,'OLLEROS',103)
insert into DISTRITO values (10317,'QUINJALCA',103)
insert into DISTRITO values (10318,'SAN FRANCISCO DE DAGUAS',103)
insert into DISTRITO values (10319,'SAN ISIDRO DE MAINO',103)
insert into DISTRITO values (10320,'SOLOCO',103)
insert into DISTRITO values (10321,'SONCHE',103)

--Distritos de CONDORCANQUI
insert into DISTRITO values (10401,'EL CENEPA',104)
insert into DISTRITO values (10402,'NIEVA',104)
insert into DISTRITO values (10403,'RIO SANTIAGO',104)

--Distritos de LUYA
insert into DISTRITO values (10501,'CAMPORREDONDO',105)
insert into DISTRITO values (10502,'COCABAMBA',105)
insert into DISTRITO values (10503,'COLCAMAR',105)
insert into DISTRITO values (10504,'CONILLA',105)
insert into DISTRITO values (10505,'INGUILPATA',105)
insert into DISTRITO values (10506,'LAMUD',105)
insert into DISTRITO values (10507,'LONGUITA',105)
insert into DISTRITO values (10508,'LONYA CHICO',105)
insert into DISTRITO values (10509,'LUYA',105)
insert into DISTRITO values (10510,'LUYA VIEJO',105)
insert into DISTRITO values (10511,'MARIA',105)
insert into DISTRITO values (10512,'OCALLI',105)
insert into DISTRITO values (10513,'OCUMAL',105)
insert into DISTRITO values (10514,'PISUQUIA',105)
insert into DISTRITO values (10515,'PROVIDENCIA',105)
insert into DISTRITO values (10516,'SAN CRISTOBAL*',105)
insert into DISTRITO values (10517,'SAN FRANCISCO DEL YESO',105)
insert into DISTRITO values (10518,'SAN JERONIMO',105)
insert into DISTRITO values (10519,'SANTA CATALINA',105)
insert into DISTRITO values (10520,'SANTO TOMAS',105)
insert into DISTRITO values (10521,'SAN JUAN DE LOPECANCHA',105)
insert into DISTRITO values (10522,'TINGO',105)
insert into DISTRITO values (10523,'TRITA',105)

--Distritos de RODRIGUEZ DE MENDOZA
insert into DISTRITO values (10601,'CHIRIMOTO',106)
insert into DISTRITO values (10602,'COCHAMAL',106)
insert into DISTRITO values (10603,'HUAMBO',106)
insert into DISTRITO values (10604,'LIMABAMBA',106)
insert into DISTRITO values (10605,'LONGAR',106)
insert into DISTRITO values (10606,'MARISCAL BENAVIDES',106)
insert into DISTRITO values (10607,'MILPUC',106)
insert into DISTRITO values (10608,'OMIA',106)
insert into DISTRITO values (10609,'SAN NICOLAS',106)
insert into DISTRITO values (10610,'SANTA ROSA',106)
insert into DISTRITO values (10611,'TOTORA',106)
insert into DISTRITO values (10612,'VISTA ALEGRE',106)

--Distritos de UTCUBAMBA
insert into DISTRITO values (10701,'BAGUA GRANDE',107)
insert into DISTRITO values (10702,'CAJARURO',107)
insert into DISTRITO values (10703,'CUMBA',107)
insert into DISTRITO values (10704,'EL MILAGRO',107)
insert into DISTRITO values (10705,'JAMALCA',107)
insert into DISTRITO values (10706,'LONYA GRANDE',107)
insert into DISTRITO values (10707,'YAMON',107)



---DEPARTAMENTO ANCASH*/
--Distritos de AIJA
insert into DISTRITO values (20101,'AIJA',201)
insert into DISTRITO values (20102,'CORIS',201)
insert into DISTRITO values (20103,'HUACLLAN',201)
insert into DISTRITO values (20104,'LA MERCED',201)
insert into DISTRITO values (20105,'SUCCHA',201)

--Distritos de ANTONIO RAIMONDI
insert into DISTRITO values (20201,'ACZO',202)
insert into DISTRITO values (20202,'CHACCHO',202)
insert into DISTRITO values (20203,'CHINGAS',202)
insert into DISTRITO values (20204,'LLAMELLIN',202)
insert into DISTRITO values (20205,'MIRGAS',202)
insert into DISTRITO values (20206,'SAN JUAN DE RONTOY',202)

--Distritos de ASUNCION
insert into DISTRITO values (20301,'ACOCHACA',203)
insert into DISTRITO values (20302,'CHACAS',203)

--Distritos de BOLOGNESI
insert into DISTRITO values (20401,'A. PARDO L.',204)
insert into DISTRITO values (20402,'A. RAIMONDI',204)
insert into DISTRITO values (20403,'AQUIA',204)
insert into DISTRITO values (20404,'CAJACAY',204)
insert into DISTRITO values (20405,'CANIS',204)
insert into DISTRITO values (20406,'CHIQUIAN',204)
insert into DISTRITO values (20407,'COLQUIOC',204)
insert into DISTRITO values (20408,'HUALLANCA',204)
insert into DISTRITO values (20409,'HUASTA',204)
insert into DISTRITO values (20410,'HUAYLLACAYAN',204)
insert into DISTRITO values (20411,'LA PRIMAVERA',204)
insert into DISTRITO values (20412,'MANGAS',204)
insert into DISTRITO values (20413,'PACLLON',204)
insert into DISTRITO values (20414,'SAN MIGUEL DE CORPANQUI',204)
insert into DISTRITO values (20415,'TICLLOS',204)

--Distritos de CARHUAZ
insert into DISTRITO values (20501,'ACOPAMPA',205)
insert into DISTRITO values (20502,'AMASCHCA',205)
insert into DISTRITO values (20503,'ANTA',205)
insert into DISTRITO values (20504,'ATAQUERO',205)
insert into DISTRITO values (20505,'CARHUAZ',205)
insert into DISTRITO values (20506,'MARCARA',205)
insert into DISTRITO values (20507,'PARIAHUANCA',205)
insert into DISTRITO values (20508,'SAN MIGUEL DE ACO',205)
insert into DISTRITO values (20509,'SHILLA',205)
insert into DISTRITO values (20510,'TINCO',205)
insert into DISTRITO values (20511,'YUNGAR',205)

--Distritos de CARLOS F.F
insert into DISTRITO values (20601,'SAN LUIS',206)
insert into DISTRITO values (20602,'SAN NICOLAS',206)
insert into DISTRITO values (20603,'YAUYA',206)

--Distritos de CASMA
insert into DISTRITO values (20701,'BUENA VISTA ALTA',207)
insert into DISTRITO values (20702,'CASMA',207)
insert into DISTRITO values (20703,'COMANDANTE NOEL',207)
insert into DISTRITO values (20704,'YAUTAN',207)

--Distritos de CORONGO
insert into DISTRITO values (20801,'ACO',208)
insert into DISTRITO values (20802,'BAMBAS',208)
insert into DISTRITO values (20803,'CORONGO',208)
insert into DISTRITO values (20804,'CUSCA',208)
insert into DISTRITO values (20805,'LA PAMPA',208)
insert into DISTRITO values (20806,'YANAC',208)
insert into DISTRITO values (20807,'YUPAN',208)

--Distritos de HUARAZ
insert into DISTRITO values (20901,'COCHABAMBA',209)
insert into DISTRITO values (20902,'COLCABAMBA',209)
insert into DISTRITO values (20903,'HUANCHAY',209)
insert into DISTRITO values (20904,'HUARAZ',209)
insert into DISTRITO values (20905,'INDEPENDENCIA',209)
insert into DISTRITO values (20906,'JANGAS',209)
insert into DISTRITO values (20907,'LA LIBERTAD',209)
insert into DISTRITO values (20908,'OLLEROS',209)
insert into DISTRITO values (20909,'PAMPAS',209)
insert into DISTRITO values (20910,'PARIACOTO',209)
insert into DISTRITO values (20911,'PIRA',209)
insert into DISTRITO values (20912,'TARICA',209)

--Distritos de HUARI
insert into DISTRITO values (21001,'ANRA',210)
insert into DISTRITO values (21002,'CAJAY',210)
insert into DISTRITO values (21003,'CHAVIN DE HUANTAR',210)
insert into DISTRITO values (21004,'HUACACHI',210)
insert into DISTRITO values (21005,'HUACCHIS',210)
insert into DISTRITO values (21006,'HUACHIS',210)
insert into DISTRITO values (21007,'HUANTAR',210)
insert into DISTRITO values (21008,'HUARI',210)
insert into DISTRITO values (21009,'MASIN',210)
insert into DISTRITO values (21010,'PAUCAS',210)
insert into DISTRITO values (21011,'PONTO',210)
insert into DISTRITO values (21012,'RAHUAPAMPA',210)
insert into DISTRITO values (21013,'RAPAYAN',210)
insert into DISTRITO values (21014,'SAN MARCOS',210)
insert into DISTRITO values (21015,'SAN PEDRO DE CHANA',210)
insert into DISTRITO values (21016,'UCO',210)

--Distritos de HUARMEY
insert into DISTRITO values (21101,'COCHAPETI',211)
insert into DISTRITO values (21102,'CULEBRAS',211)
insert into DISTRITO values (21103,'HUARMEY',211)
insert into DISTRITO values (21104,'HUAYAN',211)
insert into DISTRITO values (21105,'MALVAS',211)

--Distritos de HUAYLAS
insert into DISTRITO values (21201,'CARAZ',212)
insert into DISTRITO values (21202,'HUALLANCA',212)
insert into DISTRITO values (21203,'HUATA',212)
insert into DISTRITO values (21204,'HUAYLAS',212)
insert into DISTRITO values (21205,'MATO',212)
insert into DISTRITO values (21206,'PAMPAROMAS',212)
insert into DISTRITO values (21207,'PUEBLO LIBRE',212)
insert into DISTRITO values (21208,'SANTA CRUZ',212)
insert into DISTRITO values (21209,'SANTO TORIBIO',212)
insert into DISTRITO values (21210,'YURACMARCA',212)

--Distritos de MARISCAL LUZURIAGA
insert into DISTRITO values (21301,'CASCA',213)
insert into DISTRITO values (21302,'E. GUZMAN BARRON',213)
insert into DISTRITO values (21303,'F. OLIVAS ESCUDERO',213)
insert into DISTRITO values (21304,'LLAMA',213)
insert into DISTRITO values (21305,'LLUMPA',213)
insert into DISTRITO values (21306,'LUCMA',213)
insert into DISTRITO values (21307,'MUSGA',213)
insert into DISTRITO values (21308,'PISCOBAMBA',213)

--Distritos de OCROS
insert into DISTRITO values (21401,'ACAS',214)
insert into DISTRITO values (21402,'CAJAMARQUILLA',214)
insert into DISTRITO values (21403,'CARHUAPAMPA',214)
insert into DISTRITO values (21404,'COCHAS',214)
insert into DISTRITO values (21405,'CONGAS',214)
insert into DISTRITO values (21406,'LLIPA',214)
insert into DISTRITO values (21407,'OCROS',214)
insert into DISTRITO values (21408,'SAN CRISTOBAL DE RAJAN',214)
insert into DISTRITO values (21409,'SAN PEDRO',214)
insert into DISTRITO values (21410,'SANTIAGO DE CHILCAS',214)

--Distritos de PALLASCA
insert into DISTRITO values (21501,'BOLOGNESI',215)
insert into DISTRITO values (21502,'CABANA',215)
insert into DISTRITO values (21503,'CONCHUCOS',215)
insert into DISTRITO values (21504,'HUACASCHUQUE',215)
insert into DISTRITO values (21505,'HUANDOVAL',215)
insert into DISTRITO values (21506,'LACABAMBA',215)
insert into DISTRITO values (21507,'LLAPO',215)
insert into DISTRITO values (21508,'PALLASCA',215)
insert into DISTRITO values (21509,'PAMPAS',215)
insert into DISTRITO values (21510,'SANTA ROSA',215)
insert into DISTRITO values (21511,'TAUCA',215)

--Distritos de POMABAMBA
insert into DISTRITO values (21601,'HUAYLLAN',216)
insert into DISTRITO values (21602,'PAROBAMBA',216)
insert into DISTRITO values (21603,'POMABAMBA',216)
insert into DISTRITO values (21604,'QUINUABAMBA',216)

--Distritos de RECUAY
insert into DISTRITO values (21701,'CATAC',217)
insert into DISTRITO values (21702,'COTAPARACO',217)
insert into DISTRITO values (21703,'HUAYLLAPAMPA',217)
insert into DISTRITO values (21704,'LLACLLIN',217)
insert into DISTRITO values (21705,'MARCA',217)
insert into DISTRITO values (21706,'PAMPAS CHICO',217)
insert into DISTRITO values (21707,'PARARIN',217)
insert into DISTRITO values (21708,'RECUAY',217)
insert into DISTRITO values (21709,'TAPACOCHA',217)
insert into DISTRITO values (21710,'TICAPAMPA',217)

--Distritos de SANTA
insert into DISTRITO values (21801,'CACERES DEL PERU',218)
insert into DISTRITO values (21802,'CHIMBOTE',218)
insert into DISTRITO values (21803,'COISHCO',218)
insert into DISTRITO values (21804,'MACATE',218)
insert into DISTRITO values (21805,'MORO',218)
insert into DISTRITO values (21806,'NEPEÑA',218)
insert into DISTRITO values (21807,'NUEVO CHIMBOTE',218)
insert into DISTRITO values (21808,'SAMANCO',218)
insert into DISTRITO values (21809,'SANTA',218)

--Distritos de SIHUAS
insert into DISTRITO values (21901,'ACOBAMBA',219)
insert into DISTRITO values (21902,'ALFONSO UGARTE',219)
insert into DISTRITO values (21903,'CASHAPAMPA',219)
insert into DISTRITO values (21904,'CHINGALPO',219)
insert into DISTRITO values (21905,'HUAYLLABAMBA',219)
insert into DISTRITO values (21906,'QUICHES',219)
insert into DISTRITO values (21907,'RAGASH',219)
insert into DISTRITO values (21908,'SAN JUAN',219)
insert into DISTRITO values (21909,'SICSIBAMBA',219)
insert into DISTRITO values (21910,'SIHUAS',219)

--Distritos de YUNGAY
insert into DISTRITO values (22001,'CASCAPARA',220)
insert into DISTRITO values (22002,'MANCOS',220)
insert into DISTRITO values (22003,'MATACOTO',220)
insert into DISTRITO values (22004,'QUILLO',220)
insert into DISTRITO values (22005,'RANRAHIRCA',220)
insert into DISTRITO values (22006,'SHUPLUY',220)
insert into DISTRITO values (22007,'YANAMA',220)
insert into DISTRITO values (22008,'YUNGAY',220)


--SELECT DT.DISTRITO,P.PROVINCIA,D.DEPARTAMENTO FROM DISTRITO DT 
--INNER JOIN PROVINCIA P ON DT.IDPROVINCIA=P.IDPROVINCIA 
--INNER JOIN DEPARTAMENTO D ON P.IDDEPARTAMENTO=D.IDDEPARTAMENTO




---DEPARTAMENTO APURIMAC:
--Distritos de ABANCAY:*/
insert into DISTRITO values (30101,'ABANCAY',301)
insert into DISTRITO values (30102,'CHACOCHE',301)
insert into DISTRITO values (30103,'CIRCA',301)
insert into DISTRITO values (30104,'CURAHUASI',301)
insert into DISTRITO values (30105,'HUANIPACA',301)
insert into DISTRITO values (30106,'LAMBRAMA',301)
insert into DISTRITO values (30107,'PICHIRGUA',301)
insert into DISTRITO values (30108,'SAN PEDRO DE CACHORA',301)
insert into DISTRITO values (30109,'TAMBURCO',301)

--Distritos de ANDAHUAYLAS
insert into DISTRITO values (30201,'ANDAHUAYLAS',302)
insert into DISTRITO values (30202,'ANDARAPA',302)
insert into DISTRITO values (30203,'CHIARA',302)
insert into DISTRITO values (30204,'HUANCARAMA',302)
insert into DISTRITO values (30205,'HUANCARAY',302)
insert into DISTRITO values (30206,'HUAYANA',302)
insert into DISTRITO values (30207,'KAQUIABAMBA',302)
insert into DISTRITO values (30208,'KISHUARA',302)
insert into DISTRITO values (30209,'PACOBAMBA',302)
insert into DISTRITO values (30210,'PACUCHA',302)
insert into DISTRITO values (30211,'PAMPACHIRI',302)
insert into DISTRITO values (30212,'POMACOCHA',302)
insert into DISTRITO values (30213,'SAN ANTONIO DE CACHI',302)
insert into DISTRITO values (30214,'SAN JERONIMO',302)
insert into DISTRITO values (30215,'SAN MIGUEL DE CHACCRAMPA',302)
insert into DISTRITO values (30216,'SANTA MARIA DE CHICMO',302)
insert into DISTRITO values (30217,'TALAVERA',302)
insert into DISTRITO values (30218,'TUMAY HUARACA',302)
insert into DISTRITO values (30219,'TURPO',302)

--Distritos de ANTABAMBA
insert into DISTRITO values (30301,'ANTABAMBA',303)
insert into DISTRITO values (30302,'EL ORO',303)
insert into DISTRITO values (30303,'HUAQUIRCA',303)
insert into DISTRITO values (30304,'JUAN ESPINOZA MEDRANO',303)
insert into DISTRITO values (30305,'OROPESA',303)
insert into DISTRITO values (30306,'PACHACONAS',303)
insert into DISTRITO values (30307,'SABAINO',303)

--Distritos de AYMARAES
insert into DISTRITO values (30401,'CAPAYA',304)
insert into DISTRITO values (30402,'CARAYBAMBA',304)
insert into DISTRITO values (30403,'CHALHUANCA',304)
insert into DISTRITO values (30404,'CHAPIMARCA',304)
insert into DISTRITO values (30405,'COLCABAMBA',304)
insert into DISTRITO values (30406,'COTARUSE',304)
insert into DISTRITO values (30407,'HUAYLLO',304)
insert into DISTRITO values (30408,'JUSTO APU SAHUARAURA',304)
insert into DISTRITO values (30409,'LUCRE',304)
insert into DISTRITO values (30410,'POCOHUANCA',304)
insert into DISTRITO values (30411,'SAN JUAN DE CHACÑA',304)
insert into DISTRITO values (30412,'SAÑAYCA',304)
insert into DISTRITO values (30413,'SORAYA',304)
insert into DISTRITO values (30414,'TAPAIRIHUA',304)
insert into DISTRITO values (30415,'TINTAY',304)
insert into DISTRITO values (30416,'TORAYA',304)
insert into DISTRITO values (30417,'YANACA',304)

--Distritos de CHINCHEROS
insert into DISTRITO values (30501,'ANCO-HUALLO',305)
insert into DISTRITO values (30502,'CHINCHEROS',305)
insert into DISTRITO values (30503,'COCHARCAS',305)
insert into DISTRITO values (30504,'HUACCANA',305)
insert into DISTRITO values (30505,'OCOBAMBA',305)
insert into DISTRITO values (30506,'ONGOY',305)
insert into DISTRITO values (30507,'RANRACANCHA',305)
insert into DISTRITO values (30508,'URANMARCA',305)

--Distritos de COTABAMBAS
insert into DISTRITO values (30601,'CHALLHUAHUACHO',306)
insert into DISTRITO values (30602,'COTABAMBAS',306)
insert into DISTRITO values (30603,'COYLLURQUI',306)
insert into DISTRITO values (30604,'HUAQUIRA',306)
insert into DISTRITO values (30605,'MARA',306)
insert into DISTRITO values (30606,'TAMBOBAMBA',306)

--Distritos de GRAU
insert into DISTRITO values (30701,'CHUQUIBAMBILLA',307)
insert into DISTRITO values (30702,'CURASCO',307)
insert into DISTRITO values (30703,'CURPAHUASI',307)
insert into DISTRITO values (30704,'GAMARRA',307)
insert into DISTRITO values (30705,'HUAYLLATI',307)
insert into DISTRITO values (30706,'MAMARA',307)
insert into DISTRITO values (30707,'MICAELA BASTIDAS',307)
insert into DISTRITO values (30708,'PATAYPAMPA',307)
insert into DISTRITO values (30709,'PROGRESO',307)
insert into DISTRITO values (30710,'SAN ANTONIO',307)
insert into DISTRITO values (30711,'SANTA ROSA',307)
insert into DISTRITO values (30712,'TURPAY',307)
insert into DISTRITO values (30713,'VILCABAMBA',307)
insert into DISTRITO values (30714,'VIRUNDO',307)




---DEPARTAMENTO AREQUIPA:
--Distritos de AREQUIPA:*/
insert into DISTRITO values (40101,'ALTO SELVA ALEGRE',401)
insert into DISTRITO values (40102,'AREQUIPA',401)
insert into DISTRITO values (40103,'CAYMA',401)
insert into DISTRITO values (40104,'CERRO COLORADO',401)
insert into DISTRITO values (40105,'CHARACATO',401)
insert into DISTRITO values (40106,'CHIGUATA',401)
insert into DISTRITO values (40107,'JACOBO HUNTER',401)
insert into DISTRITO values (40108,'JOSE LUIS BUSTAMANTE Y RIVERO',401)
insert into DISTRITO values (40109,'LA JOYA',401)
insert into DISTRITO values (40110,'MARIANO MELGAR',401)
insert into DISTRITO values (40111,'MIRAFLORES',401)
insert into DISTRITO values (40112,'MOLLEBAYA',401)
insert into DISTRITO values (40113,'PAUCARPATA',401)
insert into DISTRITO values (40114,'POCSI',401)
insert into DISTRITO values (40115,'POLOBAYA',401)
insert into DISTRITO values (40116,'QUEQUEÑA',401)
insert into DISTRITO values (40117,'SABANDIA',401)
insert into DISTRITO values (40118,'SACHACA',401)
insert into DISTRITO values (40119,'SAN JUAN DE SIGUAS',401)
insert into DISTRITO values (40120,'SAN JUAN DE TARUCANI',401)
insert into DISTRITO values (40121,'SANTA ISABEL DE SIGUAS',401)
insert into DISTRITO values (40122,'SANTA RITA DE SIGUAS',401)
insert into DISTRITO values (40123,'SOCABAYA',401)
insert into DISTRITO values (40124,'TIABAYA',401)
insert into DISTRITO values (40125,'UCHUMAYO',401)
insert into DISTRITO values (40126,'VITOR',401)
insert into DISTRITO values (40127,'YANAHUARA',401)
insert into DISTRITO values (40128,'YARABAMBA',401)
insert into DISTRITO values (40129,'YURA',401)

--Distritos de CAMANA
insert into DISTRITO values (40201,'CAMANA',402)
insert into DISTRITO values (40202,'JOSE MARIA QUIMPER',402)
insert into DISTRITO values (40203,'MARIANO NICOLAS VALCARCEL',402)
insert into DISTRITO values (40204,'MARISCAL CACERES',402)
insert into DISTRITO values (40205,'NICOLAS DE PIEROLA',402)
insert into DISTRITO values (40206,'OCOÑA',402)
insert into DISTRITO values (40207,'QUILCA',402)
insert into DISTRITO values (40208,'SAMUEL PASTOR',402)

--Distritos de CARAVELÍ
insert into DISTRITO values (40301,'ACARI',403)
insert into DISTRITO values (40302,'ATICO',403)
insert into DISTRITO values (40303,'ATIQUIPA',403)
insert into DISTRITO values (40304,'BELLA UNION',403)
insert into DISTRITO values (40305,'CAHUACHO',403)
insert into DISTRITO values (40306,'CARAVELI',403)
insert into DISTRITO values (40307,'CHALA',403)
insert into DISTRITO values (40308,'CHAPARRA',403)
insert into DISTRITO values (40309,'HUANUHUANU',403)
insert into DISTRITO values (40310,'JAQUI',403)
insert into DISTRITO values (40311,'LOMAS',403)
insert into DISTRITO values (40312,'QUICACHA',403)
insert into DISTRITO values (40313,'YAUCA',403)

--Distritos de CASTILLA
insert into DISTRITO values (40401,'ANDAGUA',404)
insert into DISTRITO values (40402,'APLAO',404)
insert into DISTRITO values (40403,'AYO',404)
insert into DISTRITO values (40404,'CHACHAS',404)
insert into DISTRITO values (40405,'CHILCAYMARCA',404)
insert into DISTRITO values (40406,'CHOCO',404)
insert into DISTRITO values (40407,'HUANCARQUI',404)
insert into DISTRITO values (40408,'MACHAGUAY',404)
insert into DISTRITO values (40409,'ORCOPAMPA',404)
insert into DISTRITO values (40410,'PAMPACOLCA',404)
insert into DISTRITO values (40411,'TIPAN',404)
insert into DISTRITO values (40412,'UÑON',404)
insert into DISTRITO values (40413,'URACA',404)
insert into DISTRITO values (40414,'VIRACO',404)

--Distritos de CAYLLOMA
insert into DISTRITO values (40501,'ACHOMA',405)
insert into DISTRITO values (40502,'CABANACONDE',405)
insert into DISTRITO values (40503,'CALLALLI',405)
insert into DISTRITO values (40504,'CAYLLOMA',405)
insert into DISTRITO values (40505,'COPORAQUE',405)
insert into DISTRITO values (40506,'CHIVAY',405)
insert into DISTRITO values (40507,'HUAMBO',405)
insert into DISTRITO values (40508,'HUANCA',405)
insert into DISTRITO values (40509,'ICHUPAMPA',405)
insert into DISTRITO values (40510,'LARI',405)
insert into DISTRITO values (40511,'LLUTA',405)
insert into DISTRITO values (40512,'MACA',405)
insert into DISTRITO values (40513,'MADRIGAL',405)
insert into DISTRITO values (40514,'MAJES',405)
insert into DISTRITO values (40515,'SAN ANTONIO DE CHUCA',405)
insert into DISTRITO values (40516,'SIBAYO',405)
insert into DISTRITO values (40517,'TAPAY',405)
insert into DISTRITO values (40518,'TISCO',405)
insert into DISTRITO values (40519,'TUTI',405)
insert into DISTRITO values (40520,'YANQUE',405)

--Distritos de CONDESUYOS
insert into DISTRITO values (40601,'ANDARAY',406)
insert into DISTRITO values (40602,'CAYARANI',406)
insert into DISTRITO values (40603,'CHICHAS',406)
insert into DISTRITO values (40604,'CHUQUIBAMBA',406)
insert into DISTRITO values (40605,'IRAY',406)
insert into DISTRITO values (40606,'RIO GRANDE',406)
insert into DISTRITO values (40607,'SALAMANCA',406)
insert into DISTRITO values (40608,'YANAQUIHUA',406)

--Distritos de ISLAY
insert into DISTRITO values (40701,'COCACHACRA',407)
insert into DISTRITO values (40702,'DEAN VALDIVIA',407)
insert into DISTRITO values (40703,'ISLAY',407)
insert into DISTRITO values (40704,'MEJIA',407)
insert into DISTRITO values (40705,'MOLLENDO',407)
insert into DISTRITO values (40706,'PUNTA DE BOMBON',407)

--Distritos de LA UNION
insert into DISTRITO values (40801,'ALCA',408)
insert into DISTRITO values (40802,'COTAHUASI',408)
insert into DISTRITO values (40803,'CHARCANA',408)
insert into DISTRITO values (40804,'HUAYNACOTAS',408)
insert into DISTRITO values (40805,'PAMPAMARCA',408)
insert into DISTRITO values (40806,'PUYCA',408)
insert into DISTRITO values (40807,'QUECHUALLA',408)
insert into DISTRITO values (40808,'SAYLA',408)
insert into DISTRITO values (40809,'TAURIA',408)
insert into DISTRITO values (40810,'TOMEPAMPA',408)
insert into DISTRITO values (40811,'TORO',408)


---DEPARTAMENTO DE AYACUCHO*/
--Distrito de CANGALLO
insert into DISTRITO values (50101,'CANGALLO',501)
insert into DISTRITO values (50102,'CHUSCHI',501)
insert into DISTRITO values (50103,'LOS MOROCHUCOS',501)
insert into DISTRITO values (50104,'MARIA PARADO DE BELLIDO',501)
insert into DISTRITO values (50105,'PARAS',501)
insert into DISTRITO values (50106,'TOTOS',501)

--Distritos de HUAMANGA
insert into DISTRITO values (50201,'ACOCRO',502)
insert into DISTRITO values (50202,'ACOS VINCHOS',502)
insert into DISTRITO values (50203,'AYACUCHO',502)
insert into DISTRITO values (50204,'CARMEN ALTO',502)
insert into DISTRITO values (50205,'CHIARA',502)
insert into DISTRITO values (50206,'JESUS NAZARENO',502)
insert into DISTRITO values (50207,'OCROS',502)
insert into DISTRITO values (50208,'PACAYCASA',502)
insert into DISTRITO values (50209,'QUINUA',502)
insert into DISTRITO values (50210,'SAN JOSE DE TICLLAS',502)
insert into DISTRITO values (50211,'SAN JUAN BAUTISTA',502)
insert into DISTRITO values (50212,'SANTIAGO DE PISCHA',502)
insert into DISTRITO values (50213,'SOCOS',502)
insert into DISTRITO values (50214,'TAMBILLO',502)
insert into DISTRITO values (50215,'VINCHOS',502)

--Distritos de HUANCASANCOS
insert into DISTRITO values (50301,'CARAPO',503)
insert into DISTRITO values (50302,'SACSAMARCA',503)
insert into DISTRITO values (50303,'SANCOS',503)
insert into DISTRITO values (50304,'SANTIAGO DE LUCANAMARCA',503)

--Distritos de HUANTA
insert into DISTRITO values (50401,'AYAHUANCO',504)
insert into DISTRITO values (50402,'HUAMANGUILLA',504)
insert into DISTRITO values (50403,'HUANTA',504)
insert into DISTRITO values (50404,'IGUAIN',504)
insert into DISTRITO values (50405,'LLOCHEGUA',504)
insert into DISTRITO values (50406,'LURICOCHA',504)
insert into DISTRITO values (50407,'SANTILLANA',504)
insert into DISTRITO values (50408,'SIVIA',504)

--Distritos de LA MAR
insert into DISTRITO values (50501,'ANCO',505)
insert into DISTRITO values (50502,'AYNA',505)
insert into DISTRITO values (50503,'CHILCAS',505)
insert into DISTRITO values (50504,'CHUNGUI',505)
insert into DISTRITO values (50505,'LUIS CARRANZA',505)
insert into DISTRITO values (50506,'SAN MIGUEL',505)
insert into DISTRITO values (50507,'SANTA ROSA',505)
insert into DISTRITO values (50508,'TAMBO',505)

--Distritos de LUCANAS
insert into DISTRITO values (50601,'AUCARA',506)
insert into DISTRITO values (50602,'CABANA',506)
insert into DISTRITO values (50603,'CARMEN SALCEDO',506)
insert into DISTRITO values (50604,'CHAVIÑA',506)
insert into DISTRITO values (50605,'CHIPAO',506)
insert into DISTRITO values (50606,'HUAC-HUAS',506)
insert into DISTRITO values (50607,'LARAMATE',506)
insert into DISTRITO values (50608,'LEONCIO PRADO',506)
insert into DISTRITO values (50609,'LLAUTA',506)
insert into DISTRITO values (50610,'LUCANAS',506)
insert into DISTRITO values (50611,'OCAÑA',506)
insert into DISTRITO values (50612,'OTOCA',506)
insert into DISTRITO values (50613,'PUQUIO',506)
insert into DISTRITO values (50614,'SAISA',506)
insert into DISTRITO values (50615,'SAN CRISTOBAL',506)
insert into DISTRITO values (50616,'SAN JUAN',506)
insert into DISTRITO values (50617,'SAN PEDRO',506)
insert into DISTRITO values (50618,'SAN PEDRO DE PALCO',506)
insert into DISTRITO values (50619,'SANCOS',506)
insert into DISTRITO values (50620,'SANTA ANA DE HUAYCAHUACHO',506)
insert into DISTRITO values (50621,'SANTA LUCIA',506)

--Distritos de PARINACOCHAS
insert into DISTRITO values (50701,'CHUMPI',507)
insert into DISTRITO values (50702,'CORACORA',507)
insert into DISTRITO values (50703,'CORONEL CASTAÑEDA',507)
insert into DISTRITO values (50704,'PACAPAUSA',507)
insert into DISTRITO values (50705,'PULLO',507)
insert into DISTRITO values (50706,'PUYUSCA',507)
insert into DISTRITO values (50707,'SAN FRANCISCO DE RAVACAYCO',507)
insert into DISTRITO values (50708,'UPAHUACHO',507)

--Distritos de PAUCAR DEL SARA SARA
insert into DISTRITO values (50801,'COLTA',508)
insert into DISTRITO values (50802,'CORCULLA',508)
insert into DISTRITO values (50803,'LAMPA',508)
insert into DISTRITO values (50804,'MARCABAMBA',508)
insert into DISTRITO values (50805,'OYOLO',508)
insert into DISTRITO values (50806,'PARARCA',508)
insert into DISTRITO values (50807,'PAUSA',508)
insert into DISTRITO values (50808,'SAN JAVIER DE ALPABAMBA',508)
insert into DISTRITO values (50809,'SAN JOSE DE USHUA',508)
insert into DISTRITO values (50810,'SARA SARA',508)

--Distritos de SUCRE
insert into DISTRITO values (50901,'BELEN',509)
insert into DISTRITO values (50902,'CHALCOS',509)
insert into DISTRITO values (50903,'CHILCAYOC',509)
insert into DISTRITO values (50904,'HUACAÑA',509)
insert into DISTRITO values (50905,'MORCOLLA',509)
insert into DISTRITO values (50906,'PAICO',509)
insert into DISTRITO values (50907,'QUEROBAMBA',509)
insert into DISTRITO values (50908,'SAN PEDRO DE LARCAY',509)
insert into DISTRITO values (50909,'SAN SALVADOR DE QUIJE',509)
insert into DISTRITO values (50910,'SANTIAGO DE PAUCARAY',509)
insert into DISTRITO values (50911,'SORAS',509)

--Ditritos de VICTOR FAJARDO
insert into DISTRITO values (51001,'ALCAMENCA',510)
insert into DISTRITO values (51002,'APONGO',510)
insert into DISTRITO values (51003,'ASQUIPATA',510)
insert into DISTRITO values (51004,'CANARIA',510)
insert into DISTRITO values (51005,'CAYARA',510)
insert into DISTRITO values (51006,'COLCA',510)
insert into DISTRITO values (51007,'HUAMANQUIQUIA',510)
insert into DISTRITO values (51008,'HUANCAPI',510)
insert into DISTRITO values (51009,'HUANCARAYLLA',510)
insert into DISTRITO values (51010,'HUAYA',510)
insert into DISTRITO values (51011,'SARHUA',510)
insert into DISTRITO values (51012,'VILCANCHOS',510)

--Distritos de VILCASHUAMAN
insert into DISTRITO values (51101,'ACCOMARCA',511)
insert into DISTRITO values (51102,'CARHUANCA',511)
insert into DISTRITO values (51103,'CONCEPCION',511)
insert into DISTRITO values (51104,'HUAMBALPA',511)
insert into DISTRITO values (51105,'INDEPENDENCIA',511)
insert into DISTRITO values (51106,'SAURAMA',511)
insert into DISTRITO values (51107,'VILCASHUAMAN',511)
insert into DISTRITO values (51108,'VISCHONGO',511)




---DEPARTAMENTO DE CAJAMARCA*/
--Distritos de CAJABAMBA
insert into DISTRITO values (60101,'CACHACHI',601)
insert into DISTRITO values (60102,'CAJABAMBA',601)
insert into DISTRITO values (60103,'CONDEBAMBA',601)
insert into DISTRITO values (60104,'SITACOCHA',601)

--Distritos de CAJAMARCA
insert into DISTRITO values (60201,'ASUNCION',602)
insert into DISTRITO values (60202,'CAJAMARCA',602)
insert into DISTRITO values (60203,'CHETILLA',602)
insert into DISTRITO values (60204,'COSPAN',602)
insert into DISTRITO values (60205,'ENCAÑADA',602)
insert into DISTRITO values (60206,'JESUS',602)
insert into DISTRITO values (60207,'LLACANORA',602)
insert into DISTRITO values (60208,'LOS BAÑOS DEL INCA ',602)
insert into DISTRITO values (60209,'MAGDALENA',602)
insert into DISTRITO values (60210,'MATARA',602)
insert into DISTRITO values (60211,'NAMORA',602)
insert into DISTRITO values (60212,'SAN JUAN ',602)

--Distritos de CELENDIN
insert into DISTRITO values (60301,'CELENDIN',603)
insert into DISTRITO values (60302,'CHUMUCH',603)
insert into DISTRITO values (60303,'CORTEGANA',603)
insert into DISTRITO values (60304,'HUASMIN',603)
insert into DISTRITO values (60305,'JORGE CHAVEZ',603)
insert into DISTRITO values (60306,'JOSE GALVEZ ',603)
insert into DISTRITO values (60307,'LA LIBERTAD DE PALLAN ',603)
insert into DISTRITO values (60308,'MIGUEL IGLESIAS ',603)
insert into DISTRITO values (60309,'OXAMARCA',603)
insert into DISTRITO values (60310,'SOROCHUCO',603)
insert into DISTRITO values (60311,'SUCRE',603)
insert into DISTRITO values (60312,'UTCO',603)

--Distritos de CHOTA
insert into DISTRITO values (60401,'ANGUIA',604)
insert into DISTRITO values (60402,'CHADIN',604)
insert into DISTRITO values (60403,'CHALAMARCA',604)
insert into DISTRITO values (60404,'CHIGUIRIP',604)
insert into DISTRITO values (60405,'CHIMBAN',604)
insert into DISTRITO values (60406,'CHOROPAMPA',604)
insert into DISTRITO values (60407,'CHOTA',604)
insert into DISTRITO values (60408,'COCHABAMBA',604)
insert into DISTRITO values (60409,'CONCHAN',604)
insert into DISTRITO values (60410,'HUAMBOS',604)
insert into DISTRITO values (60411,'LAJAS',604)
insert into DISTRITO values (60412,'LLAMA',604)
insert into DISTRITO values (60413,'MIRACOSTA',604)
insert into DISTRITO values (60414,'PACCHA',604)
insert into DISTRITO values (60415,'PION',604)
insert into DISTRITO values (60416,'QUEROCOTO',604)
insert into DISTRITO values (60417,'SAN JUAN DE LICUPIS',604)
insert into DISTRITO values (60418,'TACABAMBA',604)
insert into DISTRITO values (60419,'TOCMOCHE',604)

--Distritos de CONTUMAZA
insert into DISTRITO values (60501,'CHILETE',605)
insert into DISTRITO values (60502,'CONTUMAZA',605)
insert into DISTRITO values (60503,'CUPISNIQUE',605)
insert into DISTRITO values (60504,'GUZMANGO',605)
insert into DISTRITO values (60505,'SAN BENITO',605)
insert into DISTRITO values (60506,'SANTA CRUZ DE TOLED',605)
insert into DISTRITO values (60507,'TANTARICA',605)
insert into DISTRITO values (60508,'YONAN',605)

--Distritos de CUTERVO
insert into DISTRITO values (60601,'CALLAYUC',606)
insert into DISTRITO values (60602,'CHOROS',606)
insert into DISTRITO values (60603,'CUJILLO',606)
insert into DISTRITO values (60604,'CUTERVO',606)
insert into DISTRITO values (60605,'LA RAMADA ',606)
insert into DISTRITO values (60606,'PIMPINGOS',606)
insert into DISTRITO values (60607,'QUEROCOTILLO',606)
insert into DISTRITO values (60608,'SAN ANDRES DE CUTERVO',606)
insert into DISTRITO values (60609,'SAN JUAN DE CUTERVO ',606)
insert into DISTRITO values (60610,'SAN LUIS DE LUCMA',606)
insert into DISTRITO values (60611,'SANTA CRUZ',606)
insert into DISTRITO values (60612,'SANTO DOMINGO DE LA CAPILLA',606)
insert into DISTRITO values (60613,'SANTO TOMAS',606)
insert into DISTRITO values (60614,'SOCOTA',606)
insert into DISTRITO values (60615,'TORIBIO CASANOVA',606)

--Distritos de HUALGAYOC
insert into DISTRITO values (60701,'BAMBAMARCA',607)
insert into DISTRITO values (60702,'CHUGUR',607)
insert into DISTRITO values (60703,'HUALGAYOC',607)

--Distritos de JAEN
insert into DISTRITO values (60801,'BELLAVISTA',608)
insert into DISTRITO values (60802,'CHONTALI',608)
insert into DISTRITO values (60803,'COLASAY',608)
insert into DISTRITO values (60804,'HUABAL',608)
insert into DISTRITO values (60805,'JAEN',608)
insert into DISTRITO values (60806,'LAS PIRIAS ',608)
insert into DISTRITO values (60807,'POMAHUACA',608)
insert into DISTRITO values (60808,'PUCARA',608)
insert into DISTRITO values (60809,'SALLIQUE',608)
insert into DISTRITO values (60810,'SAN FELIPE',608)
insert into DISTRITO values (60811,'SAN JOSE DEL ALTO',608)
insert into DISTRITO values (60812,'SANTA ROSA',608)

--Distritos de SAN IGNACIO
insert into DISTRITO values (60901,'CHIRINOS',609)
insert into DISTRITO values (60902,'HUARANGO',609)
insert into DISTRITO values (60903,'LA COIPA',609)
insert into DISTRITO values (60904,'NAMBALLE',609)
insert into DISTRITO values (60905,'SAN IGNACIO',609)
insert into DISTRITO values (60906,'SAN JOSE DE LOURDES',609)
insert into DISTRITO values (60907,'TABACONAS',609)

--Distritos de SAN MARCOS
insert into DISTRITO values (61001,'CHANCAY',610)
insert into DISTRITO values (61002,'EDUARDO VILLANUEVA',610)
insert into DISTRITO values (61003,'GREGORIO PITA',610)
insert into DISTRITO values (61004,'ICHOCAN',610)
insert into DISTRITO values (61005,'JOSE MANUEL QUIROZ',610)
insert into DISTRITO values (61006,'JOSE SABOGAL',610)
insert into DISTRITO values (61007,'PEDRO GALVEZ',610)

--Distritos de SAN MIGUEL
insert into DISTRITO values (61101,'BOLIVAR',611)
insert into DISTRITO values (61102,'CALQUIS',611)
insert into DISTRITO values (61103,'CATILLUC',611)
insert into DISTRITO values (61104,'EL PRADO',611)
insert into DISTRITO values (61105,'LA FLORIDA',611)
insert into DISTRITO values (61106,'LLAPA',611)
insert into DISTRITO values (61107,'NANCHOC',611)
insert into DISTRITO values (61108,'NIEPOS',611)
insert into DISTRITO values (61109,'SAN GREGORIO',611)
insert into DISTRITO values (61110,'SAN MIGUEL',611)
insert into DISTRITO values (61111,'SAN SILVESTRE DE COCHAN',611)
insert into DISTRITO values (61112,'TONGOD',611)
insert into DISTRITO values (61113,'UNION AGUA BLANCA',611)

--Distritos de SAN PABLO
insert into DISTRITO values (61201,'SAN BERNARDINO',612)
insert into DISTRITO values (61202,'SAN LUIS',612)
insert into DISTRITO values (61203,'SAN PABLO',612)
insert into DISTRITO values (61204,'TUMBADEN',612)

--Distritos de SANTA CRUZ
insert into DISTRITO values (61301,'ANDABAMBA',613)
insert into DISTRITO values (61302,'CATACHE',613)
insert into DISTRITO values (61303,'CHANCAYBAÑOS',613)
insert into DISTRITO values (61304,'LA ESPERANZA',613)
insert into DISTRITO values (61305,'NINABAMBA',613)
insert into DISTRITO values (61306,'PULAN',613)
insert into DISTRITO values (61307,'SANTA CRUZ',613)
insert into DISTRITO values (61308,'SAUCEPAMPA',613)
insert into DISTRITO values (61309,'SEXI',613)
insert into DISTRITO values (61310,'UTICYACU',613)
insert into DISTRITO values (61311,'YAUYUCAN',613)



---DEPARTAMENTO DE CUZCO*/
--Distritos de ACOMAYO
insert into DISTRITO values (70101,'ACOMAYO',701)
insert into DISTRITO values (70102,'ACOPIA',701)
insert into DISTRITO values (70103,'ACOS',701)
insert into DISTRITO values (70104,'MOSOC LLACTA',701)
insert into DISTRITO values (70105,'POMACANCHI',701)
insert into DISTRITO values (70106,'RONDOCAN',701)
insert into DISTRITO values (70107,'SANGARARA',701)

--Distritos de ANTA
insert into DISTRITO values (70201,'ANCAHUASI',702)
insert into DISTRITO values (70202,'ANTA',702)
insert into DISTRITO values (70203,'CACHIMAYO',702)
insert into DISTRITO values (70204,'CHINCHAYPUJIO',702)
insert into DISTRITO values (70205,'HUAROCONDO',702)
insert into DISTRITO values (70206,'LIMATAMBO',702)
insert into DISTRITO values (70207,'MOLLEPATA',702)
insert into DISTRITO values (70208,'PUCYURA',702)
insert into DISTRITO values (70209,'ZURITE',702)

--Distritos de CALCA
insert into DISTRITO values (70301,'CALCA',703)
insert into DISTRITO values (70302,'COYA',703)
insert into DISTRITO values (70303,'LAMAY',703)
insert into DISTRITO values (70304,'LARES',703)
insert into DISTRITO values (70305,'PISAC',703)
insert into DISTRITO values (70306,'SAN SALVADOR',703)
insert into DISTRITO values (70307,'TARAY',703)
insert into DISTRITO values (70308,'YANATILE',703)

--Distritos de CANAS
insert into DISTRITO values (70401,'CHECCA',704)
insert into DISTRITO values (70402,'KUNTURKANKI',704)
insert into DISTRITO values (70403,'LANGUI',704)
insert into DISTRITO values (70404,'LAYO',704)
insert into DISTRITO values (70405,'PAMPAMARCA',704)
insert into DISTRITO values (70406,'QUEHUE',704)
insert into DISTRITO values (70407,'TUPAC AMARU',704)
insert into DISTRITO values (70408,'YANAOCA',704)

--Distritos de CANCHIS
insert into DISTRITO values (70501,'CHECACUPE',705)
insert into DISTRITO values (70502,'COMBAPATA',705)
insert into DISTRITO values (70503,'MARANGANI',705)
insert into DISTRITO values (70504,'PITUMARCA',705)
insert into DISTRITO values (70505,'SAN PABLO',705)
insert into DISTRITO values (70506,'SAN PEDRO',705)
insert into DISTRITO values (70507,'SICUANI',705)
insert into DISTRITO values (70508,'TINTA',705)

--Distritos de CHUMBIVILCAS
insert into DISTRITO values (70601,'CAPACMARCA',706)
insert into DISTRITO values (70602,'CHAMACA',706)
insert into DISTRITO values (70603,'COLQUEMARCA',706)
insert into DISTRITO values (70604,'LIVITACA',706)
insert into DISTRITO values (70605,'LLUSCO',706)
insert into DISTRITO values (70606,'QUIÑOTA',706)
insert into DISTRITO values (70607,'SANTO TOMAS',706)
insert into DISTRITO values (70608,'VELILLE',706)

--Distritos de CUZCO
insert into DISTRITO values (70701,'CCORCA',707)
insert into DISTRITO values (70702,'CUSCO',707)
insert into DISTRITO values (70703,'POROY',707)
insert into DISTRITO values (70704,'SAN JERONIMO',707)
insert into DISTRITO values (70705,'SAN SEBASTIAN',707)
insert into DISTRITO values (70706,'SANTIAGO',707)
insert into DISTRITO values (70707,'SAYLLA',707)
insert into DISTRITO values (70708,'WANCHAQ',707)

--Distritos de ESPINAR
insert into DISTRITO values (70801,'ALTO PICHIGUA',708)
insert into DISTRITO values (70802,'CONDOROMA',708)
insert into DISTRITO values (70803,'COPORAQUE',708)
insert into DISTRITO values (70804,'ESPINAR',708)
insert into DISTRITO values (70805,'OCORURO',708)
insert into DISTRITO values (70806,'PALLPATA',708)
insert into DISTRITO values (70807,'PICHIGUA',708)
insert into DISTRITO values (70808,'SUYCKUTAMBO',708)

--Distritos de LA CONVENCION
insert into DISTRITO values (70901,'ECHARATE',709)
insert into DISTRITO values (70902,'HUAYOPATA',709)
insert into DISTRITO values (70903,'MARANURA',709)
insert into DISTRITO values (70904,'OCOBAMBA',709)
insert into DISTRITO values (70905,'PICHARI',709)
insert into DISTRITO values (70906,'QUELLOUNO',709)
insert into DISTRITO values (70907,'QUIMBIRI',709)
insert into DISTRITO values (70908,'SANTA ANA',709)
insert into DISTRITO values (70909,'SANTA TERESA',709)
insert into DISTRITO values (70910,'VILCABAMBA',709)

--Distritos de PARURO
insert into DISTRITO values (71001,'ACCHA',710)
insert into DISTRITO values (71002,'CCAPI',710)
insert into DISTRITO values (71003,'COLCHA',710)
insert into DISTRITO values (71004,'HUANOQUITE',710)
insert into DISTRITO values (71005,'OMACHA',710)
insert into DISTRITO values (71006,'PACCARITAMBO',710)
insert into DISTRITO values (71007,'PARURO',710)
insert into DISTRITO values (71008,'PILLPINTO',710)
insert into DISTRITO values (71009,'YAURISQUE',710)

--Distritos de PAUCARTAMBO
insert into DISTRITO values (71101,'CAICAY',711)
insert into DISTRITO values (71102,'CHALLABAMBA',711)
insert into DISTRITO values (71103,'COLQUEPATA',711)
insert into DISTRITO values (71104,'HUANCARANI',711)
insert into DISTRITO values (71105,'KOSÑIPATA',711)
insert into DISTRITO values (71106,'PAUCARTAMBO',711)

--Distritos de QUISPICANCHI
insert into DISTRITO values (71201,'ANDAHUAYLILLAS',712)
insert into DISTRITO values (71202,'CAMANTI',712)
insert into DISTRITO values (71203,'CCARHUAYO',712)
insert into DISTRITO values (71204,'CCATCA',712)
insert into DISTRITO values (71205,'CUSIPATA',712)
insert into DISTRITO values (71206,'HUARO',712)
insert into DISTRITO values (71207,'LUCRE',712)
insert into DISTRITO values (71208,'MARCAPATA',712)
insert into DISTRITO values (71209,'OCONGATE',712)
insert into DISTRITO values (71210,'OROPESA',712)
insert into DISTRITO values (71211,'QUIQUIJANA',712)
insert into DISTRITO values (71212,'URCOS',712)

--Distritos de URUBAMBA
insert into DISTRITO values (71301,'CHINCHERO',713)
insert into DISTRITO values (71302,'HUAYLLABAMBA',713)
insert into DISTRITO values (71303,'MACHU PICCHU',713)
insert into DISTRITO values (71304,'MARAS',713)
insert into DISTRITO values (71305,'OLLANTAYTAMBO',713)
insert into DISTRITO values (71306,'URUBAMBA',713)
insert into DISTRITO values (71307,'YUCAY',713)




---DEPARTAMENTO DE HUANCAVELICA*/
--Distritos de HUANCAVELICA
insert into DISTRITO values (80101,'ACOBAMBA',801)
insert into DISTRITO values (80102,'ANDABAMBA',801)
insert into DISTRITO values (80103,'ANTA',801)
insert into DISTRITO values (80104,'CAJA',801)
insert into DISTRITO values (80105,'MARCAS',801)
insert into DISTRITO values (80106,'PAUCARA',801)
insert into DISTRITO values (80107,'POMACOCHA',801)
insert into DISTRITO values (80108,'ROSARIO',801)

--Distritos de ANGARAES
insert into DISTRITO values (80201,'ANCHONGA',802)
insert into DISTRITO values (80202,'CALLANMARCA',802)
insert into DISTRITO values (80203,'CCOCHACCASA',802)
insert into DISTRITO values (80204,'CHINCHO',802)
insert into DISTRITO values (80205,'CONGALLA',802)
insert into DISTRITO values (80206,'HUANCA-HUANCA',802)
insert into DISTRITO values (80207,'HUAYLLAY GRANDE',802)
insert into DISTRITO values (80208,'JULCAMARCA',802)
insert into DISTRITO values (80209,'LIRCAY',802)
insert into DISTRITO values (80210,'SAN ANTONIO DE ANTAPARCO',802)
insert into DISTRITO values (80211,'SANTO TOMAS DE PATA',802)
insert into DISTRITO values (80212,'SECCLLA',802)

--Distritos de CASTROVIRREYNA
insert into DISTRITO values (80301,'ARMA',803)
insert into DISTRITO values (80302,'AURAHUA',803)
insert into DISTRITO values (80303,'CAPILLAS',803)
insert into DISTRITO values (80304,'CASTROVIRREYNA',803)
insert into DISTRITO values (80305,'CHUPAMARCA',803)
insert into DISTRITO values (80306,'COCAS',803)
insert into DISTRITO values (80307,'HUACHOS',803)
insert into DISTRITO values (80308,'HUAMATAMBO',803)
insert into DISTRITO values (80309,'MOLLEPAMPA',803)
insert into DISTRITO values (80310,'SAN JUAN',803)
insert into DISTRITO values (80311,'SANTA ANA',803)
insert into DISTRITO values (80312,'TANTARA',803)
insert into DISTRITO values (80313,'TICRAPO',803)

--Distritos de CHURCAMPA
insert into DISTRITO values (80401,'ANCO',804)
insert into DISTRITO values (80402,'CHINCHIHUASI',804)
insert into DISTRITO values (80403,'CHURCAMPA',804)
insert into DISTRITO values (80404,'EL CARMEN',804)
insert into DISTRITO values (80405,'LA MERCED',804)
insert into DISTRITO values (80406,'LOCROJA',804)
insert into DISTRITO values (80407,'PACHAMARCA',804)
insert into DISTRITO values (80408,'PAUCARBAMBA',804)
insert into DISTRITO values (80409,'SAN MIGUEL DE MAYOCC',804)
insert into DISTRITO values (80410,'SAN PEDRO DE CORIS',804)

--Distritos de HUANCAVELICA
insert into DISTRITO values (80501,'ACOBAMBILLA',805)
insert into DISTRITO values (80502,'ACORIA',805)
insert into DISTRITO values (80503,'ASCENSION',805)
insert into DISTRITO values (80504,'CONAYCA',805)
insert into DISTRITO values (80505,'CUENCA',805)
insert into DISTRITO values (80506,'HUACHOCOLPA',805)
insert into DISTRITO values (80507,'HUANCAVELICA',805)
insert into DISTRITO values (80508,'HUANDO',805)
insert into DISTRITO values (80509,'HUAYLLAHUARA',805)
insert into DISTRITO values (80510,'IZCUCHACA',805)
insert into DISTRITO values (80511,'LARIA',805)
insert into DISTRITO values (80512,'MANTA',805)
insert into DISTRITO values (80513,'MARISCAL CACERES',805)
insert into DISTRITO values (80514,'MOYA',805)
insert into DISTRITO values (80515,'NUEVO OCCORO',805)
insert into DISTRITO values (80516,'PALCA',805)
insert into DISTRITO values (80517,'PILCHACA',805)
insert into DISTRITO values (80518,'VILCA',805)
insert into DISTRITO values (80519,'YAULI',805)

--Distritos de HUAYTARA
insert into DISTRITO values (80601,'AYAVI',806)
insert into DISTRITO values (80602,'CORDOVA',806)
insert into DISTRITO values (80603,'HUAYACUNDO ARMA',806)
insert into DISTRITO values (80604,'HUAYTARA',806)
insert into DISTRITO values (80605,'LARAMARCA',806)
insert into DISTRITO values (80606,'OCOYO',806)
insert into DISTRITO values (80607,'PILPICHACA',806)
insert into DISTRITO values (80608,'QUERCO',806)
insert into DISTRITO values (80609,'QUITO-ARMA',806)
insert into DISTRITO values (80610,'SAN ANTONIO DE CUSICANCHA',806)
insert into DISTRITO values (80611,'SAN FRANCISCO DE SANGAYAICO',806)
insert into DISTRITO values (80612,'SAN ISIDRO',806)
insert into DISTRITO values (80613,'SANTIAGO DE CHOCORVOS',806)
insert into DISTRITO values (80614,'SANTIAGO DE QUIRAHUARA',806)
insert into DISTRITO values (80615,'SANTO DOMINGO DE CAPILLAS',806)
insert into DISTRITO values (80616,'TAMBO',806)

--Distritos de TAYACAJA
insert into DISTRITO values (80701,'ACOSTAMBO',807)
insert into DISTRITO values (80702,'ACRAQUIA',807)
insert into DISTRITO values (80703,'AHUAYCHA',807)
insert into DISTRITO values (80704,'COLCABAMBA',807)
insert into DISTRITO values (80705,'DANIEL HERNANDEZ',807)
insert into DISTRITO values (80706,'HUACHOCOLPA',807)
insert into DISTRITO values (80707,'HUARIBAMBA',807)
insert into DISTRITO values (80708,'ÑAHUIMPUQUIO',807)
insert into DISTRITO values (80709,'PAMPAS',807)
insert into DISTRITO values (80710,'PAZOS',807)
insert into DISTRITO values (80711,'QUISHUAR',807)
insert into DISTRITO values (80712,'SALCABAMBA',807)
insert into DISTRITO values (80713,'SALCAHUASI',807)
insert into DISTRITO values (80714,'SAN MARCOS DE ROCCHAC',807)
insert into DISTRITO values (80715,'SURCUBAMBIA',807)
insert into DISTRITO values (80716,'TINTAY PUNCU',807)


---Departamento de HUANUCO*/
--Distritos de AMBO
insert into DISTRITO values (90101,'AMBO',901)
insert into DISTRITO values (90102,'CAYNA',901)
insert into DISTRITO values (90103,'COLPAS',901)
insert into DISTRITO values (90104,'CONCHAMARCA',901)
insert into DISTRITO values (90105,'HUACAR',901)
insert into DISTRITO values (90106,'SAN FRANCISCO',901)
insert into DISTRITO values (90107,'SAN RAFAEL',901)
insert into DISTRITO values (90108,'TOMAY KICHWA',901)

--Distritos de DOS DE MAYO
insert into DISTRITO values (90201,'CHUQUIS',902)
insert into DISTRITO values (90202,'LA UNION',902)
insert into DISTRITO values (90203,'MARIAS',902)
insert into DISTRITO values (90204,'PACHAS',902)
insert into DISTRITO values (90205,'QUIVILLA',902)
insert into DISTRITO values (90206,'RIPAN',902)
insert into DISTRITO values (90207,'SHUNQUI',902)
insert into DISTRITO values (90208,'SILLAPATA',902)
insert into DISTRITO values (90209,'YANAS',902)

--Distritos de HUACAYBAMBA
insert into DISTRITO values (90301,'CANCHABAMBA',903)
insert into DISTRITO values (90302,'COCHABAMBA',903)
insert into DISTRITO values (90303,'HUACAYBAMBA',903)
insert into DISTRITO values (90304,'PINRA',903)

--Distritos de HUAMALIES
insert into DISTRITO values (90401,'ARANCAY',904)
insert into DISTRITO values (90402,'CHAVIN DE PARIARCA',904)
insert into DISTRITO values (90403,'JACAS GRANDE',904)
insert into DISTRITO values (90404,'JIRCAN',904)
insert into DISTRITO values (90405,'LLATA',904)
insert into DISTRITO values (90406,'MIRAFLORES',904)
insert into DISTRITO values (90407,'MONZON',904)
insert into DISTRITO values (90408,'PUNCHAO',904)
insert into DISTRITO values (90409,'PUÑOS',904)
insert into DISTRITO values (90410,'SINGA',904)
insert into DISTRITO values (90411,'TANTAMAYO',904)

--Distritos de HUANUCO
insert into DISTRITO values (90501,'AMARILIS',905)
insert into DISTRITO values (90502,'CHINCHAO',905)
insert into DISTRITO values (90503,'CHURUBAMBA',905)
insert into DISTRITO values (90504,'HUANUCO',905)
insert into DISTRITO values (90505,'MARGOS',905)
insert into DISTRITO values (90506,'PILLCO MARCA',905)
insert into DISTRITO values (90507,'QUISQUI',905)
insert into DISTRITO values (90508,'SAN FRANCISCO DE CAYRAN',905)
insert into DISTRITO values (90509,'SAN PEDRO DE CHAULAN',905)
insert into DISTRITO values (90510,'SANTA MARIA DEL VALLE',905)
insert into DISTRITO values (90511,'YARUMAYO',905)

--Distritos de LAURICOCHA
insert into DISTRITO values (90601,'BAÑOS',906)
insert into DISTRITO values (90602,'JESUS',906)
insert into DISTRITO values (90603,'JIVIA',906)
insert into DISTRITO values (90604,'QUEROPALCA',906)
insert into DISTRITO values (90605,'RONDOS',906)
insert into DISTRITO values (90606,'SAN FRANCISCO DE ASIS',906)
insert into DISTRITO values (90607,'SAN MIGUEL DE CAURI',906)

--Distritos de LEONCIO PRADO
insert into DISTRITO values (90701,'DANIEL ALOMIAS ROBLES',907)
insert into DISTRITO values (90702,'HERMILIO VALDIZAN',907)
insert into DISTRITO values (90703,'JOSE CRESPO Y CASTILLO',907)
insert into DISTRITO values (90704,'LUYANDO',907)
insert into DISTRITO values (90705,'MARIANO DAMASO BERAUN',907)
insert into DISTRITO values (90706,'RUPA-RUPA',907)

--Distritos de MARAÑON
insert into DISTRITO values (90801,'CHOLON',908)
insert into DISTRITO values (90802,'HUACRACHUCO',908)
insert into DISTRITO values (90803,'SAN BUENAVENTURA',908)

--Distritos de PACHITEA
insert into DISTRITO values (90901,'CHAGLLA',909)
insert into DISTRITO values (90902,'MOLINO',909)
insert into DISTRITO values (90903,'PANAO',909)
insert into DISTRITO values (90904,'UMARI',909)

--Distritos de PUERTO INCA
insert into DISTRITO values (91001,'CODO DEL POZUZO',910)
insert into DISTRITO values (91002,'HONORIA',910)
insert into DISTRITO values (91003,'PUERTO INCA',910)
insert into DISTRITO values (91004,'TOURNAVISTA',910)
insert into DISTRITO values (91005,'YUYAPICHIS',910)

--Distritos de YAROWILCA
insert into DISTRITO values (91101,'APARICIO POMARES',911)
insert into DISTRITO values (91102,'CAHUAC',911)
insert into DISTRITO values (91103,'CHACABAMBA',911)
insert into DISTRITO values (91104,'CHAVINILLO',911)
insert into DISTRITO values (91105,'CHORAS',911)
insert into DISTRITO values (91106,'JACAS CHICO',911)
insert into DISTRITO values (91107,'OBAS',911)
insert into DISTRITO values (91108,'PAMPAMARCA',911)




---DEPARTAMENTO ICA:
--PROVINCIA ICA:*/
--Distritos de CHINCHA
insert into DISTRITO values(100101,'ALTO LARAN',1001)
insert into DISTRITO values(100102,'CHAVIN',1001)
insert into DISTRITO values(100103,'CHINCHA ALTA',1001)
insert into DISTRITO values(100104,'CHINCHA BAJA',1001)
insert into DISTRITO values(100105,'EL CARMEN',1001)
insert into DISTRITO values(100106,'GROCIO PRADO',1001)
insert into DISTRITO values(100107,'PUEBLO NUEVO',1001)
insert into DISTRITO values(100108,'SAN JUAN DE YANAC',1001)
insert into DISTRITO values(100109,'SAN PEDRO DE HUACARPANA',1001)
insert into DISTRITO values(100110,'SUNAMPE',1001)
insert into DISTRITO values(100111,'TAMBO DE MORA',1001)

--Distritos de ICA
insert into DISTRITO values (100201,'ICA',1002)
insert into DISTRITO values (100202,'LA TINGUIÑA',1002)
insert into DISTRITO values (100203,'LOS AQUIJES',1002)
insert into DISTRITO values (100204,'OCUCAJE',1002)
insert into DISTRITO values (100205,'PACHACUTEC',1002)
insert into DISTRITO values (100206,'PARCONA',1002)
insert into DISTRITO values (100207,'PUEBLO NUEVO',1002)
insert into DISTRITO values (100208,'SALAS',1002)
insert into DISTRITO values (100209,'SAN JOSE DE LOS MOLINOS',1002)
insert into DISTRITO values (100210,'SAN JUAN BAUTISTA',1002)
insert into DISTRITO values (100211,'SANTIAGO',1002)
insert into DISTRITO values (100212,'SUBTANJALLA',1002)
insert into DISTRITO values (100213,'TATE',1002)
insert into DISTRITO values (100214,'YAUCA DEL ROSARIO',1002)

--Distritos de NAZCA
insert into DISTRITO values(100301,'CHANGUILLO',1003)
insert into DISTRITO values(100302,'EL INGENIO',1003)
insert into DISTRITO values(100303,'MARCONA',1003)
insert into DISTRITO values(100304,'NAZCA',1003)
insert into DISTRITO values(100305,'VISTA ALEGRE',1003)

--Distritos de PALPA
insert into DISTRITO values(100401,'LLIPATA',1004)
insert into DISTRITO values(100402,'PALPA',1004)
insert into DISTRITO values(100403,'RIO GRANDE',1004)
insert into DISTRITO values(100404,'SANTA CRUZ',1004)
insert into DISTRITO values(100405,'TIBILLO',1004)

--Distritos de PISCO
insert into DISTRITO values(100501,'HUANCANO',1005)
insert into DISTRITO values(100502,'HUMAY',1005)
insert into DISTRITO values(100503,'INDEPENDENCIA',1005)
insert into DISTRITO values(100504,'PARACAS',1005)
insert into DISTRITO values(100505,'PISCO',1005)
insert into DISTRITO values(100506,'SAN ANDRES',1005)
insert into DISTRITO values(100507,'SAN CLEMENTE',1005)
insert into Distrito values(100508,'SAN MIGUEL',1005)
insert into DISTRITO values(100509,'TUPAC AMARU INCA',1005)


---DEPARTAMENTO DE JUNIN*/
--Distritos de CHANCHAMAYO
insert into DISTRITO values (110101,'CHANCHAMAYO',1101)
insert into DISTRITO values (110102,'PERENE',1101)
insert into DISTRITO values (110103,'PICHANAQUI',1101)
insert into DISTRITO values (110104,'SAN LUIS DE SHUARO',1101)
insert into DISTRITO values (110105,'SAN RAMON',1101)
insert into DISTRITO values (110106,'VITOC',1101)

--Distritos de CHUPACA
insert into DISTRITO values (110201,'AHUAC',1102)
insert into DISTRITO values (110202,'CHONGOS BAJO',1102)
insert into DISTRITO values (110203,'CHUPACA',1102)
insert into DISTRITO values (110204,'HUACHAC',1102)
insert into DISTRITO values (110205,'HUAMANCACA CHICO',1102)
insert into DISTRITO values (110206,'SAN JUAN DE JARPA',1102)
insert into DISTRITO values (110207,'SAN JUAN DE YSCOS',1102)
insert into DISTRITO values (110208,'TRES DE DICIEMBRE',1102)
insert into DISTRITO values (110209,'YANACANCHA',1102)

--Distritos de CONCEPCION
insert into DISTRITO values (110301,'ACO',1103)
insert into DISTRITO values (110302,'ANDAMARCA',1103)
insert into DISTRITO values (110303,'CHAMBARA',1103)
insert into DISTRITO values (110304,'COCHAS',1103)
insert into DISTRITO values (110305,'COMAS',1103)
insert into DISTRITO values (110306,'CONCEPCION',1103)
insert into DISTRITO values (110307,'HEROINAS TOLEDO',1103)
insert into DISTRITO values (110308,'MANZANARES',1103)
insert into DISTRITO values (110309,'MARISCAL CASTILLA',1103)
insert into DISTRITO values (110310,'MATAHUASI',1103)
insert into DISTRITO values (110311,'MITO',1103)
insert into DISTRITO values (110312,'NUEVE DE JULIO',1103)
insert into DISTRITO values (110313,'ORCOTUNA',1103)
insert into DISTRITO values (110314,'SAN JOSE DE QUERO',1103)
insert into DISTRITO values (110315,'SANTA ROSA DE OCOPA',1103)

--Distritos de HUANCAYO
insert into DISTRITO values (110401,'CARHUACALLANGA',1104)
insert into DISTRITO values (110402,'CHACAPAMPA',1104)
insert into DISTRITO values (110403,'CHICCHE',1104)
insert into DISTRITO values (110404,'CHILCA',1104)
insert into DISTRITO values (110405,'CHONGOS ALTO',1104)
insert into DISTRITO values (110406,'CHUPURO',1104)
insert into DISTRITO values (110407,'COLCA',1104)
insert into DISTRITO values (110408,'CULLHUAS',1104)
insert into DISTRITO values (110409,'EL TAMBO',1104)
insert into DISTRITO values (110410,'HUACRAPUQUIO',1104)
insert into DISTRITO values (110411,'HUALHUAS',1104)
insert into DISTRITO values (110412,'HUANCAN',1104)
insert into DISTRITO values (110413,'HUANCAYO',1104)
insert into DISTRITO values (110414,'HUASICANCHA',1104)
insert into DISTRITO values (110415,'HUAYUCACHI',1104)
insert into DISTRITO values (110416,'INGENIO',1104)
insert into DISTRITO values (110417,'PARIAHUANCA',1104)
insert into DISTRITO values (110418,'PILCOMAYO',1104)
insert into DISTRITO values (110419,'PUCARA',1104)
insert into DISTRITO values (110420,'QUICHUAY',1104)
insert into DISTRITO values (110421,'QUILCAS',1104)
insert into DISTRITO values (110422,'SAN AGUSTIN',1104)
insert into DISTRITO values (110423,'SAN JERONIMO DE TUNAN',1104)
insert into DISTRITO values (110424,'SAÑO',1104)
insert into DISTRITO values (110425,'SANTO DOMINGO DE ACOBAMBA',1104)
insert into DISTRITO values (110426,'SAPALLANGA',1104)
insert into DISTRITO values (110427,'SICAYA',1104)
insert into DISTRITO values (110428,'VIQUES',1104)

--Distritos de JAUJA
insert into DISTRITO values (110501,'ACOLLA',1105)
insert into DISTRITO values (110502,'APATA',1105)
insert into DISTRITO values (110503,'ATAURA',1105)
insert into DISTRITO values (110504,'CANCHAYLLO',1105)
insert into DISTRITO values (110505,'CURICACA',1105)
insert into DISTRITO values (110506,'EL MANTARO',1105)
insert into DISTRITO values (110507,'HUAMALI',1105)
insert into DISTRITO values (110508,'HUARIPAMPA',1105)
insert into DISTRITO values (110509,'HUERTAS',1105)
insert into DISTRITO values (110510,'JANJAILLO',1105)
insert into DISTRITO values (110511,'JAUJA',1105)
insert into DISTRITO values (110512,'JULCAN',1105)
insert into DISTRITO values (110513,'LEONOR ORDOÑEZ',1105)
insert into DISTRITO values (110514,'LLOCLLAPAMPA',1105)
insert into DISTRITO values (110515,'MARCO',1105)
insert into DISTRITO values (110516,'MASMA',1105)
insert into DISTRITO values (110517,'MASMA CHICCHE',1105)
insert into DISTRITO values (110518,'MOLINOS',1105)
insert into DISTRITO values (110519,'MONOBAMBA',1105)
insert into DISTRITO values (110520,'MUQUI',1105)
insert into DISTRITO values (110521,'MUQUIYAUYO',1105)
insert into DISTRITO values (110522,'PACA',1105)
insert into DISTRITO values (110523,'PACCHA',1105)
insert into DISTRITO values (110524,'PANCAN',1105)
insert into DISTRITO values (110525,'PARCO',1105)
insert into DISTRITO values (110526,'POMACANCHA',1105)
insert into DISTRITO values (110527,'RICRAN',1105)
insert into DISTRITO values (110528,'SAN LORENZO',1105)
insert into DISTRITO values (110529,'SAN PEDRO DE CHUNAN',1105)
insert into DISTRITO values (110530,'SAUSA',1105)
insert into DISTRITO values (110531,'SINCOS',1105)
insert into DISTRITO values (110532,'TUNAN MARCA',1105)
insert into DISTRITO values (110533,'YAULI',1105)
insert into DISTRITO values (110534,'YAUYOS',1105)

--Distritos de JUNIN
insert into DISTRITO values (110601,'CARHUAMAYO',1106)
insert into DISTRITO values (110602,'JUNIN',1106)
insert into DISTRITO values (110603,'ONDORES',1106)
insert into DISTRITO values (110604,'ULCUMAYO',1106)

--Distritos de SATIPO
insert into DISTRITO values (110701,'COVIRIALI',1107)
insert into DISTRITO values (110702,'LLAYLLA',1107)
insert into DISTRITO values (110703,'MAZAMARI',1107)
insert into DISTRITO values (110704,'PAMPA HERMOSA',1107)
insert into DISTRITO values (110705,'PANGOA',1107)
insert into DISTRITO values (110706,'RIO NEGRO',1107)
insert into DISTRITO values (110707,'RIO TAMBO',1107)
insert into DISTRITO values (110708,'SATIPO',1107)

--Distritos de TARMA
insert into DISTRITO values (110801,'ACOBAMBA',1108)
insert into DISTRITO values (110802,'HUARICOLCA',1108)
insert into DISTRITO values (110803,'HUASAHUASI',1108)
insert into DISTRITO values (110804,'LA UNION',1108)
insert into DISTRITO values (110805,'PALCA',1108)
insert into DISTRITO values (110806,'PALCAMAYO',1108)
insert into DISTRITO values (110807,'SAN PEDRO DE CAJAS',1108)
insert into DISTRITO values (110808,'TAPO',1108)
insert into DISTRITO values (110809,'TARMA',1108)

--Distritos de YAULI
insert into DISTRITO values (110901,'CHACAPALPA',1109)
insert into DISTRITO values (110902,'HUAY-HUAY',1109)
insert into DISTRITO values (110903,'LA OROYA',1109)
insert into DISTRITO values (110904,'MARCAPOMACOCHA',1109)
insert into DISTRITO values (110905,'MOROCOCHA',1109)
insert into DISTRITO values (110906,'PACCHA',1109)
insert into DISTRITO values (110907,'SANTA BARBARA DE CARHUACAYAN',1109)
insert into DISTRITO values (110908,'SANTA ROSA DE SACCO',1109)
insert into DISTRITO values (110909,'SUITUCANCHA',1109)
insert into DISTRITO values (110910,'YAULI',1109)




---DEPARTAMENTO DE LAMBAYEQUE*/
--Distritos de CHICLAYO
insert into DISTRITO values (120101,'CAYALTI',1202)
insert into DISTRITO values (120102,'CHICLAYO',1202)
insert into DISTRITO values (120103,'CHONGOYAPE',1202)
insert into DISTRITO values (120104,'ETEN',1202)
insert into DISTRITO values (120105,'ETEN PUERTO',1202)
insert into DISTRITO values (120106,'JOSE LEONARDO ORTIZ',1202)
insert into DISTRITO values (120107,'LA VICTORIA',1202)
insert into DISTRITO values (120108,'LAGUNAS',1202)
insert into DISTRITO values (120109,'MOSEFU',1202)
insert into DISTRITO values (120110,'NUEVA ARICA',1202)
insert into DISTRITO values (120111,'OYOTUN',1202)
insert into DISTRITO values (120112,'PATAPO',1202)
insert into DISTRITO values (120113,'PICSI',1202)
insert into DISTRITO values (120114,'PIMENTEL',1202)
insert into DISTRITO values (120115,'POMALCA',1202)
insert into DISTRITO values (120116,'PUCALA',1202)
insert into DISTRITO values (120117,'REQUE',1202)
insert into DISTRITO values (120118,'ZAÑA',1202)
insert into DISTRITO values (120119,'SANTA ROSA',1202)
insert into DISTRITO values (120120,'TUMAN',1202)

--Distritos de FERREÑAFE
insert into DISTRITO values (120201,'CAÑARIS',1202)
insert into DISTRITO values (120202,'FERREÑAFE',1202)
insert into DISTRITO values (120203,'INCAHUASI',1202)
insert into DISTRITO values (120204,'MANUEL ANTONIO MESONES MURO',1202)
insert into DISTRITO values (120205,'PITIPO',1202)
insert into DISTRITO values (120206,'PUEBLO NUEVO',1202)

--Distritos de LAMBAYEQUE
insert into DISTRITO values (120301,'CHOCHOPE',1203)
insert into DISTRITO values (120302,'ILLIMO',1203)
insert into DISTRITO values (120303,'JAYANCA',1203)
insert into DISTRITO values (120304,'LAMBAYEQUE',1203)
insert into DISTRITO values (120305,'MOCHUMI',1203)
insert into DISTRITO values (120306,'MORROPE',1203)
insert into DISTRITO values (120307,'MOTUPE',1203)
insert into DISTRITO values (120308,'OLMOS',1203)
insert into DISTRITO values (120309,'PACORA',1203)
insert into DISTRITO values (120310,'SALAS',1203)
insert into DISTRITO values (120311,'SAN JOSE',1203)
insert into DISTRITO values (120312,'TUCUME',1203)





---DEPARTAMENTO DE LA LIBERTAD*/
--Distritos de ASCOPE
insert into DISTRITO values (130101,'ASCOPE',1301)
insert into DISTRITO values (130102,'CASA GRANDE',1301)
insert into DISTRITO values (130103,'CHICAMA',1301)
insert into DISTRITO values (130104,'CHOCOPE',1301)
insert into DISTRITO values (130105,'MAGDALENA DE CAO',1301)
insert into DISTRITO values (130106,'PAIJAN',1301)
insert into DISTRITO values (130107,'RAZURI',1301)
insert into DISTRITO values (130108,'SANTIAGO DE CAO',1301)

--Distritos de BOLIVAR
insert into DISTRITO values (130201,'BAMBAMARCA',1302)
insert into DISTRITO values (130202,'BOLIVAR',1302)
insert into DISTRITO values (130203,'CONDORMARCA',1302)
insert into DISTRITO values (130204,'LONGOTEA',1302)
insert into DISTRITO values (130205,'UCHUMARCA',1302)
insert into DISTRITO values (130206,'UCUNCHA',1302)

--Distritos de CHEPEN
insert into DISTRITO values (130301,'CHEPEN',1303)
insert into DISTRITO values (130302,'PACANGA',1303)
insert into DISTRITO values (130303,'PUEBLO NUEVO',1303)

--Distritos de GRAN CHIMU
insert into DISTRITO values (130401,'CASCAS',1304)
insert into DISTRITO values (130402,'LUCMA',1304)
insert into DISTRITO values (130403,'MARMOT',1304)
insert into DISTRITO values (130404,'SAYAPULLO',1304)

--Distritos de JULCAN 
insert into DISTRITO values (130501,'CALAMARCA',1305)
insert into DISTRITO values (130502,'CARABAMBA',1305)
insert into DISTRITO values (130503,'HUASO',1305)
insert into DISTRITO values (130504,'JULCAN',1305)

--Distritos de OTUZCO
insert into DISTRITO values (130601,'AGALLPAMPA',1306)
insert into DISTRITO values (130602,'CHARAT',1306)
insert into DISTRITO values (130603,'HUARANCHAL',1306)
insert into DISTRITO values (130604,'LA CUESTA',1306)
insert into DISTRITO values (130605,'MACHE',1306)
insert into DISTRITO values (130606,'OTUZCO',1306)
insert into DISTRITO values (130607,'PARANDAY',1306)
insert into DISTRITO values (130608,'SALPO',1306)
insert into DISTRITO values (130609,'SINSICAP',1306)
insert into DISTRITO values (130610,'USQUILL',1306)

--Distritos de PACASMAYO
insert into DISTRITO values (130701,'GUADALUPE',1307)
insert into DISTRITO values (130702,'JEQUETEPEQUE',1307)
insert into DISTRITO values (130703,'PACASMAYO',1307)
insert into DISTRITO values (130704,'SAN JOSE',1307)
insert into DISTRITO values (130705,'SAN PEDRO DE LLOC',1307)

--Distritos de PATAZ
insert into DISTRITO values (130801,'BULDIBUYO',1308)
insert into DISTRITO values (130802,'CHILLIA',1308)
insert into DISTRITO values (130803,'HUANCASPATA',1308)
insert into DISTRITO values (130804,'HUAYLILLAS',1308)
insert into DISTRITO values (130805,'HUAYO',1308)
insert into DISTRITO values (130806,'ONGON',1308)
insert into DISTRITO values (130807,'PARCOY',1308)
insert into DISTRITO values (130808,'PATAZ',1308)
insert into DISTRITO values (130809,'PIAS',1308)
insert into DISTRITO values (130810,'SANTIAGO DE CHALLAS',1308)
insert into DISTRITO values (130811,'TAURIJA',1308)
insert into DISTRITO values (130812,'TAYABAMBA',1308)
insert into DISTRITO values (130813,'URPAY',1308)

--Distritos de SANCHEZ CARRION
insert into DISTRITO values (130901,'CHUGAY',1309)
insert into DISTRITO values (130902,'COCHORCO',1309)
insert into DISTRITO values (130903,'CURGOS',1309)
insert into DISTRITO values (130904,'HUAMACHUCO',1309)
insert into DISTRITO values (130905,'MARCABAL',1309)
insert into DISTRITO values (130906,'SANAGORAN',1309)
insert into DISTRITO values (130907,'SARIN',1309)
insert into DISTRITO values (130908,'SARTIMBAMBA',1309)

--Distritos de SANTIAGO DE CHUCO
insert into DISTRITO values (131001,'ANGASMARCA',1310)
insert into DISTRITO values (131002,'CACHICADAN',1310)
insert into DISTRITO values (131003,'MOLLEBAMBA',1310)
insert into DISTRITO values (131004,'MOLLEPATA',1310)
insert into DISTRITO values (131005,'QUIRUVILCA',1310)
insert into DISTRITO values (131006,'SANTA CRUZ DE CHUCA',1310)
insert into DISTRITO values (131007,'SANTIAGO DE CHUCO',1310)
insert into DISTRITO values (131008,'SITABAMBA',1310)

--Distritos de TRUJILLO
insert into DISTRITO values (131101,'EL PORVENIR',1311)
insert into DISTRITO values (131102,'FLORENCIA DE MORA',1311)
insert into DISTRITO values (131103,'HUANCHACO',1311)
insert into DISTRITO values (131104,'LA ESPERANZA',1311)
insert into DISTRITO values (131105,'LAREDO',1311)
insert into DISTRITO values (131106,'MOCHE',1311)
insert into DISTRITO values (131107,'POROTO',1311)
insert into DISTRITO values (131108,'SALAVERRY',1311)
insert into DISTRITO values (131109,'SIMBAL',1311)
insert into DISTRITO values (131110,'TRUJILLO',1311)
insert into DISTRITO values (131111,'VICTOR LARCO HERRERA',1311)

--Distritos de VIRU
insert into DISTRITO values (131201,'CHAO',1312)
insert into DISTRITO values (131202,'GUADALUPITO',1312)
insert into DISTRITO values (131203,'VIRU',1312)





---DEPARTAMENTO DE LIMA*/
--Distritos de BARRANCA
insert into DISTRITO values (140101,'BARRANCA',1401)
insert into DISTRITO values (140102,'PARAMONGA',1401)
insert into DISTRITO values (140103,'PATIVILCA',1401)
insert into DISTRITO values (140104,'SUPE',1401)
insert into DISTRITO values (140105,'SUPE PUERTO',1401)

--Distritos de CAJATAMBO
insert into DISTRITO values (140201,'CAJATAMBO',1402)
insert into DISTRITO values (140202,'COPA',1402)
insert into DISTRITO values (140203,'GORGOR',1402)
insert into DISTRITO values (140204,'HUANCAPON',1402)
insert into DISTRITO values (140205,'MANAS',1402)

--Distritos de CANTA
insert into DISTRITO values (140301,'ARAHUAY',1403)
insert into DISTRITO values (140302,'CANTA',1403)
insert into DISTRITO values (140303,'HUAMANTANGA',1403)
insert into DISTRITO values (140304,'HUAROS',1403)
insert into DISTRITO values (140305,'LACHAQUI',1403)
insert into DISTRITO values (140306,'SAN BUENAVENTURA',1403)
insert into DISTRITO values (140307,'SANTA ROSA DE QUIVES',1403)

--Distritos de CAÑETE
insert into DISTRITO values (140401,'ASIA',1404)
insert into DISTRITO values (140402,'CALANGO',1404)
insert into DISTRITO values (140403,'CERRO AZUL',1404)
insert into DISTRITO values (140404,'CHILCA',1404)
insert into DISTRITO values (140405,'COAYLLO',1404)
insert into DISTRITO values (140406,'IMPERIAL',1404)
insert into DISTRITO values (140407,'LUNAHUANA',1404)
insert into DISTRITO values (140408,'MALA',1404)
insert into DISTRITO values (140409,'NUEVO IMPERIAL',1404)
insert into DISTRITO values (140410,'PACARAN',1404)
insert into DISTRITO values (140411,'QUILMANA',1404)
insert into DISTRITO values (140412,'SAN ANTONIO',1404)
insert into DISTRITO values (140413,'SAN LUIS',1404)
insert into DISTRITO values (140414,'SAN VICENTE DE CAÑETE',1404)
insert into DISTRITO values (140415,'SANTA CRUZ DE FLORES',1404)
insert into DISTRITO values (140416,'ZUÑIGA',1404)

--Distritos de HUARAL
insert into DISTRITO values (140501,'ATAVILLOS ALTO',1405)
insert into DISTRITO values (140502,'ATAVILLOS BAJO',1405)
insert into DISTRITO values (140503,'AUCALLAMA',1405)
insert into DISTRITO values (140504,'CHANCAY',1405)
insert into DISTRITO values (140505,'HUARAL',1405)
insert into DISTRITO values (140506,'IHUARI',1405)
insert into DISTRITO values (140507,'LAMPIAN',1405)
insert into DISTRITO values (140508,'PACARAOS',1405)
insert into DISTRITO values (140509,'SAN MIGUEL DE ACOS',1405)
insert into DISTRITO values (140510,'SANTA CRUZ DE ANDAMARCA',1405)
insert into DISTRITO values (140511,'SUMBILCA',1405)
insert into DISTRITO values (140512,'VEINTISIETE DE NOVIEMBRE',1405)

--Distritos de HUAROCHIRI
insert into DISTRITO values (140601,'ANTIOQUIA',1406)
insert into DISTRITO values (140602,'CALLAHUANCA',1406)
insert into DISTRITO values (140603,'CARAMPOMA',1406)
insert into DISTRITO values (140604,'CHICLA',1406)
insert into DISTRITO values (140605,'CUENCA',1406)
insert into DISTRITO values (140606,'HUACHUPAMPA',1406)
insert into DISTRITO values (140607,'HUANZA',1406)
insert into DISTRITO values (140608,'HUAROCHIRI',1406)
insert into DISTRITO values (140609,'LAHUAYTAMBO',1406)
insert into DISTRITO values (140610,'LANGA',1406)
insert into DISTRITO values (140611,'LARAOS',1406)
insert into DISTRITO values (140612,'MARIATANA',1406)
insert into DISTRITO values (140613,'MATUCANA',1406)
insert into DISTRITO values (140614,'RICARDO PALMA',1406)
insert into DISTRITO values (140615,'SAN ANDRES DE TUPICOCHA',1406)
insert into DISTRITO values (140616,'SAN ANTONIO',1406)
insert into DISTRITO values (140617,'SAN BARTOLOME',1406)
insert into DISTRITO values (140618,'SAN DAMIAN',1406)
insert into DISTRITO values (140619,'SAN JUAN DE IRIS',1406)
insert into DISTRITO values (140620,'SAN JUAN DE TANTARANCHE',1406)
insert into DISTRITO values (140621,'SAN LORENZO DE QUINTI',1406)
insert into DISTRITO values (140622,'SAN MATEO',1406)
insert into DISTRITO values (140623,'SAN MATEO DE OTAO',1406)
insert into DISTRITO values (140624,'SAN PEDRO DE CASTA',1406)
insert into DISTRITO values (140625,'SAN PEDRO DE HUANCAYRE',1406)
insert into DISTRITO values (140626,'SANGALLAYA',1406)
insert into DISTRITO values (140627,'SANTA CRUZ DE COCACHACRA',1406)
insert into DISTRITO values (140628,'SANTA EULALIA',1406)
insert into DISTRITO values (140629,'SANTIAGO DE ANCHUCAYA',1406)
insert into DISTRITO values (140630,'SANTIAGO DE TUNA',1406)
insert into DISTRITO values (140631,'SANTO DOMINGO DE LOS OLLEROS',1406)
insert into DISTRITO values (140632,'SURCO',1406)

--Distritos de HUAURA
insert into DISTRITO values (140701,'AMBAR',1407)
insert into DISTRITO values (140702,'CALETA DE CARQUIN',1407)
insert into DISTRITO values (140703,'CHECRAS',1407)
insert into DISTRITO values (140704,'HUACHO',1407)
insert into DISTRITO values (140705,'HUALMAY',1407)
insert into DISTRITO values (140706,'HUAURA',1407)
insert into DISTRITO values (140707,'LEONCIO PRADO',1407)
insert into DISTRITO values (140708,'PACCHO',1407)
insert into DISTRITO values (140709,'SANTA LEONOR',1407)
insert into DISTRITO values (140710,'SANTA MARIA',1407)
insert into DISTRITO values (140711,'SAYAN',1407)
insert into DISTRITO values (140712,'VEGUETA',1407)

--Distritos de LIMA
insert into DISTRITO values (140801,'ANCON',1408)
insert into DISTRITO values (140802,'ATE',1408)
insert into DISTRITO values (140803,'BARRANCO',1408)
insert into DISTRITO values (140804,'BREÑA',1408)
insert into DISTRITO values (140805,'CARABAYLLO',1408)
insert into DISTRITO values (140806,'CHACLACAYO',1408)
insert into DISTRITO values (140807,'CHORRILLOS',1408)
insert into DISTRITO values (140808,'CIENEGUILLA',1408)
insert into DISTRITO values (140809,'COMAS',1408)
insert into DISTRITO values (140810,'EL AGUSTINO',1408)
insert into DISTRITO values (140811,'INDEPENDENCIA',1408)
insert into DISTRITO values (140812,'JESUS MARIA',1408)
insert into DISTRITO values (140813,'LA MOLINA',1408)
insert into DISTRITO values (140814,'LA VICTORIA',1408)
insert into DISTRITO values (140815,'LIMA',1408)
insert into DISTRITO values (140816,'LINCE',1408)
insert into DISTRITO values (140817,'LOS OLIVOS',1408)
insert into DISTRITO values (140818,'LURIGANCHO',1408)
insert into DISTRITO values (140819,'LURIN',1408)
insert into DISTRITO values (140820,'MAGDALENA DEL MAR',1408)
insert into DISTRITO values (140821,'MAGDALENA VIEJA',1408)
insert into DISTRITO values (140822,'MIRAFLORES',1408)
insert into DISTRITO values (140823,'PACHACAMAC',1408)
insert into DISTRITO values (140824,'PUCUSANA',1408)
insert into DISTRITO values (140825,'PUENTE PIEDRA',1408)
insert into DISTRITO values (140826,'PUNTA HERMOSA',1408)
insert into DISTRITO values (140827,'PUNTA NEGRA',1408)
insert into DISTRITO values (140828,'RIMAC',1408)
insert into DISTRITO values (140829,'SAN BARTOLO',1408)
insert into DISTRITO values (140830,'SAN BORJA',1408)
insert into DISTRITO values (140831,'SAN ISIDRO',1408)
insert into DISTRITO values (140832,'SAN JUAN DE LURIGANCHO',1408)
insert into DISTRITO values (140833,'SAN JUAN DE MIRAFLORES',1408)
insert into DISTRITO values (140834,'SAN LUIS',1408)
insert into DISTRITO values (140835,'SAN MARTIN DE PORRES',1408)
insert into DISTRITO values (140836,'SAN MIGUEL',1408)
insert into DISTRITO values (140837,'SANTA ANITA',1408)
insert into DISTRITO values (140838,'SANTA MARIA DEL MAR',1408)
insert into DISTRITO values (140839,'SANTA ROSA',1408)
insert into DISTRITO values (140840,'SANTIAGO DE SURCO',1408)
insert into DISTRITO values (140841,'SURQUILLO',1408)
insert into DISTRITO values (140842,'VILLA EL SALVADOR',1408)
insert into DISTRITO values (140843,'VILLA MARIA DEL TRIUNFO',1408)

--Distritos de OYON
insert into DISTRITO values (140901,'ANDAJES',1409)
insert into DISTRITO values (140902,'CAUJUL',1409)
insert into DISTRITO values (140903,'COCHAMARCA',1409)
insert into DISTRITO values (140904,'NAVAN',1409)
insert into DISTRITO values (140905,'OYON',1409)
insert into DISTRITO values (140906,'PACHANGARA',1409)

--Distritos de YAUYOS
insert into DISTRITO values (141001,'ALIS',1410)
insert into DISTRITO values (141002,'AYAUCA',1410)
insert into DISTRITO values (141003,'AYAVIRI',1410)
insert into DISTRITO values (141004,'AZANGARO',1410)
insert into DISTRITO values (141005,'CACRA',1410)
insert into DISTRITO values (141006,'CARANIA',1410)
insert into DISTRITO values (141007,'CATAHUASI',1410)
insert into DISTRITO values (141008,'CHOCOS',1410)
insert into DISTRITO values (141009,'COCHAS',1410)
insert into DISTRITO values (141010,'COLONIA',1410)
insert into DISTRITO values (141011,'HONGOS',1410)
insert into DISTRITO values (141012,'HUAMPARA',1410)
insert into DISTRITO values (141013,'HUANCAYA',1410)
insert into DISTRITO values (141014,'HUAÑEC',1410)
insert into DISTRITO values (141015,'HUANGASCAR',1410)
insert into DISTRITO values (141016,'HUANTAN',1410)
insert into DISTRITO values (141017,'LARAOS',1410)
insert into DISTRITO values (141018,'LINCHA',1410)
insert into DISTRITO values (141019,'MADEAN',1410)
insert into DISTRITO values (141020,'MIRAFLORES',1410)
insert into DISTRITO values (141021,'OMAS',1410)
insert into DISTRITO values (141022,'PUTINZA',1410)
insert into DISTRITO values (141023,'QUINCHES',1410)
insert into DISTRITO values (141024,'QUINOCAY',1410)
insert into DISTRITO values (141025,'SAN JOAQUIN',1410)
insert into DISTRITO values (141026,'SAN PEDRO DE PILAS',1410)
insert into DISTRITO values (141027,'TANTA',1410)
insert into DISTRITO values (141028,'TAURIPAMPA',1410)
insert into DISTRITO values (141029,'TOMAS',1410)
insert into DISTRITO values (141030,'TUPE',1410)
insert into DISTRITO values (141031,'VIÑAC',1410)
insert into DISTRITO values (141032,'VITIS',1410)
insert into DISTRITO values (141033,'YAUYOS',1410)



---DEPARTAMENTO DE LORETO*/
--Distritos de ALTO AMAZONAS
insert into DISTRITO values (150101,'BALSAPUERTO',1501)
insert into DISTRITO values (150102,'BARRANCA',1501)
insert into DISTRITO values (150103,'CAHUAPANAS',1501)
insert into DISTRITO values (150104,'JEBEROS',1501)
insert into DISTRITO values (150105,'LAGUNAS',1501)
insert into DISTRITO values (150106,'MANSERICHE',1501)
insert into DISTRITO values (150107,'MORONA',1501)
insert into DISTRITO values (150108,'PASTAZA',1501)
insert into DISTRITO values (150109,'SANTA CRUZ',1501)
insert into DISTRITO values (150110,'TENIENTE CESAR LOPEZ ROJAS',1501)
insert into DISTRITO values (150111,'YURIMAGUAS',1501)

--Distritos de LORETO
insert into DISTRITO values (150201,'NAUTA',1502)
insert into DISTRITO values (150202,'PARINARI',1502)
insert into DISTRITO values (150203,'TIGRE',1502)
insert into DISTRITO values (150204,'TROMPETEROS',1502)
insert into DISTRITO values (150205,'URARINAS',1502)

--Distritos de MARISCAL RAMON CASTILLA
insert into DISTRITO values (150301,'PEBAS',1503)
insert into DISTRITO values (150302,'RAMON CASTILLA',1503)
insert into DISTRITO values (150303,'SAN PABLO',1503)
insert into DISTRITO values (150304,'YAVARI',1503)

--Distritos de MAYNAS
insert into DISTRITO values (150401,'ALTO NANAY',1504)
insert into DISTRITO values (150402,'BELEN',1504)
insert into DISTRITO values (150403,'FERNANDO LORES',1504)
insert into DISTRITO values (150404,'INDIANA',1504)
insert into DISTRITO values (150405,'IQUITOS',1504)
insert into DISTRITO values (150406,'LAS AMAZONAS',1504)
insert into DISTRITO values (150407,'MAZAN',1504)
insert into DISTRITO values (150408,'NAPO',1504)
insert into DISTRITO values (150409,'PUNCHANA',1504)
insert into DISTRITO values (150410,'PUTUMAYO',1504)
insert into DISTRITO values (150411,'SAN JUAN BAUTISTA',1504)
insert into DISTRITO values (150412,'TENIENTE MANUEL CLAVERO',1504)
insert into DISTRITO values (150413,'TORRES CAUSANA',1504)

--Distritos de REQUENA
insert into DISTRITO values (150501,'ALTO TAPICHE',1505)
insert into DISTRITO values (150502,'CAPELO',1505)
insert into DISTRITO values (150503,'EMILIO SAN MARTIN',1505)
insert into DISTRITO values (150504,'JENARO HERRERA',1505)
insert into DISTRITO values (150505,'MAQUIA',1505)
insert into DISTRITO values (150506,'PUINAHUA',1505)
insert into DISTRITO values (150507,'REQUENA',1505)
insert into DISTRITO values (150508,'SAQUENA',1505)
insert into DISTRITO values (150509,'SOPLIN',1505)
insert into DISTRITO values (150510,'TAPICHE',1505)
insert into DISTRITO values (150511,'YAQUERANA',1505)

--Distritos de UCAYALI
insert into DISTRITO values (150601,'CONTAMANA',1506)
insert into DISTRITO values (150602,'INAHUAYA',1506)
insert into DISTRITO values (150603,'PADRE MARQUEZ',1506)
insert into DISTRITO values (150604,'PAMPA HERMOSA',1506)
insert into DISTRITO values (150605,'SARAYACU',1506)
insert into DISTRITO values (150606,'VARGAS GUERRA',1506)



---DEPARTAMENTO DE MADRE DE DIOS*/
--Distritos de MANU
insert into DISTRITO values (160101,'FITZCARRALD',1601)
insert into DISTRITO values (160102,'HUEPETUHE',1601)
insert into DISTRITO values (160103,'MADRE DE DIOS',1601)
insert into DISTRITO values (160104,'MANU',1601)

--Distritos de TAHUAMANU
insert into DISTRITO values (160201,'IBERIA',1602)
insert into DISTRITO values (160202,'IÑAPARI',1602)
insert into DISTRITO values (160203,'TAHUAMANU',1602)

--Distritos de TAMBOPATA
insert into DISTRITO values (160301,'INAMBARI',1603)
insert into DISTRITO values (160302,'LABERINTO',1603)
insert into DISTRITO values (160303,'LAS PIEDRAS',1603)
insert into DISTRITO values (160304,'TAMBOPATA',1603)



---DEPARTAMENTO DE MOQUEGUA*/
--Distritos de GENERAL SANCHEZ CERRO
insert into DISTRITO values (170101,'COALAQUE',1701)
insert into DISTRITO values (170102,'ICHUÑA',1701)
insert into DISTRITO values (170103,'LA CAPILLA',1701)
insert into DISTRITO values (170104,'LLOQUE',1701)
insert into DISTRITO values (170105,'MATALAQUE',1701)
insert into DISTRITO values (170106,'OMATE',1701)
insert into DISTRITO values (170107,'PUQUINA',1701)
insert into DISTRITO values (170108,'QUINISTAQUILLAS',1701)
insert into DISTRITO values (170109,'UBINAS',1701)
insert into DISTRITO values (170110,'YUNGA',1701)

--Distritos de ILO
insert into DISTRITO values (170201,'EL ALGARROBAL',1702)
insert into DISTRITO values (170202,'ILO',1702)
insert into DISTRITO values (170203,'PACOCHA',1702)

--Distritos de MARISCAL NIETO
insert into DISTRITO values (170301,'CARUMAS',1703)
insert into DISTRITO values (170302,'CUCHUMBAYA',1703)
insert into DISTRITO values (170303,'MOQUEGUA',1703)
insert into DISTRITO values (170304,'SAMEGUA',1703)
insert into DISTRITO values (170305,'SAN CRISTOBAL',1703)
insert into DISTRITO values (170306,'TORATA',1703)


---DEPARTAMENTO DE PASCO*/
--Distritos de DANIEL CARRION
insert into DISTRITO values (180101,'CHACAYAN',1801)
insert into DISTRITO values (180102,'GOYLLARISQUIZGA',1801)
insert into DISTRITO values (180103,'PAUCAR',1801)
insert into DISTRITO values (180104,'SAN PEDRO DE PILLAO',1801)
insert into DISTRITO values (180105,'SANTA ANA DE TUSI',1801)
insert into DISTRITO values (180106,'TAPUC',1801)
insert into DISTRITO values (180107,'VILCABAMBA',1801)
insert into DISTRITO values (180108,'YANAHUANCA',1801)

--Distritos de OXAPAMPA
insert into DISTRITO values (180201,'CHONTABAMBA',1802)
insert into DISTRITO values (180202,'HUANCABAMBA',1802)
insert into DISTRITO values (180203,'OXAPAMPA',1802)
insert into DISTRITO values (180204,'PALCAZU',1802)
insert into DISTRITO values (180205,'POZUZO',1802)
insert into DISTRITO values (180206,'PUERTO BERMUDEZ',1802)
insert into DISTRITO values (180207,'VILLA RICA',1802)

--Distritos de PASCO
insert into DISTRITO values (180301,'CHAUPIMARCA',1803)
insert into DISTRITO values (180302,'HUACHON',1803)
insert into DISTRITO values (180303,'HUARIACA',1803)
insert into DISTRITO values (180304,'HUAYLLAY',1803)
insert into DISTRITO values (180305,'NINACACA',1803)
insert into DISTRITO values (180306,'PALLANCHACRA',1803)
insert into DISTRITO values (180307,'PAUCARTAMBO',1803)
insert into DISTRITO values (180308,'SAN FRANCISCO DE ASIS DE YARUSYACAN',1803)
insert into DISTRITO values (180309,'SIMON BOLIVAR',1803)
insert into DISTRITO values (180310,'TICLACAYAN',1803)
insert into DISTRITO values (180311,'TINYAHUARCO',1803)
insert into DISTRITO values (180312,'VICCO',1803)
insert into DISTRITO values (180313,'YANACANCHA',1803)




---DEPARTAMENTO de PIURA*/
--Distritos de AYABACA
insert into DISTRITO values (190101,'AYABACA',1901)
insert into DISTRITO values (190102,'FRIAS',1901)
insert into DISTRITO values (190103,'JILILI',1901)
insert into DISTRITO values (190104,'LAGUNAS',1901)
insert into DISTRITO values (190105,'MONTERO',1901)
insert into DISTRITO values (190106,'PACAIPAMPA',1901)
insert into DISTRITO values (190107,'PAIMAS',1901)
insert into DISTRITO values (190108,'SAPILLICA',1901)
insert into DISTRITO values (190109,'SICCHEZ',1901)
insert into DISTRITO values (190110,'SUYO',1901)

--Distritos de HUANCABAMBA
insert into DISTRITO values (190201,'CANCHAQUE',1902)
insert into DISTRITO values (190202,'EL CARMEN DE LA FRONTERA',1902)
insert into DISTRITO values (190203,'HUANCABAMBA',1902)
insert into DISTRITO values (190204,'HUARMACA',1902)
insert into DISTRITO values (190205,'LALAQUIZ',1902)
insert into DISTRITO values (190206,'SAN MIGUEL DE EL FAIQUE',1902)
insert into DISTRITO values (190207,'SONDOR',1902)
insert into DISTRITO values (190208,'SONDORILLO',1902)

--Distritos de MORROPON
insert into DISTRITO values (190301,'BUENOS AIRES',1903)
insert into DISTRITO values (190302,'CHALACO',1903)
insert into DISTRITO values (190303,'CHULUCANAS',1903)
insert into DISTRITO values (190304,'LA MATANZA',1903)
insert into DISTRITO values (190305,'MORROPON',1903)
insert into DISTRITO values (190306,'SALITRAL',1903)
insert into DISTRITO values (190307,'SAN JUAN DE BIGOTE',1903)
insert into DISTRITO values (190308,'SANTA CATALINA DE MOSSA',1903)
insert into DISTRITO values (190309,'SANTO DOMINGO',1903)
insert into DISTRITO values (190310,'YAMANGO',1903)

--Distritos de PAITA
insert into DISTRITO values (190401,'AMOTAPE',1904)
insert into DISTRITO values (190402,'ARENAL',1904)
insert into DISTRITO values (190403,'COLAN',1904)
insert into DISTRITO values (190404,'LA HUACA',1904)
insert into DISTRITO values (190405,'PAITA',1904)
insert into DISTRITO values (190406,'TAMARINDO',1904)
insert into DISTRITO values (190407,'VICHAYAL',1904)

--Distritos de PIURA
insert into DISTRITO values (190501,'CASTILLA',1905)
insert into DISTRITO values (190502,'CATACAOS',1905)
insert into DISTRITO values (190503,'CURA MORI',1905)
insert into DISTRITO values (190504,'EL TALLAN',1905)
insert into DISTRITO values (190505,'LA ARENA',1905)
insert into DISTRITO values (190506,'LA UNION',1905)
insert into DISTRITO values (190507,'LAS LOMAS',1905)
insert into DISTRITO values (190508,'PIURA',1905)
insert into DISTRITO values (190509,'TAMBO GRANDE',1905)

--Distritos de SECHURA
insert into DISTRITO values (190601,'BELLAVISTA DE LA UNION',1906)
insert into DISTRITO values (190602,'BERNAL',1906)
insert into DISTRITO values (190603,'CRISTO NOS VALGA',1906)
insert into DISTRITO values (190604,'RINCONADA LLICUAR',1906)
insert into DISTRITO values (190605,'SECHURA',1906)
insert into DISTRITO values (190606,'VICE',1906)

--Distritos de SULLANA
insert into DISTRITO values (190701,'BELLAVISTA',1907)
insert into DISTRITO values (190702,'IGNACIO ESCUDERO',1907)
insert into DISTRITO values (190703,'LANCONES',1907)
insert into DISTRITO values (190704,'MARCAVELICA',1907)
insert into DISTRITO values (190705,'MIGUEL CHECA',1907)
insert into DISTRITO values (190706,'QUERECOTILLO',1907)
insert into DISTRITO values (190707,'SALITRAL',1907)
insert into DISTRITO values (190708,'SULLANA',1907)

--Distritos de TALARA
insert into DISTRITO values (190801,'EL ALTO',1908)
insert into DISTRITO values (190802,'LA BREA',1908)
insert into DISTRITO values (190803,'LOBITOS',1908)
insert into DISTRITO values (190804,'LOS ORGANOS',1908)
insert into DISTRITO values (190805,'MANCORA',1908)
insert into DISTRITO values (190806,'PARIÑAS',1908)




---DEPARTAMENTO DE PUNO*/
--Distritos de AZANGARO
insert into DISTRITO values (200101,'ACHAYA',2001)
insert into DISTRITO values (200102,'ARAPA',2001)
insert into DISTRITO values (200103,'ASILLO',2001)
insert into DISTRITO values (200104,'AZANGARO',2001)
insert into DISTRITO values (200105,'CAMINACA',2001)
insert into DISTRITO values (200106,'CHUPA',2001)
insert into DISTRITO values (200107,'JOSE DOMINGO CHOQUEHUANCA',2001)
insert into DISTRITO values (200108,'MUÑANI',2001)
insert into DISTRITO values (200109,'POTONI',2001)
insert into DISTRITO values (200110,'SAMAN',2001)
insert into DISTRITO values (200111,'SAN ANTON',2001)
insert into DISTRITO values (200112,'SAN JOSE',2001)
insert into DISTRITO values (200113,'SAN JUAN DE SALINAS',2001)
insert into DISTRITO values (200114,'SANTIAGO DE PUPUJA',2001)
insert into DISTRITO values (200115,'TIRAPATA',2001)

--Distritos de CARABAYA
insert into DISTRITO values (200201,'AJOYANI',2002)
insert into DISTRITO values (200202,'AYAPATA',2002)
insert into DISTRITO values (200203,'COASA',2002)
insert into DISTRITO values (200204,'CORANI',2002)
insert into DISTRITO values (200205,'CRUCERO',2002)
insert into DISTRITO values (200206,'HUATA',2002)
insert into DISTRITO values (200207,'MACUSANI',2002)
insert into DISTRITO values (200208,'OLLACHE',2002)
insert into DISTRITO values (200209,'SAN GABAN',2002)
insert into DISTRITO values (200210,'USICAYOS',2002)

--Distritos de CHUCUITO
insert into DISTRITO values (200301,'DESAGUADERO',2003)
insert into DISTRITO values (200302,'HUACULLANI',2003)
insert into DISTRITO values (200303,'JULI',2003)
insert into DISTRITO values (200304,'KELLUYO',2003)
insert into DISTRITO values (200305,'PISACOMA',2003)
insert into DISTRITO values (200306,'POMATA',2003)
insert into DISTRITO values (200307,'ZEPITA',2003)

--Distritos de EL COLLAO
insert into DISTRITO values (200401,'CAPAZO',2004)
insert into DISTRITO values (200402,'CONDURIRI',2004)
insert into DISTRITO values (200403,'ILAVE',2004)
insert into DISTRITO values (200404,'PILCUYO',2004)
insert into DISTRITO values (200405,'SANTA ROSA',2004)

--Distritos de HUANCANE
insert into DISTRITO values (200501,'COJATA',2005)
insert into DISTRITO values (200502,'HUANCANE',2005)
insert into DISTRITO values (200503,'HUATASANI',2005)
insert into DISTRITO values (200504,'INCHUPALLA',2005)
insert into DISTRITO values (200505,'PUSI',2005)
insert into DISTRITO values (200506,'ROSASPATA',2005)
insert into DISTRITO values (200507,'TARACO',2005)
insert into DISTRITO values (200508,'VILQUE CHICO',2005)

--Distritos de LAMPA
insert into DISTRITO values (200601,'CABANILLA',2006)
insert into DISTRITO values (200602,'CALAPUJA',2006)
insert into DISTRITO values (200603,'LAMPA',2006)
insert into DISTRITO values (200604,'NICASIO',2006)
insert into DISTRITO values (200605,'OCUVIRI',2006)
insert into DISTRITO values (200606,'PALCA',2006)
insert into DISTRITO values (200607,'PARATIA',2006)
insert into DISTRITO values (200608,'PUCARA',2006)
insert into DISTRITO values (200609,'SANTA LUCIA',2006)
insert into DISTRITO values (200610,'VILAVILA',2006)

--Distritos de MELGAR
insert into DISTRITO values (200701,'ANAUTA',2007)
insert into DISTRITO values (200702,'AYAVIRI',2007)
insert into DISTRITO values (200703,'CUPI',2007)
insert into DISTRITO values (200704,'LLALLI',2007)
insert into DISTRITO values (200705,'MACARI',2007)
insert into DISTRITO values (200706,'NUÑOA',2007)
insert into DISTRITO values (200707,'ORURILLO',2007)
insert into DISTRITO values (200708,'SANTA ROSA',2007)
insert into DISTRITO values (200709,'UMACHIRI',2007)

--Distritos de MOHO
insert into DISTRITO values (200801,'COMIMA',2008)
insert into DISTRITO values (200802,'HUAYRAPATA',2008)
insert into DISTRITO values (200803,'MOHO',2008)
insert into DISTRITO values (200804,'TILALI',2008)

--Distritos de PUNO
insert into DISTRITO values (200901,'ACORA',2009)
insert into DISTRITO values (200902,'AMANTANI',2009)
insert into DISTRITO values (200903,'ATUNCOLLA',2009)
insert into DISTRITO values (200904,'CAPACHICA',2009)
insert into DISTRITO values (200905,'CHUCUITO',2009)
insert into DISTRITO values (200906,'COATA',2009)
insert into DISTRITO values (200907,'HUATA',2009)
insert into DISTRITO values (200908,'MAÑAZO',2009)
insert into DISTRITO values (200909,'PAUCARCOLLA',2009)
insert into DISTRITO values (200910,'PICHACANI',2009)
insert into DISTRITO values (200911,'PLATERIA',2009)
insert into DISTRITO values (200912,'PUNO',2009)
insert into DISTRITO values (200913,'SAN ANTONIO',2009)
insert into DISTRITO values (200914,'TIQUILLACA',2009)
insert into DISTRITO values (200915,'VILQUE',2009)

--Distritos de SANDIA
insert into DISTRITO values (201001,'ALTO INAMBARI',2010)
insert into DISTRITO values (201002,'CUYOCUYO',2010)
insert into DISTRITO values (201003,'LIMBANI',2010)
insert into DISTRITO values (201004,'PATAMBUCO',2010)
insert into DISTRITO values (201005,'PHARA',2010)
insert into DISTRITO values (201006,'QUIACA',2010)
insert into DISTRITO values (201007,'SAN JUAN DEL ORO',2010)
insert into DISTRITO values (201008,'SAN PEDRO DE PUTINA PUNCO',2010)
insert into DISTRITO values (201009,'SANDIA',2010)
insert into DISTRITO values (201010,'YANAHUAYA',2010)

--Distritos de SAN ANTONIO DE PUTINA
insert into DISTRITO values (201101,'ANANEA',2011)
insert into DISTRITO values (201102,'PEDRO VILCA APAZA',2011)
insert into DISTRITO values (201103,'PUTINA',2011)
insert into DISTRITO values (201104,'QUILCAPUNCU',2011)
insert into DISTRITO values (201105,'SINA',2011)

--Distritos de SAN ROMAN
insert into DISTRITO values (201201,'CABANA',2012)
insert into DISTRITO values (201202,'CABANILLA',2012)
insert into DISTRITO values (201203,'CARACOTO',2012)
insert into DISTRITO values (201204,'JULIACA',2012)

--Distritos de YUNGUYO
insert into DISTRITO values (201301,'ANAPIA',2013)
insert into DISTRITO values (201302,'COPANI',2013)
insert into DISTRITO values (201303,'CUTURAPI',2013)
insert into DISTRITO values (201304,'OLLARAYA',2013)
insert into DISTRITO values (201305,'TINICACHI',2013)
insert into DISTRITO values (201306,'UNICACHI',2013)
insert into DISTRITO values (201307,'YUNGUYO',2013)




---DEPARTAMENTO DE SAN MARTIN*/
--Distritos de BELLA VISTA
insert into DISTRITO values (210101,'ALTO BIAVO',2101)
insert into DISTRITO values (210102,'BAJO BIAVO',2101)
insert into DISTRITO values (210103,'BELLAVISTA',2101)
insert into DISTRITO values (210104,'HUALLAGA',2101)
insert into DISTRITO values (210105,'SAN PABLO',2101)
insert into DISTRITO values (210106,'SAN RAFAEL',2101)

--Distritos de EL DORADO
insert into DISTRITO values (210201,'AGUA BLANCA',2102)
insert into DISTRITO values (210202,'SAN JOSE DE SISA',2102)
insert into DISTRITO values (210203,'SAN MARTIN',2102)
insert into DISTRITO values (210204,'SANTA ROSA',2102)
insert into DISTRITO values (210205,'SHATOJA',2102)

--Distritos de HUALLAGA
insert into DISTRITO values (210301,'ALTO SAPOSOA',2103)
insert into DISTRITO values (210302,'EL ESLABON',2103)
insert into DISTRITO values (210303,'PISCOYACU',2103)
insert into DISTRITO values (210304,'SACANCHE',2103)
insert into DISTRITO values (210305,'SAPOSOA',2103)
insert into DISTRITO values (210306,'TINGO DE SAPOSOA',2103)

--Distritos de LAMAS
insert into DISTRITO values (210401,'ALONSO DE ALVARADO',2104)
insert into DISTRITO values (210402,'BARRANQUITA',2104)
insert into DISTRITO values (210403,'CAYNARACHI',2104)
insert into DISTRITO values (210404,'CUÑUMBUQUI',2104)
insert into DISTRITO values (210405,'LAMAS',2104)
insert into DISTRITO values (210406,'PINTO RECODO',2104)
insert into DISTRITO values (210407,'RUMISAPA',2104)
insert into DISTRITO values (210408,'SAN ROQUE DE CUMBAZA',2104)
insert into DISTRITO values (210409,'SHANAO',2104)
insert into DISTRITO values (210410,'TABALOSOS',2104)
insert into DISTRITO values (210411,'ZAPATERO',2104)

--Distritos de  MARISCAL CACERES 
insert into DISTRITO values (210501,'CAMPANILLA',2105)
insert into DISTRITO values (210502,'HUICUNGO',2105)
insert into DISTRITO values (210503,'JUANJUI',2105)
insert into DISTRITO values (210504,'PACHIZA',2105)
insert into DISTRITO values (210505,'PAJARILLO',2105)

--Distritos de MOYOBAMBA
insert into DISTRITO values (210601,'CALZADA',2106)
insert into DISTRITO values (210602,'HABANA',2106)
insert into DISTRITO values (210603,'JEPELACIO',2106)
insert into DISTRITO values (210604,'MOYOBAMBA',2106)
insert into DISTRITO values (210605,'SORITOR',2106)
insert into DISTRITO values (210606,'YANTALO',2106)

--Distritos de PICOTA
insert into DISTRITO values (210701,'BUENOS AIRES',2107)
insert into DISTRITO values (210702,'CASPISAPA',2107)
insert into DISTRITO values (210703,'PICOTA',2107)
insert into DISTRITO values (210704,'PILLUANA',2107)
insert into DISTRITO values (210705,'PUCACACA',2107)
insert into DISTRITO values (210706,'SAN CRISTOBAL',2107)
insert into DISTRITO values (210707,'SAN HILARION',2107)
insert into DISTRITO values (210708,'SHAMBOYACU',2107)
insert into DISTRITO values (210709,'TINGO DE PONASA',2107)
insert into DISTRITO values (210710,'TRES UNIDOS',2107)

--Distritos de RIOJA
insert into DISTRITO values (210801,'AWAJUN',2108)
insert into DISTRITO values (210802,'ELIAS SOPLIN VARGAS',2108)
insert into DISTRITO values (210803,'NUEVA CAJAMARCA',2108)
insert into DISTRITO values (210804,'PARDO MIGUEL',2108)
insert into DISTRITO values (210805,'POSIC',2108)
insert into DISTRITO values (210806,'RIOJA',2108)
insert into DISTRITO values (210807,'SAN FERNANDO',2108)
insert into DISTRITO values (210808,'YORONGOS',2108)
insert into DISTRITO values (210809,'YURACYACU',2108)

--Distritos de SAN MARTIN
insert into DISTRITO values (210901,'ALBERTO LEVEAU',2109)
insert into DISTRITO values (210902,'CACATACHI',2109)
insert into DISTRITO values (210903,'CHAZUTA',2109)
insert into DISTRITO values (210904,'CHIPURANA',2109)
insert into DISTRITO values (210905,'EL PORVENIR',2109)
insert into DISTRITO values (210906,'HUIMBAYOC',2109)
insert into DISTRITO values (210907,'JUAN GUERRA',2109)
insert into DISTRITO values (210908,'LA BANDA DE SHILCAYO',2109)
insert into DISTRITO values (210909,'MORALES',2109)
insert into DISTRITO values (210910,'PAPAPLAYA',2109)
insert into DISTRITO values (210911,'SAN ANTONIO',2109)
insert into DISTRITO values (210912,'SAUCE',2109)
insert into DISTRITO values (210913,'SHAPAJA',2109)
insert into DISTRITO values (210914,'TARAPOTO',2109)

--Distritos de TOCACHE
insert into DISTRITO values (211001,'NUEVO PROGRESO',2110)
insert into DISTRITO values (211002,'POLVORA',2110)
insert into DISTRITO values (211003,'SHUNTE',2110)
insert into DISTRITO values (211004,'TOCACHE',2110)
insert into DISTRITO values (211005,'UCHIZA',2110)




---DEPARTAMENTO DE TACNA*/
--Distritos de CANDARAVE
insert into DISTRITO values (220101,'CAIRANI',2201)
insert into DISTRITO values (220102,'CAMILACA',2201)
insert into DISTRITO values (220103,'CANDARAVE',2201)
insert into DISTRITO values (220104,'CURIBAYA',2201)
insert into DISTRITO values (220105,'HUANUARA',2201)
insert into DISTRITO values (220106,'QUILAHUANI',2201)

--Distritos de JORGE BASADRE
insert into DISTRITO values (220201,'ILABAYA',2202)
insert into DISTRITO values (220202,'ITE',2202)
insert into DISTRITO values (220203,'LOCUMBA',2202)

--Distritos de TACNA
insert into DISTRITO values (220301,'ALTO DE LA ALIANZA',2203)
insert into DISTRITO values (220302,'CALANA',2203)
insert into DISTRITO values (220303,'CIUDAD NUEVA',2203)
insert into DISTRITO values (220304,'CORONEL GREGORIO ALBARRACIN LANCHIP',2203)
insert into DISTRITO values (220305,'INCLAN',2203)
insert into DISTRITO values (220306,'PACHIA',2203)
insert into DISTRITO values (220307,'PALCA',2203)
insert into DISTRITO values (220308,'POCOLLAY',2203)
insert into DISTRITO values (220309,'SAMA',2203)
insert into DISTRITO values (220311,'TACNA',2203)

--Distritos de TARATA
insert into DISTRITO values (220401,'ESTIQUE',2204)
insert into DISTRITO values (220402,'ESTIQUE-PAMPA',2204)
insert into DISTRITO values (220403,'HEROES ALBARRACIN',2204)
insert into DISTRITO values (220404,'SITAJARA',2204)
insert into DISTRITO values (220405,'SUSAPAYA',2204)
insert into DISTRITO values (220406,'TARATA',2204)
insert into DISTRITO values (220407,'TARUCACHI',2204)
insert into DISTRITO values (220408,'TICACO',2204)



---DEPARTAMENTO DE TUMBES*/
--Distritos de CONTRALMIRANTE VILLAR
insert into DISTRITO values (230101,'CASITAS',2301)
insert into DISTRITO values (230102,'ZORRITOS',2301)

--Distritos de TUMBES
insert into DISTRITO values (230201,'CORRALES',2302)
insert into DISTRITO values (230202,'LA CRUZ',2302)
insert into DISTRITO values (230203,'PAMPAS DE HOSPITAL',2302)
insert into DISTRITO values (230204,'SAN JACINTO',2302)
insert into DISTRITO values (230205,'SAN JUAN DE LA VIRGEN',2302)
insert into DISTRITO values (230206,'TUMBES',2302)

--Distritos de ZARUMILLA
insert into DISTRITO values (230301,'AGUAS VERDES',2303)
insert into DISTRITO values (230302,'MATAPALO',2303)
insert into DISTRITO values (230303,'PAPAYAL',2303)
insert into DISTRITO values (230304,'ZARUMILLA',2303)




---DEPARTAMENTO DE UCAYALI*/
--Distritos de ATALAYA
insert into DISTRITO values (240101,'RAYMONDI',2401)
insert into DISTRITO values (240102,'SEPAHUA',2401)
insert into DISTRITO values (240103,'TAHUANIA',2401)
insert into DISTRITO values (240104,'YURUA',2401)

--Distritos de CORONEL PORTILLO
insert into DISTRITO values (240201,'CALLERIA',2402)
insert into DISTRITO values (240202,'CAMPOVERDE',2402)
insert into DISTRITO values (240203,'IPARIA',2402)
insert into DISTRITO values (240204,'MASISEA',2402)
insert into DISTRITO values (240205,'NUEVA REQUENA',2402)
insert into DISTRITO values (240206,'YARINACHOCHA',2402)

--Distritos de PADRE ABAD
insert into DISTRITO values (240301,'CURIMANA',2403)
insert into DISTRITO values (240302,'IRAZOLA',2403)
insert into DISTRITO values (240303,'PADRE ABAD',2403)

--Distritos de PURUS
insert into DISTRITO values (240401,'PURUS',2404)
GO

--Registro de empleados
insert into Empleados values ('45919413','Edward','Rojas Alfaro','04/08/1989','Soltero','978512583','fake_51@hotmail.com','Av. Panamericana sur #1232 - A','100507')
--insert into Empleados values ('45919413','Celso','Robles Carrion','04/08/1989','Casado','','','Av. Jose carlos Mariategui 123','100507')
--insert into Empleados values ('45919413','Pablo','Corzo Sedano','04/08/1991','Soltero','','','Av. Los Libertadores 123','100507')
--insert into Empleados values ('45919413','Christiam','Huamantupa','04/08/1989','Viudo','','','Calle los desemparados 123','100507')	
go
--select * from Distrito where NombreDistrito='San Clemente'
--Registro de Clientes
--insert into Clientes values ('45919413','Natural','Miguel','Magallanes','','','','Casado','Calle Lima 123','100507')
insert into Contrato values	('1','10/06/2012','10/06/2099','admin','admin','Administrador','Todo el dia','1')	
--go

----Registro de Categorias
--insert into Categoria values('Linea blanca','Refrigeradoras,cocinas y lavadoras,etc')
--insert into Categoria values('Motos','')
--insert into Categoria values('Linea negra','Radios, televisores, etc')
--insert into Categoria values('Computadoras','') 
--go
