using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Nome da cidade")]
        public virtual string Nome { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Display(Name = "Estado")]
        public virtual Estado Estado { get; set; }
    }
}
