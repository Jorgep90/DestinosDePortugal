using System.Web.Mvc;
using DestinosDePortugal.Models;

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
            Administrador admin = new Administrador();

            return View(admin.SelectById(1));
        }
        public ActionResult Colaborador()
        {
            return View();
        }
    }
}