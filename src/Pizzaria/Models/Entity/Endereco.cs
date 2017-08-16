using NHibernate;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Entity
{
    /// <summary>
    /// Endereco do cliente <see cref="Cliente.Endereco"/>
    /// </summary>
    public class Endereco : BaseEntity
    {
        /// <summary>
        /// Código do endereco
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [Required(ErrorMessage = "A cidade é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Cidade")]
        public virtual Cidade Cidade { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required(ErrorMessage = "O Logradouro é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Logradouro")]
        public virtual string Logradouro { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        [Required(ErrorMessage = "O bairro é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Bairro")]
        public virtual string Bairro { get; set; }

        /// <summary>
        /// CEP do endereço
        /// </summary>
        [Required(ErrorMessage = "O CEP é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "CEP")]
        public virtual string Cep { get; set; }

        /// <summary>
        /// Número
        /// </summary>		
        [Required(ErrorMessage = "O número é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Número")]
        public virtual string Numero { get; set; }

        /// <summary>
        /// Complemento (caso precise)
        /// </summary>
        [Display(Name = "Complemento")]
        public virtual string Complemento { get; set; }

    }
}
