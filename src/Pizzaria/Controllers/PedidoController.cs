using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using NHibernate.Criterion;
using System;
using Pizzaria.Models.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Controllers
{
    public class PedidoController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Lista()
        {
            //var cliente = new RepositoryDAO<Cliente>().Get(3);

            //var b = new Pedido(cliente);
            //b.Itens = new List<ItemPedido>{
            //    new ItemPedido(b)
            //    {
            //        Produto = new RepositoryDAO<Produto>().Get(1),
            //        Quantidade = 2,
            //        Observacao = "sem pimentao"
            //    }
            //};

            //new PedidoDAO().Create(b);
            var listaCliente = new RepositoryDAO<Cliente>().ListAll(c => c.Nome, Ordem.Asc);

            ViewBag.Cliente = new SelectList(
                listaCliente,
                "Id",
                "Nome"
            );


            var pedido = new PedidoDAO().GetPedidosComItens();

            return View(pedido);
        }

        /// <summary>
        /// Cadastro da pizza
        /// </summary>
        public ActionResult Cadastro(int id)
        {
            var pedido = new PedidoDAO().GetPedidoById(id);

            var listaProduto = new RepositoryDAO<Produto>().ListAll(c => c.Nome, Ordem.Asc);
            
            ViewBag.Produto = new SelectList(
                listaProduto,
                "Id",
                "Nome"
            );
            
            return View(pedido);
        }

        public ActionResult CadastroPedidoCliente(int idCliente)
        {
            var cliente = new RepositoryDAO<Cliente>().ListOneWhere(c => c.Id == idCliente);
            var pedido = new Pedido(cliente);
            new PedidoDAO().Create(pedido);
            
            return RedirectToAction("Cadastro", new { id = pedido.Id });
        }

        public PartialViewResult SelecionarCliente()
        {
            var listaCliente = new RepositoryDAO<Cliente>().ListAll(c => c.Nome, Ordem.Asc);

            ViewBag.Cliente = new SelectList(
                listaCliente,
                "Id",
                "Nome"
            );

            return PartialView("_ModalSelecionarCliente");
        }


        
    }
}