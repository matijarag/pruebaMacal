using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaMacal.Controllers;
using PruebaMacal.Models;
using PruebaMacal.Repository;

namespace PruebaMacal.Controllers
{
    public class NegocioController : ApiController
    {
        [HttpGet]
        [Route("api/gerentes")]
        public IHttpActionResult Get()
        {
            RepositoryEmpleado rpEmp = new RepositoryEmpleado();
            return Ok(rpEmp.ObtenerGerentes());
        }

        [HttpGet]
        [Route("api/subGerentes")]
        public IHttpActionResult GetSub()
        {
            RepositoryEmpleado rpEmp = new RepositoryEmpleado();
            return Ok(rpEmp.ObtenerSubGerentes());
        }

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

    }
}