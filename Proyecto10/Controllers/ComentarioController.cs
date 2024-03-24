using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto10.Models;
namespace Proyecto10.Controllers
{
    public class ComentarioController : Controller
    {
        // GET: Comentario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()
        {
            var comentarios = TempData["Comentarios"] as List<ComentarioModel> ?? new List<ComentarioModel>();
            return View(comentarios);
        }

        [HttpPost]
        public ActionResult Enviar(ComentarioModel model)
        {
            var comentarios = TempData["Comentarios"] as List<ComentarioModel>;
            if (comentarios == null)
            {
                comentarios = new List<ComentarioModel>();
            }
            comentarios.Add(model);
            TempData["Comentarios"] = comentarios;

            return RedirectToAction("Listado");
        }
    }
}