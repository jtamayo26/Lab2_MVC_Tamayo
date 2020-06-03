using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Tamayo.Models;
namespace Lab2_MVC_Tamayo.Controllers
{
    public class PersonaController : Controller
    {
        //si o si lo hizo
        //hcaer una cambio para personaasdasdasdasdasd
        List<ClsPersona> objLista = new List<ClsPersona>();
        // GET: Persona
        public ActionResult Index()
        {
            //Instanciar para el objeto 1
            ClsPersona objPersona1 = new ClsPersona();
            objPersona1.apellido = "Tamayo Conde";
            objPersona1.nombre = "Jaime";
            objPersona1.email = "jtamayo@upt.pe";
            objPersona1.sexo = true;
            objPersona1.edad = 27;
            objPersona1.talla = 1.69;
            objLista.Add(objPersona1);

            ClsPersona objPersona2 = new ClsPersona();
            objPersona2.apellido = "Tamayo Conde";
            objPersona2.nombre = "Oscar";
            objPersona2.email = "oscartc@gmail.com";
            objPersona2.sexo = true;
            objPersona2.edad = 30;
            objPersona2.talla = 1.73;
            objLista.Add(objPersona2);

            ClsPersona objPersona3 = new ClsPersona();
            objPersona3.apellido = "Damasco";
            objPersona3.nombre = "Yoselin";
            objPersona3.email = "yoselind@gmail.com";
            objPersona3.sexo = false;
            objPersona3.edad = 23;
            objPersona3.talla = 1.56;
            objLista.Add(objPersona3);

            return View(objLista);
        }
        
    }
}
