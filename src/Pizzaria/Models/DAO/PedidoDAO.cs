using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using Pizzaria.Models.Entity;
using System.Linq.Expressions;

namespace Pizzaria.Models.DAO
{
    public class PedidoDAO : RepositoryDAO<Pedido>
    {
        /// <summary>
        /// Retorna os pedidos com itens
        /// </summary>
        public List<Pedido> GetPedidosComItens()
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                try
                {
                    //IQueryable<Pedido> queryable = (from pedido in session.Query<Pedido>()
                    //								join cliente in session.Query<Cliente>() on pedido.Cliente equals cliente
                    //								where cliente.Nome == "Tais pig"
                    //								orderby pedido.Id descending 
                    //								select pedido);

                    //Pedido a = queryable.First();

                    return session.Query<Pedido>()
                        .FetchMany(pedido => pedido.Itens)
                        .ThenFetch(itemPedido => itemPedido.Produto)
                        .ToList();
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
            }
        }

        /// <summary>
        /// Retorna um pedido a partir do id
        /// </summary>
        public Pedido GetPedidoById(int id)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                try
                {
                    return session.Query<Pedido>().Where(pedido => pedido.Id == id)
                        .FetchMany(pedido => pedido.Itens)
                        .ThenFetch(itemPedido => itemPedido.Produto).SingleOrDefault();

                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
            }
        }
    }
}