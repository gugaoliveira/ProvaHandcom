using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
	/// <summary>
	/// Cliente da pizzaria
	/// </summary>
	public class Cliente : BaseEntity
    {
		/// <summary>
		/// Código do cliente
		/// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [Required(ErrorMessage = "O nome do cliente é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome Cliente")]
        public virtual string Nome { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        [Required(ErrorMessage = "O CPF do cliente é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        public virtual string Cpf { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um e-mail válido")]
        [Display(Name = "E-mail")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        [Required(ErrorMessage = "O nome do telefone é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone")]
        public virtual string Telefone { get; set; }

        /// <summary>
        /// Endereco do cliente
        /// </summary>
        [Display(Name = "Endereço")]
        public virtual Endereco Endereco { get; set; }

		/// <summary>
		/// Lista de pedidos do cliente
		/// </summary>
		public virtual IList<Pedido> Pedidos { get; set; }
    }
}
