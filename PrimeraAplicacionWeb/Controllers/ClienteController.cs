using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraAplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Buscar(string rut) {
            string respuesta = "";
            if (rut != null){
                respuesta = "<h1> Buscando al cliente con rut..." + rut + "</h1>";
                respuesta += @"<ul>
                                 <li>asado</li>
                                 <li>Entraña</li>
                                 <li>Costilla</li>
                               </ul>";
            }
            else
                respuesta = "<h1> Debe enviar un rut para consultar </h1>";
            return Content(respuesta);
        }
    }
}