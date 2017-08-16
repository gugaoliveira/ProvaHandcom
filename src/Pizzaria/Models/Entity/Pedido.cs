using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
	/// <summary>
	/// Pedido do cliente <see cref="Cliente"/>
	/// </summary>
	public class Pedido : BaseEntity
    {
        protected Pedido() { }

        public Pedido(Cliente cliente)
        {
            this.Cliente = cliente;
        }

        /// <summary>
        /// Código do pedido
        /// </summary>
        public virtual int Id { get; set; }

		/// <summary>
		/// Cliente que realizou o pedido
		/// </summary>
        public virtual Cliente Cliente { get; set; }

        /// <summary>
        /// Data e hora em que o pedido foi criado
        /// </summary>
        [DataType(DataType.DateTime)]
        public virtual DateTime DataPedido { get; set; } = DateTime.Now;

        /// <summary>
        /// Data e hora em que o pedido foi entregue
        /// </summary>
        [DataType(DataType.DateTime)]
        public virtual DateTime? DataEntrega { get; set; }

		/// <summary>
		/// Lista de itens do pedido
		/// </summary>
		public virtual IList<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

		/// <summary>
		/// Valor total do pedido
		/// </summary>
		public virtual decimal ValorTotal
		{
			get
			{
				return this.Itens.Sum(item => item.Quantidade * item.Produto.Preco);
			}
		}
	}
}

