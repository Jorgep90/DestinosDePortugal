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
            Users users = new Users();

            return View(users.SelectById(1));
        }
        public ActionResult Colaborador()
        {
            return View();
        }
    }
}