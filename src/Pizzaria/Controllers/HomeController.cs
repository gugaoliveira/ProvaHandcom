using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using NHibernate.Criterion;
using NHibernate.Util;

namespace Pizzaria.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Página inicial do sistema
        /// </summary>
        public ActionResult Index()
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

            //var a = new PedidoDAO().GetPedidosComItens();

            //foreach (Pedido pedido in a)
            //{
            //    decimal gastoComPizza = pedido.Itens.Where(x => x.Produto is Pizza).Sum(x => x.Produto.Preco);
            //    decimal gastoComBebida = pedido.Itens.Where(x => x.Produto is Bebida).Sum(x => x.Produto.Preco);
            //    decimal gastoComSobremesa = pedido.Itens.Where(x => x.Produto is Sobremesa).Sum(x => x.Produto.Preco);
            //}

            var teste = new RepositoryDAO<Cidade>().ListAll();

            ViewBag.Cidade = new SelectList(
                teste,
                "Id",
                    "Nome",
                    "Estado"
                );

            return View();
        }
    }
}