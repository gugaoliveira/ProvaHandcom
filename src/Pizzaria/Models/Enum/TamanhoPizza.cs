using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Enum
{
    /// <summary>
    /// Enumera os tamanhos de pizza que o cliente pode solicitar em seu pedido
    /// </summary>
    public enum TamanhoPizza
	{
        /// <summary>
		/// Tamanho da pizza
		/// </summary>
		[Display(Name = "Brotinho")]
        Brotinho = 1,
        [Display(Name = "Pequena")]
        Pequena = 2,
        [Display(Name = "Média")]
        Media = 3,
        [Display(Name = "Grande")]
        Grande = 4,
        [Display(Name = "Família")]
        Familia = 5
	}
}