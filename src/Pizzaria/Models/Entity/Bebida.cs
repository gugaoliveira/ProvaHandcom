﻿using Pizzaria.Models.Enum;

namespace Pizzaria.Models.Entity
{
	/// <summary>
	/// Bebida que pode ser adicionada ao pedido do cliente <see cref="Pedido.Bebidas"/>
	/// </summary>
    public class Bebida : Produto
    {
		/// <summary>
		/// Tipo da bebida. Ex.: água, refrigerante ou cerveja
		/// </summary>
        public virtual TipoBebida Tipo { get; set; }   
    }
}
