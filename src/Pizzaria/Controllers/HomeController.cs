using System.Web.Mvc;

namespace Pizzaria.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
    }
}