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


		4. Autenticar al usuario
Endpoint: /api/authenticate
Método:
- POST
Recibirás un 200 OK con un el token JWT como string si la autenticación es exitosa.

		5. Obtener Stock por Variedad
Endpoint: /api/wines/variety/{variety}
Método:
- GET
Recibirás un 200 OK con una lista de todos los vinos disponibles de ésa variedad.

		6. Actualizar el Stock de un Vino
Endpoint: /api/wines/{wineId}/stock
Método:
- PUT
Recibirás 204 No Content si la actualización fue exitosa.
