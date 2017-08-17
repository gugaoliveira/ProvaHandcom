using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using System;
namespace Pizzaria.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoDAO pedidoDAO = new PedidoDAO();

        /// <summary>
        /// Página com todos os pedidos
        /// </summary>
        public ActionResult Lista()
        {
            var pedido = pedidoDAO.GetPedidosComItens();

            return View(pedido);
        }

        /// <summary>
        /// Cadastro de pedidos
        /// </summary>
        public ActionResult Cadastro(int id)
        {
            var pedido = pedidoDAO.GetPedidoById(id);
            
            return View(pedido);
        }

        /// <summary>
        /// Cadastro de cliente para poder cadastrar um pedido
        /// </summary>
        public int CadastroPedidoCliente(int idCliente)
        {
            var cliente = new RepositoryDAO<Cliente>().ListOneWhere(c => c.Id == idCliente);
            var pedido = new Pedido(cliente);
            pedidoDAO.Create(pedido);
            
            return pedido.Id;
        }

        /// <summary>
        /// Action que renderiza modal para selecionar um cliente
        /// </summary>
        public PartialViewResult SelecionarCliente()
        {
            var listaCliente = new RepositoryDAO<Cliente>().ListAll(c => c.Nome);

            ViewBag.Cliente = new SelectList(
                listaCliente,
                "Id",
                "Nome"
            );

            return PartialView("_ModalSelecionarCliente");
        }

        /// <summary>
        /// Salvar um pedido
        /// </summary>
        public ActionResult Salvar(int idPedido, DateTime dataPedido, DateTime dataEntrega)
        {

            if (dataEntrega < dataPedido.AddMinutes(30))
            {
                //Data de entrega deve ser no mínimo 30 minutos depois da data do pedido
                return null;
            }

            Pedido pedido = pedidoDAO.GetPedidoById(idPedido);
            pedido.DataPedido = dataPedido;
            pedido.DataEntrega = dataEntrega;
            pedidoDAO.Update(pedido);

            return RedirectToAction("Cadastro", pedido);
        }

        /// <summary>
        /// Excluir pedido
        /// </summary>
        public ActionResult Excluir(int id)
        {
            var pedido = pedidoDAO.GetPedidoById(id);
            pedidoDAO.Delete(pedido);

            return RedirectToAction("Lista");
        }

    }
}