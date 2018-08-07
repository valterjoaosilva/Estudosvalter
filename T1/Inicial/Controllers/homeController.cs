using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inicial.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            // código da regra de negocio
            return View();
        }
    }
}