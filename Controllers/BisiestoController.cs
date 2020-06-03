using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Tamayo.Models;

namespace Lab2_MVC_Tamayo.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Visualizar(ClsBisiesto o)
        {

            return View(o);
        }
    }
}