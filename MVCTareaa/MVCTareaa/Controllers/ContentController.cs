using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTareaa.Models;

namespace MVCTareaa.Controllers
{
    public class ContentController : Controller
    {
        
        // GET: Content
        public ActionResult Contenido()
        {
            return View();
        }

        public ActionResult ContentRedirect(Content cont)
        {
            string selec = cont.Contenido;

            switch (selec)
            {
                case "Noticias":
                    return RedirectToAction("Noticias");
                case "Música":
                    return RedirectToAction("Musica");
                case "Películas":
                    return RedirectToAction("Peliculas");
            }
            return RedirectToAction("Contenido");
        }

        public ActionResult Noticias()
        {
            return View();
        }
        public ActionResult Musica()
        {
            return View();
        }
        public ActionResult Peliculas()
        {
            return View();
        }
    }
}