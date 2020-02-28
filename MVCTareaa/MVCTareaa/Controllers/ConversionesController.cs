using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTareaa.Models;

namespace MVCTareaa.Controllers
{
    public class ConversionesController : Controller
    {
        // GET: Conversiones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Longitud()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Longitud(DatosConversiones datos)
        {
             string resultadoLongitud = datos.ConversionLongitudFormaCorta();
             ViewBag.miResultado = resultadoLongitud;
             return View(datos);
        }

        public ActionResult Temperatura( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult Temperatura(DatosConversiones datos)
        {
           string resultado = datos.ConversionTemperaturaFormaCorta();
            ViewBag.miResultado = resultado;
            return View(datos);
        }


        public ActionResult Masa( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult Masa(DatosConversiones datos)
        {
            string resultado = datos.ConversionMasaFormaCorta();
            ViewBag.miResultado = resultado;
            return View(datos);
        }

        public ActionResult Datos( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult Datos(DatosConversiones datos)
        {
            string resultado = datos.ConversionDatosFormaCorta();
            ViewBag.miResultado = resultado;
            return View(datos);
        }

    }
}