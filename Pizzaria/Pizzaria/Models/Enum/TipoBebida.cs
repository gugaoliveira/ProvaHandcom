using System;
using System.Collections.Generic;
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
		Refrigerante = 1,

		/// <summary>
		/// Água mineral
		/// </summary>
		Agua = 2,

		/// <summary>
		/// Cerveja
		/// </summary>
		Cerveja = 3
	}
}