using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeraAplicacionWeb.Models
{
    public class BBDD {
        public static List<Persona> LasPersonas = new List<Persona>

        {
            new Persona("1-9", "cami", "silva"),
            new Persona("2-7", "kira", "ignacia"),
            new Persona("3-5", "Draco", "ignacio"),
        };
    }
}