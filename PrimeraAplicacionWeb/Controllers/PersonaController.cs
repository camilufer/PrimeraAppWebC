using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeraAplicacionWeb.Models;

namespace PrimeraAplicacionWeb.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Listado()
        {
            return View(BBDD.LasPersonas);
        }

        [HttpGet]
        public ActionResult Edit(string rut)
        {
            Persona per = BBDD.LasPersonas.Single(p => p.Rut == rut);
            return View(per);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection formulario)
        {
            string rut = formulario["rut"].ToString();
            Persona per = BBDD.LasPersonas.Single(p => p.Rut == rut);
            per.Nombre = formulario["nombre"].ToString();
            per.Apellido = formulario["apellido"].ToString();
            return RedirectToAction("Listado");
        }

        public ActionResult Details(string rut) {
            if (rut != null) {
                Persona per = BBDD.LasPersonas.Single(p => p.Rut == rut);
                return View(per);
            }
            else
                return RedirectToAction("Listado");
            
        }

        [HttpGet]
        public ActionResult Delete(string rut) {
            if (rut != null)
            {
                Persona per = BBDD.LasPersonas.Single(p => p.Rut == rut);
                return View(per);
            }

            return Content("no ha ingresado rut");

        }

        [HttpPost]
        public ActionResult Delete(string rut, string confirmacion)
        {
            for(int x=0; x<BBDD.LasPersonas.Count; ++x)
            {
                if (BBDD.LasPersonas[x].Rut == rut)
                    BBDD.LasPersonas.RemoveAt(x);
            }

            return RedirectToAction("Listado");

        }
    }
}