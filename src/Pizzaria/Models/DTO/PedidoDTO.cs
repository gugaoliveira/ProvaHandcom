using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizzaria.Models.Entity;

namespace Pizzaria.Models.DTO
{
    /// <summary>
    /// Pedido do cliente <see cref="Cliente"/>
    /// </summary>
    public class PedidoDTO : BaseEntity
    {

        /// <summary>
        /// Valor total gasto
        /// </summary>
        [Display(Name = "Valor total")]
        public virtual decimal ValorTotal { get; set; }

        /// <summary>
        /// Valor gasto com pizza
        /// </summary>
        [Display(Name = "Gasto com Pizza")]
        public virtual decimal ValorPizza { get; set; }

        /// <summary>
        /// Valor gasto com pizza
        /// </summary>
        [Display(Name = "Gasto com bebida")]
        public virtual decimal ValorBebida { get; set; }

        /// <summary>
        /// Valor gasto com sobremesa
        /// </summary>
        [Display(Name = "Gasto com Sobremesa")]
        public virtual decimal ValorSobremesa { get; set; }

        /// <summary>
        /// Quantidade total de produtos
        /// </summary>
        [Display(Name = "Quantidade de produtos")]
        public virtual int QuantidadeTotalProdutos { get; set; }

        /// <summary>
        /// Quantidade total de pizzas
        /// </summary>
        [Display(Name = "Quantidade de pizzas")]
        public virtual int QuantidadeTotalPizza { get; set; }

        /// <summary>
        /// Quantidade total de bebidas
        /// </summary>
        [Display(Name = "Quantidade de bebidas")]
        public virtual int QuantidadeTotalBebidas { get; set; }

        /// <summary>
        /// Quantidade total de sobremesa
        /// </summary>
        [Display(Name = "Quantidade de sobremesa")]
        public virtual int QuantidadeTotalSobremesa { get; set; }

        /// <summary>
        /// Quantidade total de pedidos
        /// </summary>
        [Display(Name = "Quantidade de pedidos")]
        public virtual int QuantidadeTotalPedidos { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [Display(Name = "Nome do cliente")]
        public virtual string NomeCliente { get; set; }
    }
}

