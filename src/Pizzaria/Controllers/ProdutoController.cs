using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using Pizzaria.Models.Enum;

namespace Pizzaria.Controllers
{
    public class ProdutoController : Controller
    {

        private RepositoryDAO<Pizza> pizzaDAO = new RepositoryDAO<Pizza>();
        private RepositoryDAO<Sobremesa> sobremesaDAO = new RepositoryDAO<Sobremesa>();
        private RepositoryDAO<Bebida> bebidaDAO = new RepositoryDAO<Bebida>();

        /// <summary>
        /// Página com todos os produtos
        /// </summary>
        public ActionResult Lista()
        {         
            var listaPizza = new RepositoryDAO<Pizza>().ListAll(p=>p.Nome, Ordem.Asc);
            var listaBebida = new RepositoryDAO<Bebida>().ListAll(p => p.Nome, Ordem.Asc);
            var listaSobremesa = new RepositoryDAO<Sobremesa>().ListAll(p => p.Nome, Ordem.Asc);

            //pedido.Itens.Where(x => x.Produto is Sobremesa).Sum(x => x.Produto.Preco);


            return View();
        }        

    }
}