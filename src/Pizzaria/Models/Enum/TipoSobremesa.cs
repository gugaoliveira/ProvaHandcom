using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Enum
{
	/// <summary>
	/// Enumera os tipos de sobremesa que o cliente pode solicitar em seu pedido
	/// </summary>
	public enum TipoSobremesa
	{
        /// <summary>
        /// Doce feito a partir de chocolate em pó
        /// </summary>
        [Display(Name = "Brigadeiro")]
        Brigadeiro = 1,

        /// <summary>
        /// Doce feito com coco
        /// </summary>
        [Display(Name = "Beijinho")]
        Beijinho = 2,

        /// <summary>
        /// Doce feito a partir de chocolate e biscoitos
        /// </summary>
        [Display(Name = "Palha Italiana")]
        PalhaItaliana = 3
	}
}