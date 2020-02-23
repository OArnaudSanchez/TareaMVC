using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTareaa.Models;
using MVCTareaa.Formulas;

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
        public ActionResult Longitud(DatosConversiones datos, Longitudes lon)
        {
            var opcion = lon.ConversionLongitudes(datos.Longitud);

            return View();
        }

        public ActionResult Temperatura()
        {
            return View();
        }

        public ActionResult Masa()
        {
            return View();
        }

        public ActionResult Datos()
        {
            return View();
        }

    }
}