using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaria.Models.Entity
{
	/// <summary>
	/// Estado do Brasil
	/// </summary>
    public class Estado : BaseEntity
    {
		/// <summary>
		/// Código do estado
		/// </summary>
        public virtual int Id { get; set; }

		/// <summary>
		/// Nome do estado
		/// </summary>
        public virtual string Nome { get; set; }

		/// <summary>
		/// Sigla do estado. Ex.: MG, SP
		/// </summary>
        public virtual string Sigla { get; set; }        
    }
}
