		Está API permite:
		1. la creación de nuevos usuarios
Endpoint: /api/users
Método:
- POST
Si el usuario se crea exitosamente, recibirás un 200 OK.
Tener en cuenta:
1) El nombre de usuario es obligatorio.
2) La contraseña debe tener un mínimo de 8 caracteres.

		2. La creación de nuevos vinos
Endpoint: /api/wine
Método:
- POST
Si el usuario se crea exitosamente, recibirás un 200 OK.
Tener en cuenta:
1) El nombre del vino es obligatorio.
2) El año de cosecha debe estar entre 1860 y el año actual.
3) La cantidad de stock debe ser un número mayor o igual a 0.


		3. la consulta del inventario actual.
Endpoint: /api/wine
Método:
- GET
Recibirás un 200 OK con una lista de todos los vinos disponibles en el inventario.

