﻿using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
    /// <summary>
    /// Produto que pode ser adicionado ao pedido do cliente
    /// </summary>
    public abstract class Produto : BaseEntity
	{
        /// <summary>
        /// Código do produto
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        [Display(Name = "Nome")]
        public virtual string Nome { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Display(Name = "Descrição")]
        public virtual string Descricao { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>        
        [Required]
        [Display(Name = "Preço")]        
        public virtual decimal Preco { get; set; }
	}
}
