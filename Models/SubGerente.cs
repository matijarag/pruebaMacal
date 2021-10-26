using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMacal.Models
{
    public class SubGerente : Empleado
    {
        public string pagar(int sueldo)
        {
            this.pagarSueldo(sueldo);
            string nombreCompleto = this.sayMyName();
            return "Se pagó el sueldo al Gerente " + nombreCompleto + " Sueldo Pagado: " + this.sueldo;
        }

    }
}