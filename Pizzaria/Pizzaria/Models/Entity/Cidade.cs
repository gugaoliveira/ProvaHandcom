using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Entity
{
	/// <summary>
	/// Cidade do cliente
	/// </summary>
    public class Cidade : BaseEntity
    {
		/// <summary>
		/// Código da cidade
		/// </summary>
        public virtual int Id { get; set; }

		/// <summary>
		/// Nome da cidade
		/// </summary>
        public virtual string Nome { get; set; }

		/// <summary>
		/// Estado
		/// </summary>
        public virtual Estado Estado { get; set; }
    }
}
