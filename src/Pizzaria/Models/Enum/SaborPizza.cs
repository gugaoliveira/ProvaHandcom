using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Models.Enum
{
    /// <summary>
    /// Enumera os sabores de pizza que o cliente pode solicitar em seu pedido
    /// </summary>
    public enum SaborPizza
	{
        /// <summary>
		/// Sabores da pizza
		/// </summary>
		[Display(Name = "Portuguesa")]
        Portuguesa = 1,
        [Display(Name = "Marguerita")]
        Marguerita = 2,
        [Display(Name = "Calabresa")]
        Calabresa = 3,
        [Display(Name = "Milho")]
        Milho = 4,
        [Display(Name = "Quatro Queijos")]
        QuatroQueijos = 5,
        [Display(Name = "Frango com Catupiry")]
        FrangoCatupiry = 6,
        [Display(Name = "Atum")]
        Atum = 7,
        [Display(Name = "Da Casa")]
        DaCasa = 8,
        [Display(Name = "Vegetariana")]
        Vegetariana = 9,
        [Display(Name = "Lombinho")]
        Lombinho = 10,
        [Display(Name = "Peito de Peru")]
        PeitoDePeru = 12,
        [Display(Name = "Pepperoni")]
        Pepperoni = 13,
        [Display(Name = "Frango com Cheddar")]
        FrangoCheddar = 14,
        [Display(Name = "Parisiense")]
        Parisiense = 15,
        [Display(Name = "Banana")]
        Banana = 16,
        [Display(Name = "Chocolate")]
        Chocolate = 17,
        [Display(Name = "Prestígio")]
        Prestigio = 18,
        [Display(Name = "Romeu e Julieta")]
        RomeuJulieta = 19,
        [Display(Name = "Morango")]
        Morango = 20
    }
}                                                           