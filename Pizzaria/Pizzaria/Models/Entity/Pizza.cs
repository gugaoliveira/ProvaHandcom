using Pizzaria.Models.Enum;

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
        public virtual SaborPizza Sabor { get; set;}

        /// <summary>
        /// Tamanho da pizza
        /// </summary>
        public virtual TamanhoPizza Tamanho { get; set;}
	}
}