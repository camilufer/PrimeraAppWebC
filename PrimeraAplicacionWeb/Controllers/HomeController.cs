using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraAplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index(string id, string nombre)
        {
            return "<h1>hola</h1><hr>Parametro id: " + id + ", nombre:" + nombre;
        }
    }
}