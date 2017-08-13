using System;
using System.Collections.Generic;
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
		Brotinho = 1,
		Pequena = 2,
		Media = 3,
		Grande = 4,
		Familia = 5
	}
}