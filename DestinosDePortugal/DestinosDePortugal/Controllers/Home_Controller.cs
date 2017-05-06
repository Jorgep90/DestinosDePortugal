using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinosDePortugal.Controllers
{
    public class Home_Controller : Controller
    {
        // GET: Home_
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Administrador()
        {
            return View();
        }
        public ActionResult Colaborador()
        {
            return View();
        }
    }
}