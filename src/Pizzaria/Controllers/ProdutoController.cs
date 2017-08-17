using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;

namespace Pizzaria.Controllers
{
    public class ProdutoController : Controller
    {
        private RepositoryDAO<Produto> produtoDAO = new RepositoryDAO<Produto>();

        /// <summary>
        /// Página com todos os produtos
        /// </summary>
        public ActionResult Lista()
        {
            var produto = produtoDAO.ListAll();
            return View(produto);
        }

        /// <summary>
        /// Cadastro de produtos redireciona para o tipo
        /// </summary>
        public ActionResult Cadastro(int id = -1)
        {
            Produto produto = produtoDAO.ListOneWhere(c => c.Id == id);

            if (produto is Pizza)
            {
                return RedirectToAction("Cadastro", "Pizza", new { id = produto.Id });
            }
            if (produto is Bebida)
            {
                return RedirectToAction("Cadastro", "Bebida", new { id = produto.Id });
            }
            if (produto is Sobremesa)
            {
                return RedirectToAction("Cadastro", "Sobremesa", new { id = produto.Id });
            }

            return RedirectToAction("Lista");
        }

        /// <summary>
        /// Exclusão de produtos redireciona para o tipo
        /// </summary>
        public ActionResult Excluir(Produto produto)
        {
            if (produto is Pizza)
            {
                return RedirectToAction("Excluir", "Pizza", new { pizza = produto });
            }
            if (produto is Bebida)
            {
                return RedirectToAction("Excluir", "Bebida", new { bebida = produto });
            }
            if (produto is Sobremesa)
            {
                return RedirectToAction("Excluir", "Sobremesa", new { sobremesa = produto });
            }

            return RedirectToAction("Lista");
        }

    }
}