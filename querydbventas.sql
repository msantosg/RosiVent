use master
go

create database dbventas
go

use dbventas
go

create table usuario(
	usuarioID int identity not null primary key,
	nombreUsuario varchar(50),
	claveUsuario varchar(50)
)
go

create table categoria(
	categoriaID int identity not null primary key,
	nombreCategoria varchar(50)
)
go

create table proveedor(
	proveedorID int identity not null primary key,
	nitProveedor bigInt,
	nombreProveedor varchar(100),
	direccionProveedor varchar(100),
	telefonoProveedor bigInt
)
go

create table cliente(
	clienteID int identity not null primary key,
	nitCliente bigInt,
	nombreCliente varchar(100),
	direccionCliente varchar(100)
)
go

create table producto(
	productoID int identity not null primary key,
	categoriaID int references categoria,
	proveedorID int references proveedor,
	nombreProducto varchar(100),
	unidadMedida varchar(50),
	existenciaProducto int,
	precioCompra decimal(18,2),
	precioVenta decimal(18,2)
)
go

create table compra(
	compraID int identity not null primary key,
	proveedorID int references proveedor,
	fechaCompra date,
	noFactura int,
	serieFactura varchar(10)
)
go

create table detalleCompra(
	detalleCompraID int identity not null primary key,
	compraID int references compra,
	productoID int references producto,
	cantidadCompra int,
	precioCompra decimal(18,2)
)
go

create table venta(
	ventaID int identity not null primary key,
	usuarioID int references usuario,
	clienteID int references cliente,
	fechaVenta date
)
go

create table detalleVenta(
	detalleVentaID int identity not null primary key,
	ventaID int references venta,
	productoID int references producto,
	cantidadVenta int,
	precioVenta int
)
go