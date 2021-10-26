## Respuestas preguntas SQL
[Click Aqui](https://github.com/matijarag/pruebaMacal/blob/master/mediaForReadme/SQL%20Respuestas.SQL)

# Funcionalidad APP
## Lista de gerentes
```C#
        public static List<Gerente> _listaGerente = new List<Gerente>()
        {
            new Gerente(){ Nombre="Matias", ApellidoPaterno = "Jara", ApellidoMaterno = "Gomez"},
            new Gerente(){ Nombre="Antonio", ApellidoPaterno = "Machado", ApellidoMaterno = "Diaz"}
        };
```
## Lista SubGerentes
```C#
        public static List<SubGerente> _listaSubGerente = new List<SubGerente>()
        {
            new SubGerente(){ Nombre="Carlos", ApellidoPaterno = "Gonzalez", ApellidoMaterno = "Kurt"},
            new SubGerente(){ Nombre="Edgar", ApellidoPaterno = "Soto", ApellidoMaterno = "Vallejos"}
        };
```
## Método utilizado para pagar al gerente y subgerente ingresando su index de la lista como parámetro (Estoy utilizando un monto Random para el sueldo)

```C#
[HttpGet]
        public IHttpActionResult Get(int id)
        {
            RepositoryEmpleado rpEmp = new RepositoryEmpleado();
            Random r = new Random();
            int rndmSueldo = r.Next(1500000,2000000);
            Random r2 = new Random();
            int rndmSueldo2 = r2.Next(1000000, 1500000);
            var config = new[]
            {
                new {message = rpEmp.pagarGerente(id, rndmSueldo)},
                new {message = rpEmp.pagarSubGerente(id, rndmSueldo2)}
            };
            var jsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            return Ok(config);
        }
```
## Ejecución
### Pagando a gerente y subgerente con index 1
![Image](https://github.com/matijarag/pruebaMacal/blob/master/mediaForReadme/pagoId.png)
### Obtener Gerentes 
![Image](https://github.com/matijarag/pruebaMacal/blob/master/mediaForReadme/gerentes.png)
### Obtener Sub Gerentes
![Image](https://github.com/matijarag/pruebaMacal/blob/master/mediaForReadme/subGerentes.png)

### Lo ideal para la API Sería implementar un JSON Web Token para la validación de los Request, se envía como Bearer "token" en el Header de la consulta, así se puede tener una capa de seguridad para validar la integridad del remitente del request, el JWT debería estar firmado por una Key global de la aplicación. El token no se debe guardar por ningún motivo en caché ni en Local Storage ni debe contener información sensible del negocio, cualquier validación extra debe ser resuelta en el backend de la aplicación.
