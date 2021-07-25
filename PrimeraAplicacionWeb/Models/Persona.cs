using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeraAplicacionWeb.Models
{
    public class Persona {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {
        }

        public Persona(string rut, string nombre, string apellido)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}