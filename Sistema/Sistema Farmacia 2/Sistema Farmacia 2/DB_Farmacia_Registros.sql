INSERT INTO Vendedor (
	nombres,
	apellidos,
	sexo,
	edad,
	tefefono,
	email
)
VALUES
	(
		'Mick Heral',
		'Valles Espiritu',
		1,
		20,
		'977289353',
		'heral@hotmail.com'
	);

INSERT INTO Vendedor (
	nombres,
	apellidos,
	sexo,
	edad,
	tefefono,
	email
)
VALUES
	(
		'Carlos',
		'Avalos Polo',
		1,
		20,
		'987659467',
		'carlos@hotmail.com'
	);

INSERT INTO Vendedor (
	nombres,
	apellidos,
	sexo,
	edad,
	tefefono,
	email
)
VALUES
	(
		'Hugo',
		'Quispe Albites',
		1,
		40,
		'997835678',
		'hugo@hotmail.com'
	);

INSERT INTO Usuarios (
	idVendedor,
	usuario,
	pass,
	nivel
)
VALUES
	(1, 'mick', 'DXBfbb0SDyo=', 1);

INSERT INTO Usuarios (
	idVendedor,
	usuario,
	pass,
	nivel
)
VALUES
	(
		2,
		'carlos',
		'DXBfbb0SDyo=',
		1
	);

INSERT INTO Usuarios (
	idVendedor,
	usuario,
	pass,
	nivel
)
VALUES
	(3, 'hugo', 'DXBfbb0SDyo=', 1);

INSERT INTO Farmacia (nombre, direccion)
VALUES
	(
		'Farmacia 1',
		'Av. Arequipa N°1234'
	);

INSERT INTO Farmacia (nombre, direccion)
VALUES
	(
		'Farmacia 2',
		'Av. Javier Prado Este N°789'
	);

INSERT INTO Farmacia (nombre, direccion)
VALUES
	(
		'Farmacia 3',
		'Av. Pardo N°345'
	);

INSERT INTO Categoria (nombre)
VALUES
	('Pastillas');

INSERT INTO Categoria (nombre)
VALUES
	('Analgesicos');

INSERT INTO Categoria (nombre)
VALUES
	('Jarabes');

INSERT INTO Productos (
	nombre_producto,
	precio_venta,
	precio_compra,
	caducidad,
	existencia,
	descripcion,
	especificaciones,
	fecha_ingreso,
	idCategoria
)
VALUES
	(
		'Panadol',
		0.80,
		0.50,
		GETDATE(),
		50,
		'jkdskjmcfds',
		'nmcxvdbfjhldfs',
		GETDATE(),
		1
	);

INSERT INTO Productos (
	nombre_producto,
	precio_venta,
	precio_compra,
	caducidad,
	existencia,
	descripcion,
	especificaciones,
	fecha_ingreso,
	idCategoria
)
VALUES
	(
		'Amoxicilina',
		1.00,
		0.70,
		GETDATE(),
		50,
		'jkdskjmcfds',
		'nmcxvdbfjhldfs',
		GETDATE(),
		1
	);

INSERT INTO Productos (
	nombre_producto,
	precio_venta,
	precio_compra,
	caducidad,
	existencia,
	descripcion,
	especificaciones,
	fecha_ingreso,
	idCategoria
)
VALUES
	(
		'Paracetamol',
		0.80,
		0.50,
		GETDATE(),
		50,
		'jkdskjmcfds',
		'nmcxvdbfjhldfs',
		GETDATE(),
		1
	);
