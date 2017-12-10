using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuyaCarMVCIsa.Models;
using CuyaCarMVCIsa.BDContext;

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
            ViewBag.Message = "Esto es un ViewBag.Message en Get";
            Coche coche = new Coche();
            coche.marca ="Renault";
            coche.matricula ="123456";
            //ViewBag.Message = coche.marca;

            return View();
        }


        [HttpPost]
        public ActionResult Coche(Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Post";
            //Coche uncoche = new Coche();
            //uncoche.marca = "Renault";
            //uncoche.matricula = "654321";
         
            var db = new CuyaCarsDbContext();
            db.Coche.Add(coche);
            db.SaveChanges();
            
            return View();
        }


        public ActionResult Cliente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}