-- 1. De la bases de datos Empresa, obtener el listado de las unidades vendidas por 
-- año, mes y artículo, (generando también los subtotales por año y año-mes.)no

use EMPRESA

select Year(V.Fecha) as Año, Month(V.Fecha) as Mes, A.Descripcion as Articulo, count(*) as uds

from Ventas as V

inner join Articulos as A
on V.CodigoArticulo = A.Codigo

group by Year(V.Fecha), Month(V.Fecha), A.Descripcion
go



--2. Obtener en un único listado los datos de los artículos de la base de datos
--empresa y de la base de datos gescom. Mostrando el código de artículo, el nombre y el precio.

use EMPRESA
go

drop table finaldb
go

create table finaldb (DB VARCHAR(20), codigo varchar(40), nombre varchar(40), precio decimal)
go

merge into finaldb as f
using gescom.dbo.articulos as GA
	on f.codigo = CAST(GA.REFERENCIA_ART as varchar(40))

when matched then
	update set f.DB = 'Gescom',
			   f.codigo = CAST(GA.REFERENCIA_ART as varchar(40)),
			   f.nombre = CAST(GA.NOMBRE_ART as varchar(40)),
			   f.precio = CAST(GA.precioconiva as decimal)

when not matched by target then
	insert values ('Gescom',
				   CAST(GA.REFERENCIA_ART as varchar(40)),
				   CAST(GA.NOMBRE_ART as varchar(40)),
			       CAST(GA.precioconiva as decimal))

when not matched by source then
	delete
;
go


merge into finaldb as f
using Empresa.dbo.Articulos as EA
	on f.codigo = CAST(EA.Codigo as varchar(40))

when matched then
	update set f.DB = 'Empresa',
			   f.codigo = CAST(EA.Codigo as int),
			   f.nombre = CAST(EA.Descripcion as varchar(40)),
			   f.precio = CAST(EA.PrecioVenta as decimal)

when not matched by target then
	insert values ('Empresa',
				   CAST(EA.Codigo as varchar(40)),
				   CAST(EA.Descripcion as varchar(40)),
			       CAST(EA.PrecioVenta as decimal))

;
go

select codigo, nombre, precio
from finaldb
go


-- 3. Crear una vista para listar los 3 clientes que más han facturado

create view MasFacturado

with gescomFacturado (facturado, nombre)
as
(
	select Top 3 sum(A.precioconiva*LP.cantidad_pdo), C.nombre + ' ' + C.apellido as nombre
	from GESCOM.dbo.LINEAS_PDO as LP

	inner join GESCOM.dbo.PEDIDOS as P
	on LP.numero_pdo = P.numero_pdo

	inner join GESCOM.dbo.CLIENTES as C
	on P.numero_cli = C.numero

	inner join GESCOM.dbo.ARTICULOS as A
	on LP.referencia_art = A.REFERENCIA_ART

	group by C.nombre + ' ' + C.apellido
	order by 1 desc
)
,
empresaFacturado (facturado, nombre)
as
(
	select TOP 3 sum(A.PrecioVenta*V.Cantidad) , C.Nombre as nombre
	from EMPRESA.dbo.Ventas as V

	inner join Empresa.dbo.Articulos as A
	on V.CodigoArticulo = A.Codigo

	inner join EMPRESA.dbo.Clientes as C
	on V.CodigoCliente = C.CodigoCliente

	inner join EMPRESA.dbo.Descuentos as D
	on C.TipoDescuento = D.TipoDescuento

	Group by nombre
	order by sum(A.PrecioVenta*V.Cantidad)
)

select *
from gescomFacturado as G

full outer join empresaFacturado as E
on g.nombre = e.nombre



-- 4. Obtener el listado de los clientes con descuento A y de Trapagaran. Mostrando
--el nombre, dirección y teléfono, ordenando por el nombre en modo descendente.

use empresa

select C.Nombre, C.direccion, C.telefono

from Clientes as C

inner join Descuentos as D
on C.TipoDescuento = D.TipoDescuento

where upper(C.Poblacion) like ('%TRAPAGARAN%') and D.TipoDescuento in ('A')


-- 5. Obtener el listado de los clientes que contienen la palabra “Jose” en la columna nombre


use EMPRESA

select * 
from Clientes


where upper(Nombre) like '%JOSE%' 




-- 6. Crear un procedimiento almacenado para obtener el listado de las ventas del
--año y nombre mes que pasamos como parámetro


use empresa
go
alter procedure ventasAñoMes(@año int, @mes int)
as
select *
from Ventas
where year(fecha) = @año and Month(fecha) = @mes
go
exec ventasAñoMes 2013,7


