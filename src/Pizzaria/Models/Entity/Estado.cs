using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Nome do Estado")]
        public virtual string Nome { get; set; }

        /// <summary>
        /// Sigla do estado. Ex.: MG, SP
        /// </summary>
        [Display(Name = "Sigla")]
        public virtual string Sigla { get; set; }        
    }
}
