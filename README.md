# Funcionalidad
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
## Método utilizado para pagar al gerente y subgerente ingresando su index de la lista como parámetro

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
