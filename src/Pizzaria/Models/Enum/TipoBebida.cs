using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Enum
{
	/// <summary>
	/// Enumera os tipos de bebida que o cliente pode solicitar em seu pedido
	/// </summary>
	public enum TipoBebida
	{
        /// <summary>
        /// Refrigerante. Ex.: coca-cola, guaraná
        /// </summary>
        [Display(Name = "Refrigerante")]
        Refrigerante = 1,

        /// <summary>
        /// Água mineral
        /// </summary>
        [Display(Name = "Agua")]
        Agua = 2,

        /// <summary>
        /// Cerveja
        /// </summary>
        [Display(Name = "Cerveja")]
        Cerveja = 3
	}
}