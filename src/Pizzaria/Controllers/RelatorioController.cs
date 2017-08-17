using System.Linq;
using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.DTO;
using Pizzaria.Models.Entity;

namespace Pizzaria.Controllers
{
    public class RelatorioController : Controller
    {
        /// <summary>
        /// Página de relatório
        /// </summary>
        public ActionResult Lista(int idCliente = -1)
        {
            var listaCliente = new RepositoryDAO<Cliente>().ListAll(c => c.Nome);

            ViewBag.Cliente = new SelectList(
                listaCliente,
                "Id",
                "Nome"
            );
            
            var pedidoDTO = GetRelatorioPedidos(idCliente);

            return View(pedidoDTO);

        }

        /// <summary>
        /// Listar clientes
        /// </summary>
        private PedidoDTO GetRelatorioPedidos(int idCliente)
        {
            var pedido = idCliente == -1 ? new PedidoDAO().GetPedidosComItens() : new PedidoDAO().GetPedidoCliente(idCliente);

            decimal gastoComPizza = 0;
            decimal gastoComBebida = 0;
            decimal gastoComSobremesa = 0;

            int quantidadePizza = 0;
            int quantidadeBebida = 0;
            int quantidadeSobremesa = 0;

            foreach (var p in pedido)
            {
                gastoComPizza += p.Itens.Where(x => x.Produto is Pizza).Sum(x => x.Produto.Preco);
                gastoComBebida += p.Itens.Where(x => x.Produto is Bebida).Sum(x => x.Produto.Preco);
                gastoComSobremesa += p.Itens.Where(x => x.Produto is Sobremesa).Sum(x => x.Produto.Preco);

                quantidadePizza += p.Itens.Where(x => x.Produto is Pizza).Sum(x => x.Quantidade);
                quantidadeBebida += p.Itens.Where(x => x.Produto is Bebida).Sum(x => x.Quantidade);
                quantidadeSobremesa += p.Itens.Where(x => x.Produto is Sobremesa).Sum(x => x.Quantidade);
            }

            var pedidoDTO = new PedidoDTO
            {
                ValorPizza = gastoComPizza,
                ValorBebida = gastoComBebida,
                ValorSobremesa = gastoComSobremesa,
                QuantidadeTotalPizza = quantidadePizza,
                QuantidadeTotalBebidas = quantidadeBebida,
                QuantidadeTotalSobremesa = quantidadeSobremesa,

                ValorTotal = gastoComPizza + gastoComBebida + gastoComSobremesa,
                QuantidadeTotalProdutos = quantidadePizza + quantidadeBebida + quantidadeSobremesa,
                QuantidadeTotalPedidos = pedido.Count
            };

            return pedidoDTO;
        }
        
    }
}