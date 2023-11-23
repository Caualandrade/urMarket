using System;
using System.Collections.Generic;

namespace urMarket.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Carrinho> Carrinhos { get; set; } = new List<Carrinho>();
}
