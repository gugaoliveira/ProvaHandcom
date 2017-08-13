using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Entity
{
	public class ItemPedido : BaseEntity
	{
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
	}
}
