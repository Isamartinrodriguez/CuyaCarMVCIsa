using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuyaCarMVCIsa.Models;

namespace CuyaCarMVCIsa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Coche()
        {
            ViewBag.Message = "Esto es un ViewBag.Message.";
            Coche coche = new Coche();
            coche.marca ="Renault";
            coche.matricula ="123456";
            //ViewBag.Message = coche.marca;

            return View();
        }


        [HttpPost]
        public ActionResult Coche(Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message.";
            Coche uncoche = new Coche();
            //uncoche.marca = "Renault";
            //uncoche.matricula = "654321";
            ViewBag.Message = coche.marca;
            ViewBag.Message = coche.matricula;

            return View(uncoche);
        }


        public ActionResult Cliente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}