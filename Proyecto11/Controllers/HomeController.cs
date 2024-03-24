using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto11.Models;

namespace Proyecto11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enviar(ValoracionModel model, string[] Asignatura)
        {
            var valoraciones = Session["Valoraciones"] as List<ValoracionModel> ?? new List<ValoracionModel>();

            model.Asignaturas = Asignatura.ToList();

            valoraciones.Add(model);
            valoraciones = valoraciones.Take(3).ToList();
            Session["Valoraciones"] = valoraciones;

            return RedirectToAction("Listado");
        }

            public ActionResult Listado()
        {
            var valoraciones = Session["Valoraciones"] as List<ValoracionModel> ?? new List<ValoracionModel>();

            return View(valoraciones);
        }

        

        public ActionResult LlenarOtroFormulario()
        {
            return RedirectToAction("Index");
        }
    }
}