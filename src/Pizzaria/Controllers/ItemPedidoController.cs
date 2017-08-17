using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using System.Collections.Generic;

namespace Pizzaria.Controllers
{
    public class ItemPedidoController : Controller
    {
        private RepositoryDAO<ItemPedido> itemPedidoDAO = new RepositoryDAO<ItemPedido>();

        /// <summary>
        /// Action que renderiza modal para cadastrar um novo item no pedido
        /// </summary>
        public PartialViewResult NovoItemPedido(int idPedido)
        {
            var pedido = new PedidoDAO().GetPedidoById(idPedido);
            ItemPedido itemPedido = new ItemPedido(pedido);

            var listaProduto = new RepositoryDAO<Produto>().ListAll(c => c.Nome);

            ViewBag.Produto = new SelectList(
                listaProduto,
                "Id",
                "Nome"
            );

            return PartialView("~/Views/Pedido/_ModalNovoItemPedido.cshtml", itemPedido);
        }

        /// <summary>
        /// Cadastro de um item do pedido
        /// </summary>
        public ActionResult Cadastro(int idPedido, int idProduto, int quantidade, string observacao)
        {
            var pedido = new PedidoDAO().GetPedidoById(idPedido);

            var produto = new RepositoryDAO<Produto>().ListOneWhere(p => p.Id == idProduto);

            pedido.Itens = new List<ItemPedido>{
                new ItemPedido(pedido)
                {
                    Produto = produto,
                    Quantidade = quantidade,
                    Observacao = observacao
                }
            };

            new PedidoDAO().Update(pedido);

            return RedirectToAction("Cadastro", "Pedido", new { id = pedido.Id });
        }
        
        /// <summary>
        /// Excluir um item do pedido
        /// </summary>
        public ActionResult Excluir(int idItemPedido)
        {
            var itemPedido = itemPedidoDAO.Get(idItemPedido);
            int idPedido = itemPedido.Pedido.Id;
            itemPedidoDAO.Delete(itemPedido);
            
            return RedirectToAction("Cadastro", "Pedido", new { id = idPedido });
        }

    }
}