using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Entity
{
	public class ItemPedido : BaseEntity
	{
        protected ItemPedido()
        {
        }

        public ItemPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        /// <summary>
        /// Código do item
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Quantidade de itens
        /// </summary>
        public virtual int Quantidade { get; set; }

        /// <summary>
        /// Observacao do item
        /// </summary>
        public virtual string Observacao { get; set; }

        /// <summary>
        /// Produto ex.: pizza, bebida ou sobremesa
        /// </summary>
        public virtual Produto Produto { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
