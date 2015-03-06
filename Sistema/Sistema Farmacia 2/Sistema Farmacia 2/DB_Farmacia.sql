/*
Navicat SQL Server Data Transfer

Source Server         : localhost
Source Server Version : 90000
Source Host           : CARLBRADLEY\AUTODESKVAULT:1433
Source Database       : DB_Farmacia
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 100000
File Encoding         : 65001

Date: 2013-10-26 15:01:40
*/


-- ----------------------------
-- Table structure for Categoria
-- ----------------------------
DROP TABLE [Categoria]
GO
CREATE TABLE [Categoria] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombre] varchar(150) NULL 
)


GO
DBCC CHECKIDENT(N'[Categoria]', RESEED, 3)
GO

-- ----------------------------
-- Records of Categoria
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Categoria] ON
GO
INSERT INTO [Categoria] ([id], [nombre]) VALUES (N'1', N'Pastillas'), (N'2', N'Analgesicos'), (N'3', N'Jarabes')
GO
GO
SET IDENTITY_INSERT [Categoria] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Clientes
-- ----------------------------
DROP TABLE [Clientes]
GO
CREATE TABLE [Clientes] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombres] varchar(200) NOT NULL ,
[direccion] varchar(200) NOT NULL ,
[dni] varchar(8) NULL ,
[ruc] varchar(11) NULL ,
[nro_telefonico] varchar(20) NOT NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO

-- ----------------------------
-- Records of Clientes
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Clientes] ON
GO
SET IDENTITY_INSERT [Clientes] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for DetalleVenta
-- ----------------------------
DROP TABLE [DetalleVenta]
GO
CREATE TABLE [DetalleVenta] (
[serie] char(8) NULL ,
[idProducto] int NULL ,
[descripcion] varchar(140) NULL ,
[precio] decimal(10,2) NOT NULL ,
[cantidad] int NOT NULL ,
[total] decimal(10,2) NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO

-- ----------------------------
-- Records of DetalleVenta
-- ----------------------------
BEGIN TRANSACTION
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Farmacia
-- ----------------------------
DROP TABLE [Farmacia]
GO
CREATE TABLE [Farmacia] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombre] varchar(100) NOT NULL ,
[direccion] varchar(150) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[Farmacia]', RESEED, 3)
GO

-- ----------------------------
-- Records of Farmacia
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Farmacia] ON
GO
INSERT INTO [Farmacia] ([id], [nombre], [direccion]) VALUES (N'1', N'Farmacia 1', N'Av. Arequipa N°1234'), (N'2', N'Farmacia 2', N'Av. Javier Prado Este N°789'), (N'3', N'Farmacia 3', N'Av. Pardo N°345')
GO
GO
SET IDENTITY_INSERT [Farmacia] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Productos
-- ----------------------------
DROP TABLE [Productos]
GO
CREATE TABLE [Productos] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombre_producto] varchar(200) NOT NULL ,
[precio_venta] decimal(10,2) NOT NULL ,
[precio_compra] decimal(10,2) NOT NULL ,
[caducidad] datetime NOT NULL ,
[existencia] int NOT NULL ,
[descripcion] varchar(200) NOT NULL ,
[especificaciones] varchar(200) NOT NULL ,
[fecha_ingreso] datetime NOT NULL ,
[idCategoria] int NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[Productos]', RESEED, 3)
GO

