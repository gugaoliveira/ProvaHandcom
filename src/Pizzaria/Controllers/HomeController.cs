using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;

namespace Pizzaria.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Index()
        {
	        var pizza = new RepositoryDAO<Pizza>().Get(1);

			return View();
        }       
    }
}