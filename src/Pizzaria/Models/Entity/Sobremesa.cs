using Pizzaria.Models.Entity;
using Pizzaria.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
    /// <summary>
    /// Sobremesa que pode ser adicionada ao pedido do cliente
    /// </summary>
    public class Sobremesa : Produto
	{

        /// <summary>
        /// Tipo de sobremesa. Ex.: brigadeiro, beijinho ou palha italiana
        /// </summary>
        [Display(Name = "Tipo")]
        public virtual TipoSobremesa Tipo { get; set; }      
    }
}
