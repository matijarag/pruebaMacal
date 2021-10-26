--1
SELECT nombre as nombre_producto, precio as precio_producto
FROM producto;

--2
SELECT f.nombre as nombre_fabricante, 
p.nombre as nombre_producto, 
p.precio as precio_producto, 
CAST(ROUND((p.precio/815.74),2,1)as decimal(10,2))as precio_en_dolares
FROM producto p
LEFT JOIN fabricante f ON p.codigo_fabricante = f.codigo
ORDER BY f.nombre ASC;

--3
SELECT nombre as nombre_fabricante
FROM fabricante
ORDER BY nombre DESC;

--4
SELECT nombre as nombre_producto
FROM producto
WHERE precio <= 170000;

--5
SELECT
p.nombre as nombre_producto, 
p.precio as precio_producto 
FROM producto p
LEFT JOIN fabricante f ON p.codigo_fabricante = f.codigo
WHERE f.codigo IN (1, 3, 5);

--1.1.5
SELECT f.nombre as nombre_fabricante,
ISNULL(p.nombre,'No tiene') as nombre_producto
FROM fabricante f
LEFT JOIN producto p
ON f.codigo = p.codigo_fabricante;

--1.1.6-1
SELECT COUNT(nombre) as total_productos
FROM producto;

--1.1.6-2
SELECT AVG(precio) as media_productos
FROM producto;

--1.1.6-2
SELECT MAX(precio) as max_precio_productos
FROM producto;

--1.1.7.1-1
SELECT nombre as nombre_producto
FROM producto
WHERE codigo_fabricante = (
	SELECT codigo 
	FROM fabricante
	WHERE nombre = 'Lenovo'
);

--1.1.7.1-2

SELECT nombre as nombre_producto,
precio as precio_producto
FROM producto
WHERE precio = (
	SELECT MAX(precio) as precio_max
	FROM producto
	WHERE codigo_fabricante = (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Lenovo'
)
);

--1.1.7.1-3
SELECT nombre as nombre_producto
FROM producto
WHERE precio = (
	SELECT MAX(precio) as precio_max
	FROM producto
	WHERE codigo_fabricante = (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Lenovo'
)
);

--1.1.7.1-4
SELECT nombre as nombre_producto
FROM producto
WHERE precio = (
	SELECT MIN(precio) as precio_max
	FROM producto
	WHERE codigo_fabricante = (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Hewlett-Packard'
)
);

--1.1.7.1-5

SELECT nombre as nombre_producto,
precio as precio_producto
FROM producto
WHERE precio >= (
	SELECT MAX(precio) as precio_max
	FROM producto
	WHERE codigo_fabricante = (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Lenovo'
)
);

--1.1.7.1-6
SELECT nombre as nombre_producto,
precio as precio_producto
FROM producto
WHERE precio > (
	SELECT AVG(precio) as precio_max
	FROM producto
	WHERE codigo_fabricante = (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Asus'
)
)
AND codigo_fabricante =  (
		SELECT codigo 
		FROM fabricante
		WHERE nombre = 'Asus'
);


--1.1.7.3
SELECT nombre as nombre_fabricante
FROM fabricante 
WHERE codigo IN (
	SELECT codigo_fabricante as cod_fabricante 
	FROM producto
);

--1.1.7.4
SELECT nombre as nombre_fabricante
FROM fabricante f
WHERE EXISTS(
	SELECT * FROM
	producto p WHERE p.codigo_fabricante = f.codigo 
)


--1.1.7.5
SELECT f.nombre as nombre_fabricante,
		p.nombre as nombre_producto,
		MAX(p.precio) as precio_producto
FROM producto p
JOIN fabricante f 
ON f.codigo = p.codigo
GROUP BY p.nombre, f.nombre
