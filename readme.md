		Est� API permite:
		1. la creaci�n de nuevos usuarios
Endpoint: /api/users
M�todo:
- POST
Si el usuario se crea exitosamente, recibir�s un 200 OK.
Tener en cuenta:
1) El nombre de usuario es obligatorio.
2) La contrase�a debe tener un m�nimo de 8 caracteres.

		2. La creaci�n de nuevos vinos
Endpoint: /api/wine
M�todo:
- POST
Si el usuario se crea exitosamente, recibir�s un 200 OK.
Tener en cuenta:
1) El nombre del vino es obligatorio.
2) El a�o de cosecha debe estar entre 1860 y el a�o actual.
3) La cantidad de stock debe ser un n�mero mayor o igual a 0.


		3. la consulta del inventario actual.
Endpoint: /api/wine
M�todo:
- GET
Recibir�s un 200 OK con una lista de todos los vinos disponibles en el inventario.


		4. Autenticar al usuario
Endpoint: /api/authenticate
M�todo:
- POST
Recibir�s un 200 OK con un el token JWT como string si la autenticaci�n es exitosa.

		5. Obtener Stock por Variedad
Endpoint: /api/wines/variety/{variety}
M�todo:
- GET
Recibir�s un 200 OK con una lista de todos los vinos disponibles de �sa variedad.

		6. Actualizar el Stock de un Vino
Endpoint: /api/wines/{wineId}/stock
M�todo:
- PUT
Recibir�s 204 No Content si la actualizaci�n fue exitosa.
