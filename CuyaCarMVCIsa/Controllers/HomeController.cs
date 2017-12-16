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
            ViewBag.Message = "Esto es un ViewBag.Message en Coche Get";
            return View();
        }


        [HttpPost]
        public ActionResult Coche(Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Coche Post";
            return View();
        }


        [HttpGet]
        public ActionResult Añadir()
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Añadir Get";
            return View();
        }

        [HttpPost]
        public ActionResult Añadir (Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Añadir Post";
            //Coche uncoche = new Coche();
            //uncoche.marca = "Renault";
            //uncoche.matricula = "654321";

            var db = new CuyaCarsDbContext();
            db.Coche.Add(coche);
            db.SaveChanges();

            return PartialView("Coche", coche);
        }


        [HttpGet]
        public ActionResult Buscar()
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Añadir Get";
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Añadir Post";
            //Coche uncoche = new Coche();
            //uncoche.marca = "Renault";
            //uncoche.matricula = "654321";

            Coche uncoche = new Coche();
            var db = new CuyaCarsDbContext();
            uncoche=db.Coche.Find(coche.Marca);

           // db.SaveChanges();

            return PartialView("Coche", uncoche);
        }

        [HttpGet]
        public ActionResult MostrarTodos ()
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Buscar Get";
            Coche uncoche = new Coche();
            var db = new CuyaCarsDbContext();
            List<Coche> todosloscoches = new List<Coche>();

            var todos = from Coche in db.Coche
                        select Coche;
                        //todosloscoches.Add(Coche);
            
            return View(todos);
        }

        [HttpPost]
        public ActionResult MostrarTodos(Coche coche)
        {
            ViewBag.Message = "Esto es un ViewBag.Message en Buscar Post";
   
            
            return PartialView("Coche", coche);
        }


        public ActionResult Cliente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}