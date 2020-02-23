using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTareaa.Models;

namespace MVCTareaa.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult FormularioE(DatosUsuario datosusuario, HttpPostedFileBase foto)
        {
            if (ModelState.IsValid)
            {

                string nombreFoto = foto.FileName;
                foto.SaveAs(Server.MapPath("/img/" + nombreFoto));
                ViewBag.picture = nombreFoto;
                return View(datosusuario);
            }
            else
            {
                return View(datosusuario);
            }
        }
    }
}