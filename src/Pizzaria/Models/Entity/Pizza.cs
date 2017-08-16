using Pizzaria.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
    /// <summary>
    /// Pizza que pode ser adicionada ao pedido do cliente
    /// </summary>
    public class Pizza : Produto
	{
        /// <summary>
        /// Sabor da pizza
        /// </summary>
        [Display(Name = "Sabor")]
        public virtual SaborPizza Sabor { get; set;}

        /// <summary>
        /// Tamanho da pizza
        /// </summary>
        [Display(Name = "Tamanho")]
        public virtual TamanhoPizza Tamanho { get; set;}
	}
}