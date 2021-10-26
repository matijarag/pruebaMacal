using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaMacal.Models;

namespace PruebaMacal.Repository
{
    public class RepositoryEmpleado
    {
        public static List<Gerente> _listaGerente = new List<Gerente>()
        {
            new Gerente(){ Nombre="Matias", ApellidoPaterno = "Jara", ApellidoMaterno = "Gomez"},
            new Gerente(){ Nombre="Antonio", ApellidoPaterno = "Machado", ApellidoMaterno = "Diaz"}
        };

        public static List<SubGerente> _listaSubGerente = new List<SubGerente>()
        {
            new SubGerente(){ Nombre="Carlos", ApellidoPaterno = "Gonzalez", ApellidoMaterno = "Kurt"},
            new SubGerente(){ Nombre="Edgar", ApellidoPaterno = "Soto", ApellidoMaterno = "Vallejos"}
        };

        public string pagarSubGerente(int index, int sueldo)
        {
            int tamano = _listaSubGerente.Count - 1;

            if (tamano >= index)
            {
                SubGerente subg = _listaSubGerente[index];
                return subg.pagar(sueldo);
            }
            else
            {
                return "No existe este subgerente";
            }

            
        }

        public string pagarGerente(int index, int sueldo)
        {
            int tamano = _listaGerente.Count - 1;
            
            if (tamano >= index)
            {
                Gerente ger = _listaGerente[index];
                return ger.pagar(sueldo);
            }
            else
            {
                return "No existe este gerente";
            }
            
        }

        public IEnumerable<Gerente> ObtenerGerentes()
        {
            return _listaGerente;
        }

        public IEnumerable<SubGerente> ObtenerSubGerentes()
        {
            return _listaSubGerente;
        }
    }
}