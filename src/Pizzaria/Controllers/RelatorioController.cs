using System.Web.Mvc;

namespace Pizzaria.Controllers
{
    public class RelatorioController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Lista()
        {
			return View();
        }       
    }
}