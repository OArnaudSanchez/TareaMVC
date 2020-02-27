using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTareaa.Models;
using System.IO;

namespace MVCTareaa.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult FormularioE()
        {
            return View();
        }

        public ActionResult EnvioDatos(DatosUsuario datosusuario)
        {
            if (ModelState.IsValid)
            {
                if (datosusuario.foto != null && datosusuario.curriculum != null)
                {


                    string nombreFoto = "foto_" + DateTime.Now.ToString("ddMMyyHHmmss") +
                        Path.GetExtension(datosusuario.foto.FileName);
                    datosusuario.foto.SaveAs(Path.Combine(Server.MapPath("~/Fotos/"), nombreFoto));

                    ViewBag.StatusFoto = "Foto Enviada";
                        string nombreCurri = "curriculum_" + DateTime.Now.ToString("ddMMyyHHmmss") +
                            Path.GetExtension(datosusuario.curriculum.FileName);
                        datosusuario.curriculum.SaveAs(Path.Combine(Server.MapPath("~/Curriculums/"), nombreCurri));
                    ViewBag.curri = nombreCurri;
                        ViewBag.StatusCurri = "Currículum Enviado";
                        return View(datosusuario);
                }
                    
            }
            ViewBag.StatusFoto = "Error al enviar la foto";
            ViewBag.StatusCurri = "Error al enviar el currículum";
            return View(datosusuario);

        }
    }
}