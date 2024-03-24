using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto8.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Listado()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }
    }
}