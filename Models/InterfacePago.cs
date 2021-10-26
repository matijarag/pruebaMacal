using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMacal.Models
{
    public interface InterfacePago
    {
        int sueldo { get; set; }
        void pagarSueldo(int sueldo);

    }
}