-- ----------------------------
-- Records of Productos
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Productos] ON
GO
INSERT INTO [Productos] ([id], [nombre_producto], [precio_venta], [precio_compra], [caducidad], [existencia], [descripcion], [especificaciones], [fecha_ingreso], [idCategoria], [estado]) VALUES (N'1', N'Panadol', N'.80', N'.50', N'2013-10-25 23:51:34.907', N'45', N'jkdskjmcfds', N'nmcxvdbfjhldfs', N'2013-10-25 23:51:34.907', N'1', N'1'), (N'2', N'Amoxicilina', N'1.00', N'.70', N'2013-10-25 23:51:34.947', N'45', N'jkdskjmcfds', N'nmcxvdbfjhldfs', N'2013-10-25 23:51:34.947', N'1', N'1'), (N'3', N'Paracetamol', N'.80', N'.50', N'2013-10-25 23:51:34.963', N'47', N'jkdskjmcfds', N'nmcxvdbfjhldfs', N'2013-10-25 23:51:34.963', N'1', N'1')
GO
GO
SET IDENTITY_INSERT [Productos] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Usuarios
-- ----------------------------
DROP TABLE [Usuarios]
GO
CREATE TABLE [Usuarios] (
[id] int NOT NULL IDENTITY(1,1) ,
[idVendedor] int NULL ,
[usuario] varchar(50) NOT NULL ,
[pass] varchar(255) NOT NULL ,
[nivel] int NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[Usuarios]', RESEED, 3)
GO

-- ----------------------------
-- Records of Usuarios
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Usuarios] ON
GO
INSERT INTO [Usuarios] ([id], [idVendedor], [usuario], [pass], [nivel], [estado]) VALUES (N'1', N'1', N'mick', N'DXBfbb0SDyo=', N'1', N'1'), (N'2', N'2', N'carlos', N'DXBfbb0SDyo=', N'1', N'1'), (N'3', N'3', N'hugo', N'DXBfbb0SDyo=', N'1', N'1')
GO
GO
SET IDENTITY_INSERT [Usuarios] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Vendedor
-- ----------------------------
DROP TABLE [Vendedor]
GO
CREATE TABLE [Vendedor] (
[id] int NOT NULL IDENTITY(1,1) ,
[nombres] varchar(150) NOT NULL ,
[apellidos] varchar(50) NOT NULL ,
[sexo] char(1) NOT NULL ,
[edad] int NOT NULL ,
[tefefono] char(9) NOT NULL ,
[email] varchar(80) NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[Vendedor]', RESEED, 3)
GO

-- ----------------------------
-- Records of Vendedor
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Vendedor] ON
GO
INSERT INTO [Vendedor] ([id], [nombres], [apellidos], [sexo], [edad], [tefefono], [email], [estado]) VALUES (N'1', N'Mick Heral', N'Valles Espiritu', N'1', N'20', N'977289353', N'heral@hotmail.com', N'1'), (N'2', N'Carlos', N'Avalos Polo', N'1', N'20', N'987659467', N'carlos@hotmail.com', N'1'), (N'3', N'Hugo', N'Quispe Albites', N'1', N'40', N'997835678', N'hugo@hotmail.com', N'1')
GO
GO
SET IDENTITY_INSERT [Vendedor] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for Ventas
-- ----------------------------
DROP TABLE [Ventas]
GO
CREATE TABLE [Ventas] (
[id] int NOT NULL IDENTITY(1,1) ,
[serie] char(8) NOT NULL ,
[idUsuario] int NOT NULL ,
[idCliente] int NULL ,
[idFarmacia] int NOT NULL ,
[fecha] datetime NOT NULL ,
[tipo] int NULL ,
[subtotal] decimal(10,2) NOT NULL ,
[descuento] decimal(10,2) NULL ,
[igv] decimal(10,2) NOT NULL ,
[total] decimal(10,2) NOT NULL ,
[estado] int NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[Ventas]', RESEED, 7)
GO

-- ----------------------------
-- Records of Ventas
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [Ventas] ON
GO
SET IDENTITY_INSERT [Ventas] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Indexes structure for table Categoria
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Categoria
-- ----------------------------
ALTER TABLE [Categoria] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Clientes
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Clientes
-- ----------------------------
ALTER TABLE [Clientes] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Farmacia
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Farmacia
-- ----------------------------
ALTER TABLE [Farmacia] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Productos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Productos
-- ----------------------------
ALTER TABLE [Productos] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Usuarios
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Usuarios
-- ----------------------------
ALTER TABLE [Usuarios] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Uniques structure for table Usuarios
-- ----------------------------
ALTER TABLE [Usuarios] ADD UNIQUE ([usuario] ASC)
GO

-- ----------------------------
-- Indexes structure for table Vendedor
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Vendedor
-- ----------------------------
ALTER TABLE [Vendedor] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Ventas
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Ventas
-- ----------------------------
ALTER TABLE [Ventas] ADD PRIMARY KEY ([serie])
GO

-- ----------------------------
-- Foreign Key structure for table [DetalleVenta]
-- ----------------------------
ALTER TABLE [DetalleVenta] ADD FOREIGN KEY ([idProducto]) REFERENCES [Productos] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [DetalleVenta] ADD FOREIGN KEY ([serie]) REFERENCES [Ventas] ([serie]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [Productos]
-- ----------------------------
ALTER TABLE [Productos] ADD FOREIGN KEY ([idCategoria]) REFERENCES [Categoria] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [Usuarios]
-- ----------------------------
ALTER TABLE [Usuarios] ADD FOREIGN KEY ([idVendedor]) REFERENCES [Vendedor] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [Ventas]
-- ----------------------------
ALTER TABLE [Ventas] ADD FOREIGN KEY ([idCliente]) REFERENCES [Clientes] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Ventas] ADD FOREIGN KEY ([idFarmacia]) REFERENCES [Farmacia] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [Ventas] ADD FOREIGN KEY ([idUsuario]) REFERENCES [Usuarios] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
