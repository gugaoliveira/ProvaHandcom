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
        public virtual Cidade Cidade { get; set; }

		/// <summary>
		/// Logradouro
		/// </summary>
        public virtual string Logradouro { get; set; }

		/// <summary>
		/// Bairro
		/// </summary>
        public virtual string Bairro { get; set; }

		/// <summary>
		/// CEP do endereço
		/// </summary>
        public virtual string Cep { get; set; }

		/// <summary>
		/// Número
		/// </summary>		
        public virtual string Numero { get; set; }

		/// <summary>
		/// Complemento (caso precise)
		/// </summary>
        public virtual string Complemento { get; set; }
    }
}
