using Lab2_MVC_Tamayo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Tamayo.Models;

namespace Lab2_MVC_Tamayo.Controllers
{
    public class BilleteController : Controller
    {
        // GET: Billete
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar(ClsBillete objBillete)
        {
            int cantidad;
            cantidad = objBillete.monto;

            int cant100, cant50, cant20m, cant10;
            int res100, res50, res20m, res10;

            cant100 = cantidad / 100;
            res100 = cantidad % 100;

            cant50 = res100 / 50;
            res50 = res100 % 50;

            cant20m = res50 / 20;
            res20m = res50 % 20;

            cant10 = res20m / 10;
            res10 = res20m % 10;

            objBillete.b100 = cant100;
            objBillete.b50 = cant50;
            objBillete.b20 = cant20m;
            objBillete.b10 = cant10;


            return View(objBillete);
        }
    }
}