using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMacal.Models
{
    public class Empleado : InterfacePago
    {

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int sueldo { get; set; }

        public Empleado()
        {

        }

        public Empleado(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }


        public string sayMyName()
        {
            string nombreCompleto = this.Nombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno;

            return nombreCompleto;
        }

        public void pagarSueldo(int sueldo)
        {
            this.sueldo = sueldo;
        }
    }
}