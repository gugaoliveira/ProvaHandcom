using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using NHibernate.Criterion;

namespace Pizzaria.Controllers
{
    public class RelatorioController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Lista()
        {
	        var pizza = new RepositoryDAO<Pizza>().Get(1);

            var teste = new RepositoryDAO<Cidade>().ListWhere(l => l.Nome == "Cataguases");

			return View();
        }       
    }
}